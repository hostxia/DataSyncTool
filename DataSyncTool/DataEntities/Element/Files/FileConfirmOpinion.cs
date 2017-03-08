using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataEntities.Config;
using DevExpress.Xpo;

namespace DataEntities.Element.Files
{

    [Persistent("T_FileConfirmOpinion")]
    public class FileConfirmOpinion : XPLiteObject
    {
        int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        private FileConfirm fileConfirm;
        [Persistent("n_FileConfirmID"), Association("File-FileConfirmOpinion")]
        public FileConfirm TheFileConfirm
        {
            get { return fileConfirm; }
            set { SetPropertyValue("n_FileConfirmID", ref fileConfirm, value); }
        }

        private CodeFileConfirmOpinion codeFileConfirmOpinion;
        [Persistent("n_OpinionID"), Association("Opinion-FileConfirmOpinion")]
        public CodeFileConfirmOpinion TheConfirmOpinion
        {
            get { return codeFileConfirmOpinion; }
            set { SetPropertyValue("n_OpinionID", ref codeFileConfirmOpinion, value); }
        }
        public FileConfirmOpinion(Session session) : base(session) { }
        public FileConfirmOpinion() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
}
