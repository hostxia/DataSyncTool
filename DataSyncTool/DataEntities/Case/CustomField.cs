using DataEntities.Config;
using DevExpress.Xpo;

namespace DataEntities.Case
{
    [Persistent("TCase_CaseCustomField")]
    public class CustomField : XPLiteObject
    {
        private BasicCase basicCase;
        private int fn_FieldCodeID;
        private int fn_ID;
        private string fs_Value;

        public CustomField(Session session)
            : base(session)
        {
        }

        public CustomField()
            : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("Case-CustomFields")]
        [Persistent("n_CaseID")]
        public BasicCase BasicCase
        {
            get { return basicCase; }
            set { SetPropertyValue("n_CaseID", ref basicCase, value); }
        }

        public int n_FieldCodeID
        {
            get { return fn_FieldCodeID; }
            set { SetPropertyValue<int>("n_FieldCodeID", ref fn_FieldCodeID, value); }
        }

        [Size(500)]
        public string s_Value
        {
            get { return fs_Value; }
            set { SetPropertyValue("s_Value", ref fs_Value, value); }
        }

        [NonPersistent]
        public string sFieldName
        {
            get
            {
                using (var tempUow = new UnitOfWork())
                {
                    var customField =
                        tempUow.GetObjectByKey<CodeCaseCustomField>(n_FieldCodeID);
                    if (customField == null) return string.Empty;
                    return customField.s_CustomFieldName;
                }
            }
        }

        [NonPersistent]
        public string sFieldType
        {
            get
            {
                using (var tempUow = new UnitOfWork())
                {
                    var customField =
                        tempUow.GetObjectByKey<CodeCaseCustomField>(n_FieldCodeID);
                    if (customField == null) return string.Empty;
                    return customField.s_Type;
                }
            }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}