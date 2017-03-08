using System;
using DevExpress.Xpo;

namespace DataEntities.Case.Patents
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("TPCase_PCTICaseInfo")]
    public class CasePCTI : ExtendedPatent
    {
        private DateTime fdt_ISADate;
        private int fn_ISACountry;
        private string fs_ISA;

        private string fs_ISANum;

        public CasePCTI(Session session) : base(session)
        {
        }

        public CasePCTI() : base(Session.DefaultSession)
        {
        }

        /// <summary>
        ///     PCT国家
        /// </summary>
        [Aggregated, Association("PCTIntl-PCTICountrires", typeof (PCTICountry))]
        public XPCollection PCTICountrys
        {
            get { return GetCollection("PCTICountrys"); }
        }

        [Size(200)]
        public string s_ISA
        {
            get { return fs_ISA; }
            set { SetPropertyValue("s_ISA", ref fs_ISA, value); }
        }

        [Size(20)]
        public string s_ISANum
        {
            get { return fs_ISANum; }
            set { SetPropertyValue("s_ISANum", ref fs_ISANum, value); }
        }

        public DateTime dt_ISADate
        {
            get { return fdt_ISADate; }
            set { SetPropertyValue<DateTime>("dt_ISADate", ref fdt_ISADate, value); }
        }

        public int n_ISACountry
        {
            get { return fn_ISACountry; }
            set { SetPropertyValue<int>("n_ISACountry", ref fn_ISACountry, value); }
        }


        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}