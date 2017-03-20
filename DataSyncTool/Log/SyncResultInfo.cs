using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Aspose.Email.Mail;
using Aspose.Email.Mime;
using DataSyncTool.Common;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;
using Newtonsoft.Json;

namespace DataSyncTool.Log
{
    public struct SyncResultInfo
    {
        public DateTime CreateTime { get; set; }
        public InfoType InfoType { get; set; }
        public string InfoTypeString => InfoType.ToString();
        public string Content { get; set; }
        public string Source { get; set; }
        public string Target { get; set; }
        public string Note { get; set; }
    }

    public enum InfoType
    {
        Info,
        Warning,
        Error
    }

    public class SyncResultInfoSet : List<SyncResultInfo>
    {
        private readonly GridControl _gridControl;

        public SyncResultInfoSet(GridControl gridControl)
        {
            _gridControl = gridControl;
            _gridControl.Invoke(new Action(() => { _gridControl.DataSource = this; }));
        }

        public SyncResultInfoSet Add(InfoType infoType, string sContent, string sSource = null,
            string sTarget = null, string sNote = null, DateTime dtCreateTime = new DateTime())
        {
            Add(new SyncResultInfo
            {
                InfoType = infoType,
                Content = sContent,
                CreateTime = dtCreateTime == new DateTime() ? DateTime.Now : dtCreateTime,
                Source = sSource,
                Target = sTarget,
                Note = sNote
            });
            _gridControl.Invoke(new Action(() => { _gridControl.RefreshDataSource(); }));
            return this;
        }

        public SyncResultInfoSet AddError(string sContent, string sSource = null, string sTarget = null,
            string sNote = null, DateTime dtCreateTime = new DateTime())
        {
            return Add(InfoType.Error, sContent, sSource, sTarget, sNote, dtCreateTime);
        }

        public SyncResultInfoSet AddWarning(string sContent, string sSource = null, string sTarget = null,
            string sNote = null, DateTime dtCreateTime = new DateTime())
        {
            return Add(InfoType.Warning, sContent, sSource, sTarget, sNote, dtCreateTime);
        }

        public SyncResultInfoSet AddInfo(string sContent, string sSource = null, string sTarget = null,
            string sNote = null, DateTime dtCreateTime = new DateTime())
        {
            return Add(InfoType.Info, sContent, sSource, sTarget, sNote, dtCreateTime);
        }

        #region Send Email

        public void SendEmailByCondition()
        {
            if (ConfigHelper.GetConfigString("SendTrigger") == "B")
            {
                if (this.All(r => r.InfoType == InfoType.Info)) return;
            }
            SendEmail();
            SendMessage();
        }

        public void SendEmail()
        {
            var sFilePath = $"{Application.StartupPath}\\同步结果\\数据同步结果{DateTime.Now:yyyyMMddHHmmss}.xlsx";
            if (!Directory.Exists(Path.GetDirectoryName(sFilePath)))
                Directory.CreateDirectory(Path.GetDirectoryName(sFilePath));
            _gridControl.MainView.OptionsPrint.ShowPrintExportProgress = false;
            _gridControl.ExportToXlsx(sFilePath);

            var mailMessage = new MailMessage
            {
                From = ConfigHelper.GetConfigString("SendEmail"),
                Subject = $"数据同步结果 {DateTime.Now}",
            };

            ConfigHelper.GetConfigString("ReceivedEmail").Split(';').ToList().ForEach(mailMessage.To.Add);
            mailMessage.Attachments.Add(new Attachment(sFilePath));

            var smtpClient = new SmtpClient
            {
                Host = ConfigHelper.GetConfigString("SendServer"),
                Username = ConfigHelper.GetConfigString("SendUser"),
                Password = ConfigHelper.GetConfigString("SendPassword")
            };

            try
            {
                smtpClient.Send(mailMessage);
            }
            catch (Exception e)
            {
            }
        }

        #endregion

        private DateTime _dtTokenTime;

