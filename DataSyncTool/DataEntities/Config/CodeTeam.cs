using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataEntities.Config.Right;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_Team")]
    public class CodeTeam : XPLiteObject
    {
        private int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        string fs_Name;
        [Size(200)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue<string>("s_Name", ref fs_Name, value); }
        }

        string fs_Note;
        [Size(500)]
        public string s_Note
        {
            get { return fs_Note; }
            set { SetPropertyValue<string>("s_Note", ref fs_Note, value); }
        }

        [Aggregated, Association("Team-UserTeams")]
        public XPCollection<UserTeam> UserTeams
        {
            get { return GetCollection<UserTeam>("UserTeams"); }
        }
        public CodeTeam(Session session) : base(session) { }
        public CodeTeam() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
}

