using System;
using System.Linq;
using DataEntities.Config;
using DataEntities.Contact.Agency;
using DataEntities.Contact.Client;
using DataEntities.Element.Files;
using DataSyncTool.Log;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;
using DevExpress.Xpo;
using DataEntities.Case.Patents;

namespace DataSyncTool.Sync.Element
{
    public class SyncAnnualFeeData : SyncData<AnnualFee, GENERALALERT>
    {
        public SyncAnnualFeeData(object dataIPSPIndex) : base(dataIPSPIndex)
        {
        }

        public override GENERALALERT GetExistDataPC(AnnualFee dataIPSP)
        {
            var sCondition = $"TYPEID = 'annualfee' and ITEMNUMBER = '{dataIPSP.n_YearNo}' and OURNO = '{dataIPSP.TheBasicPatent?.s_CaseSerial}'";
            var existAlert = new PC.BLL.GENERALALERT().GetModelList(sCondition);
            IsExistDataPC = existAlert.Count > 0;
            SyncResultInfoSet.AddInfo(InfoString.ToSyncInfo("年费", IsExistDataPC.Value, dataIPSP.n_AnnualFeeID, dataIPSP.TheBasicPatent?.s_CaseSerial + " 第" + dataIPSP.n_YearNo + "年"),
                dataIPSP.ClassInfo.TableName, typeof(GENERALALERT).Name);
            return existAlert.Count > 0 ? existAlert[0] : null;
        }

        public override void ConvertToDataPC(GENERALALERT dataPC, AnnualFee dataIPSP)
        {
            dataPC.CREATED = DateTime.Now;
            dataPC.TYPEID = "annualfee";
            dataPC.OURNO = dataIPSP.TheBasicPatent?.s_CaseSerial;
            dataPC.ITEMNUMBER = dataIPSP.n_YearNo;
            dataPC.COMPLETEDATE = dataIPSP.dt_OfficialPayDate;
            FillDefaultValue();
            if (!IsExistDataPC.HasValue) return;
            if (IsExistDataPC.Value)
            {
                new PC.BLL.GENERALALERT().Update(dataPC);
            }
            else
            {
                new PC.BLL.GENERALALERT().Add(dataPC);
            }
            while (DateTime.Now < dataPC.CREATED.AddSeconds(1))
            {

            }
        }
    }
}