using DevExpress.Xpo;

namespace DataEntities.Element.Files
{
    [Persistent("T_ListInFile")]
    public class SubmitListInFile : XPLiteObject
    {
        private int fn_ID;

        private OutFile theFile;
        private TrademarkSubmitList theListFile;

        public SubmitListInFile(Session session) : base(session)
        {
        }

        public SubmitListInFile() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Persistent("n_ListID")]
        [Association("List-SubmitListInFile")]
        public TrademarkSubmitList TheListFile
        {
            get { return theListFile; }
            set { SetPropertyValue("n_ListID", ref theListFile, value); }
        }

        [Persistent("n_FileID")]
        [Association("File-SubmitListInFile")]
        public OutFile TheFile
        {
            get { return theFile; }
            set { SetPropertyValue("n_FileID", ref theFile, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}