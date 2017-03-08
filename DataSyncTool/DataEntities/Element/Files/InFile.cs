using System;
using System.Text;
using DataEntities.Contact.Applicant;
using DataEntities.Contact.Client;
using DataEntities.Element.Tasks;
using DevExpress.Xpo;

namespace DataEntities.Element.Files
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("T_InFiles")]
    public class InFile : BaseFile
    {
        private DateTime fdt_GetCertificatedate;
        private DateTime fdt_TransmitDate;
        private int fn_AgencyOfficeID;
        private int fn_FileCodeID;
        private int fn_GovOfficeID;
        private string fs_FileType;
        private string fs_GetCertificater;
        private string fs_Lock;
        private string fs_Locker;
        private string fs_OFileStatus;
        private string fs_Officer;
        private string fs_OfficialNO;
        private int fn_ParentID;

        public InFile(Session session)
            : base(session)
        {
        }

        public InFile()
            : base(Session.DefaultSession)
        {
        }

        public int n_FileCodeID
        {
            get { return fn_FileCodeID; }
            set { SetPropertyValue<int>("n_FileCodeID", ref fn_FileCodeID, value); }
        }

        //[Size(50)]
        //public string s_FileType
        //{
        //    get { return fs_FileType; }
        //    set { SetPropertyValue("s_FileType", ref fs_FileType, value); }
        //}

        public int n_GovOfficeID
        {
            get { return fn_GovOfficeID; }
            set { SetPropertyValue<int>("n_GovOfficeID", ref fn_GovOfficeID, value); }
        }

        public int n_AgencyOfficeID
        {
            get { return fn_AgencyOfficeID; }
            set { SetPropertyValue<int>("n_AgencyOfficeID;", ref fn_AgencyOfficeID, value); }
        }

        [Size(50)]
        public string s_Officer
        {
            get { return fs_Officer; }
            set { SetPropertyValue("s_Officer", ref fs_Officer, value); }
        }
        [Size(50)]
        public string s_OfficialNO
        {
            get { return fs_OfficialNO; }
            set { SetPropertyValue("s_OfficialNO", ref fs_OfficialNO, value); }
        }

        [Size(1)]
        public string s_OFileStatus
        {
            get { return fs_OFileStatus; }
            set { SetPropertyValue("s_OFileStatus", ref fs_OFileStatus, value); }
        }

        private string fs_Distribute;
        [Size(1)]
        public string s_Distribute
        {
            get { return string.IsNullOrEmpty(fs_Distribute) ? "N" : fs_Distribute; }
            set { SetPropertyValue("s_Distribute", ref fs_Distribute, value); }
        }
        private string fs_IsPreChange;
        [Size(1)]
        public string s_IsPreChange
        {
            get { return string.IsNullOrEmpty(fs_IsPreChange) ? "N" : fs_IsPreChange; }
            set { SetPropertyValue("s_IsPreChange", ref fs_IsPreChange, value); }
        }
        [Size(1)]
        public string s_Lock
        {
            get { return fs_Lock; }
            set { SetPropertyValue("s_Lock", ref fs_Lock, value); }
        }

        [Size(50)]
        public string s_Locker
        {
            get { return fs_Locker; }
            set { SetPropertyValue("s_Locker", ref fs_Locker, value); }
        }

        public DateTime dt_TransmitDate
        {
            get { return fdt_TransmitDate; }
            set { SetPropertyValue<DateTime>("dt_TransmitDate", ref fdt_TransmitDate, value); }
        }

        [Size(100)]
        public string s_GetCertificater
        {
            get { return fs_GetCertificater; }
            set { SetPropertyValue("s_GetCertificater", ref fs_GetCertificater, value); }
        }

        public DateTime dt_GetCertificatedate
        {
            get { return fdt_GetCertificatedate; }
            set { SetPropertyValue<DateTime>("dt_GetCertificatedate", ref fdt_GetCertificatedate, value); }
        }

        string fs_Note;
        [Size(500)]
        public string s_Note
        {
            get { return fs_Note; }
            set { SetPropertyValue<string>("s_Note", ref fs_Note, value); }
        }

        private string fs_Urgent;
        [Size(2)]
        public string s_Urgent
        {
            get { return string.IsNullOrEmpty(fs_Urgent) ? "N" : fs_Urgent; }
            set { SetPropertyValue<string>("s_Urgent", ref fs_Urgent, value); }
        }

        public int n_ParentID
        {
            get { return fn_ParentID; }
            set { SetPropertyValue<int>("n_ParentID", ref fn_ParentID, value); }
        }

        /// <summary>
        ///     临时字段 存放数据文件xml
        ///     coder:zhangjiechen(2010-09-06)
        /// </summary>
        [NonPersistent]
        public string sDataXmlPath { get; set; }

        /// <summary>
        ///     客户名称
        ///     Coder: gengxuejiao (2014-08-27)
        /// </summary>
        [NonPersistent]
        public string sClinetName
        {
            get
            {
                if (TheFileClient != null)
                {
                    return TheFileClient.s_Name;
                }
                else if (FileInCases.Count >= 1)
                {
                    var sTmp = new StringBuilder();
                    var fileInCase = (FileInCase)FileInCases[0];
                    if (fileInCase.TheCase != null && fileInCase.TheCase.TheClient != null)
                    {
                        sTmp.Append(fileInCase.TheCase.TheClient.s_Name);
                        if (FileInCases.Count > 1)
                        {
                            sTmp.Append("...");
                        }
                    }
                    return sTmp.ToString();
                }
                return "";
            }
        }

        /// <summary>
        ///     申请人名称
        ///     Coder: gengxuejiao (2014-08-27)
        /// </summary>
        [NonPersistent]
        public string sApplicationName
        {
            get
            {
                if (TheFileApplicant != null)
                {
                    return TheFileApplicant.s_Name;
                }
                else if (FileInCases.Count >= 1)
                {
                    var sTmp = new StringBuilder();
                    var fileInCase = (FileInCase)FileInCases[0];
                    if (fileInCase.TheCase != null && fileInCase.TheCase.FstApplicant != null)
                    {
                        sTmp.Append(fileInCase.TheCase.FstApplicant.s_Name);
                        if (FileInCases.Count > 1)
                        {
                            sTmp.Append("...");
                        }
                    }
                    return sTmp.ToString();
                }
                return "";
            }
        }

        /// <summary>
        ///     临时字段 存放转函时候的文件路径 防止和s_FilePathName冲突
        ///     coder:zhangjiechen(2010-09-06)
        /// </summary>
        [NonPersistent]
        public string sFilePathName { get; set; }

        /// <summary>
        ///     保存新建时候的临时字段
        /// </summary>
        [NonPersistent]
        public string sFileName { get; set; }


        /// <summary>
        ///     保存新建时候的临时字段
        /// </summary>
        [NonPersistent]
        public int iTemplateID { get; set; }

        //[Association("File-TaskChains")]
        //public XPCollection<OldTFTaskChain> TaskChains
        //{
        //    get { return GetCollection<OldTFTaskChain>("TaskChains"); }
        //}

        [Association("File-Tasks", typeof(Task))]
        public XPCollection GetTasks
        {
            get { return GetCollection("GetTasks"); }
        }

        [Aggregated, Association("InFile-FileConfirms")]
        public XPCollection<FileConfirm> FileConfirm
        {
            get { return GetCollection<FileConfirm>("FileConfirm"); }
        }

        [Aggregated, Association("InFile-LawItems")]
        public XPCollection<LawItem> LawItems
        {
            get { return GetCollection<LawItem>("LawItems"); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        /// <summary>
        /// 根据标签名称,拆分名称中的组成部分
        /// </summary>
        /// <param name="tagName">标签名称</param>
        /// <returns></returns>
        public static string[] TagPart(string tagName)
        {
            if (string.IsNullOrEmpty(tagName)) { return null; }
            //根据当前的来文 和 分类,获取对应的T_LawItem对象
            string[] tagArr = tagName.Split('_');
            string Mark = tagArr[0];
            string Num = tagArr[1].Replace("[", "").Replace("]", "");
            string code = tagArr[2].Replace("[", "").Replace("]", "").Replace('―', '-').Replace('-', '.').Replace("(EN)", "");

            string dateExpressions = tagArr.Length > 3 ? tagArr[3] : null;
            string dateFormat = tagArr.Length > 4 ? tagArr[4] : null;
            string[] parts = new string[5];
            parts[0] = Mark;
            parts[1] = Num;
            parts[2] = code;
            parts[3] = dateExpressions;
            parts[4] = dateFormat;
            return parts;
        }
        public static string[] TagPartByMark(string tagName)
        {
            if (string.IsNullOrEmpty(tagName)) { return null; }
            //根据当前的来文 和 分类,获取对应的T_LawItem对象
            string[] tagArr = tagName.Split('_');
            string Num = tagArr[0].Replace("[", "").Replace("]", "");
            string code = tagArr[1].Replace("[", "").Replace("]", "").Replace('―', '-').Replace('-', '.');

            string dateExpressions = tagArr.Length > 2 ? tagArr[2].Replace("[", "").Replace("]", "") : null;
            string dateFormat = tagArr.Length > 3 ? tagArr[3].Replace("[", "").Replace("]", "") : null;
            string[] parts = new string[5];
            parts[0] = "";
            parts[1] = Num;
            parts[2] = code;
            parts[3] = dateExpressions;
            parts[4] = dateFormat;
            return parts;
        }
        /// <summary>
        /// 根据标签名,获取对应的参数对象
        /// </summary>
        /// <param name="tagName"></param>
        /// <returns></returns>
        public LawItemPara GetParaByTagName(string tagName)
        {
            string[] tagPart = TagPart(tagName);
            LawItem law = null;
            foreach (LawItem item in LawItems)
            {
                if (tagPart[1] == "OA1" && item.s_Code == "OAFirst")
                {
                    law = item;
                    break;
                }
                if (tagPart[1] == "OAN" && item.s_Code == "OANTimes")
                {
                    law = item;
                    break;
                }
                if (tagPart[1] == "OA1N" && item.s_Code == "OAFirstN")
                {
                    law = item;
                    break;
                }
                if (tagPart[1] == "OAS" && (item.s_Code == "OAFirstNSearch" || item.s_Code == "OAFirstSearch" || item.s_Code == "OANTimesSearch"))
                {
                    law = item;
                    break;
                }
            }
            if (law == null) { return null; }
            XPCollection<LawItemPara> paras = law.LawItemParas;
            foreach (LawItemPara p in paras)
            {
                if (p.s_ParaLocationCode == tagPart[2])
                {
                    return p;
                }
            }

            return null;
        }
        /// <summary>
        /// 根据标签 获取值
        /// </summary>
        /// <param name="tagName"></param>
        /// <returns></returns>
        public string GetTagValue(string tagName)
        {
            LawItemPara p = GetParaByTagName(tagName);
            if (p != null)
            {
                return p.s_ParaValue;
            }
            return "";
        }
        /// <summary>
        /// 根据标签 获取表格值
        /// </summary>
        /// <param name="tagName"></param>
        /// <returns></returns>
        public string GetTagTableValue(string tagName)
        {
            LawItemPara p = GetParaByTagName(tagName);
            if (p != null)
            {
                return Convert.ToBase64String(p.byte_ParaValue);
            }
            return null;
        }
        /// <summary>
        /// 根据标签 获取BOOL值
        /// </summary>
        /// <param name="tagName"></param>
        /// <returns></returns>
        public bool GetTagBoolValue(string tagName)
        {
            LawItemPara p = GetParaByTagName(tagName);
            if (p != null)
            {
                return p.s_ParaValue == "True";
            }
            return false;
        }

        /// <summary>
        /// 根据标签,获取日期值
        /// 支持日期加减
        /// 支持自定义日期格式
        /// 注意:本方法只用于从参数传递日期加减与格式计算 
        /// </summary>
        /// <param name="tagName"></param>
        /// <returns></returns>
        public string GetTagDateValue(string tagName)
        {
            string[] tagPart = TagPart(tagName);
            LawItemPara p = GetParaByTagName(tagName);
            if (p != null)
            {
                string value = p.s_ParaValue;
                if (!string.IsNullOrEmpty(value))
                {
                    DateTime dt = DateTime.Parse(value);
                    //对值进行加减
                    dt = AplayDate(dt, tagPart[3]);
                    //对值进行格式化
                    return FormatDate(ref dt, tagPart[4]);
                }
            }
            return null;
        }
        /// <summary>
        /// 支持M,D(天,月)的加减
        /// 暂不支持年,时分秒
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="expressions"></param>
        /// <returns></returns>
        public static DateTime AplayDate(DateTime dt, string expressions)
        {
            string regText = @"-?[1-9]\d*[D,M,d,m]";

            if (!string.IsNullOrEmpty(expressions))
            {
                System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex(regText,
                System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.Compiled);

                System.Text.RegularExpressions.Match mt;
                for (mt = r.Match(expressions); mt.Success; mt = mt.NextMatch())
                {
                    string rt = mt.Value;
                    if (rt.IndexOf("D", StringComparison.OrdinalIgnoreCase) != -1)
                    {
                        int addData = int.Parse(rt.Replace("D", "").Replace("d", ""));
                        dt = dt.AddDays(addData);
                    }
                    else if (rt.IndexOf("M", StringComparison.OrdinalIgnoreCase) != -1)
                    {
                        int addMonth = int.Parse(rt.Replace("M", "").Replace("m", ""));
                        dt = dt.AddMonths(addMonth);
                    }
                }
            }
            return dt;
        }
        public static string FormatDate(ref DateTime dt, string dateFormat)
        {
            if (!string.IsNullOrEmpty(dateFormat))
            {
                try
                {
                    return dt.ToString(dateFormat);
                }
                catch (Exception)
                {
                    return dt.ToString("yyyy-MM-dd");
                }
            }
            else
            {
                return dt.ToString("yyyy-MM-dd");
            }
        }
    }
}