using System;
using DevExpress.Xpo;

namespace DataEntities.Element.Files
{
    [Persistent("T_LawItemPara")]
    public class LawItemPara : XPLiteObject
    {
        private int fn_ID;
        private string fs_ParaLocationCode;
        private string fs_ParaType;
        private string fs_ParaValue;
        private byte[] fbyte_ParaValue;
        private LawItem lawItem;

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Size(10)]
        public string s_ParaLocationCode
        {
            get { return fs_ParaLocationCode; }
            set { SetPropertyValue("s_ParaLocationCode", ref fs_ParaLocationCode, value); }
        }

        [Size(10)]
        public string s_ParaType
        {
            get { return fs_ParaType; }
            set { SetPropertyValue("s_ParaType", ref fs_ParaType, value); }
        }

        [Size(500)]
        public string s_ParaValue
        {
            get { return fs_ParaValue; }
            set { SetPropertyValue("s_ParaValue", ref fs_ParaValue, value); }
        }

        public byte[] byte_ParaValue
        {
            get { return fbyte_ParaValue; }
            set { SetPropertyValue("byte_ParaValue", ref fbyte_ParaValue, value); }
        }

        [Persistent("n_LawItemID"), Association("LawItem-LawItemParas")]
        public LawItem TheLawItem
        {
            get { return lawItem; }
            set { SetPropertyValue("n_LawItemID", ref lawItem, value); }
        }

        public LawItemPara(Session session)
            : base(session)
        {
        }

        public LawItemPara()
            : base(Session.DefaultSession)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}