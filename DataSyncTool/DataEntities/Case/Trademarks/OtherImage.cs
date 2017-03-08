using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [Persistent("TTCase_OtherImage")]
    public class OtherImage : XPLiteObject
    {
        private readonly XPDelayedProperty fimg_OtherOrigImg = new XPDelayedProperty();
        private ExtendedTrademark extendedTrademark;
        private int fn_ID;

        public OtherImage(Session session) : base(session)
        {
        }

        public OtherImage() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("Trademark-OtherImages")]
        [Persistent("n_CaseID")]
        public ExtendedTrademark TheTrademark
        {
            get { return extendedTrademark; }
            set { SetPropertyValue("n_CaseID", ref extendedTrademark, value); }
        }

        [Delayed("fimg_OtherOrigImg")]
        public byte[] img_OtherOrigImg
        {
            get { return (byte[]) fimg_OtherOrigImg.Value; }
            set { fimg_OtherOrigImg.Value = value; }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}