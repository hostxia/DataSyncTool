using System;
using DevExpress.Xpo;

namespace DataEntities.Case.Patents
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("TPCase_WriteInfo")]
    public class CaseWriting : ExtendedPatent
    {
        //int fn_ID;
        //[Key(true)]
        //public int n_ID
        //{
        //    get { return fn_ID; }
        //    set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        //}
        //Patent fn_CaseID;
        //[Association("Patent-WriteInfo")]
        //[Persistent("n_CaseID")]
        //public Patent Patent
        //{
        //    get { return fn_CaseID; }
        //    set { SetPropertyValue<Patent>("n_CaseID", ref fn_CaseID, value); }
        //}

        private DateTime fdt_WriteAssignDate;
        private DateTime fdt_WriteEndDate;
        private DateTime fdt_WriteLtdDate;
        private int fn_DescPageNum;
        private int fn_ImgNum;
        private int fn_PowerItemNum;
        private int fn_TypeWritePageNum;
        private int fn_TypewriteID;
        private int fn_WriterID;
        private string fs_WriteQuality;

        public CaseWriting(Session session) : base(session)
        {
        }

        public CaseWriting() : base(Session.DefaultSession)
        {
        }

        [Size(50)]
        public int n_WriterID
        {
            get { return fn_WriterID; }
            set { SetPropertyValue<int>("n_WriterID", ref fn_WriterID, value); }
        }

        public DateTime dt_WriteAssignDate
        {
            get { return fdt_WriteAssignDate; }
            set { SetPropertyValue<DateTime>("dt_WriteAssignDate", ref fdt_WriteAssignDate, value); }
        }

        public DateTime dt_WriteLtdDate
        {
            get { return fdt_WriteLtdDate; }
            set { SetPropertyValue<DateTime>("dt_WriteLtdDate", ref fdt_WriteLtdDate, value); }
        }

        public DateTime dt_WriteEndDate
        {
            get { return fdt_WriteEndDate; }
            set { SetPropertyValue<DateTime>("dt_WriteEndDate", ref fdt_WriteEndDate, value); }
        }

        public int n_DescPageNum
        {
            get { return fn_DescPageNum; }
            set { SetPropertyValue<int>("n_DescPageNum", ref fn_DescPageNum, value); }
        }

        public int n_ImgNum
        {
            get { return fn_ImgNum; }
            set { SetPropertyValue<int>("n_ImgNum", ref fn_ImgNum, value); }
        }

        public int n_PowerItemNum
        {
            get { return fn_PowerItemNum; }
            set { SetPropertyValue<int>("n_PowerItemNum", ref fn_PowerItemNum, value); }
        }

        [Size(300)]
        public string s_WriteQuality
        {
            get { return fs_WriteQuality; }
            set { SetPropertyValue("s_WriteQuality", ref fs_WriteQuality, value); }
        }

        [Size(50)]
        public int n_TypewriteID
        {
            get { return fn_TypewriteID; }
            set { SetPropertyValue<int>("n_TypewriteID", ref fn_TypewriteID, value); }
        }

        public int n_TypeWritePageNum
        {
            get { return fn_TypeWritePageNum; }
            set { SetPropertyValue<int>("n_TypeWritePageNum", ref fn_TypeWritePageNum, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}