        public void SendMessage()
        {
            var sToken = string.Empty;
            if (_dtTokenTime == DateTime.MinValue)
                _dtTokenTime = DateTime.Now;
            //请注意：移植时需要将所有逻辑用子线程控制，避免界面卡死
            var nRepeatCount = 0; //重置重试次数
            while (string.IsNullOrEmpty(sToken) || (DateTime.Now - _dtTokenTime).Seconds > 7000)
            //令牌为空或令牌已过期，则重新尝试获取令牌，200秒为提前量，避免在执行下面逻辑时超时
            {
                //TODO 设置重试次数，默认尝试3次，间隔时间为10秒，若3次都失败则记录错误并退出
                if (nRepeatCount >= 3)
                {
                    //TODO 重试3次后跳出
                    return;
                }
                var nExpireSeconds = 0;
                if (TryGetAccessToken(out sToken, out nExpireSeconds)) continue;

                //TODO 记录失败原因
                nRepeatCount++; //增加重试次数
                Thread.Sleep(10000);
            }
            _dtTokenTime = DateTime.Now;
            var sDepartmentId = GetRootDepartmentId(sToken); //获取顶级部门ID
            if (string.IsNullOrEmpty(sDepartmentId))
            {
                throw new Exception(); //TODO 处理获取失败逻辑
            }
            var listUserInfo = GetAllUserInfo(sToken, sDepartmentId); //根据顶级部门ID获取到全部用户信息
            var listSendUserId = new List<string>();
            foreach (string sUserName in ConfigHelper.GetConfigString("ReceivedMessageUser").Split(';')) //根据用户名称获取该用户的微信ID
            {
                if (string.IsNullOrWhiteSpace(sUserName)) continue;
                dynamic dynUserInfo = listUserInfo.FirstOrDefault(u => u.name.ToString() == sUserName);
                if (dynUserInfo == null) continue;
                listSendUserId.Add(dynUserInfo.userid);
            }
            if (!listSendUserId.Any()) return;
            bool bSendSuccess = SendWeixinMessage(sToken, listSendUserId,
                $"{DateTime.Now.ToLongDateString()}：数据回写已完成，请通过邮件查看回写结果。"); //发送消息
            //TODO 处理发送失败后的逻辑
        }

        /// <summary>
        ///     向指定用户ID发送消息
        /// </summary>
        /// <param name="sToken"></param>
        /// <param name="listUserId"></param>
        /// <param name="sText"></param>
        /// <returns></returns>
        private bool SendWeixinMessage(string sToken, List<string> listUserId, string sText)
        {
            const string sUrlSendMessage = "https://qyapi.weixin.qq.com/cgi-bin/message/send";

            var strUrl = new StringBuilder(sUrlSendMessage);
            strUrl.AppendFormat("?access_token={0}", sToken);

            //构造发送对象
            dynamic dynMessage = new ExpandoObject();
            dynMessage.touser = string.Join("|", listUserId);
            //dynMessage.toparty = string.Empty; //发送部门ID集合
            //dynMessage.totag = string.Empty; //发送标签组ID集合
            dynMessage.msgtype = "text"; //发送类型
            dynMessage.agentid = 1000002; //agentid,不知道具体值，填其他值会报错
            dynamic dynContent = new ExpandoObject();
            dynContent.content = sText;
            dynMessage.text = dynContent; //发送信息，要构造为一个对象
            //dynMessage.safe = "0";

            dynamic dynResult = GetUrlResponseDictionary(strUrl.ToString(), true,
                JsonConvert.SerializeObject(dynMessage));
            if (dynResult.errcode.ToString() != "0")
            {
                throw new Exception(dynResult.errmsg.ToString()); //TODO 返回失败提示
            }
            return true;
        }

        /// <summary>
        ///     根据顶级部门ID获取所有用户信息
        /// </summary>
        /// <param name="sToken"></param>
        /// <param name="sRootDepartmentId"></param>
        /// <returns></returns>
        private List<dynamic> GetAllUserInfo(string sToken, string sRootDepartmentId)
        {
            const string sUrlDepartment = "https://qyapi.weixin.qq.com/cgi-bin/user/simplelist";
            const string sFetchChild = "1"; //1/0：是否递归获取子部门下面的成员
            const string sStatus = "0"; //0获取全部员工，1获取已关注成员列表，2获取禁用成员列表，4获取未关注成员列表。status可叠加

            var strUrl = new StringBuilder(sUrlDepartment);
            strUrl.AppendFormat("?access_token={0}", sToken);
            strUrl.AppendFormat("&department_id={0}", sRootDepartmentId); //顶级部门ID
            strUrl.AppendFormat("&fetch_child={0}", sFetchChild); //是否递归获取子部门下面的成员
            strUrl.AppendFormat("&status={0}", sStatus); //获取员工列表参数
            dynamic dynResult = GetUrlResponseDictionary(strUrl.ToString(), false);
            if (dynResult.errcode.ToString() != "0")
            {
                throw new Exception(dynResult.errmsg); //TODO 返回失败提示
            }
            return (List<dynamic>)dynResult.userlist;
        }

