using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DataEntities.Case;
using DataEntities.Case.Patents;
using DataEntities.Element.Files;
using DataEntities.TaskFlowConfig;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata.Helpers;

namespace DataEntities
{
    public static class ConmonFunctionForUpdate
    {
        private static readonly Hashtable ObjectKeyName = new Hashtable();
        private static readonly Hashtable ObjectProperties = new Hashtable();

        private static string GetXpObjectKeyName(this Type type)
        {
            if (ObjectKeyName.Contains(type)) return (string)ObjectKeyName[type];
            var sKeyName = type.GetProperties().ToList().First(p => p.GetCustomAttributes(typeof(KeyAttribute), true).Length > 0).Name;
            ObjectKeyName.Add(type, sKeyName);
            return sKeyName;
        }

        public static void CopyDataEntityFileds<T>(T xpoSource, T xpoTarget, List<MonitorField> listMonitorFileds) where T : XPLiteObject
        {
            if (xpoSource == null || xpoTarget == null) return;
            var type = xpoSource.GetType();
            var sKeyName = type.GetXpObjectKeyName();

            List<PropertyInfo> listPropertyInfo;
            if (ObjectProperties.Contains(type))
            {
                listPropertyInfo = (List<PropertyInfo>)ObjectProperties[type];
            }
            else
            {
                listPropertyInfo = type.GetProperties().Where(p => p.Name != sKeyName && p.CanWrite && p.CanRead && listMonitorFileds.Select(s => s.FieldName).Contains(p.Name)).ToList();
                ObjectProperties.Add(type, listPropertyInfo);
            }
            var keyPropertyInfo = type.GetProperties().FirstOrDefault(p => p.Name == sKeyName);
            if (!listPropertyInfo.Contains(keyPropertyInfo)) listPropertyInfo.Add(keyPropertyInfo);
            listPropertyInfo.ForEach(p => xpoTarget.SetMemberValue(p.Name, xpoSource.GetMemberValue(p.Name)));
        }

        public static void CompareDataEntityFiledsForDeadline<T>(T xpoNew, T xpoOriginal, List<MonitorField> listMonitorFileds) where T : XPLiteObject
        {
            if (xpoNew == null || xpoOriginal == null) return;
            var type = xpoNew.GetType();
            var listPropertyInfo = (List<PropertyInfo>)ObjectProperties[type];
            foreach (MonitorField monitorField in listMonitorFileds)
            {
                if (monitorField.MonitorType != EnumMonitorType.Deadline) continue;
                var propertyInfo = listPropertyInfo.FirstOrDefault(f => f.Name == monitorField.FieldName);
                if (propertyInfo == null) continue;
                var dtNewValue = (DateTime)(xpoNew.GetMemberValue(propertyInfo.Name) ?? DateTime.MinValue);
                var dtOriginalValue = (DateTime)(xpoOriginal.GetMemberValue(propertyInfo.Name) ?? DateTime.MinValue);
                if (dtNewValue == dtOriginalValue) continue;
                var codeBaseDate = new UnitOfWork().FindObject<TFCodeBaseDate>(CriteriaOperator.Parse("s_NameSpace = ? AND s_FieldName = ?", monitorField.CodeNameSpace, monitorField.CodeFieldName));
                if (codeBaseDate == null) continue;
                int nKeyValue = 0;
                if (monitorField.CodeFieldName.Contains("TheLawInfo"))
                {
                    object obj = null;
                    var patentLawInfo = xpoNew as DataEntities.Case.Patents.LawInfo;
                    if (patentLawInfo != null) obj = xpoNew.GetMemberValue("BasePatents");
                    var trademarkLawInfo = xpoNew as DataEntities.Case.Trademarks.LawInfo;
                    if (trademarkLawInfo != null) obj = xpoNew.GetMemberValue("Cases");
                    if (obj == null) continue;
                    var xpc = obj as XPCollection;
                    var list = xpc.Cast<BasicCase>().ToList();
                    foreach (var xpLiteObject in list)
                    {
                        var t = xpLiteObject.GetType();
                        nKeyValue = (int)xpLiteObject.GetMemberValue(t.GetXpObjectKeyName());
                        if (nKeyValue <= 0) continue;
                        //IPSServiceMethodsSingleton.Instance.ByServerAutoUpdateDeadlineByCodeBaseDate(codeBaseDate.n_ID, "Case", nKeyValue);
                    }
                    continue;
                }

                if (monitorField.CodeFieldName.Contains("TheOrigPatInfo"))
                {
                    var origPatInfo = xpoNew as OrigPatInfo;
                    if (origPatInfo == null) continue;
                    var obj = xpoNew.GetMemberValue("BasePatents");
                    var xpc = obj as XPCollection;
                    if (xpc == null) continue;
                    var list = xpc.Cast<BasicCase>().ToList();
                    foreach (var xpLiteObject in list)
                    {
                        var t = xpLiteObject.GetType();
                        nKeyValue = (int)xpLiteObject.GetMemberValue(t.GetXpObjectKeyName());
                        if (nKeyValue <= 0) continue;
                        //IPSServiceMethodsSingleton.Instance.ByServerAutoUpdateDeadlineByCodeBaseDate(codeBaseDate.n_ID, "Case", nKeyValue);
                    }
                    continue;
                }

                nKeyValue = (int)xpoNew.GetMemberValue(type.GetXpObjectKeyName());
                if (nKeyValue <= 0) continue;
                //if (monitorField.CodeNameSpace.Contains("DataEntities.Case"))
                //{
                //    IPSServiceMethodsSingleton.Instance.ByServerAutoUpdateDeadlineByCodeBaseDate(codeBaseDate.n_ID, "Case", nKeyValue);
                //    continue;
                //}
                //if (monitorField.CodeNameSpace.Contains("DataEntities.Element.Files"))
                //{
                //    IPSServiceMethodsSingleton.Instance.ByServerAutoUpdateDeadlineByCodeBaseDate(codeBaseDate.n_ID, "CameFileOfficial", nKeyValue);
                //    continue;
                //}
            }
        }

