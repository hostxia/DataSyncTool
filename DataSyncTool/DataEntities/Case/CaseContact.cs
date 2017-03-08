using DataEntities.Contact.Agency;
using DataEntities.Contact.Applicant;
using DevExpress.Xpo;

namespace DataEntities.Case
{
    [Persistent("TCase_Contact")]
    public class CaseContact : XPLiteObject
    {
        private int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        BasicCase basicCase;
        [Association("Case-Contact")]
        [Persistent("n_CaseID")]
        public BasicCase BasicCase
        {
            get { return basicCase; }
            set { SetPropertyValue("n_CaseID", ref basicCase, value); }
        }

        string fs_ContactType;
        [Size(100)]
        public string s_ContactType
        {
            get { return fs_ContactType; }
            set { SetPropertyValue<string>("s_ContactType", ref fs_ContactType, value); }
        }

        int fn_ContactID;
        public int n_ContactID
        {
            get { return fn_ContactID; }
            set { SetPropertyValue<int>("n_ContactID", ref fn_ContactID, value); }
        }

        int fn_Sequence;
        public int n_Sequence
        {
            get { return fn_Sequence; }
            set { SetPropertyValue<int>("n_Sequence", ref fn_Sequence, value); }
        }

        string fs_Identity;
        [Size(50)]
        public string s_Identity
        {
            get { return fs_Identity; }
            set { SetPropertyValue<string>("s_Identity", ref fs_Identity, value); }
        }

        [NonPersistent]
        public XPLiteObject RelatedObject
        {
            get
            {
                var theUow = this.Session as UnitOfWork;
                if (s_ContactType == "Client") return theUow.GetObjectByKey<Contact.Client.ClientContact>(n_ContactID);
                if (s_ContactType == "RelatedClient") return theUow.GetObjectByKey<Contact.Client.ClientContact>(n_ContactID);
                if (s_ContactType == "Applicant") return theUow.GetObjectByKey<ApplicantContact>(n_ContactID);
                if (s_ContactType == "Agency") return theUow.GetObjectByKey<AgencyContact>(n_ContactID);
                return null;
            }
        }

        [NonPersistent]
        public string ContactName
        {
            get
            {
                if (RelatedObject == null) return string.Empty;
                var clientContact = RelatedObject as Contact.Client.ClientContact;
                if (clientContact != null) return clientContact.ContactName;
                var applicantContact = RelatedObject as ApplicantContact;
                if (applicantContact != null) return applicantContact.ContactName;
                var agencyContact = RelatedObject as AgencyContact;
                if (agencyContact != null) return agencyContact.ContactName;
                return string.Empty;
            }
            set { }
        }

        [NonPersistent]
        public string ContactFirstName
        {
            get
            {
                if (RelatedObject == null) return string.Empty;
                var clientContact = RelatedObject as Contact.Client.ClientContact;
                if (clientContact != null) return clientContact.s_FirstName;
                var applicantContact = RelatedObject as ApplicantContact;
                if (applicantContact != null) return applicantContact.s_FirstName;
                var agencyContact = RelatedObject as AgencyContact;
                if (agencyContact != null) return agencyContact.s_FirstName;
                return string.Empty;
            }
            set { }
        }

        [NonPersistent]
        public string ContactLastName
        {
            get
            {
                if (RelatedObject == null) return string.Empty;
                var clientContact = RelatedObject as Contact.Client.ClientContact;
                if (clientContact != null) return clientContact.s_LastName;
                var applicantContact = RelatedObject as ApplicantContact;
                if (applicantContact != null) return applicantContact.s_LastName;
                var agencyContact = RelatedObject as AgencyContact;
                if (agencyContact != null) return agencyContact.s_LastName;
                return string.Empty;
            }
            set { }
        }

