using System;
using DevExpress.Xpo;

namespace DataEntities.Case.Copyrights
{
    [Persistent("TCCase_CustomMemo")]
    public class CopyrightCustomMemo : XPLiteObject
    {
        private BasicCopyright copyright;
        private DateTime fdt_CheckDate;
        private DateTime fdt_ConfirmDate;
        private DateTime fdt_ExpiredDate;
        private DateTime fdt_MemoExpireDate;
        private DateTime fdt_ReceiveDate;
        private int fn_ID;
        private string fs_AppNum;
        private string fs_AttachedFiles;
        private string fs_LicenseNum;
        private string fs_MemoName;
        private string fs_MemoNum;
        private string fs_Name;
        private string fs_Note;
        private string fs_OtherClaim;

        public CopyrightCustomMemo(Session session) : base(session)
        {
        }

        public CopyrightCustomMemo() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Persistent("n_CaseID")]
        [Association("Copyright-CustomMemo")]
        public BasicCopyright Copyright
        {
            get { return copyright; }
            set { SetPropertyValue("n_CaseID", ref copyright, value); }
        }

        [Size(300)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue("s_Name", ref fs_Name, value); }
        }

        [Size(30)]
        public string s_LicenseNum
        {
            get { return fs_LicenseNum; }
            set { SetPropertyValue("s_LicenseNum", ref fs_LicenseNum, value); }
        }

        public DateTime dt_ExpiredDate
        {
            get { return fdt_ExpiredDate; }
            set { SetPropertyValue<DateTime>("dt_ExpiredDate", ref fdt_ExpiredDate, value); }
        }

        [Size(600)]
        public string s_Note
        {
            get { return fs_Note; }
            set { SetPropertyValue("s_Note", ref fs_Note, value); }
        }

        [Size(2)]
        public string s_AttachedFiles
        {
            get { return fs_AttachedFiles; }
            set { SetPropertyValue("s_AttachedFiles", ref fs_AttachedFiles, value); }
        }

        [Size(600)]
        public string s_OtherClaim
        {
            get { return fs_OtherClaim; }
            set { SetPropertyValue("s_OtherClaim", ref fs_OtherClaim, value); }
        }

        [Size(60)]
        public string s_AppNum
        {
            get { return fs_AppNum; }
            set { SetPropertyValue("s_AppNum", ref fs_AppNum, value); }
        }

        public DateTime dt_ReceiveDate
        {
            get { return fdt_ReceiveDate; }
            set { SetPropertyValue<DateTime>("dt_ReceiveDate", ref fdt_ReceiveDate, value); }
        }

        [Size(300)]
        public string s_MemoName
        {
            get { return fs_MemoName; }
            set { SetPropertyValue("s_MemoName", ref fs_MemoName, value); }
        }

        public DateTime dt_CheckDate
        {
            get { return fdt_CheckDate; }
            set { SetPropertyValue<DateTime>("dt_CheckDate", ref fdt_CheckDate, value); }
        }

        public DateTime dt_ConfirmDate
        {
            get { return fdt_ConfirmDate; }
            set { SetPropertyValue<DateTime>("dt_ConfirmDate", ref fdt_ConfirmDate, value); }
        }

        [Size(30)]
        public string s_MemoNum
        {
            get { return fs_MemoNum; }
            set { SetPropertyValue("s_MemoNum", ref fs_MemoNum, value); }
        }

        public DateTime dt_MemoExpireDate
        {
            get { return fdt_MemoExpireDate; }
            set { SetPropertyValue<DateTime>("dt_MemoExpireDate", ref fdt_MemoExpireDate, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}