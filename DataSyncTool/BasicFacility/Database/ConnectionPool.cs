/// <copyright from='2000' to='2010' company='北京彼速信息技术有限公司'>        
///    Copyright(c) 北京彼速信息技术有限公司版权所有.                           
/// </copyright>     
///**************************************************************/
///*  FileName: ConnectionPool.cs                               */
///*  Function: 连接池操作                                */
///*    Coder: ryo.wu                                           */
///*      Date: 2006-3-20                                       */
///*  Modified:                                                 */
///*  提供连接池操作对象的动态管理，默认情况下提供了     */
///*  100个操作对象，之后程序员可以通过修改常数          */
///*  SQL_CONNECTION_COUNT后重新编译来改变操作对象数量     */
///*  的上限。操作对象在close后会被下一个连接请求获得    */
///*  并自动open                                               */
///*  支持不同的config文件名称，默认为config.ini                 */
///**************************************************************/

using System.Collections;
using System.Data;

namespace BasicFacility.Database
{
    /// <summary>
    /// 连接池操作
    /// </summary>
    public class ConnectionPool
    {
        #region [常数]
        /// <summary>
        /// 数据库连接池中的代理对象数量
        /// </summary>
        private const int SQL_CONNECTION_COUNT = 100;
        /// <summary>
        /// 保存数据库连接信息的配置文件名称
        /// </summary>
        private const string CONNECTSTRING_CONFIG_FILENAME = "IPSconfig.ini";
        #endregion

        #region [字段]
        /// <summary>
        /// 数据库连接串
        /// </summary>
        private  string _sSqlConnectionString;
        /// <summary>
        /// 连接池的代理对象
        /// </summary>
        private ArrayList _sSqlConnections;
        #endregion

        #region [属性]
        /// <summary>
        /// 数据库连接串 字段封装
        /// </summary>
        public string sSQLConnectionString
        {
            get { return _sSqlConnectionString; }
        }        
        #endregion

        #region [构造函数]
        /// <summary>
        /// 构造函数 - 读取默认的数据库信息配置文件
        /// ryo 20060320
        /// </summary>
        public ConnectionPool()
        {
            //从默认配置文件中读取连接串
            //_sSqlConnectionString = IPSServiceMethodsSingleton.Instance.GetConnectionString();
            _sSqlConnections = new ArrayList(SQL_CONNECTION_COUNT);
        }
        /// <summary>
        /// 构造函数 - 读取指定的数据库信息配置文件
        /// ryo 20060320
        /// </summary>
        /// <param name="ConfigFilename">配置文件的文件名</param>
        public ConnectionPool(string ConfigFilename)
        {
            //从默认配置文件中读取连接串
            _sSqlConnectionString = "server=" + Config.ConfigManager.GetConfigKeys("server", ConfigFilename) +
                                    ((Config.ConfigManager.GetConfigKeys("instance", ConfigFilename) == "") ? "" : "\\" + Config.ConfigManager.GetConfigKeys("instance", ConfigFilename)) + ";" +
                                    "timeout=100;database=" + Config.ConfigManager.GetConfigKeys("database", ConfigFilename) + ";" +
                                    "uid=" + Config.ConfigManager.GetConfigKeys("uid", ConfigFilename) + ";" +
                                    "pwd=" + Crypt.BasicCrypt.DecryptIt(Config.ConfigManager.GetConfigKeys("pwd", ConfigFilename));
            //建立连接池的代理对象SQL_CONNECTION_COUNT个
            _sSqlConnections = new ArrayList(SQL_CONNECTION_COUNT);
        }
        #endregion

        #region [方法]
        ///#################################################################################
        /// <summary>
        /// 从连接对象集合中获取SQL连接对象
        /// ryo 20060320
        /// </summary>
        /// <returns>一个可用的连接对象</returns>
        ///#################################################################################
        public System.Data.SqlClient.SqlConnection GetConnection()
        {
            int i;
            try
            {
                //循环每一个现有的连接对象
                for (i = 0; i < _sSqlConnections.Count; i++)
                {
                    switch (((System.Data.SqlClient.SqlConnection)_sSqlConnections[i]).State)
                    {
                        //如果当前连接对象处于关闭状态，则启用此对象并返回给程序员
                        case ConnectionState.Closed:
                            {
                                ((System.Data.SqlClient.SqlConnection)_sSqlConnections[i]).Open();
                                return (System.Data.SqlClient.SqlConnection)_sSqlConnections[i];
                            }
                        //如果当前连接对象处于中断状态，则关闭此连接后，启用此对象并返回给程序员
                        case ConnectionState.Broken:
                            {
                                ((System.Data.SqlClient.SqlConnection)_sSqlConnections[i]).Close();
                                ((System.Data.SqlClient.SqlConnection)_sSqlConnections[i]).Open();
                                return (System.Data.SqlClient.SqlConnection)_sSqlConnections[i];
                            }
                    }
                }
                //循环完毕后发现仍然没有可用的连接，检测连接对象集合容量
                //如果没有超出则添加一个连接对象到连接对象集合中
                if (_sSqlConnections.Count < SQL_CONNECTION_COUNT)
                {
                    System.Data.SqlClient.SqlConnection tmpcon = new System.Data.SqlClient.SqlConnection(_sSqlConnectionString);
                    tmpcon.Open();
                    _sSqlConnections.Add(tmpcon);
                    return tmpcon;
                }
                //如果已经到达连接对象集合的上限了
                else
                {
                    return null;
                }
            }
            catch//出现异常则返回null告知获取连接失败
            {
                return null;
            }
        }
        #endregion
    }
}
