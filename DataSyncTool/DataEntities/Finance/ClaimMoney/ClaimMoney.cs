using System;
using System.IO;
using DataEntities.Config;
using DataEntities.Contact.Client;
using DataEntities.Element.Emails;
using DataEntities.Element.Files;
using DevExpress.Xpo;

namespace DataEntities.Finance.ClaimMoney
{
    [Persistent("T_ClaimMoney")]
    public class ClaimMoney : XPLiteObject
    {

        private int fn_ID;
        private int fn_ClientID;
        private int fn_ClaimCount;
        private int fn_LetterTemplateID;
        private int fn_EmailTemplateID;
        private int fn_OutFileID;
        private int fn_EmailID;
        private string fs_Note;
        private string fs_Editor;
        private DateTime fdt_EditTime;

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        //public int n_ClientID
        //{
        //    get { return fn_ClientID; }
        //    set { SetPropertyValue<int>("n_ClientID", ref fn_ClientID, value); }
        //}

        private Client _client;
        [Persistent("n_ClientID"), Association("Client-ClaimMoney")]
        public Client TheClient
        {
            get { return _client; }
            set { SetPropertyValue("n_ClientID", ref _client, value); }
        }

        public int n_ClaimCount
        {
            get { return fn_ClaimCount; }
            set { SetPropertyValue<int>("n_ClaimCount", ref fn_ClaimCount, value); }
        }
        public int n_LetterTemplateID
        {
            get { return fn_LetterTemplateID; }
            set { SetPropertyValue<int>("n_LetterTemplateID", ref fn_LetterTemplateID, value); }
        }
        public int n_EmailTemplateID
        {
            get { return fn_EmailTemplateID; }
            set { SetPropertyValue<int>("n_EmailTemplateID", ref fn_EmailTemplateID, value); }
        }
        //public int n_OutFileID
        //{
        //    get { return fn_OutFileID; }
        //    set { SetPropertyValue<int>("n_OutFileID", ref fn_OutFileID, value); }
        //}

        private OutFile _outFile;
        [Persistent("n_OutFileID"), Association("OutFile-ClaimMoney")]
        public OutFile TheOutFile
        {
            get { return _outFile; }
            set { SetPropertyValue("n_OutFileID", ref _outFile, value); }
        }

        private OutFile _emailOutFile;
        [Persistent("n_EmailOutFileID"), Association("EmailOutFile-ClaimMoney")]
        public OutFile TheEmailOutFile
        {
            get { return _emailOutFile; }
            set { SetPropertyValue("n_EmailOutFileID", ref _emailOutFile, value); }
        }
        //public int n_EmailID
        //{
        //    get { return fn_EmailID; }
        //    set { SetPropertyValue<int>("n_EmailID", ref fn_EmailID, value); }
        //}

        [Size(1000)]
        public string s_Note
        {
            get { return fs_Note; }
            set { SetPropertyValue<string>("s_Note", ref fs_Note, value); }
        }
        [Size(50)]
        public string s_Editor
        {
            get { return fs_Editor; }
            set { SetPropertyValue<string>("s_Editor", ref fs_Editor, value); }
        }

        public DateTime dt_EditTime
        {
            get { return fdt_EditTime; }
            set { SetPropertyValue<DateTime>("dt_EditTime", ref fdt_EditTime, value); }
        }

        [Aggregated, Association("ClaimMoney-ClaimMoneyItem")]
        public XPCollection<ClaimMoneyItem> ClaimMoneyItems
        {
            get { return GetCollection<ClaimMoneyItem>("ClaimMoneyItems"); }
        }

        /// <summary>
        ///     判断文件是是什么类型的文件
        /// </summary>
        public string sFile
        {
            get
            {
                if (TheOutFile!=null)
                {
                    if(!string.IsNullOrEmpty(TheOutFile.s_FilePathName))
                    {
                        string sExtension = Path.GetExtension(TheOutFile.s_FilePathName);
                        if (string.IsNullOrEmpty(sExtension)) return "nofile";
                        string sExtensionWithOutPoint = sExtension.TrimStart('.');
                        switch (sExtensionWithOutPoint.ToLower())
                        {
                            case "doc":
                            case "docx":
                                return "word";
                            case "xls":
                            case "xlsx":
                                return "excel";
                            case "txt":
                                return "txt";
                            case "pdf":
                                return "pdf";
                            case "msg":
                            case "eml":
                                return "mail";
                            default:
                                return "other";
                        }
                    }
                }
                return "nofile";
            }
        }

        [NonPersistent]
        public CodeCycleConfig TheCodeCycleConfig { get; set; }

        [NonPersistent]
        public bool Check { get; set; }

        [NonPersistent]
        public bool bCheck { get; set; }

        [NonPersistent]
        public string sLetterPath;

        [NonPersistent]
        public string sEmailPath;

        [NonPersistent]
        public string sEmail { get; set; }

        [NonPersistent]
        public string sFlag { get; set; }

        [NonPersistent]//标记邮件是否发送成功
        public bool bSuccess { get; set; }

        [NonPersistent]//邮件发送时间
        public DateTime dtSendTime { get; set; }
        public ClaimMoney(Session session)
            : base(session)
        {
        }

        public ClaimMoney()
            : base(Session.DefaultSession)
        {
        }
    }
}
