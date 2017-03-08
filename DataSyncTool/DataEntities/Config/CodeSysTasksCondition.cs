using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_SysTasksCondition")]
    public class CodeSysTasksCondition : XPLiteObject
    {
        private string _displayValue;
        private CodeSysTasks codeSysTasks;
        private int fn_ID;
        private string fs_Methord;
        private string fs_Value;

        public CodeSysTasksCondition(Session session) : base(session)
        {
        }

        public CodeSysTasksCondition() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("CodeSysTask-CodeSysTaskCondition")]
        [Persistent("n_SysTaskCodeID")]
        public CodeSysTasks CodeSysTasks
        {
            get { return codeSysTasks; }
            set { SetPropertyValue("n_SysTaskCodeID", ref codeSysTasks, value); }
        }

        public string s_Methord
        {
            get { return fs_Methord; }
            set { SetPropertyValue("s_Methord", ref fs_Methord, value); }
        }

        [Size(50)]
        public string s_Value
        {
            get { return fs_Value; }
            set { SetPropertyValue("s_Value", ref fs_Value, value); }
        }

        [NonPersistent]
        public string DisPlayValue
        {
            get
            {
                GetDisplayItem();
                return _displayValue;
            }
            set
            {
                _displayValue = value;
                getValue();
            }
        }


        public void getValue()
        {
            string fileName = GetConditionFilePath();
            //string fileName = Application.StartupPath + "\\Config" + "\\Condition.xml";
            if (!File.Exists(fileName)) return;
            var xmlDocument = new XmlDocument();
            xmlDocument.Load(fileName);
            XmlNode rootNode = xmlDocument.SelectSingleNode("/Resources");
            if (rootNode == null) return;
            XmlNodeList nodeList = rootNode.SelectNodes("Condition");
            foreach (XmlNode xmlNode in nodeList)
            {
                if (xmlNode.Attributes["Value"].Value == s_Methord)
                {
                    XmlNodeList nodeListItem = xmlNode.SelectNodes("Item");
                    foreach (XmlNode xmlNode1 in nodeListItem)
                    {
                        if (xmlNode1.Attributes["Text"].Value == _displayValue)
                        {
                            s_Value = xmlNode1.Attributes["Value"].Value;
                            return;
                        }
                    }
                }
            }
            s_Value = "";
        }

        private string GetConditionFilePath()
        {
            string sFilePath = Application.StartupPath + "\\Config\\DefaultLoadConfig.ini";
            string sSetion = "Language";
            string sKey = "Language";
            string missValue = "zh-CN";
            var sLanguage = new StringBuilder(100);
            //APIFunctions.GetPrivateProfileString(sSetion, sKey, missValue, sLanguage, 100,
            //    sFilePath);
            if (sLanguage.ToString() == string.Empty) sLanguage.Append(missValue);
            string fileName = "";
            switch (sLanguage.ToString())
            {
                case "zh-CN":
                    switch (codeSysTasks.s_IPType)
                    {
                        case "P":
                            fileName = Application.StartupPath + "\\Config" + "\\Condition.xml";
                            break;
                        case "T":
                            fileName = Application.StartupPath + "\\Config" + "\\Condition_T.xml";
                            break;
                        case "D":
                            fileName = "";
                            break;
                        case "C":
                            fileName = "";
                            break;
                        case "O":
                            fileName = "";
                            break;
                    }
                    break;
                case "en-US":
                    switch (codeSysTasks.s_IPType)
                    {
                        case "P":
                            fileName = Application.StartupPath + "\\Config" + "\\Condition_EN.xml";
                            break;
                        case "T":
                            fileName = Application.StartupPath + "\\Config" + "\\Condition_T_EN.xml";
                            break;
                        case "D":
                            fileName = "";
                            break;
                        case "C":
                            fileName = "";
                            break;
                        case "O":
                            fileName = "";
                            break;
                    }
                    break;
            }
            return fileName;
        }

        public string GetDisplayItem()
        {
            string fileName = GetConditionFilePath();
            //string fileName = Application.StartupPath + "\\Config" + "\\Condition.xml";
            if (!File.Exists(fileName)) return null;
            var xmlDocument = new XmlDocument();
            xmlDocument.Load(fileName);
            XmlNode rootNode = xmlDocument.SelectSingleNode("/Resources");
            if (rootNode == null) return null;
            XmlNodeList nodeList = rootNode.SelectNodes("Condition");
            foreach (XmlNode xmlNode in nodeList)
            {
                if (xmlNode.Attributes["Value"].Value == s_Methord)
                {
                    XmlNodeList nodeListItem = xmlNode.SelectNodes("Item");
                    foreach (XmlNode xmlNode1 in nodeListItem)
                    {
                        if (xmlNode1.Attributes["Value"].Value == s_Value)
                        {
                            return _displayValue = xmlNode1.Attributes["Text"].Value;
                        }
                    }
                }
            }
            return "";
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}