        /// <summary>
        ///     获取顶级部门ID
        /// </summary>
        /// <param name="sToken"></param>
        /// <returns></returns>
        private string GetRootDepartmentId(string sToken)
        {
            const string sUrlDepartment = "https://qyapi.weixin.qq.com/cgi-bin/department/list";

            var strUrl = new StringBuilder(sUrlDepartment);
            strUrl.AppendFormat("?access_token={0}", sToken);
            dynamic dynResult = GetUrlResponseDictionary(strUrl.ToString(), false);
            if (dynResult.errcode.ToString() != "0")
            {
                throw new Exception(dynResult.errmsg); //TODO 返回失败提示
            }
            List<dynamic> listDepartments = dynResult.department;
            return listDepartments.First(d => d.id.ToString() == "1").id.ToString(); //获取顶级部门的下一级部门，这里可能不太对
        }

        /// <summary>
        ///     尝试获取访问Token
        /// </summary>
        /// <param name="sToken"></param>
        /// <param name="nExpireSeconds"></param>
        /// <returns></returns>
        private bool TryGetAccessToken(out string sToken, out int nExpireSeconds)
        {
            const string sUrlToken = "https://qyapi.weixin.qq.com/cgi-bin/gettoken";
            const string sCorpId = "ww15622aba3ae54bc8";
            const string sSecret = @"IJGudGmtEe4a2065jrD6uco6kuZh6hfw1tenlPFczv0";

            var strUrl = new StringBuilder(sUrlToken);
            strUrl.AppendFormat("?corpid={0}", sCorpId);
            strUrl.AppendFormat("&corpsecret={0}", sSecret);
            dynamic dynResult = GetUrlResponseDictionary(strUrl.ToString(), false);
            if (dynResult.errcode.ToString() != "0")
            {
                throw new Exception(dynResult.errmsg); //TODO 返回失败提示
            }
            sToken = dynResult.access_token;
            int.TryParse(dynResult.expires_in.ToString(), out nExpireSeconds);
            return !string.IsNullOrEmpty(sToken);
        }

        /// <summary>
        ///     使用Get方法获取返回结果并转换为动态对象
        /// </summary>
        /// <param name="sUrl"></param>
        /// <param name="bSendByPost"></param>
        /// <param name="sBody"></param>
        /// <returns></returns>
        private dynamic GetUrlResponseDictionary(string sUrl, bool bSendByPost, string sBody = "")
        {
            try
            {
                WebRequest httpRequest = WebRequest.Create(sUrl);
                httpRequest.Method = bSendByPost ? "POST" : "GET";
                if (bSendByPost)
                {
                    using (Stream writeStream = httpRequest.GetRequestStream())
                    {
                        byte[] byteContents = Encoding.UTF8.GetBytes(sBody);
                        writeStream.Write(byteContents, 0, byteContents.Length);
                        writeStream.Close();
                    }
                }
                var response = httpRequest.GetResponse() as HttpWebResponse;
                if (response == null || response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception(); //TODO 返回失败提示
                }
                var stream = response.GetResponseStream();
                if (stream == null)
                {
                    throw new Exception(); //TODO 返回失败提示
                }
                using (var reader = new StreamReader(stream, Encoding.GetEncoding("utf-8")))
                {
                    string str = reader.ReadToEnd();
                    reader.Close();
                    return JsonConvert.DeserializeObject<ExpandoObject>(str);
                }
            }
            catch (Exception ex)
            {
                throw ex; //TODO 返回失败提示
            }
        }
    }
}