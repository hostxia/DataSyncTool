using System;
using DataEntities.Config;
using DevExpress.Xpo;

namespace DataEntities.Case
{
    [Persistent("TCase_ArchivesHistory")]
    public class ArchivesHistory : XPLiteObject
    {
        int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        BasicCase basicCase;
        [Association("Case-ArchivesHistory")]
        [Persistent("n_CaseID")]
        public BasicCase BasicCase
        {
            get { return basicCase; }
            set { SetPropertyValue("n_CaseID", ref basicCase, value); }
        }

        DateTime fdt_InstructionBorrowerTime;
        public DateTime dt_InstructionBorrowerTime
        {
            get { return fdt_InstructionBorrowerTime; }
            set { SetPropertyValue<DateTime>("dt_InstructionBorrowerTime", ref fdt_InstructionBorrowerTime, value); }
        }

        int fn_BorrowerID;
        public int n_BorrowerID
        {
            get { return fn_BorrowerID; }
            set { SetPropertyValue<int>("n_BorrowerID", ref fn_BorrowerID, value); }
        }

        DateTime fdt_BorrowerTime;
        public DateTime dt_BorrowerTime
        {
            get { return fdt_BorrowerTime; }
            set { SetPropertyValue<DateTime>("dt_BorrowerTime", ref fdt_BorrowerTime, value); }
        }

        DateTime fdt_BackTime;
        public DateTime dt_BackTime
        {
            get { return fdt_BackTime; }
            set { SetPropertyValue<DateTime>("dt_BackTime", ref fdt_BackTime, value); }
        }

        string fs_Notes;
        [Size(500)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue<string>("s_Notes", ref fs_Notes, value); }
        }

        DateTime fdt_CreateTime;
        public DateTime dt_CreateTime
        {
            get { return fdt_CreateTime; }
            set { SetPropertyValue<DateTime>("dt_CreateTime", ref fdt_CreateTime, value); }
        }

        public ArchivesHistory(Session session)
            : base(session)
        {
        }

        public ArchivesHistory()
            : base(Session.DefaultSession)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}