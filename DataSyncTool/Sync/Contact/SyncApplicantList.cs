using System.Collections.Generic;
using System.Linq;
using DataEntities.Contact.Applicant;
using DataSyncTool.Common;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;
using DevExpress.Xpo;

namespace DataSyncTool.Sync.Contact
{
    public class SyncApplicantList : SyncList<Applicant, CLIENTDB>
    {
        public override List<SyncData<Applicant, CLIENTDB>> GetListSyncData()
        {
            SyncResultInfoSet?.AddInfo("筛选需同步的申请人数据...");
            return new XPQuery<Applicant>(new UnitOfWork()).Where(
                    c =>
                        c.dt_CreateDate >= ConfigHelper.BeginDate && c.dt_CreateDate < ConfigHelper.NextDate ||
                        c.dt_EditDate >= ConfigHelper.BeginDate && c.dt_EditDate < ConfigHelper.NextDate)
                .Select(c => c.n_AppID)
                .ToList()
                .Select(c => new SyncApplicantData(c) { SyncResultInfoSet = SyncResultInfoSet })
                .Cast<SyncData<Applicant, CLIENTDB>>()
                .ToList();
        }

        public override List<SyncData<Applicant, CLIENTDB>> GetListRelatedData()
        {
            return new List<SyncData<Applicant, CLIENTDB>>();
        }
    }
}