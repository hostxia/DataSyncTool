using DataEntities.Case;
using DataSyncTool.Log;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;
using IDTEXT = DataSyncTool.PC.BLL.IDTEXT;

namespace DataSyncTool.Sync.Case
{
    public class SyncCustomFieldData : SyncData<CustomField, CASEOTHERINFO>
    {
        public SyncCustomFieldData(object dataIPSPIndex) : base(dataIPSPIndex)
        {
        }

        public override CASEOTHERINFO GetExistDataPC(CustomField dataIPSP)
        {
            if (GetFieldType(dataIPSP.sFieldName) == string.Empty)
            {
                SyncResultInfoSet.AddInfo(
                    InfoString.ToSkipInfo("自定义属性", dataIPSP.BasicCase?.s_CaseSerial, dataIPSP.sFieldName),
                    dataIPSP.ClassInfo.TableName, typeof(CASEOTHERINFO).Name);
                return null;
            }
            var sCondition =
                $"CASENO = '{dataIPSP.BasicCase?.s_CaseSerial}' AND INFOTYPE = '{GetFieldType(dataIPSP.sFieldName)}'";
            var existCaseOtherInfo = new PC.BLL.CASEOTHERINFO().GetModelList(sCondition);
            IsExistDataPC = existCaseOtherInfo.Count > 0;
            SyncResultInfoSet.AddInfo(
                InfoString.ToSyncInfo("自定义属性", IsExistDataPC.Value, dataIPSP.BasicCase?.s_CaseSerial,
                    dataIPSP.sFieldName),
                dataIPSP.ClassInfo.TableName, typeof(CASEOTHERINFO).Name);
            return existCaseOtherInfo.Count > 0 ? existCaseOtherInfo[0] : null;
        }

        public override void ConvertToDataPC(CASEOTHERINFO dataPC, CustomField dataIPSP)
        {
            dataPC.CASENO = dataIPSP.BasicCase?.s_CaseSerial;
            dataPC.INFOTYPE = GetFieldType(dataIPSP.sFieldName);
            dataPC.INFO = dataIPSP.s_Value;

            FillDefaultValue();
            if (!IsExistDataPC.HasValue) return;
            if (IsExistDataPC.Value)
                new PC.BLL.CASEOTHERINFO().Update(dataPC);
            else
                new PC.BLL.CASEOTHERINFO().Add(dataPC);
        }

        private string GetFieldType(string sFieldName)
        {
            var idtext = new IDTEXT().GetModelList($"IDGROUP = 'otherinfotype' and TEXT like '{sFieldName}%'");
            if (idtext.Count > 0)
                return idtext[0].ID;
            return string.Empty;
        }
    }
}