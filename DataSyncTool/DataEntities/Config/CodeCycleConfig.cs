using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataEntities.Contact.Client;
using DataEntities.Element.Emails;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_CycleConfig")]
    public class CodeCycleConfig : XPLiteObject
    {

        private int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        private int fn_PaymentCycle;//催款周期
        public int n_PaymentCycle
        {
            get { return fn_PaymentCycle; }
            set { SetPropertyValue<int>("n_PaymentCycle", ref fn_PaymentCycle, value); }
        }

        private int fn_LetterTemplateID;//催款模板
        public int n_LetterTemplateID
        {
            get { return fn_LetterTemplateID; }
            set { SetPropertyValue<int>("n_LetterTemplateID", ref fn_LetterTemplateID, value); }
        }

        //private CodeLetterTemplate _codeLetterTemplate;
        //[Persistent("n_LetterTemplateID"), Association("LetterTemplate-CycleConfig")]
        //public CodeLetterTemplate TheCodeLetterTemplate
        //{
        //    get { return _codeLetterTemplate; }
        //    set { SetPropertyValue("n_LetterTemplateID", ref _codeLetterTemplate, value); }
        //}
        private int fn_EmailTemplateID;//催款邮件模板
        public int n_EmailTemplateID
        {
            get { return fn_EmailTemplateID; }
            set { SetPropertyValue<int>("n_EmailTemplateID", ref fn_EmailTemplateID, value); }
        }
        //private EmailTemplate _emailTemplate;
        //[Persistent("n_EmailTemplateID"), Association("EmailTemplate-CycleConfig")]
        //public EmailTemplate TheEmailTemplate
        //{
        //    get { return _emailTemplate; }
        //    set { SetPropertyValue("n_EmailTemplateID", ref _emailTemplate, value); }
        //} 

        //private int fn_ClientID;
        //public int n_ClientID
        //{
        //    get { return fn_ClientID; }
        //    set { SetPropertyValue<int>("n_ClientID", ref fn_ClientID, value); }
        //}
        private Client _client;
        [Persistent("n_ClientID"), Association("Client-CodeCycleConfig")]
        public Client TheClient
        {
            get { return _client; }
            set { SetPropertyValue("n_ClientID", ref _client, value); }
        }

        private int fn_Sequence;//催款次数
        public int n_Sequence
        {
            get { return fn_Sequence; }
            set { SetPropertyValue<int>("n_Sequence", ref fn_Sequence, value); }
        }

        private string fs_GlobalConfig;//是否是全局配置的催款
        [Size(2)]
        public string s_GlobalConfig
        {
            get { return fs_GlobalConfig; }
            set { SetPropertyValue("s_GlobalConfig", ref fs_GlobalConfig, value); }
        }

        public CodeCycleConfig(Session session)
            : base(session)
        {
        }

        public CodeCycleConfig()
            : base(Session.DefaultSession)
        {
        }
    }
}