        [NonPersistent]
        public string ContactPrefix
        {
            get
            {
                if (RelatedObject == null) return string.Empty;
                var clientContact = RelatedObject as Contact.Client.ClientContact;
                if (clientContact != null) return clientContact.s_Prefix;
                var applicantContact = RelatedObject as ApplicantContact;
                if (applicantContact != null) return applicantContact.s_Prefix;
                var agencyContact = RelatedObject as AgencyContact;
                if (agencyContact != null) return agencyContact.s_Prefix;
                return string.Empty;
            }
            set { }
        }

        [NonPersistent]
        public string ContactEmail
        {
            get
            {
                if (RelatedObject == null) return string.Empty;
                var clientContact = RelatedObject as Contact.Client.ClientContact;
                if (clientContact != null) return clientContact.s_Email;
                var applicantContact = RelatedObject as ApplicantContact;
                if (applicantContact != null) return applicantContact.s_Email;
                var agencyContact = RelatedObject as AgencyContact;
                if (agencyContact != null) return agencyContact.s_Email;
                return string.Empty;
            }
            set { }
        }

        [NonPersistent]
        public string ContactPhone
        {
            get
            {
                if (RelatedObject == null) return string.Empty;
                var clientContact = RelatedObject as Contact.Client.ClientContact;
                if (clientContact != null) return clientContact.s_Phone;
                var applicantContact = RelatedObject as ApplicantContact;
                if (applicantContact != null) return applicantContact.s_Phone;
                var agencyContact = RelatedObject as AgencyContact;
                if (agencyContact != null) return agencyContact.s_Phone;
                return string.Empty;
            }
            set { }
        }

        [NonPersistent]
        public string ContactFax
        {
            get
            {
                if (RelatedObject == null) return string.Empty;
                var clientContact = RelatedObject as Contact.Client.ClientContact;
                if (clientContact != null) return clientContact.s_Fax;
                var applicantContact = RelatedObject as ApplicantContact;
                if (applicantContact != null) return applicantContact.s_Fax;
                var agencyContact = RelatedObject as AgencyContact;
                if (agencyContact != null) return agencyContact.s_Fax;
                return string.Empty;
            }
            set { }
        }

        [NonPersistent]
        public string ContactMobile
        {
            get
            {
                if (RelatedObject == null) return string.Empty;
                var clientContact = RelatedObject as Contact.Client.ClientContact;
                if (clientContact != null) return clientContact.s_Mobile;
                var applicantContact = RelatedObject as ApplicantContact;
                if (applicantContact != null) return applicantContact.s_Mobile;
                var agencyContact = RelatedObject as AgencyContact;
                if (agencyContact != null) return agencyContact.s_Mobile;
                return string.Empty;
            }
            set { }
        }

        [NonPersistent]
        public string ContactAddress1Type
        {
            get
            {
                if (RelatedObject == null) return string.Empty;
                var clientContact = RelatedObject as Contact.Client.ClientContact;
                if (clientContact != null) return clientContact.Address1Type;
                var applicantContact = RelatedObject as ApplicantContact;
                if (applicantContact != null) return applicantContact.Address1Type;
                var agencyContact = RelatedObject as AgencyContact;
                if (agencyContact != null) return agencyContact.Address1Type;
                return string.Empty;
            }
            set { }
        }

        [NonPersistent]
        public string ContactAddress1TypeDisplay
        {
            get
            {
                return ContactAddress1Type.Replace("O", "办公地址")
                    .Replace("E", "办公地址(外文)")
                    .Replace("B", "账单地址")
                    .Replace("M", "转函地址");
            }
            set { }
        }

        [NonPersistent]
        public string ContactAddress1
        {
            get
            {
                if (RelatedObject == null) return string.Empty;
                var clientContact = RelatedObject as Contact.Client.ClientContact;
                if (clientContact != null) return clientContact.Address1;
                var applicantContact = RelatedObject as ApplicantContact;
                if (applicantContact != null) return applicantContact.Address1;
                var agencyContact = RelatedObject as AgencyContact;
                if (agencyContact != null) return agencyContact.Address1;
                return string.Empty;
            }
            set { }
        }

