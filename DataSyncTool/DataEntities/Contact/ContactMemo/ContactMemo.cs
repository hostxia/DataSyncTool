using System;
using System.IO;
using DataEntities.Case;
using DataEntities.Case.Patents;
using DevExpress.Xpo;

namespace DataEntities.Contact.ContactMemo
{
    [Persistent("T_ContactMemo")]
    public class ContactMemo : XPLiteObject
    {
        private readonly XPDelayedProperty fdt_CreateDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_EditDate = new XPDelayedProperty();
        private BasicCase basicCase;
        private DateTime fdt_ContactTime;
        private int fn_EmployeeID;
        private int fn_ID;

        private int fn_ObjectID;
        private string fs_CotactWay;
        private string fs_Creator;
        private string fs_Editor;
        private string fs_FilePath;
        private string fs_Memo;
        private string fs_ObjectType;
        private string fs_Subject;

        public ContactMemo(Session session) : base(session)
        {
        }

        public ContactMemo() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        public int n_ObjectID
        {
            get { return fn_ObjectID; }
            set { SetPropertyValue<int>("n_ObjectID", ref fn_ObjectID, value); }
        }

        [Persistent("n_CaseID"), NoForeignKey, Association("BasicCase-ContactMemo")]
        public BasicCase TheCase
        {
            get { return basicCase; }
            set { SetPropertyValue("n_CaseID", ref basicCase, value); }
        }

        [Size(1)]
        public string s_ObjectType
        {
            get { return fs_ObjectType; }
            set { SetPropertyValue("s_ObjectType", ref fs_ObjectType, value); }
        }

        [Size(500)]
        public string s_Subject
        {
            get { return fs_Subject; }
            set { SetPropertyValue("s_Subject", ref fs_Subject, value); }
        }

        [Size(50)]
        public string s_CotactWay
        {
            get { return fs_CotactWay; }
            set { SetPropertyValue("s_CotactWay", ref fs_CotactWay, value); }
        }

        public DateTime dt_ContactTime
        {
            get { return fdt_ContactTime; }
            set { SetPropertyValue<DateTime>("dt_ContactTime", ref fdt_ContactTime, value); }
        }

        public int n_EmployeeID
        {
            get { return fn_EmployeeID; }
            set { SetPropertyValue<int>("n_EmployeeID", ref fn_EmployeeID, value); }
        }

        [Size(2000)]
        public string s_Memo
        {
            get { return fs_Memo; }
            set { SetPropertyValue("s_Memo", ref fs_Memo, value); }
        }

        [NonPersistent]
        public string s_CaseSerial
        {
            get
            {
                BasicCase basicCase = TheCase;
                if (basicCase == null)
                    return "";
                return basicCase.s_CaseSerial;
            }
        }

        public string s_FilePath
        {
            get { return fs_FilePath; }
            set { SetPropertyValue("s_FilePath", ref fs_FilePath, value); }
        }

        [NonPersistent]
        public string s_OldFilePath { get; set; }

        /// <summary>
        ///     判断文件是是什么类型的文件
        ///     coder:zhangjiechen(2010-09-06)
        /// </summary>
        public string sFile
        {
            get
            {
                if (!string.IsNullOrEmpty(s_FilePath))
                {
                    string sExtension = Path.GetExtension(s_FilePath);
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
                return "nofile";
            }
        }

        [Size(50)]
        public string s_Creator
        {
            get { return fs_Creator; }
            set { SetPropertyValue("s_Creator", ref fs_Creator, value); }
        }

        [Size(50)]
        public string s_Editor
        {
            get { return fs_Editor; }
            set { SetPropertyValue("s_Editor", ref fs_Editor, value); }
        }

        [Delayed("fdt_CreateDate")]
        public DateTime dt_CreateDate
        {
            get
            {
                if (fdt_CreateDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_CreateDate.Value;
            }
            set { fdt_CreateDate.Value = value; }
        }

        [Delayed("fdt_EditDate")]
        public DateTime dt_EditDate
        {
            get
            {
                if (fdt_EditDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_EditDate.Value;
            }
            set { fdt_EditDate.Value = value; }
        }

        [NonPersistent]
        public string sObjName
        {
            get
            {
                if (n_ObjectID == -1) return "";
                using (var uow = new UnitOfWork())
                {
                    switch (s_ObjectType)
                    {
                        case "C":
                        {
                            return uow.GetObjectByKey<Client.Client>(n_ObjectID) == null
                                ? string.Empty
                                : uow.GetObjectByKey<Client.Client>(n_ObjectID).s_Name;
                        }
                        case "A":
                        {
                            if (TheCase == null)
                            {
                                return uow.GetObjectByKey<Applicant.Applicant>(n_ObjectID) == null
                                    ? string.Empty
                                    : uow.GetObjectByKey<Applicant.Applicant>(n_ObjectID).s_Name;
                            }
                            return uow.GetObjectByKey<Case.Applicant>(n_ObjectID) == null
                                ? string.Empty
                                : uow.GetObjectByKey<Case.Applicant>(n_ObjectID).s_Name;
                        }
                        case "O":
                        {
                            return uow.GetObjectByKey<Agency.Agency>(n_ObjectID) == null
                                ? string.Empty
                                : uow.GetObjectByKey<Agency.Agency>(n_ObjectID).s_Name;
                        }
                        case "I":
                        {
                            return uow.GetObjectByKey<Introducer.Introducer>(n_ObjectID) == null
                                ? string.Empty
                                : uow.GetObjectByKey<Introducer.Introducer>(n_ObjectID).Name;
                        }
                        case "F":
                        {
                            return uow.GetObjectByKey<Inventor>(n_ObjectID) == null
                                ? string.Empty
                                : uow.GetObjectByKey<Inventor>(n_ObjectID).s_Name;
                        }
                        default:
                            return "";
                    }
                }
            }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}