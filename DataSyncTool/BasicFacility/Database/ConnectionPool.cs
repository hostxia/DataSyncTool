/// <copyright from='2000' to='2010' company='����������Ϣ�������޹�˾'>        
///    Copyright(c) ����������Ϣ�������޹�˾��Ȩ����.                           
/// </copyright>     
///**************************************************************/
///*  FileName: ConnectionPool.cs                               */
///*  Function: ���ӳز���                                */
///*    Coder: ryo.wu                                           */
///*      Date: 2006-3-20                                       */
///*  Modified:                                                 */
///*  �ṩ���ӳز�������Ķ�̬����Ĭ��������ṩ��     */
///*  100����������֮�����Ա����ͨ���޸ĳ���          */
///*  SQL_CONNECTION_COUNT�����±������ı������������     */
///*  �����ޡ�����������close��ᱻ��һ������������    */
///*  ���Զ�open                                               */
///*  ֧�ֲ�ͬ��config�ļ����ƣ�Ĭ��Ϊconfig.ini                 */
///**************************************************************/

using System.Collections;
using System.Data;

namespace BasicFacility.Database
{
    /// <summary>
    /// ���ӳز���
    /// </summary>
    public class ConnectionPool
    {
        #region [����]
        /// <summary>
        /// ���ݿ����ӳ��еĴ����������
        /// </summary>
        private const int SQL_CONNECTION_COUNT = 100;
        /// <summary>
        /// �������ݿ�������Ϣ�������ļ�����
        /// </summary>
        private const string CONNECTSTRING_CONFIG_FILENAME = "IPSconfig.ini";
        #endregion

        #region [�ֶ�]
        /// <summary>
        /// ���ݿ����Ӵ�
        /// </summary>
        private  string _sSqlConnectionString;
        /// <summary>
        /// ���ӳصĴ������
        /// </summary>
        private ArrayList _sSqlConnections;
        #endregion

        #region [����]
        /// <summary>
        /// ���ݿ����Ӵ� �ֶη�װ
        /// </summary>
        public string sSQLConnectionString
        {
            get { return _sSqlConnectionString; }
        }        
        #endregion

        #region [���캯��]
        /// <summary>
        /// ���캯�� - ��ȡĬ�ϵ����ݿ���Ϣ�����ļ�
        /// ryo 20060320
        /// </summary>
        public ConnectionPool()
        {
            //��Ĭ�������ļ��ж�ȡ���Ӵ�
            //_sSqlConnectionString = IPSServiceMethodsSingleton.Instance.GetConnectionString();
            _sSqlConnections = new ArrayList(SQL_CONNECTION_COUNT);
        }
        /// <summary>
        /// ���캯�� - ��ȡָ�������ݿ���Ϣ�����ļ�
        /// ryo 20060320
        /// </summary>
        /// <param name="ConfigFilename">�����ļ����ļ���</param>
        public ConnectionPool(string ConfigFilename)
        {
            //��Ĭ�������ļ��ж�ȡ���Ӵ�
            _sSqlConnectionString = "server=" + Config.ConfigManager.GetConfigKeys("server", ConfigFilename) +
                                    ((Config.ConfigManager.GetConfigKeys("instance", ConfigFilename) == "") ? "" : "\\" + Config.ConfigManager.GetConfigKeys("instance", ConfigFilename)) + ";" +
                                    "timeout=100;database=" + Config.ConfigManager.GetConfigKeys("database", ConfigFilename) + ";" +
                                    "uid=" + Config.ConfigManager.GetConfigKeys("uid", ConfigFilename) + ";" +
                                    "pwd=" + Crypt.BasicCrypt.DecryptIt(Config.ConfigManager.GetConfigKeys("pwd", ConfigFilename));
            //�������ӳصĴ������SQL_CONNECTION_COUNT��
            _sSqlConnections = new ArrayList(SQL_CONNECTION_COUNT);
        }
        #endregion

        #region [����]
        ///#################################################################################
        /// <summary>
        /// �����Ӷ��󼯺��л�ȡSQL���Ӷ���
        /// ryo 20060320
        /// </summary>
        /// <returns>һ�����õ����Ӷ���</returns>
        ///#################################################################################
        public System.Data.SqlClient.SqlConnection GetConnection()
        {
            int i;
            try
            {
                //ѭ��ÿһ�����е����Ӷ���
                for (i = 0; i < _sSqlConnections.Count; i++)
                {
                    switch (((System.Data.SqlClient.SqlConnection)_sSqlConnections[i]).State)
                    {
                        //�����ǰ���Ӷ����ڹر�״̬�������ô˶��󲢷��ظ�����Ա
                        case ConnectionState.Closed:
                            {
                                ((System.Data.SqlClient.SqlConnection)_sSqlConnections[i]).Open();
                                return (System.Data.SqlClient.SqlConnection)_sSqlConnections[i];
                            }
                        //�����ǰ���Ӷ������ж�״̬����رմ����Ӻ����ô˶��󲢷��ظ�����Ա
                        case ConnectionState.Broken:
                            {
                                ((System.Data.SqlClient.SqlConnection)_sSqlConnections[i]).Close();
                                ((System.Data.SqlClient.SqlConnection)_sSqlConnections[i]).Open();
                                return (System.Data.SqlClient.SqlConnection)_sSqlConnections[i];
                            }
                    }
                }
                //ѭ����Ϻ�����Ȼû�п��õ����ӣ�������Ӷ��󼯺�����
                //���û�г��������һ�����Ӷ������Ӷ��󼯺���
                if (_sSqlConnections.Count < SQL_CONNECTION_COUNT)
                {
                    System.Data.SqlClient.SqlConnection tmpcon = new System.Data.SqlClient.SqlConnection(_sSqlConnectionString);
                    tmpcon.Open();
                    _sSqlConnections.Add(tmpcon);
                    return tmpcon;
                }
                //����Ѿ��������Ӷ��󼯺ϵ�������
                else
                {
                    return null;
                }
            }
            catch//�����쳣�򷵻�null��֪��ȡ����ʧ��
            {
                return null;
            }
        }
        #endregion
    }
}