        [NonPersistent]
        public string ContactAddress1EN
        {
            get
            {
                if (RelatedObject == null) return string.Empty;
                var clientContact = RelatedObject as Contact.Client.ClientContact;
                if (clientContact != null) return clientContact.Address1EN;
                var applicantContact = RelatedObject as ApplicantContact;
                if (applicantContact != null) return applicantContact.Address1EN;
                var agencyContact = RelatedObject as AgencyContact;
                if (agencyContact != null) return agencyContact.Address1EN;
                return string.Empty;
            }
            set { }
        }

        [NonPersistent]
        public string ContactAddress1Street
        {
            get
            {
                if (RelatedObject == null) return string.Empty;
                var clientContact = RelatedObject as Contact.Client.ClientContact;
                if (clientContact != null) return clientContact.Address1Street;
                var applicantContact = RelatedObject as ApplicantContact;
                if (applicantContact != null) return applicantContact.Address1Street;
                var agencyContact = RelatedObject as AgencyContact;
                if (agencyContact != null) return agencyContact.Address1Street;
                return string.Empty;
            }
            set { }
        }

        [NonPersistent]
        public string ContactAddress1ZipCode
        {
            get
            {
                if (RelatedObject == null) return string.Empty;
                var clientContact = RelatedObject as Contact.Client.ClientContact;
                if (clientContact != null) return clientContact.Address1ZipCode;
                var applicantContact = RelatedObject as ApplicantContact;
                if (applicantContact != null) return applicantContact.Address1ZipCode;
                var agencyContact = RelatedObject as AgencyContact;
                if (agencyContact != null) return agencyContact.Address1ZipCode;
                return string.Empty;
            }
            set { }
        }

        [NonPersistent]
        public string ContactAddress2Type
        {
            get
            {
                if (RelatedObject == null) return string.Empty;
                var clientContact = RelatedObject as Contact.Client.ClientContact;
                if (clientContact != null) return clientContact.Address2Type;
                var applicantContact = RelatedObject as ApplicantContact;
                if (applicantContact != null) return applicantContact.Address2Type;
                var agencyContact = RelatedObject as AgencyContact;
                if (agencyContact != null) return agencyContact.Address2Type;
                return string.Empty;
            }
            set { }
        }

        [NonPersistent]
        public string ContactAddress2TypeDisplay
        {
            get
            {
                return ContactAddress2Type.Replace("O", "办公地址")
                    .Replace("E", "办公地址(外文)")
                    .Replace("B", "账单地址")
                    .Replace("M", "转函地址");
            }
            set { }
        }

        [NonPersistent]
        public string ContactAddress2
        {
            get
            {
                if (RelatedObject == null) return string.Empty;
                var clientContact = RelatedObject as Contact.Client.ClientContact;
                if (clientContact != null) return clientContact.Address2;
                var applicantContact = RelatedObject as ApplicantContact;
                if (applicantContact != null) return applicantContact.Address2;
                var agencyContact = RelatedObject as AgencyContact;
                if (agencyContact != null) return agencyContact.Address2;
                return string.Empty;
            }
            set { }
        }

        [NonPersistent]
        public string ContactAddress2EN
        {
            get
            {
                if (RelatedObject == null) return string.Empty;
                var clientContact = RelatedObject as Contact.Client.ClientContact;
                if (clientContact != null) return clientContact.Address2EN;
                var applicantContact = RelatedObject as ApplicantContact;
                if (applicantContact != null) return applicantContact.Address2EN;
                var agencyContact = RelatedObject as AgencyContact;
                if (agencyContact != null) return agencyContact.Address2EN;
                return string.Empty;
            }
            set { }
        }

        [NonPersistent]
        public string ContactAddress2Street
        {
            get
            {
                if (RelatedObject == null) return string.Empty;
                var clientContact = RelatedObject as Contact.Client.ClientContact;
                if (clientContact != null) return clientContact.Address2Street;
                var applicantContact = RelatedObject as ApplicantContact;
                if (applicantContact != null) return applicantContact.Address2Street;
                var agencyContact = RelatedObject as AgencyContact;
                if (agencyContact != null) return agencyContact.Address2Street;
                return string.Empty;
            }
            set { }
        }

