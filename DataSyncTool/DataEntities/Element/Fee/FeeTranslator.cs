using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataEntities.Config;
using DevExpress.Xpo;

namespace DataEntities.Element.Fee
{
    [Persistent("T_FeeTranslator")]
    public class FeeTranslator : XPLiteObject
    {
        private int fn_ID;
        private string fs_Translator;
        private int fn_TransLateCount;
        private int fn_SelectTranslatorID;
        private Fee theFee;
        private CodeEmployee currentTranslator;
        private int fn_FeeWorkTypeID;
        public FeeTranslator(Session session)
            : base(session)
        {
        }

        public FeeTranslator()
            : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        public int n_TransLateCount
        {
            get { return fn_TransLateCount; }
            set { SetPropertyValue<int>("n_TransLateCount", ref fn_TransLateCount, value); }
        }
        [Association("Fee-FeeTranslator")]
        [Persistent("n_FeeID")]
        public Fee TheFee
        {
            get { return theFee; }
            set { SetPropertyValue("n_FeeID", ref theFee, value); }
        }
        public int n_SelectTranslatorID
        {
            get { return fn_SelectTranslatorID; }
            set { SetPropertyValue<int>("n_SelectTranslatorID", ref fn_SelectTranslatorID, value); }
        }

        public string s_Translator
        {
            get { return fs_Translator; }
            set { SetPropertyValue<string>("s_Translator", ref fs_Translator, value); }
        }

        public int n_FeeWorkTypeID
        {
            get { return fn_FeeWorkTypeID; }
            set { SetPropertyValue<int>("n_FeeWorkTypeID", ref fn_FeeWorkTypeID, value); }
        }
    }
}
