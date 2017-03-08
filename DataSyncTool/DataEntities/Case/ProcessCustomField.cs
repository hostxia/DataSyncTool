using DataEntities.Config;
using DevExpress.Xpo;

namespace DataEntities.Case
{
    [Persistent("TCase_ProcessCustomField")]
    public class ProcessCustomField : XPLiteObject
    {
        private readonly XPDelayedProperty fn_FieldCodeID = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Value = new XPDelayedProperty();
        private int fn_ID;

        private Process process;

        public ProcessCustomField(Session session) : base(session)
        {
        }

        public ProcessCustomField() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("Process-CustomFields")]
        [Persistent("n_ProcessID")]
        public Process Process
        {
            get { return process; }
            set { SetPropertyValue("n_ProcessID", ref process, value); }
        }

        [Delayed("fn_FieldCodeID")]
        public int n_FieldCodeID
        {
            get
            {
                if (fn_FieldCodeID.Value == null)
                {
                    return -1;
                }
                return (int) fn_FieldCodeID.Value;
            }
            set { fn_FieldCodeID.Value = value; }
        }

        [Delayed("fs_Value")]
        public string s_Value
        {
            get { return (string) fs_Value.Value; }
            set { fs_Value.Value = value; }
        }

        [NonPersistent]
        public string FieldName
        {
            get
            {
                using (var tempUow = new UnitOfWork())
                {
                    var codeProcess = tempUow.GetObjectByKey<CodeProcessCustomField>(n_FieldCodeID);
                    return codeProcess == null ? null : codeProcess.s_CustomFieldName;
                }
            }
        }

        [NonPersistent]
        public string FieldType
        {
            get
            {
                using (var tempUow = new UnitOfWork())
                {
                    var codeProcess = tempUow.GetObjectByKey<CodeProcessCustomField>(n_FieldCodeID);
                    return codeProcess == null ? null : codeProcess.s_Type;
                }
            }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}