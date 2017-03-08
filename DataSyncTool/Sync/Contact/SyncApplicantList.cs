using System.Collections.Generic;
using System.Linq;
using DataEntities.Contact.Applicant;
using DataSyncTool.Common;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataSyncTool.Sync.Contact
{
    public class SyncApplicantList : SyncList<Applicant, CLIENTDB>
    {
        public override List<SyncData<Applicant, CLIENTDB>> GetListSyncData()
        {
            var sCondition = $"dt_CreateDate Between (#{ConfigHelper.BeginDate}#, #{ConfigHelper.NextDate}#) Or dt_EditDate Between (#{ConfigHelper.BeginDate}#, #{ConfigHelper.NextDate}#)";
            SyncResultInfoSet?.AddInfo("筛选需同步的申请人数据...", typeof(Applicant).Name, string.Empty, $"查询条件：{sCondition}");
            return
                new XPCollection<Applicant>(CriteriaOperator.Parse(sCondition))
                    .Select(c => new SyncApplicantData { DataIPSP = c, SyncResultInfoSet = SyncResultInfoSet })
                    .Cast<SyncData<Applicant, CLIENTDB>>()
                    .ToList();
        }

        public override List<SyncData<Applicant, CLIENTDB>> GetListRelatedData()
        {
            return new List<SyncData<Applicant, CLIENTDB>>();
        }
    }
}