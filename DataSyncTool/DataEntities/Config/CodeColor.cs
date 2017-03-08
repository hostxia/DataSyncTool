using System;
using DataEntities.Properties;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_ColorConfig")]
    public class CodeColorConfig : XPLiteObject
    {
        private decimal fn_AbsDay;
        private int fn_ID;
        private string fs_BackColor;
        private string fs_DateFieldName;
        private string fs_ForeColor;

        private string fs_ModuleName;
        private string fs_TypeForTask;

        public CodeColorConfig(Session session) : base(session)
        {
        }

        public CodeColorConfig() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        public string s_ModuleName
        {
            get { return fs_ModuleName; }
            set { SetPropertyValue("s_ModuleName", ref fs_ModuleName, value); }
        }

        public string s_DateFieldName
        {
            get { return fs_DateFieldName; }
            set { SetPropertyValue("s_DateFieldName", ref fs_DateFieldName, value); }
        }

        public decimal n_AbsDay
        {
            get { return fn_AbsDay; }
            set { SetPropertyValue<decimal>("n_AbsDay", ref fn_AbsDay, value); }
        }
        string fs_ToolTip;
        [Size(50)]
        public string s_ToolTip
        {
            get { return fs_ToolTip; }
            set { SetPropertyValue<string>("s_ToolTip", ref fs_ToolTip, value); }
        }

        public string s_ForeColor
        {
            get { return fs_ForeColor; }
            set { SetPropertyValue("s_ForeColor", ref fs_ForeColor, value); }
        }

        public string s_BackColor
        {
            get { return fs_BackColor; }
            set { SetPropertyValue("s_BackColor", ref fs_BackColor, value); }
        }

        public DateTime s_DateNow
        {
            get { return DateTime.Now; }
        }

        public string s_ModuleFieldName
        {
            get { return fs_ModuleName + "." + fs_DateFieldName; }
        }

        public string s_AbsDay
        {
            get
            {
                if (fn_AbsDay == 0)
                    return Resource.Color_Config_Be_Due;
                if (fn_AbsDay < 0 && fn_AbsDay != -2)
                    return Resource.Color_Config_Overdue;
                if (fn_AbsDay > 0)
                    return Resource.Color_Config_Before_1 + fn_AbsDay + Resource.Color_Config_Before_2;
                return fs_TypeForTask + Resource.RadioGroup_3_Text;
            }
        }

        public string s_TypeForTask
        {
            get { return fs_TypeForTask; }
            set { SetPropertyValue("s_TypeForTask", ref fs_TypeForTask, value); }
        }

        public double TypeForTask
        {
            get
            {
                try
                {
                    double num = 0;
                    switch (fs_TypeForTask)
                    {
                        case "1/3":
                            double.TryParse((1/3F).ToString(), out num);
                            break;
                        case "1/2":
                            double.TryParse((1/2F).ToString(), out num);
                            break;
                        case "2/3":
                            double.TryParse((2/3F).ToString(), out num);
                            break;
                    }
                    return num;
                }
                catch
                {
                    return -1F;
                }
            }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}