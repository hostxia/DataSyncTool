using System;
using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("TTCase_TranslateInfo")]
    public class CaseTranslation : ExtendedTrademark
    {
        private readonly XPDelayedProperty fdt_CollateAssignDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_CollateEndDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_CollateLtdDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_TransAssignDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_TransEndDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_TransLtdDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_Collator1ID = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_Collator2ID = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_DestLan = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_OrigLan = new XPDelayedProperty();

        private readonly XPDelayedProperty fn_OrigWordsNum = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_TranslatorID = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_TypeWriteByID = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_TransQuality = new XPDelayedProperty();

        public CaseTranslation(Session session) : base(session)
        {
        }

        public CaseTranslation() : base(Session.DefaultSession)
        {
        }

        [Delayed("fn_OrigLan")]
        public int n_OrigLan
        {
            get
            {
                if (fn_OrigLan.Value == null)
                {
                    return -1;
                }
                return (int) fn_OrigLan.Value;
            }
            set { fn_OrigLan.Value = value; }
        }

        [Delayed("fn_OrigWordsNum")]
        public int n_OrigWordsNum
        {
            get
            {
                if (fn_OrigWordsNum.Value == null)
                {
                    return -1;
                }
                return (int) fn_OrigWordsNum.Value;
            }
            set { fn_OrigWordsNum.Value = value; }
        }

        [Delayed("fn_DestLan")]
        public int n_DestLan
        {
            get
            {
                if (fn_DestLan.Value == null)
                {
                    return -1;
                }
                return (int) fn_DestLan.Value;
            }
            set { fn_DestLan.Value = value; }
        }

        [Delayed("fn_TranslatorID")]
        public int n_TranslatorID
        {
            get
            {
                if (fn_TranslatorID.Value == null)
                {
                    return -1;
                }
                return (int) fn_TranslatorID.Value;
            }
            set { fn_TranslatorID.Value = value; }
        }

        [Delayed("fdt_TransAssignDate")]
        public DateTime dt_TransAssignDate
        {
            get
            {
                if (fdt_TransAssignDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_TransAssignDate.Value;
            }
            set { fdt_TransAssignDate.Value = value; }
        }

        [Delayed("fdt_TransLtdDate")]
        public DateTime dt_TransLtdDate
        {
            get
            {
                if (fdt_TransLtdDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_TransLtdDate.Value;
            }
            set { fdt_TransLtdDate.Value = value; }
        }

        [Delayed("fdt_TransEndDate")]
        public DateTime dt_TransEndDate
        {
            get
            {
                if (fdt_TransEndDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_TransEndDate.Value;
            }
            set { fdt_TransEndDate.Value = value; }
        }

        [Delayed("fn_Collator1ID")]
        public int n_Collator1ID
        {
            get
            {
                if (fn_Collator1ID.Value == null)
                {
                    return -1;
                }
                return (int) fn_Collator1ID.Value;
            }
            set { fn_Collator1ID.Value = value; }
        }

        [Delayed("fn_Collator2ID")]
        public int n_Collator2ID
        {
            get
            {
                if (fn_Collator2ID.Value == null)
                {
                    return -1;
                }
                return (int) fn_Collator2ID.Value;
            }
            set { fn_Collator2ID.Value = value; }
        }

        [Delayed("fdt_CollateAssignDate")]
        public DateTime dt_CollateAssignDate
        {
            get
            {
                if (fdt_CollateAssignDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_CollateAssignDate.Value;
            }
            set { fdt_CollateAssignDate.Value = value; }
        }

        [Delayed("fdt_CollateLtdDate")]
        public DateTime dt_CollateLtdDate
        {
            get
            {
                if (fdt_CollateLtdDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_CollateLtdDate.Value;
            }
            set { fdt_CollateLtdDate.Value = value; }
        }

        [Delayed("fdt_CollateEndDate")]
        public DateTime dt_CollateEndDate
        {
            get
            {
                if (fdt_CollateEndDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_CollateEndDate.Value;
            }
            set { fdt_CollateEndDate.Value = value; }
        }

        [Delayed("fn_TypeWriteByID")]
        public int n_TypeWriteByID
        {
            get
            {
                if (fn_TypeWriteByID.Value == null)
                {
                    return -1;
                }
                return (int) fn_TypeWriteByID.Value;
            }
            set { fn_TypeWriteByID.Value = value; }
        }

        [Delayed("fs_TransQuality")]
        [Size(500)]
        public string s_TransQuality
        {
            get { return (string) fs_TransQuality.Value; }
            set { fs_TransQuality.Value = value; }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}