        public static void CompareDataEntityFiledsForRelatedInfo<T>(T xpoNew, T xpoOriginal, List<MonitorField> listMonitorFileds) where T : XPLiteObject
        {
            if (xpoNew == null || xpoOriginal == null) return;
            var type = xpoNew.GetType();
            var listPropertyInfo = (List<PropertyInfo>)ObjectProperties[type];
            MonitorField anyMatchedMonitorFiled = null;
            foreach (MonitorField monitorField in listMonitorFileds)
            {
                if (anyMatchedMonitorFiled != null) continue;
                if (monitorField.MonitorType != EnumMonitorType.RelatedInfo) continue;
                var propertyInfo = listPropertyInfo.FirstOrDefault(f => f.Name == monitorField.FieldName);
                if (propertyInfo == null) continue;
                var dtNewValue = (string)(xpoNew.GetMemberValue(propertyInfo.Name));
                var dtOriginalValue = (string)(xpoOriginal.GetMemberValue(propertyInfo.Name));
                if (dtNewValue == dtOriginalValue) continue;
                anyMatchedMonitorFiled = monitorField;
            }
            if (anyMatchedMonitorFiled == null) return;
            var baseFile = xpoNew as BaseFile;
            if (baseFile != null)
            {
                if (baseFile.s_IOType != "I" || baseFile.s_ClientGov != "O") return;
                //IPSServiceMethodsSingleton.Instance.ByServerAutoUpdateRelatedInfo("CameFileOfficial", baseFile.n_FileID);
                return;
            }
            var listToBeUpdatedBaseCase = new List<BasicCase>();
            var baseCase = xpoNew as BasicCase;
            if (baseCase != null) listToBeUpdatedBaseCase.Add(baseCase);
            if (anyMatchedMonitorFiled.CodeFieldName.Contains("TheLawInfo"))
            {
                object obj = null;
                var patentLawInfo = xpoNew as DataEntities.Case.Patents.LawInfo;
                if (patentLawInfo != null) obj = xpoNew.GetMemberValue("BasePatents");
                var trademarkLawInfo = xpoNew as DataEntities.Case.Trademarks.LawInfo;
                if (trademarkLawInfo != null) obj = xpoNew.GetMemberValue("Cases");
                if (obj == null) return;
                var xpc = obj as XPCollection;
                if (xpc == null) return;
                listToBeUpdatedBaseCase = xpc.Cast<BasicCase>().ToList();
            }
            foreach (var toBeUpdatedBaseCase in listToBeUpdatedBaseCase)
            {
                //IPSServiceMethodsSingleton.Instance.ByServerAutoUpdateRelatedInfo("Case", toBeUpdatedBaseCase.n_CaseID);
                var listFileInCases = toBeUpdatedBaseCase.FileInCases.Cast<FileInCase>().ToList();
                foreach (var fileInCase in listFileInCases)
                {
                    var file = fileInCase.TheFile;
                    if (file == null || file.s_IOType != "I" || file.s_ClientGov != "O") continue;
                    //IPSServiceMethodsSingleton.Instance.ByServerAutoUpdateRelatedInfo("CameFileOfficial", file.n_FileID);
                }
            }
        }

        public class MonitorField
        {
            public EnumMonitorType MonitorType { get; set; }
            public string FieldName { get; set; }
            public string CodeNameSpace { get; set; }
            public string CodeFieldName { get; set; }
        }

        public enum EnumMonitorType
        {
            Deadline,
            RelatedInfo,
        }
    }
}