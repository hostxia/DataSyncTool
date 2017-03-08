using System;
using DevExpress.Xpo;

namespace DataEntities.Config.Log
{
    [Persistent("T_Log")]
    public class Log : XPLiteObject
    {
        private DateTime fdt_Date;
        private int fn_ID;
        private string fs_Content;

        private string fs_Module;

        private string fs_Operator;
        private string fs_Type;

        public Log(Session session) : base(session)
        {
        }

        public Log() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        public string s_Module
        {
            get { return fs_Module; }
            set { SetPropertyValue("s_Module", ref fs_Module, value); }
        }

        public string s_Operator
        {
            get { return fs_Operator; }
            set { SetPropertyValue("s_Operator", ref fs_Operator, value); }
        }

        public DateTime dt_Date
        {
            get { return fdt_Date; }
            set { SetPropertyValue<DateTime>("dt_Date", ref fdt_Date, value); }
        }

        [Size(500)]
        public string s_Content
        {
            get { return fs_Content; }
            set { SetPropertyValue("s_Content", ref fs_Content, value); }
        }

        /// <summary>
        ///     A:管理员;N:普通用户
        /// </summary>
        [Size(1)]
        public string s_Type
        {
            get { return fs_Type; }
            set { SetPropertyValue("s_Type", ref fs_Type, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}