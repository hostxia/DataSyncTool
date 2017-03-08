using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataEntities.Element.Emails
{
    [Persistent("T_TempEmail")]
    public class TempEmail : XPLiteObject
    {
        private int fn_ID;
        private DateTime fdt_SendDate;
        private DateTime fdt_ReviceDate;
        private string fs_AddresserName;
        private string fs_AddresserEmail;
        private string fs_RecipientsEmail;
        private string fs_Level;
        private string fs_Title;
        private string fs_Content;
        private int fn_CustomerID;
        private string fs_CustomerName;
        private int fn_ContactID;
        private string fs_ContactName;
        private string fs_CustomerType;
        private int fn_CaseID;
        private string fs_CaseSerial;
        private string fs_AppNo;
        private string fs_EmailPath;
        private string fs_IsDelete;
        private int fn_DistributeID;
        private string fs_DistributeName;
        private string fs_Remark;

        public TempEmail(Session session)
            : base(session)
        {
        }

        public TempEmail()
            : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        public DateTime dt_SendDate
        {
            get { return fdt_SendDate; }
            set { SetPropertyValue<DateTime>("dt_SendDate", ref fdt_SendDate, value); }
        }

        public DateTime dt_ReviceDate
        {
            get { return fdt_ReviceDate; }
            set { SetPropertyValue<DateTime>("dt_ReviceDate", ref fdt_ReviceDate, value); }
        }


        [Size(200)]
        public string s_AddresserName
        {
            get { return fs_AddresserName; }
            set { SetPropertyValue("s_AddresserName", ref fs_AddresserName, value); }
        }

        [Size(200)]
        public string s_AddresserEmail
        {
            get { return fs_AddresserEmail; }
            set { SetPropertyValue("s_AddresserEmail", ref fs_AddresserEmail, value); }
        }

        [Size(200)]
        public string s_RecipientsEmail
        {
            get { return fs_RecipientsEmail; }
            set { SetPropertyValue("s_RecipientsEmail", ref fs_RecipientsEmail, value); }
        }

        [Size(10)]
        public string s_Level
        {
            get { return fs_Level; }
            set { SetPropertyValue("s_Level", ref fs_Level, value); }
        }

        [Size(100)]
        public string s_Title
        {
            get { return fs_Title; }
            set { SetPropertyValue("s_Title", ref fs_Title, value); }
        }

        [Size(20)]
        public string s_CustomerType
        {
            get { return fs_CustomerType; }
            set { SetPropertyValue("s_CustomerType", ref fs_CustomerType, value); }
        }

        [Size(100)]
        public string s_CustomerName
        {
            get { return fs_CustomerName; }
            set { SetPropertyValue("s_CustomerName", ref fs_CustomerName, value); }
        }

        [Size(100)]
        public string s_ContactName
        {
            get { return fs_ContactName; }
            set { SetPropertyValue("s_ContactName", ref fs_ContactName, value); }
        }

        [Size(100)]
        public string s_AppNo
        {
            get { return fs_AppNo; }
            set { SetPropertyValue("s_AppNo", ref fs_AppNo, value); }
        }

        [Size(2000)]
        public string s_Content
        {
            get { return fs_Content; }
            set { SetPropertyValue("s_Content", ref fs_Content, value); }
        }

        public int n_CustomerID
        {
            get { return fn_CustomerID; }
            set { SetPropertyValue<int>("n_CustomerID", ref fn_CustomerID, value); }
        }

        public int n_ContactID
        {
            get { return fn_ContactID; }
            set { SetPropertyValue<int>("n_ContactID", ref fn_ContactID, value); }
        }

        public int n_CaseID
        {
            get { return fn_CaseID; }
            set { SetPropertyValue<int>("n_CaseID", ref fn_CaseID, value); }
        }

        [Size(200)]
        public string s_EmailPath
        {
            get { return fs_EmailPath; }
            set { SetPropertyValue("s_EmailPath", ref fs_EmailPath, value); }
        }

        [Size(100)]
        public string s_CaseSerial
        {
            get { return fs_CaseSerial; }
            set { SetPropertyValue("s_CaseSerial", ref fs_CaseSerial, value); }
        }

        [Size(1)]
        public string s_IsDelete
        {
            get { return fs_IsDelete; }
            set { SetPropertyValue("s_IsDelete", ref fs_IsDelete, value); }
        }

        public int n_DistributeID
        {
            get { return fn_DistributeID; }
            set { SetPropertyValue<int>("n_DistributeID", ref fn_DistributeID, value); }
        }

        [Size(50)]
        public string s_DistributeName
        {
            get { return fs_DistributeName; }
            set { SetPropertyValue("s_DistributeName", ref fs_DistributeName, value); }
        }

        [Size(2000)]
        public string s_Remark
        {
            get { return fs_Remark; }
            set { SetPropertyValue("s_Remark", ref fs_Remark, value); }
        }


        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
