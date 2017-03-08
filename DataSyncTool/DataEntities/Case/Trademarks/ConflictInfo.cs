using System;
using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("TTCase_ConflictInfo")]
    public class ConflictInfo : ExtendedTrademark
    {
        private readonly XPDelayedProperty fs_Address = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Agent = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_CitedTMClass = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_CitedTMName = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_CitedTMRegNO = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Contact = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Fax = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Name = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_NeedProof = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_OfficeSerial = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_OtherAddress = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_OtherClass = new XPDelayedProperty();

        private readonly XPDelayedProperty fs_OtherName = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Reason = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Tel = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_ZipCode = new XPDelayedProperty();

        public ConflictInfo(Session session) : base(session)
        {
        }

        public ConflictInfo() : base(Session.DefaultSession)
        {
        }

        [Delayed("fs_Name")]
        [Size(200)]
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

        [Delayed("fs_Address")]
        [Size(300)]
        public string s_Address
        {
            get { return (string) fs_Address.Value; }
            set { fs_Address.Value = value; }
        }

        [Delayed("fs_OtherAddress")]
        [Size(300)]
        public string s_OtherAddress
        {
            get { return (string) fs_OtherAddress.Value; }
            set { fs_OtherAddress.Value = value; }
        }

        [Delayed("fs_ZipCode")]
        [Size(10)]
        public string s_ZipCode
        {
            get { return (string) fs_ZipCode.Value; }
            set { fs_ZipCode.Value = value; }
        }

        [Delayed("fs_Contact")]
        public string s_Contact
        {
            get { return (string) fs_Contact.Value; }
            set { fs_Contact.Value = value; }
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

        [Delayed("fs_Agent")]
        [Size(200)]
        public string s_Agent
        {
            get { return (string) fs_Agent.Value; }
            set { fs_Agent.Value = value; }
        }

        [Delayed("fs_Reason")]
        [Size(800)]
        public string s_Reason
        {
            get { return (string) fs_Reason.Value; }
            set { fs_Reason.Value = value; }
        }

        [Delayed("fs_OfficeSerial")]
        [Size(30)]
        public string s_OfficeSerial
        {
            get { return (string) fs_OfficeSerial.Value; }
            set { fs_OfficeSerial.Value = value; }
        }

        [Delayed("fs_OtherClass")]
        [Size(300)]
        public string s_OtherClass
        {
            get { return (string) fs_OtherClass.Value; }
            set { fs_OtherClass.Value = value; }
        }

        [Delayed("fs_NeedProof")]
        [Size(1)]
        public string s_NeedProof
        {
            get { return (string) fs_NeedProof.Value; }
            set { fs_NeedProof.Value = value; }
        }

        [Delayed("fs_CitedTMName")]
        [Size(300)]
        public string s_CitedTMName
        {
            get { return (string) fs_CitedTMName.Value; }
            set { fs_CitedTMName.Value = value; }
        }

        [Delayed("fs_CitedTMClass")]
        [Size(200)]
        public string s_CitedTMClass
        {
            get { return (string) fs_CitedTMClass.Value; }
            set { fs_CitedTMClass.Value = value; }
        }

        [Delayed("fs_CitedTMRegNO")]
        [Size(100)]
        public string s_CitedTMRegNO
        {
            get { return (string) fs_CitedTMRegNO.Value; }
            set { fs_CitedTMRegNO.Value = value; }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        #region 方法

        /// ############################################################
        /// <summary>
        ///     判断是否是需要补充证据材料
        ///     coder: Kevin Wang(2010-10-22)
        /// </summary>
        /// <returns>需要为true，否则为false</returns>
        public string NeedProof()
        {
            if (String.IsNullOrEmpty(s_NeedProof) == false)
            {
                return s_NeedProof.ToUpper() == "Y" ? "true" : "false";
            }
            return "false";
        }

        /// ############################################################
        /// <summary>
        ///     判断是否是需要补充证据材料
        ///     coder: Kevin Wang(2010-10-22)
        /// </summary>
        /// <returns>不需要为true，否则为false</returns>
        public string NotNeedProof()
        {
            if (String.IsNullOrEmpty(s_NeedProof) == false)
            {
                return s_NeedProof.ToUpper() == "N" ? "true" : "false";
            }
            return "false";
        }

        #endregion
    }
}