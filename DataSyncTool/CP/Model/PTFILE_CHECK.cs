using System;
namespace DataSyncTool.Model
{
    /// <summary>
    /// PTFILE_CHECK:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class PTFILE_CHECK
    {
        public PTFILE_CHECK()
        { }
        #region Model
        private string _caseno;
        private string _name;
        private string _path;
        private string _tsize;
        private string _ct;
        private string _mt;
        private string _lastseen;
        private DateTime _lastbkup;
        private DateTime _lastverify = new DateTime(1900, 1, 1);
        /// <summary>
        /// 
        /// </summary>
        public string CASENO
        {
            set { _caseno = value; }
            get { return _caseno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string NAME
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PATH
        {
            set { _path = value; }
            get { return _path; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TSIZE
        {
            set { _tsize = value; }
            get { return _tsize; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CT
        {
            set { _ct = value; }
            get { return _ct; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MT
        {
            set { _mt = value; }
            get { return _mt; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LASTSEEN
        {
            set { _lastseen = value; }
            get { return _lastseen; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime LASTBKUP
        {
            set { _lastbkup = value; }
            get { return _lastbkup; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime LASTVERIFY
        {
            set { _lastverify = value; }
            get { return _lastverify; }
        }
        #endregion Model

    }
}

