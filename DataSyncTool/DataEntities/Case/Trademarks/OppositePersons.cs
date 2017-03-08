using DataEntities.Config;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [Persistent("TTCase_OppositePersons")]
    public class OppositePerson : XPLiteObject
    {
        private readonly XPDelayedProperty fn_RegCountry = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Addr = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Contact = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Email = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Fax = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_IsDelegacy = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_LawDeputy = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Name = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_OtherAddr = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_OtherName = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Role = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Tel = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_ZipCode = new XPDelayedProperty();
        private int fn_ID;

        private MultiPersonCase trademark;

        public OppositePerson(Session session) : base(session)
        {
        }

        public OppositePerson() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("Trademark-OppositePersons")]
        [Persistent("n_CaseID")]
        public MultiPersonCase TheTrademark
        {
            get { return trademark; }
            set { SetPropertyValue("n_CaseID", ref trademark, value); }
        }

        [Delayed("fs_Role")]
        [Size(1)]
        public string s_Role
        {
            get { return (string) fs_Role.Value; }
            set { fs_Role.Value = value; }
        }

        [Delayed("fs_Name")]
        [Size(300)]
        public string s_Name
        {
            get { return (string) fs_Name.Value; }
            set { fs_Name.Value = value; }
        }

        [Delayed("fs_OtherName")]
        [Size(200)]
        public string s_OtherName
        {
            get { return (string) fs_OtherName.Value; }
            set { fs_OtherName.Value = value; }
        }

        [Delayed("fs_Addr")]
        [Size(300)]
        public string s_Addr
        {
            get { return (string) fs_Addr.Value; }
            set { fs_Addr.Value = value; }
        }

        [Delayed("fs_OtherAddr")]
        [Size(300)]
        public string s_OtherAddr
        {
            get { return (string) fs_OtherAddr.Value; }
            set { fs_OtherAddr.Value = value; }
        }

        [Delayed("fs_ZipCode")]
        [Size(10)]
        public string s_ZipCode
        {
            get { return (string) fs_ZipCode.Value; }
            set { fs_ZipCode.Value = value; }
        }

        [Delayed("fs_Tel")]
        [Size(50)]
        public string s_Tel
        {
            get { return (string) fs_Tel.Value; }
            set { fs_Tel.Value = value; }
        }

        [Delayed("fs_Fax")]
        [Size(50)]
        public string s_Fax
        {
            get { return (string) fs_Fax.Value; }
            set { fs_Fax.Value = value; }
        }

        [Delayed("fs_Email")]
        [Size(50)]
        public string s_Email
        {
            get { return (string) fs_Email.Value; }
            set { fs_Email.Value = value; }
        }

        [Delayed("fs_LawDeputy")]
        [Size(200)]
        public string s_LawDeputy
        {
            get { return (string) fs_LawDeputy.Value; }
            set { fs_LawDeputy.Value = value; }
        }

        [Delayed("fs_Contact")]
        [Size(200)]
        public string s_Contact
        {
            get { return (string) fs_Contact.Value; }
            set { fs_Contact.Value = value; }
        }

        [Delayed("fs_IsDelegacy")]
        [Size(1)]
        public string s_IsDelegacy
        {
            get { return (string) fs_IsDelegacy.Value; }
            set { fs_IsDelegacy.Value = value; }
        }

        [Delayed("fn_RegCountry")]
        public int n_RegCountry
        {
            get
            {
                if (fn_RegCountry.Value == null)
                {
                    return -1;
                }
                return (int) fn_RegCountry.Value;
            }
            set { fn_RegCountry.Value = value; }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        #region 自定义方法

        /// #################################################################
        /// <summary>
        ///     获取国别
        ///     Kevin Wang(2010-10-12)
        /// </summary>
        /// <returns>国别</returns>
        public string GetCountry()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof (CodeCountry))
                {
                    Criteria = CriteriaOperator.Parse("n_ID =" + n_RegCountry)
                };
                return xpc.Count == 0 ? "" : ((CodeCountry) xpc[0]).s_Name;
            }
        }

        #endregion
    }
}