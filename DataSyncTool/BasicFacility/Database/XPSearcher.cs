using System;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace BasicFacility.Database
{
    public static class XPSearcher
    {
        public static XPDataView ExecuteSqlQuery(this UnitOfWork uow, string sSqlString)
        {
            var dv = new XPDataView();
            var result = uow.ExecuteQueryWithMetadata(sSqlString);
            if (result.ResultSet[0].Rows.Length > 0)
            {
                foreach (var r in result.ResultSet[0].Rows)
                {
                    dv.AddProperty((string) r.Values[0],
                        DBColumn.GetType((DBColumnType) Enum.Parse(typeof (DBColumnType), (string) r.Values[2])));
                }
                dv.LoadData(new SelectedData(result.ResultSet[1]));
            }
            return dv;
        }
    }
}