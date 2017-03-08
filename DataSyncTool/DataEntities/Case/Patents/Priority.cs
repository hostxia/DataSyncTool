using System;
using DataEntities.Config;
using DevExpress.Xpo;

namespace DataEntities.Case.Patents
{
    [Persistent("TPCase_Priority")]
    public class Priority : XPLiteObject
    {
        private ExtendedPatent fPatent;
        private DateTime fdt_PDate;
        private int fn_ID;
        private int fn_PCountry;
        private int fn_Sequence;
        private string fs_InputNum;
        private string fs_PDocProvided;
        private string fs_PNum;
        private string fs_POffice;
        private string fs_POfficeType;
        private string fs_PTransDocProvided;
        private string fs_Priority;
        private string fs_Notes;

        public Priority(Session session) : base(session)
        {
        }

        public Priority() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("Patent-Priorities")]
        [Persistent("n_CaseID")]
        public ExtendedPatent ThePatent
        {
            get { return fPatent; }
            set { SetPropertyValue("n_CaseID", ref fPatent, value); }
        }

        public int n_Sequence
        {
            get { return fn_Sequence; }
            set { SetPropertyValue<int>("n_Sequence", ref fn_Sequence, value); }
        }

        [Size(500)]
        public string s_Priority
        {
            get { return fs_Priority; }
            set { SetPropertyValue("s_Priority", ref fs_Priority, value); }
        }

        [Size(50)]
        public string s_POfficeType
        {
            get { return fs_POfficeType; }
            set { SetPropertyValue("s_POfficeType", ref fs_POfficeType, value); }
        }

        public int n_PCountry
        {
            get { return fn_PCountry; }
            set { SetPropertyValue<int>("n_PCountry", ref fn_PCountry, value); }
        }

        [Size(200)]
        public string s_POffice
        {
            get { return fs_POffice; }
            set { SetPropertyValue("s_POffice", ref fs_POffice, value); }
        }

        public DateTime dt_PDate
        {
            get { return fdt_PDate; }
            set { SetPropertyValue<DateTime>("dt_PDate", ref fdt_PDate, value); }
        }

        [Size(50)]
        public string s_PNum
        {
            get { return fs_PNum; }
            set { SetPropertyValue("s_PNum", ref fs_PNum, value); }
        }

        [Size(1)]
        public string s_PDocProvided
        {
            get { return fs_PDocProvided; }
            set { SetPropertyValue("s_PDocProvided", ref fs_PDocProvided, value); }
        }

        [Size(1)]
        public string s_PTransDocProvided
        {
            get { return fs_PTransDocProvided; }
            set { SetPropertyValue("s_PTransDocProvided", ref fs_PTransDocProvided, value); }
        }

        [Size(50)]
        public string s_InputNum
        {
            get { return fs_InputNum; }
            set { SetPropertyValue("s_InputNum", ref fs_InputNum, value); }
        }

        [Size(1000)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue("s_Notes", ref fs_Notes, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        #region 方法

        /// #################################################################
        /// <summary>
        ///     获取优先权国家
        ///     Coder:likai(2010-11-10)
        /// </summary>
        /// <returns>优先权国家</returns>
        public string GetCountryName()
        {
            if (n_PCountry == 0) return "";
            using (var uow = new UnitOfWork())
            {
                var country = uow.GetObjectByKey<CodeCountry>(n_PCountry);
                return country.s_Name;
            }
        }

        /// <summary>
        ///     获取优先权国家(英文)
        ///     Coder:sunfei(2014-04-16)
        /// </summary>
        /// <returns></returns>
        public string GetCountryEName()
        {
            if (n_PCountry == 0) return "";
            using (var uow = new UnitOfWork())
            {
                var country = uow.GetObjectByKey<CodeCountry>(n_PCountry);
                return country.s_Name;
            }
        }

        public string GetWTO()
        {
            if (s_POfficeType == "国家或WTO成员" || s_POfficeType == "Country of WTO Member")
            {
                return s_POffice;
            }
            return string.Empty;
        }

        public string GetLocalOffice()
        {
            if (s_POfficeType == "地区专利局" || s_POfficeType == "Region Patent Office")
            {
                return s_POffice;
            }
            return string.Empty;
        }

        public string GetAcceptOffice()
        {
            if (s_POfficeType == "受理局" || s_POfficeType == "Acceptance Office")
            {
                return s_POffice;
            }
            return string.Empty;
        }

        #endregion
    }
}