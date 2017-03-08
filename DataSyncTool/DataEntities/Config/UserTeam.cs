using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataEntities.Config.Right;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("T_UserTeam")]
    public class UserTeam : XPLiteObject
    {
        private int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        //private int fn_UserID;
        //public int n_UserID
        //{
        //    get { return fn_UserID; }
        //    set { SetPropertyValue<int>("n_UserID", ref fn_UserID, value); }
        //}

        //private int fn_TeamID;
        //public int n_TeamID
        //{
        //    get { return fn_TeamID; }
        //    set { SetPropertyValue<int>("n_TeamID", ref fn_TeamID, value); }
        //}

        private CodeEmployee codeEmployee;
        [Persistent("n_UserID"), Association("User-UserTeams")]
        public CodeEmployee TheUser
        {
            get { return codeEmployee; }
            set { SetPropertyValue("n_UserID", ref codeEmployee, value); }
        }

        private CodeTeam codeTeam;
        [Persistent("n_TeamID"), Association("Team-UserTeams")]
        public CodeTeam TheCodeTeam
        {
            get { return codeTeam; }
            set { SetPropertyValue("n_TeamID", ref codeTeam, value); }
        }
        public UserTeam(Session session) : base(session) { }
        public UserTeam() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
}