        [NonPersistent]
        public string ContactAddress2ZipCode
        {
            get
            {
                if (RelatedObject == null) return string.Empty;
                var clientContact = RelatedObject as Contact.Client.ClientContact;
                if (clientContact != null) return clientContact.Address2ZipCode;
                var applicantContact = RelatedObject as ApplicantContact;
                if (applicantContact != null) return applicantContact.Address2ZipCode;
                var agencyContact = RelatedObject as AgencyContact;
                if (agencyContact != null) return agencyContact.Address2ZipCode;
                return string.Empty;
            }
            set { }
        }

        [NonPersistent]
        public string ContactAddress3Type
        {
            get
            {
                if (RelatedObject == null) return string.Empty;
                var clientContact = RelatedObject as Contact.Client.ClientContact;
                if (clientContact != null) return clientContact.Address3Type;
                var applicantContact = RelatedObject as ApplicantContact;
                if (applicantContact != null) return applicantContact.Address3Type;
                var agencyContact = RelatedObject as AgencyContact;
                if (agencyContact != null) return agencyContact.Address3Type;
                return string.Empty;
            }
            set { }
        }

        [NonPersistent]
        public string ContactAddress3TypeDisplay
        {
            get
            {
                return ContactAddress3Type.Replace("O", "办公地址")
                    .Replace("E", "办公地址(外文)")
                    .Replace("B", "账单地址")
                    .Replace("M", "转函地址");
            }
            set { }
        }

        [NonPersistent]
        public string ContactAddress3
        {
            get
            {
                if (RelatedObject == null) return string.Empty;
                var clientContact = RelatedObject as Contact.Client.ClientContact;
                if (clientContact != null) return clientContact.Address3;
                var applicantContact = RelatedObject as ApplicantContact;
                if (applicantContact != null) return applicantContact.Address3;
                var agencyContact = RelatedObject as AgencyContact;
                if (agencyContact != null) return agencyContact.Address3;
                return string.Empty;
            }
            set { }
        }

        [NonPersistent]
        public string ContactAddress3EN
        {
            get
            {
                if (RelatedObject == null) return string.Empty;
                var clientContact = RelatedObject as Contact.Client.ClientContact;
                if (clientContact != null) return clientContact.Address3EN;
                var applicantContact = RelatedObject as ApplicantContact;
                if (applicantContact != null) return applicantContact.Address3EN;
                var agencyContact = RelatedObject as AgencyContact;
                if (agencyContact != null) return agencyContact.Address3EN;
                return string.Empty;
            }
            set { }
        }

        [NonPersistent]
        public string ContactAddress3Street
        {
            get
            {
                if (RelatedObject == null) return string.Empty;
                var clientContact = RelatedObject as Contact.Client.ClientContact;
                if (clientContact != null) return clientContact.Address3Street;
                var applicantContact = RelatedObject as ApplicantContact;
                if (applicantContact != null) return applicantContact.Address3Street;
                var agencyContact = RelatedObject as AgencyContact;
                if (agencyContact != null) return agencyContact.Address3Street;
                return string.Empty;
            }
            set { }
        }

        [NonPersistent]
        public string ContactAddress3ZipCode
        {
            get
            {
                if (RelatedObject == null) return string.Empty;
                var clientContact = RelatedObject as Contact.Client.ClientContact;
                if (clientContact != null) return clientContact.Address3ZipCode;
                var applicantContact = RelatedObject as ApplicantContact;
                if (applicantContact != null) return applicantContact.Address3ZipCode;
                var agencyContact = RelatedObject as AgencyContact;
                if (agencyContact != null) return agencyContact.Address3ZipCode;
                return string.Empty;
            }
            set { }
        }

        public CaseContact(Session session) : base(session) { }
    }
}