using System;
using DevExpress.Xpo;

namespace DataEntities.Case.DomainNames
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("TDCase_Domain")]
    public class BasicDomain : BasicCase
    {
        private DateTime fdt_Apply;
        private DateTime fdt_Approve;
        private DateTime fdt_NextRenewal;
        private int fn_DFlowNum;

        private string fs_ApplyPurpose;
        private string fs_DomainStatus;
        private string fs_MainServerInfo;

        private string fs_Manager;
        private string fs_SecondaryServerInfo;

        public BasicDomain(Session session) : base(session)
        {
        }

        public BasicDomain() : base(Session.DefaultSession)
        {
        }

        public int n_DFlowNum
        {
            get { return fn_DFlowNum; }
            set { SetPropertyValue<int>("n_DFlowNum", ref fn_DFlowNum, value); }
        }

        [Size(500)]
        public string s_ApplyPurpose
        {
            get { return fs_ApplyPurpose; }
            set { SetPropertyValue("s_ApplyPurpose", ref fs_ApplyPurpose, value); }
        }

        [Size(50)]
        public string s_Manager
        {
            get { return fs_Manager; }
            set { SetPropertyValue("s_Manager", ref fs_Manager, value); }
        }

        [Size(500)]
        public string s_MainServerInfo
        {
            get { return fs_MainServerInfo; }
            set { SetPropertyValue("s_MainServerInfo", ref fs_MainServerInfo, value); }
        }

        [Size(500)]
        public string s_SecondaryServerInfo
        {
            get { return fs_SecondaryServerInfo; }
            set { SetPropertyValue("s_SecondaryServerInfo", ref fs_SecondaryServerInfo, value); }
        }

        public DateTime dt_Apply
        {
            get { return fdt_Apply; }
            set { SetPropertyValue<DateTime>("dt_Apply", ref fdt_Apply, value); }
        }

        public DateTime dt_Approve
        {
            get { return fdt_Approve; }
            set { SetPropertyValue<DateTime>("dt_Approve", ref fdt_Approve, value); }
        }

        [Size(50)]
        public string s_DomainStatus
        {
            get { return fs_DomainStatus; }
            set { SetPropertyValue("s_DomainStatus", ref fs_DomainStatus, value); }
        }

        public DateTime dt_NextRenewal
        {
            get { return fdt_NextRenewal; }
            set { SetPropertyValue<DateTime>("dt_NextRenewal", ref fdt_NextRenewal, value); }
        }

        [Aggregated, Association("BasicDomain-DNRenewalFee", typeof (DNRenewalFee))]
        public XPCollection DNRenewalFees
        {
            get { return GetCollection("DNRenewalFees"); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}