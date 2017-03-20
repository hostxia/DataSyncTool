using System;
using System.Linq;
using DataEntities.TaskFlowData;
using DataSyncTool.Log;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;

namespace DataSyncTool.Sync.Element
{
    public class SyncOAData : SyncData<TFTaskChain, GENERALALERT>
    {
        public SyncOAData(object dataIPSPIndex) : base(dataIPSPIndex)
        {
        }

        public override GENERALALERT GetExistDataPC(TFTaskChain dataIPSP)
        {
            var sOAType = GetOATypeByTaskChainCode(dataIPSP.GetTheCodeTaskChain().s_Code);
            if (string.IsNullOrWhiteSpace(sOAType) || !dataIPSP.dt_CreateTime.HasValue)
            {
                SyncResultInfoSet.AddInfo(
                    InfoString.ToSkipInfo("OA", dataIPSP.g_ID, dataIPSP.n_Num + " " + dataIPSP.s_Name),
                    dataIPSP.ClassInfo.TableName, typeof(GENERALALERT).Name);
                return null;
            }
            var sCondition =
                $"OATYPE = '{GetOATypeByTaskChainCode(dataIPSP.GetTheCodeTaskChain().s_Code)}' and OURNO = '{dataIPSP.GetRelatedCase()?.s_CaseSerial}' and TRIGERDATE1 = '{dataIPSP.dt_CreateTime.Value:yyyy/MM/dd}'";
            var existOA = new PC.BLL.GENERALALERT().GetModelList(sCondition);
            IsExistDataPC = existOA.Count > 0;
            SyncResultInfoSet.AddInfo(
                InfoString.ToSyncInfo("OA", IsExistDataPC.Value, dataIPSP.g_ID, dataIPSP.n_Num + " " + dataIPSP.s_Name),
                dataIPSP.ClassInfo.TableName, typeof(GENERALALERT).Name);
            return existOA.Count > 0 ? existOA[0] : null;
        }

        public override void ConvertToDataPC(GENERALALERT dataPC, TFTaskChain dataIPSP)
        {
            dataPC.CREATED = DateTime.Now;
            dataPC.TYPEID = GetOATypeByTaskChainCode(dataIPSP.GetTheCodeTaskChain().s_Code);
            dataPC.OURNO = dataIPSP.GetRelatedCase()?.s_CaseSerial;
            if (dataIPSP.dt_CreateTime.HasValue)
                dataPC.TRIGERDATE1 = dataIPSP.dt_CreateTime.Value;

            var taskTrans =
                dataIPSP.GetListNodes()
                    .FirstOrDefault(n => n.GetTheOwnTask()?.s_Name == "OA转达")?.GetTheOwnTask();
            if (taskTrans != null)
                dataPC.SUBCOMPLETE1 = taskTrans.s_State == "F" ? taskTrans.dt_FinishTime : taskTrans.dt_EndDate;

            dataPC.SUBCOMPLETE2 =
                dataIPSP.GetListNodes()
                    .Select(n => n.GetTheOwnTask())
                    .Where(t => t != null)
                    .FirstOrDefault(t => t.s_Name.Contains("客户指示"))?.dt_FinishTime ?? DateTime.MinValue;

            dataPC.SUBCOMPLETE3 =
                dataIPSP.GetListClusterTaskChains()
                    .SelectMany(c => c.GetListNodes())
                    .Select(n => n.GetTheOwnTask())
                    .FirstOrDefault(t => t != null && t.s_Name.Contains("发送账单"))?.dt_FinishTime ?? DateTime.MinValue;


            var bDelay1 =
                dataIPSP.GetListClusterTaskChains().Any(t => t.s_Name.Contains("延期") && t.s_Name.Contains("+1"));
            var bDelay2 =
                dataIPSP.GetListClusterTaskChains().Any(t => t.s_Name.Contains("延期") && t.s_Name.Contains("+2"));
            DateTime? dtReply;
            if (bDelay2)
                dtReply =
                    dataIPSP.GetListDeadlines()
                        .FirstOrDefault(d => d.GetTheCodeDeadline().s_Name.Contains("2个月延期"))?.dt_Deadline;
            else if (bDelay1)
                dtReply =
                    dataIPSP.GetListDeadlines()
                        .FirstOrDefault(d => d.GetTheCodeDeadline().s_Name.Contains("1个月延期"))?.dt_Deadline;
            else
                dtReply =
                    dataIPSP.GetListDeadlines()
                        .FirstOrDefault(d => d.GetTheCodeDeadline().s_Name.Contains("答复OA"))?.dt_Deadline;
            dataPC.DUEDATE = dtReply ?? DateTime.MinValue;

            FillDefaultValue();
            if (!IsExistDataPC.HasValue) return;
            if (IsExistDataPC.Value)
                new PC.BLL.GENERALALERT().Update(dataPC);
            else
                new PC.BLL.GENERALALERT().Add(dataPC);
        }

        private string GetOATypeByTaskChainCode(string sTaskChainCode)
        {
            if (sTaskChainCode.Contains("LW390") || sTaskChainCode.Contains("LW400"))
                return "oa1";
            if (sTaskChainCode.Contains("LW391") || sTaskChainCode.Contains("LW392"))
                return "oa2";
            return string.Empty;
        }
    }
}