using System;
using DevExpress.Xpo;

namespace DataEntities.Case.Patents
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("TPCase_TranslateInfo")]
    public class CaseTranslation : ExtendedPatent
    {
        //int fn_ID;
        //[Key(true)]
        //public int n_ID
        //{
        //    get { return fn_ID; }
        //    set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        //}
        //Patent fn_CaseID;
        //[Association("Patent-TranslateInfo")]
        //[Persistent("n_CaseID")]
        //public Patent n_CaseID
        //{
        //    get { return fn_CaseID; }
        //    set { SetPropertyValue<Patent>("n_CaseID", ref fn_CaseID, value); }
        //}

        private DateTime fdt_CollateAssignDate;
        private DateTime fdt_CollateEndDate;
        private DateTime fdt_CollateLtdDate;
        private DateTime fdt_TransAssignDate;
        private DateTime fdt_TransEndDate;
        private DateTime fdt_TransLtdDate;
        private int fn_Collator1ID;
        private int fn_Collator2ID;
        private int fn_DestLan;
        private int fn_OrigLan;

        private int fn_OrigWordsNum;
        private int fn_TranslatorID;
        private int fn_TypeWriteByID;
        private string fs_TransQuality;

        public CaseTranslation(Session session) : base(session)
        {
        }

        public CaseTranslation() : base(Session.DefaultSession)
        {
        }

        public int n_OrigLan
        {
            get { return fn_OrigLan; }
            set { SetPropertyValue<int>("n_OrigLan", ref fn_OrigLan, value); }
        }

        public int n_OrigWordsNum
        {
            get { return fn_OrigWordsNum; }
            set { SetPropertyValue<int>("n_OrigWordsNum", ref fn_OrigWordsNum, value); }
        }

        public int n_DestLan
        {
            get { return fn_DestLan; }
            set { SetPropertyValue<int>("n_DestLan", ref fn_DestLan, value); }
        }

        public int n_TranslatorID
        {
            get { return fn_TranslatorID; }
            set { SetPropertyValue<int>("n_TranslatorID", ref fn_TranslatorID, value); }
        }

        public DateTime dt_TransAssignDate
        {
            get { return fdt_TransAssignDate; }
            set { SetPropertyValue<DateTime>("dt_TransAssignDate", ref fdt_TransAssignDate, value); }
        }

        public DateTime dt_TransLtdDate
        {
            get { return fdt_TransLtdDate; }
            set { SetPropertyValue<DateTime>("dt_TransLtdDate", ref fdt_TransLtdDate, value); }
        }

        public DateTime dt_TransEndDate
        {
            get { return fdt_TransEndDate; }
            set { SetPropertyValue<DateTime>("dt_TransEndDate", ref fdt_TransEndDate, value); }
        }

        [Size(500)]
        public string s_TransQuality
        {
            get { return fs_TransQuality; }
            set { SetPropertyValue("s_TransQuality", ref fs_TransQuality, value); }
        }

        public int n_Collator1ID
        {
            get { return fn_Collator1ID; }
            set { SetPropertyValue<int>("n_Collator1ID", ref fn_Collator1ID, value); }
        }

        public int n_Collator2ID
        {
            get { return fn_Collator2ID; }
            set { SetPropertyValue<int>("n_Collator2ID", ref fn_Collator2ID, value); }
        }

        public DateTime dt_CollateAssignDate
        {
            get { return fdt_CollateAssignDate; }
            set { SetPropertyValue<DateTime>("dt_CollateAssignDate", ref fdt_CollateAssignDate, value); }
        }

        public DateTime dt_CollateLtdDate
        {
            get { return fdt_CollateLtdDate; }
            set { SetPropertyValue<DateTime>("dt_CollateLtdDate", ref fdt_CollateLtdDate, value); }
        }

        public DateTime dt_CollateEndDate
        {
            get { return fdt_CollateEndDate; }
            set { SetPropertyValue<DateTime>("dt_CollateEndDate", ref fdt_CollateEndDate, value); }
        }

        public int n_TypeWriteByID
        {
            get { return fn_TypeWriteByID; }
            set { SetPropertyValue<int>("n_TypeWriteByID", ref fn_TypeWriteByID, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}