using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataEntities.Element.Files;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_FileConfirmOpinion")]
    public class CodeFileConfirmOpinion : XPLiteObject
    {
        int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        string fs_Name;
        [Size(100)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue<string>("s_Name", ref fs_Name, value); }
        }
        string fs_IsSystem;
        [Size(2)]
        public string s_IsSystem
        {
            get { return fs_IsSystem; }
            set { SetPropertyValue<string>("s_IsSystem", ref fs_IsSystem, value); }
        }
        string fs_Code;
        [Size(2)]
        public string s_Code
        {
            get { return fs_Code; }
            set { SetPropertyValue<string>("s_Code", ref fs_Code, value); }
        }

        [Aggregated, Association("Opinion-FileConfirmOpinion")]
        public XPCollection<FileConfirmOpinion> ConfirmOpinions
        {
            get { return GetCollection<FileConfirmOpinion>("ConfirmOpinions"); }
        }
        public CodeFileConfirmOpinion(Session session) : base(session) { }
        public CodeFileConfirmOpinion() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
}
