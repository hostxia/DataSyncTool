using System;
using DataEntities.Properties;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_SerialRule")]
    public class CodeSerialRule : XPLiteObject
    {
        private string _description;
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private int fn_ID;
        private int fn_Order;
        private int fn_SnippetLength;

        private string fs_MasterType;
        private string fs_SnippetType;
        private string fs_SnippetValue;

        public CodeSerialRule(Session session)
            : base(session)
        {
        }

        public CodeSerialRule()
            : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Size(1)]
        public string s_IPType
        {
            get { return fs_MasterType; }
            set { SetPropertyValue("s_IPType", ref fs_MasterType, value); }
        }

        public int n_Order
        {
            get { return fn_Order; }
            set { SetPropertyValue<int>("n_Order", ref fn_Order, value); }
        }

        [Size(50)]
        public string s_SnippetType
        {
            get { return fs_SnippetType; }
            set { SetPropertyValue("s_SnippetType", ref fs_SnippetType, value); }
        }

        public int n_SnippetLength
        {
            get { return fn_SnippetLength; }
            set { SetPropertyValue<int>("n_SnippetLength", ref fn_SnippetLength, value); }
        }

        [Size(200)]
        public string s_SnippetValue
        {
            get { return fs_SnippetValue; }
            set { SetPropertyValue("s_SnippetValue", ref fs_SnippetValue, value); }
        }

        public DateTime dt_CreateDate
        {
            get { return fdt_CreateDate; }
            set { SetPropertyValue<DateTime>("dt_CreateDate", ref fdt_CreateDate, value); }
        }

        public DateTime dt_EditDate
        {
            get { return fdt_EditDate; }
            set { SetPropertyValue<DateTime>("dt_EditDate", ref fdt_EditDate, value); }
        }

        /// <summary>
        ///     显示的描述信息
        /// </summary>
        public string s_Description
        {
            get
            {
                GetTheDescription();
                return _description;
            }
            set { SetPropertyValue("s_Description", ref _description, value); }
        }

        /// <summary>
        ///     获取描述信息
        ///     coder:likai(2010-06-11)
        /// </summary>
        /// <returns></returns>
        private void GetTheDescription()
        {
            switch (s_SnippetType)
            {
                case "4":
                    if (s_SnippetValue == string.Empty)
                    {
                        fs_SnippetValue = string.Format("{0};{1};{2};{3}", Resource.In_In_Value, Resource.In_Out_Value,
                            Resource.Out_In_Value, Resource.Out_Out_Value);
                        //_description = string.Empty;
                        //break;
                    }
                    string[] flowDValue = s_SnippetValue.Split(';');
                    if (flowDValue.Length != 4)
                    {
                        _description = string.Empty;
                        break;
                    }
                    _description = string.Format("{0}{1};{2}{3};{4}{5};{6}{7}", Resource.In_In, flowDValue[0],
                        Resource.In_Out, flowDValue[1],
                        Resource.Out_In, flowDValue[2], Resource.Out_Out, flowDValue[3]);
                    break;
                case "5":
                    if (s_SnippetValue == string.Empty)
                    {
                        _description = string.Empty;
                        break;
                    }
                    string[] flowNValue = s_SnippetValue.Split(';');
                    if (flowNValue.Length < 2)
                    {
                        _description = string.Empty;
                        break;
                    }
                    //_description = string.Format("{0};{1}", SwitchField(flowNValue[0]), SwitchField(flowNValue[1]));
                    if (flowNValue.Length == 2)
                    {
                        _description = string.Format("{0};{1}", SwitchField(flowNValue[0]), SwitchField(flowNValue[1]));
                    }
                    else
                    {
                        _description = string.Format("{0};{1};{2}", SwitchField(flowNValue[0]), SwitchField(flowNValue[1]), SwitchField(flowNValue[2]));
                    }
                    break;
                case "10":
                    if (s_SnippetValue == string.Empty)
                    {
                        _description = string.Empty;
                        break;
                    }
                    string[] typeValue = s_SnippetValue.Split(';');
                    if (typeValue.Length != 2)
                    {
                        _description = string.Empty;
                        break;
                    }
                    _description = string.Format("{0}{1};{2}{3}", Resource.Paper, typeValue[0],
                        Resource.Online, typeValue[1]);
                    break;
                case "12":
                    if (s_SnippetValue == string.Empty)
                    {
                        _description = string.Empty;
                        break;
                    }
                    string[] wayValue = s_SnippetValue.Split(';');
                    if (wayValue.Length != 2)
                    {
                        _description = string.Empty;
                        break;
                    }
                    _description = string.Format("{0}{1};{2}{3}", Resource.SingleApplicate, wayValue[0],
                        Resource.MadridApplicate, wayValue[1]);
                    break;
                case "-1":
                case "0":
                case "1":
                case "11":
                case "15":
                case "16":
                case "17":
                case "18":
                case "7":
                case "21":
                    _description = s_SnippetValue;
                    break;
                case "2":
                    _description = Resource.FromBussinessType;
                    break;
                case "3":
                    _description = Resource.FromPatentType;
                    break;
                case "6":
                    _description = Resource.FromClientCode;
                    break;
                case "20":
                    _description = Resource.FromApplicantCode;
                    break;
                //case "7":
                //    _description = Properties.Resource.FromEmployeeCode;
                //    break;
                case "8":
                    _description = Resource.FromIntroducerCode;
                    break;
                case "9":
                    _description = Resource.RegCountryOrState;
                    break;
                case "19":
                    if (s_SnippetValue == string.Empty)
                    {
                        fs_SnippetValue = "1;1";
                        //_description = string.Empty;
                        //break;
                    }
                    string[] lengthValues = s_SnippetValue.Split(';');
                    if (lengthValues.Length != 2)
                    {
                        _description = string.Empty;
                        break;
                    }
                    _description = string.Format("{0}{1}{2}{3}{4}", Resource.From, lengthValues[0], Resource.To,
                        lengthValues[1], Resource.Place);
                    break;
                default:
                    _description = string.Empty;
                    break;
            }
        }

        /// <summary>
        ///     根据流水号的字段获取显示内容
        ///     coder:likai(2010-06-11)
        /// </summary>
        /// <param name="sValue">字段</param>
        /// <returns></returns>
        private string SwitchField(string sValue)
        {
            if (sValue == "-1")
                return Resource.NotUse;
            if (sValue == "14")
                return Resource.AcceptYear;
            if (sValue == "2")
                return Resource.BussinessType;
            if (sValue == "4")
                return Resource.FlowDirection;
            if (sValue == "10")
                return Resource.ApplicateType;
            if (sValue == "3")
                return Resource.PatentType;
            if (sValue == "13")
                return Resource.TypeOfBussinessType;
            if (sValue == "12")
                return Resource.ApplicateWay;
            if (sValue == "11")
                return Resource.TrademarkType;
            if (sValue == "A")
                return Resource.MaxNumber;
            if (sValue == "B")
                return Resource.FollowNotUsed;
            if (sValue == "Y")
                return "一标多类用同一流水号";
            return string.Empty;
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}