namespace DataSyncTool.Log
{
    public static class InfoString
    {
        public static string ToSyncInfo(string sDataName, bool bUpdate, object sId, string sCode)
        {
            return $"{(bUpdate ? "更新" : "添加")}{sDataName}信息：({sId}) {sCode}";
        }

        public static string ToSkipInfo(string sFieldName, object sId, string sCode)
        {
            return $"由于未填写{sFieldName}，跳过同步：({sId}) {sCode}";
        }
    }
}