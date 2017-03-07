using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aspose.Email.Mail;
using Aspose.Email.Mime;
using DataSyncTool.Common;
using DevExpress.XtraGrid;
using DevExpress.XtraPrinting;

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

        public void SendEmailByCondition()
        {
            if (ConfigHelper.GetConfigString("SendTrigger") == "B")
            {
                if (this.All(r => r.InfoType == InfoType.Info)) return;
            }
            SendEmail();
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
    }
}