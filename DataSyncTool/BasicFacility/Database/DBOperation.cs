/// <copyright from='2000' to='2010' company='北京彼速信息技术有限公司'>        
///    Copyright(c) 北京彼速信息技术有限公司版权所有.                           
/// </copyright>     
///*******************************************************************/
///*  FileName: DBOperation.cs                                       */
///*  Function: 数据层操作                                    */
///*    Coder: ryo.wu                                                */
///*      Date: 2006-3-21                                            */
///*  Modified:                                                      */
///*  提供数据层的基本操作，诸如获取DataSet、数据集、单条数据 */
///*  执行SQL语句等。底层连接基于连接池提供的功能，数据层中的 */
///*  操作支持事务处理。                                     */
///*******************************************************************/

using System;
using System.Data;

namespace BasicFacility.Database
{
    /// <summary>
    /// 数据库操作
    /// </summary>
    public class DBOperation
    {
        /////#################################################################################
        ///// <summary>
        ///// 获取sSQLstatement指定的查询数据集合
        ///// ryo 20060321
        ///// </summary>
        ///// <param name="sSQLstatement">SQL语句</param>
        ///// <returns>数据集合</returns>
        /////#################################################################################
        //public static DataTable GetTable(string sSQLstatement)
        //{
        //    ConnectionPool cp;
        //    System.Data.SqlClient.SqlConnection sqlcon = null;
        //    System.Data.SqlClient.SqlDataAdapter sda;
        //    DataSet ds;
        //    try
        //    {
        //        cp = new ConnectionPool();
        //        sqlcon = cp.GetConnection();
        //        sda = new System.Data.SqlClient.SqlDataAdapter(sSQLstatement, sqlcon);
        //        sda.SelectCommand.CommandTimeout = 180;
        //        ds = new DataSet();
        //        sda.Fill(ds);
        //        return ds.Tables[0];
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        sqlcon.Close();
        //    }
        //}

        /////#################################################################################
        ///// <summary>
        ///// 获取sSQLstatement指定的查询数据集合
        ///// ryo 20060321
        ///// Modify:Alex 2010-04-01  增加对不同配置文件的支持
        ///// </summary>
        ///// <param name="sSQLstatement">SQL语句</param>
        ///// <param name="sConfigFileName">配置文件名称</param>
        ///// <returns>数据集合</returns>
        /////#################################################################################
        //public static DataTable GetTable(string sSQLstatement,string sConfigFileName)
        //{
        //    ConnectionPool cp;
        //    System.Data.SqlClient.SqlConnection sqlcon = null;
        //    System.Data.SqlClient.SqlDataAdapter sda;
        //    DataSet ds;
        //    try
        //    {
        //        cp = new ConnectionPool(sConfigFileName);
        //        sqlcon = cp.GetConnection();
        //        sda = new System.Data.SqlClient.SqlDataAdapter(sSQLstatement, sqlcon);
        //        sda.SelectCommand.CommandTimeout = 180;
        //        ds = new DataSet();
        //        sda.Fill(ds);
        //        return ds.Tables[0];
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        sqlcon.Close();
        //    }
        //}

        /////#################################################################################
        ///// <summary>
        ///// 获取sSQLstatement指定的查询数据第一行第一列
        ///// ryo 20060321
        ///// </summary>
        ///// <param name="sSQLstatement">SQL语句</param>
        ///// <returns>第一行第一列的值</returns>
        /////#################################################################################
        //public static object GetRecord(string sSQLstatement)
        //{
        //    ConnectionPool cp;
        //    System.Data.SqlClient.SqlConnection sqlcon = null;
        //    System.Data.SqlClient.SqlTransaction myTrans = null;
        //    System.Data.SqlClient.SqlCommand sqlcmd;
        //    object oResult;
        //    try
        //    {
        //        cp = new ConnectionPool();
        //        sqlcon = cp.GetConnection();
        //        myTrans = sqlcon.BeginTransaction();
        //        sqlcmd = new System.Data.SqlClient.SqlCommand(sSQLstatement, sqlcon);
        //        sqlcmd.CommandTimeout = 180;
        //        sqlcmd.Transaction = myTrans;
        //        oResult = sqlcmd.ExecuteScalar();
        //        myTrans.Commit();
        //        return oResult;
        //    }
        //    catch (Exception ex)
        //    {
        //        myTrans.Rollback();
        //        throw ex;
        //    }
        //    finally
        //    {
        //        sqlcon.Close();
        //    }
        //}

        /////#################################################################################
        ///// <summary>
        ///// 获取sSQLstatement指定的查询数据第一行第一列
        ///// ryo 20060321
        ///// Modify:Alex 2010-04-01  增加对不同配置文件的支持
        ///// </summary>
        ///// <param name="sSQLstatement">SQL语句</param>
        ///// <param name="sConfigFileName">配置文件名称</param>
        ///// <returns>第一行第一列的值</returns>
        /////#################################################################################
        //public static object GetRecord(string sSQLstatement, string sConfigFileName)
        //{
        //    ConnectionPool cp;
        //    System.Data.SqlClient.SqlConnection sqlcon = null;
        //    System.Data.SqlClient.SqlTransaction myTrans = null;
        //    System.Data.SqlClient.SqlCommand sqlcmd;
        //    object oResult;
        //    try
        //    {
        //        cp = new ConnectionPool(sConfigFileName);
        //        sqlcon = cp.GetConnection();
        //        myTrans = sqlcon.BeginTransaction();
        //        sqlcmd = new System.Data.SqlClient.SqlCommand(sSQLstatement, sqlcon);
        //        sqlcmd.CommandTimeout = 180;
        //        sqlcmd.Transaction = myTrans;
        //        oResult = sqlcmd.ExecuteScalar();
        //        myTrans.Commit();
        //        return oResult;
        //    }
        //    catch (Exception ex)
        //    {
        //        myTrans.Rollback();
        //        throw ex;
        //    }
        //    finally
        //    {
        //        sqlcon.Close();
        //    }
        //}

        /////#################################################################################
        ///// <summary>
        ///// 获取sSQLstatement指定的查询数据第一行第一列(参与事务)
        ///// 执行后命令后sql连接不会被关闭，事务不会被commit。
        ///// Coder:Ryo Wu 2007-07-05
        ///// </summary>
        ///// <param name="sSQLstatement">SQL语句</param>
        ///// <param name="sqlcon">SQL连接</param>
        ///// <param name="sqlTrans">SQL事务</param>
        ///// <returns>第一行第一列的值，失败则返回null</returns>
        /////#################################################################################
        //public static object GetRecord(string sSQLstatement, System.Data.SqlClient.SqlConnection sqlcon, System.Data.SqlClient.SqlTransaction sqlTrans)
        //{
        //    System.Data.SqlClient.SqlCommand sqlcmd;
        //    object oResult = null;
        //    if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();
        //    sqlcmd = new System.Data.SqlClient.SqlCommand(sSQLstatement, sqlcon);
        //    sqlcmd.CommandTimeout = 180;
        //    sqlcmd.Transaction = sqlTrans;
        //    oResult = sqlcmd.ExecuteScalar();
        //    return oResult;
        //}
        /////#################################################################################
        ///// <summary>
        ///// 获取sSQLstatement指定的查询数据DataSet
        ///// ryo 20060321
        ///// </summary>
        ///// <param name="sSQLstatement">SQL语句</param>
        ///// <returns>数据DataSet</returns>
        /////#################################################################################
        //public static DataSet GetDataSet(string sSQLstatement)
        //{
        //    ConnectionPool cp;
        //    System.Data.SqlClient.SqlConnection sqlcon = null;
        //    System.Data.SqlClient.SqlDataAdapter sda;
        //    DataSet ds;
        //    try
        //    {
        //        cp = new ConnectionPool();
        //        sqlcon = cp.GetConnection();
        //        sda = new System.Data.SqlClient.SqlDataAdapter(sSQLstatement, sqlcon);
        //        sda.SelectCommand.CommandTimeout = 180;
        //        ds = new DataSet();
        //        sda.Fill(ds);
        //        return ds;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        sqlcon.Close();
        //    }
        //}
        /////#################################################################################
        ///// <summary>
        ///// 执行sSQLstatement指定的SQL操作，返回受影响的行数
        ///// ryo 20060321
        ///// </summary>
        ///// <param name="sSQLstatement">SQL语句</param>
        ///// <returns>受影响的行数</returns>
        /////#################################################################################
        //public static int ExecuteCommand(string sSQLstatement)
        //{
        //    ConnectionPool cp;
        //    System.Data.SqlClient.SqlConnection sqlcon = null;
        //    System.Data.SqlClient.SqlTransaction myTrans = null;
        //    System.Data.SqlClient.SqlCommand sqlcmd;
        //    int iResult;
        //    try
        //    {
        //        cp = new ConnectionPool();
        //        sqlcon = cp.GetConnection();
        //        myTrans = sqlcon.BeginTransaction();
        //        sqlcmd = new System.Data.SqlClient.SqlCommand(sSQLstatement, sqlcon);
        //        sqlcmd.CommandTimeout = 180;
        //        sqlcmd.Transaction = myTrans;
        //        iResult = sqlcmd.ExecuteNonQuery();
        //        myTrans.Commit();
        //        return iResult;
        //    }
        //    catch (Exception ex)
        //    {
        //        myTrans.Rollback();
        //        throw ex;
        //    }
        //    finally
        //    {
        //        sqlcon.Close();
        //    }
        //}

        /////#################################################################################
        ///// <summary>
        ///// 执行sSQLstatement指定的SQL操作，返回受影响的行数
        ///// ryo 20060321
        ///// Modify:Alex 2010-04-01  增加对不同配置文件的支持
        ///// </summary>
        ///// <param name="sSQLstatement">SQL语句</param>
        ///// <param name="sConfigFileName">配置文件名称</param>
        ///// <returns>受影响的行数</returns>
        /////#################################################################################
        //public static int ExecuteCommand(string sSQLstatement, string sConfigFileName)
        //{
        //    ConnectionPool cp;
        //    System.Data.SqlClient.SqlConnection sqlcon = null;
        //    System.Data.SqlClient.SqlTransaction myTrans = null;
        //    System.Data.SqlClient.SqlCommand sqlcmd;
        //    int iResult;
        //    try
        //    {
        //        cp = new ConnectionPool(sConfigFileName);
        //        sqlcon = cp.GetConnection();
        //        myTrans = sqlcon.BeginTransaction();
        //        sqlcmd = new System.Data.SqlClient.SqlCommand(sSQLstatement, sqlcon);
        //        sqlcmd.CommandTimeout = 180;
        //        sqlcmd.Transaction = myTrans;
        //        iResult = sqlcmd.ExecuteNonQuery();
        //        myTrans.Commit();
        //        return iResult;
        //    }
        //    catch (Exception ex)
        //    {
        //        myTrans.Rollback();
        //        throw ex;
        //    }
        //    finally
        //    {
        //        sqlcon.Close();
        //    }
        //}

        /////#################################################################################
        ///// <summary>
        ///// 执行sSQLstatement指定的SQL操作，返回受影响的行数
        ///// ryo 20060321
        ///// </summary>
        ///// <param name="sSQLstatement">SQL语句</param>
        ///// <returns>受影响的行数</returns>
        /////#################################################################################
        //public static int ExecuteCommand(string sSQLstatement, System.Data.SqlClient.SqlConnection sqlcon, System.Data.SqlClient.SqlTransaction sqlTrans)
        //{
        //    System.Data.SqlClient.SqlCommand sqlcmd;
        //    int iResult = 0;
        //    sqlcmd = new System.Data.SqlClient.SqlCommand(sSQLstatement, sqlcon);
        //    sqlcmd.CommandTimeout = 180;
        //    sqlcmd.Transaction = sqlTrans;
        //    iResult = sqlcmd.ExecuteNonQuery();
        //    return iResult;
        //}
       
        /////#################################################################################
        ///// <summary>
        ///// 执行sSQLstatement指定的SQL操作，返回受影响的行数
        ///// ryo 20060321
        ///// </summary>
        ///// <param name="sSQLstatement">SQL语句</param>
        ///// <returns>受影响的行数</returns>
        /////#################################################################################
        //public static void ExecuteCommandImport(string sSQLstatement)
        //{
        //    ConnectionPool cp;
        //    System.Data.SqlClient.SqlConnection sqlcon = null;
        //    System.Data.SqlClient.SqlTransaction myTrans = null;
        //    System.Data.SqlClient.SqlCommand sqlcmd = null;
        //    int iResult;
        //    try
        //    {
        //        cp = new ConnectionPool();
        //        sqlcon = cp.GetConnection();
        //        myTrans = sqlcon.BeginTransaction();
        //        sqlcmd = new System.Data.SqlClient.SqlCommand(sSQLstatement, sqlcon);
        //        sqlcmd.CommandTimeout = 180;
        //        sqlcmd.Transaction = myTrans;
        //        iResult = sqlcmd.ExecuteNonQuery();
        //        myTrans.Commit();
        //    }
        //    catch
        //    {
        //        try
        //        {
        //            sSQLstatement = sSQLstatement.Remove(0, sSQLstatement.IndexOf(';') + 1);
        //            sSQLstatement = sSQLstatement.Remove(sSQLstatement.LastIndexOf(';'));
        //            sqlcmd.CommandText = sSQLstatement;
        //            sqlcmd.ExecuteNonQuery();
        //        }
        //        catch
        //        {

        //        }

        //        //myTrans.Rollback();
        //        //throw ex;
        //    }
        //    finally
        //    {
        //        sqlcon.Close();
        //    }
        //}

        /////#################################################################################
        ///// <summary>
        ///// 执行sSQLstatement指定的SQL操作，返回受影响的行数
        ///// ryo 20060321
        ///// Modify:Alex 2010-04-01  增加对不同配置文件的支持
        ///// </summary>
        ///// <param name="sSQLstatement">SQL语句</param>
        ///// <param name="sConfigFileName">配置文件名称</param>
        /////#################################################################################
        //public static void ExecuteCommandImport(string sSQLstatement, string sConfigFileName)
        //{
        //    ConnectionPool cp;
        //    System.Data.SqlClient.SqlConnection sqlcon = null;
        //    System.Data.SqlClient.SqlTransaction myTrans = null;
        //    System.Data.SqlClient.SqlCommand sqlcmd = null;
        //    int iResult;
        //    try
        //    {
        //        cp = new ConnectionPool(sConfigFileName);
        //        sqlcon = cp.GetConnection();
        //        myTrans = sqlcon.BeginTransaction();
        //        sqlcmd = new System.Data.SqlClient.SqlCommand(sSQLstatement, sqlcon);
        //        sqlcmd.CommandTimeout = 180;
        //        sqlcmd.Transaction = myTrans;
        //        iResult = sqlcmd.ExecuteNonQuery();
        //        myTrans.Commit();
        //    }
        //    catch
        //    {
        //        try
        //        {
        //            sSQLstatement = sSQLstatement.Remove(0, sSQLstatement.IndexOf(';') + 1);
        //            sSQLstatement = sSQLstatement.Remove(sSQLstatement.LastIndexOf(';'));
        //            sqlcmd.CommandText = sSQLstatement;
        //            sqlcmd.ExecuteNonQuery();
        //        }
        //        catch
        //        {

        //        }

        //        //myTrans.Rollback();
        //        //throw ex;
        //    }
        //    finally
        //    {
        //        sqlcon.Close();
        //    }
        //}
        /////#################################################################################
        ///// <summary>
        ///// 执行sSQLstatement指定的SQL操作
        ///// ryo 20060321
        ///// </summary>
        ///// <param name="sSQLstatement">SQL语句</param>
        /////#################################################################################
        //public static void ExecuteCommandNoneQuery(string sSQLstatement)
        //{
        //    ConnectionPool cp;
        //    System.Data.SqlClient.SqlConnection sqlcon = null;
        //    System.Data.SqlClient.SqlTransaction myTrans = null;
        //    System.Data.SqlClient.SqlCommand sqlcmd;
        //    int iResult;
        //    try
        //    {
        //        cp = new ConnectionPool();
        //        sqlcon = cp.GetConnection();
        //        myTrans = sqlcon.BeginTransaction();
        //        sqlcmd = new System.Data.SqlClient.SqlCommand(sSQLstatement, sqlcon);
        //        sqlcmd.CommandTimeout = 180;
        //        sqlcmd.Transaction = myTrans;
        //        iResult = sqlcmd.ExecuteNonQuery();
        //        myTrans.Commit();
        //    }
        //    catch (Exception ex)
        //    {
        //        myTrans.Rollback();
        //        throw ex;
        //    }
        //    finally
        //    {
        //        sqlcon.Close();
        //    }
        //}

        /////#################################################################################
        ///// <summary>
        ///// 执行sSQLstatement指定的SQL操作
        ///// Modify:Alex 2010-04-01  增加对不同配置文件的支持
        ///// </summary>
        ///// <param name="sSQLstatement">SQL语句</param>
        ///// <param name="sConfigFileName">配置文件名称</param>
        /////#################################################################################
        //public static void ExecuteCommandNoneQuery(string sSQLstatement, string sConfigFileName)
        //{
        //    ConnectionPool cp;
        //    System.Data.SqlClient.SqlConnection sqlcon = null;
        //    System.Data.SqlClient.SqlTransaction myTrans = null;
        //    System.Data.SqlClient.SqlCommand sqlcmd;
        //    int iResult;
        //    try
        //    {
        //        cp = new ConnectionPool(sConfigFileName);
        //        sqlcon = cp.GetConnection();
        //        myTrans = sqlcon.BeginTransaction();
        //        sqlcmd = new System.Data.SqlClient.SqlCommand(sSQLstatement, sqlcon);
        //        sqlcmd.CommandTimeout = 180;
        //        sqlcmd.Transaction = myTrans;
        //        iResult = sqlcmd.ExecuteNonQuery();
        //        myTrans.Commit();
        //    }
        //    catch (Exception ex)
        //    {
        //        myTrans.Rollback();
        //        throw ex;
        //    }
        //    finally
        //    {
        //        sqlcon.Close();
        //    }
        //}

        /////#################################################################################
        ///// <summary>
        ///// 执行sSQLstatement指定的SQL操作,使用dbfamily对多个数据库同时执行
        ///// ryo 20070312
        ///// for 海信
        ///// </summary>
        ///// <param name="sSQLstatement">SQL语句</param>
        /////#################################################################################
        //public static void ExecuteCommandNoneQueryFamily(string sSQLstatement)
        //{
        //    string CONNECTSTRING_CONFIG_FILENAME = "config.ini";

        //    ConnectionPool cp;
        //    System.Data.SqlClient.SqlConnection sqlcon = null;
        //    System.Data.SqlClient.SqlTransaction myTrans = null;
        //    System.Data.SqlClient.SqlCommand sqlcmd;
        //    int iResult;

        //    //如果存在dbfamily,则循环每一个执行
        //    string sDBFamily = Config.ConfigManager.GetConfigKeys("dbfamily", CONNECTSTRING_CONFIG_FILENAME);
        //    if (sDBFamily != "")
        //    {
        //        string sSqlConnectionString = "";
        //        string sConString1 = "server=" + Config.ConfigManager.GetConfigKeys("server", CONNECTSTRING_CONFIG_FILENAME) +
        //    ((Config.ConfigManager.GetConfigKeys("instance", CONNECTSTRING_CONFIG_FILENAME) == "") ? "" : "\\" + Config.ConfigManager.GetConfigKeys("instance", CONNECTSTRING_CONFIG_FILENAME)) + ";" +
        //    "timeout=" + Config.ConfigManager.GetConfigKeys("timeout", CONNECTSTRING_CONFIG_FILENAME) + ";" +
        //    "database=";
        //        string sConString2 = ";" +
        //    "uid=" + Config.ConfigManager.GetConfigKeys("uid", CONNECTSTRING_CONFIG_FILENAME) + ";" +
        //    "pwd=" + BasicFacility.Crypt.BasicCrypt.DecryptIt(Config.ConfigManager.GetConfigKeys("pwd", CONNECTSTRING_CONFIG_FILENAME));
        //        foreach (string stmp in sDBFamily.Split(','))
        //        {
        //            sSqlConnectionString = sConString1 + stmp + sConString2;
        //            sqlcon = new System.Data.SqlClient.SqlConnection(sSqlConnectionString);
        //            sqlcon.Open();
        //            sqlcmd = new System.Data.SqlClient.SqlCommand(sSQLstatement, sqlcon);
        //            sqlcmd.ExecuteNonQuery();
        //            sqlcon.Close();
        //        }
        //    }
        //    else
        //    {
        //        try
        //        {
        //            cp = new ConnectionPool();
        //            sqlcon = cp.GetConnection();
        //            myTrans = sqlcon.BeginTransaction();
        //            sqlcmd = new System.Data.SqlClient.SqlCommand(sSQLstatement, sqlcon);
        //            sqlcmd.Transaction = myTrans;
        //            iResult = sqlcmd.ExecuteNonQuery();
        //            myTrans.Commit();
        //        }
        //        catch (Exception ex)
        //        {
        //            myTrans.Rollback();
        //            throw ex;
        //        }
        //        finally
        //        {
        //            sqlcon.Close();
        //        }
        //    }


        //}      

        /////#################################################################################
        ///// <summary>
        ///// 获取sSQLstatement指定的查询数据DataSet
        ///// shawn 20060330
        ///// </summary>
        ///// <param name="sSQLstatement">SQL语句</param>
        ///// <returns>数据DataSet</returns>
        /////#################################################################################
        //public static DataSet GetDataSet(string sSQLstatement, string sTableName)
        //{
        //    ConnectionPool cp;
        //    System.Data.SqlClient.SqlConnection sqlcon = null;
        //    System.Data.SqlClient.SqlDataAdapter sda;
        //    DataSet ds;
        //    try
        //    {
        //        cp = new ConnectionPool();
        //        sqlcon = cp.GetConnection();
        //        sda = new System.Data.SqlClient.SqlDataAdapter(sSQLstatement, sqlcon);
        //        //sda.SelectCommand.CommandTimeout = 180;
        //        ds = new DataSet();
        //        sda.Fill(ds, sTableName);
        //        return ds;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        sqlcon.Close();
        //    }
        //}

        /////#################################################################################
        ///// <summary>
        ///// 获取sSQLstatement指定的查询数据DataSet
        ///// shawn 20060330
        ///// Modify:Alex 2010-04-01  增加对不同配置文件的支持
        ///// </summary>
        ///// <param name="sSQLstatement">SQL语句</param>
        ///// <param name="sConfigFileName">配置文件名称</param>
        ///// <returns>数据DataSet</returns>
        /////#################################################################################
        //public static DataSet GetDataSet(string sSQLstatement, string sTableName, string sConfigFileName)
        //{
        //    ConnectionPool cp;
        //    System.Data.SqlClient.SqlConnection sqlcon = null;
        //    System.Data.SqlClient.SqlDataAdapter sda;
        //    DataSet ds;
        //    try
        //    {
        //        cp = new ConnectionPool(sConfigFileName);
        //        sqlcon = cp.GetConnection();
        //        sda = new System.Data.SqlClient.SqlDataAdapter(sSQLstatement, sqlcon);
        //        //sda.SelectCommand.CommandTimeout = 180;
        //        ds = new DataSet();
        //        sda.Fill(ds, sTableName);
        //        return ds;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        sqlcon.Close();
        //    }
        //}

        #region Get方法
        ///#################################################################################
        /// <summary>
        /// 获取sSQLstatement指定的查询数据集合
        /// ryo 20060321
        /// </summary>
        /// <param name="sSQLstatement">SQL语句</param>
        /// <returns>数据集合</returns>
        ///#################################################################################
        public static DataTable GetTable(string sSQLstatement)
        {
            ConnectionPool cp;
            System.Data.SqlClient.SqlConnection sqlcon = null;
            System.Data.SqlClient.SqlDataAdapter sda;
            DataSet ds;
            try
            {
                cp = new ConnectionPool();
                sqlcon = cp.GetConnection();
                sda = new System.Data.SqlClient.SqlDataAdapter(sSQLstatement, sqlcon);
                sda.SelectCommand.CommandTimeout = 180;
                ds = new DataSet();
                sda.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }
        }


        ///#################################################################################
        /// <summary>
        /// 获取sSQLstatement指定的查询数据第一行第一列
        /// ryo 20060321
        /// </summary>
        /// <param name="sSQLstatement">SQL语句</param>
        /// <param name="sSQLstatement">定义超时时间</param>
        /// <returns>第一行第一列的值</returns>
        ///#################################################################################
        public static DataTable GetTable(string sSQLstatement, int iTimeOut)
        {
            ConnectionPool cp;
            System.Data.SqlClient.SqlConnection sqlcon = null;
            System.Data.SqlClient.SqlDataAdapter sda;
            DataSet ds;
            try
            {
                cp = new ConnectionPool();
                sqlcon = cp.GetConnection();
                sda = new System.Data.SqlClient.SqlDataAdapter(sSQLstatement, sqlcon);
                sda.SelectCommand.CommandTimeout = iTimeOut;
                ds = new DataSet();
                sda.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }
        }

        ///#################################################################################
        /// <summary>
        /// 获取sSQLstatement指定的查询数据集合(参与事务)
        /// Coder:Ryo Wu 2007-07-05
        /// </summary>
        /// <param name="sSQLstatement">SQL语句</param>
        /// <param name="sqlcon">SQL连接</param>
        /// <returns>数据集合</returns>
        ///#################################################################################
        public static DataTable GetTable(string sSQLstatement, System.Data.SqlClient.SqlConnection sqlcon)
        {
            System.Data.SqlClient.SqlDataAdapter sda;
            DataSet ds;
            if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();
            sda = new System.Data.SqlClient.SqlDataAdapter(sSQLstatement, sqlcon);
            ds = new DataSet();
            sda.Fill(ds);
            return ds.Tables[0];
        }

        ///#################################################################################
        /// <summary>
        /// 获取sSQLstatement指定的查询数据第一行第一列
        /// ryo 20060321
        /// </summary>
        /// <param name="sSQLstatement">SQL语句</param>
        /// <returns>第一行第一列的值</returns>
        ///#################################################################################
        public static object GetRecord(string sSQLstatement)
        {
            ConnectionPool cp;
            System.Data.SqlClient.SqlConnection sqlcon = null;
            System.Data.SqlClient.SqlTransaction myTrans = null;
            System.Data.SqlClient.SqlCommand sqlcmd;
            object oResult;
            try
            {
                cp = new ConnectionPool();
                sqlcon = cp.GetConnection();
                myTrans = sqlcon.BeginTransaction();
                sqlcmd = new System.Data.SqlClient.SqlCommand(sSQLstatement, sqlcon);
                sqlcmd.CommandTimeout = 180;
                sqlcmd.Transaction = myTrans;
                oResult = sqlcmd.ExecuteScalar();
                myTrans.Commit();
                return oResult;
            }
            catch (Exception ex)
            {
                myTrans.Rollback();
                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }
        }

        ///#################################################################################
        /// <summary>
        /// 获取sSQLstatement指定的查询数据第一行第一列
        /// ryo 20060321
        /// Modify:Alex 2010-04-01  增加对不同配置文件的支持
        /// </summary>
        /// <param name="sSQLstatement">SQL语句</param>
        /// <param name="sConfigFileName">配置文件名称</param>
        /// <returns>第一行第一列的值</returns>
        ///#################################################################################
        public static object GetRecord(string sSQLstatement, string sConfigFileName)
        {
            ConnectionPool cp;
            System.Data.SqlClient.SqlConnection sqlcon = null;
            System.Data.SqlClient.SqlTransaction myTrans = null;
            System.Data.SqlClient.SqlCommand sqlcmd;
            object oResult;
            try
            {
                cp = new ConnectionPool(sConfigFileName);
                sqlcon = cp.GetConnection();
                myTrans = sqlcon.BeginTransaction();
                sqlcmd = new System.Data.SqlClient.SqlCommand(sSQLstatement, sqlcon);
                sqlcmd.CommandTimeout = 180;
                sqlcmd.Transaction = myTrans;
                oResult = sqlcmd.ExecuteScalar();
                myTrans.Commit();
                return oResult;
            }
            catch (Exception ex)
            {
                myTrans.Rollback();
                BasicFacility.Exceptions.ExceptionLog.LogException1(ex, (sSQLstatement + ";" + sqlcon.ConnectionString));
                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }
        }


        ///#################################################################################
        /// <summary>
        /// 获取sSQLstatement指定的查询数据第一行第一列(参与事务)
        /// 执行后命令后sql连接不会被关闭，事务不会被commit。
        /// Coder:Ryo Wu 2007-07-05
        /// </summary>
        /// <param name="sSQLstatement">SQL语句</param>
        /// <param name="sqlcon">SQL连接</param>
        /// <param name="sqlTrans">SQL事务</param>
        /// <returns>第一行第一列的值，失败则返回null</returns>
        ///#################################################################################
        public static object GetRecord(string sSQLstatement, System.Data.SqlClient.SqlConnection sqlcon, System.Data.SqlClient.SqlTransaction sqlTrans)
        {
            System.Data.SqlClient.SqlCommand sqlcmd;
            object oResult = null;
            if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();
            sqlcmd = new System.Data.SqlClient.SqlCommand(sSQLstatement, sqlcon);
            sqlcmd.CommandTimeout = 180;
            sqlcmd.Transaction = sqlTrans;
            oResult = sqlcmd.ExecuteScalar();
            return oResult;
        }

        ///#################################################################################
        /// <summary>
        /// 获取sSQLstatement指定的查询数据第一行第一列(参与事务)
        /// 执行后命令后sql连接不会被关闭，事务不会被commit。
        /// Coder:Ryo Wu 2007-07-05
        /// </summary>
        /// <param name="sSQLstatement">SQL语句</param>
        /// <param name="sqlcon">SQL连接</param>
        /// <param name="sqlTrans">SQL事务</param>
        /// <returns>第一行第一列的值，失败则返回null</returns>
        ///#################################################################################
        public static object GetRecord(System.Data.SqlClient.SqlCommand sqlcmd, System.Data.SqlClient.SqlConnection sqlcon, System.Data.SqlClient.SqlTransaction sqlTrans)
        {
            object oResult = null;
            if (sqlcon.State == ConnectionState.Closed) sqlcon.Open();
            sqlcmd.Connection = sqlcon;
            sqlcmd.Transaction = sqlTrans;
            oResult = sqlcmd.ExecuteScalar();
            return oResult;
        }

        ///#################################################################################
        /// <summary>
        /// 获取sqlcmd查询数据第一行第一列
        /// ryo 2007-07-25
        /// </summary>
        /// <param name="sqlcmd">SQLCommand实例</param>
        /// <returns>第一行第一列的值</returns>
        ///#################################################################################
        public static object GetRecord(System.Data.SqlClient.SqlCommand sqlcmd)
        {
            ConnectionPool cp;
            System.Data.SqlClient.SqlConnection sqlcon = null;
            System.Data.SqlClient.SqlTransaction myTrans = null;
            object oResult;
            try
            {
                cp = new ConnectionPool();
                sqlcon = cp.GetConnection();
                myTrans = sqlcon.BeginTransaction();
                sqlcmd.Connection = sqlcon;
                sqlcmd.Transaction = myTrans;
                oResult = sqlcmd.ExecuteScalar();
                myTrans.Commit();
                return oResult;
            }
            catch (Exception ex)
            {
                myTrans.Rollback();

                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }
        }

        ///#################################################################################
        /// <summary>
        /// 获取sSQLstatement指定的查询数据DataSet
        /// ryo 20060321
        /// </summary>
        /// <param name="sSQLstatement">SQL语句</param>
        /// <returns>数据DataSet</returns>
        ///#################################################################################
        public static DataSet GetDataSet(string sSQLstatement)
        {
            ConnectionPool cp;
            System.Data.SqlClient.SqlConnection sqlcon = null;
            System.Data.SqlClient.SqlDataAdapter sda;
            DataSet ds;
            try
            {
                cp = new ConnectionPool();
                sqlcon = cp.GetConnection();
                sda = new System.Data.SqlClient.SqlDataAdapter(sSQLstatement, sqlcon);
                sda.SelectCommand.CommandTimeout = 180;
                ds = new DataSet();
                sda.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }
        }

        ///#################################################################################
        /// <summary>
        /// 执行查询操作（事务方法）
        /// Coder:Arthur 2010-4-19
        /// </summary>
        /// <param name="sSQLstatement"></param>
        /// <param name="sqlcon"></param>
        /// <param name="sqlTrans"></param>
        /// <returns></returns>
        public static DataTable GetTable(string sSQLstatement, System.Data.SqlClient.SqlConnection sqlcon, System.Data.SqlClient.SqlTransaction sqlTrans)
        {
            System.Data.SqlClient.SqlDataAdapter sda;
            DataSet ds;
            try
            {
                sda = new System.Data.SqlClient.SqlDataAdapter(sSQLstatement, sqlcon);
                sda.SelectCommand.CommandTimeout = 180;
                sda.SelectCommand.Transaction = sqlTrans;
                ds = new DataSet();
                sda.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        ///#################################################################################
        /// <summary>
        /// 获取sSQLstatement指定的查询数据DataSet
        /// shawn 20060330
        /// </summary>
        /// <param name="sSQLstatement">SQL语句</param>
        /// <returns>数据DataSet</returns>
        ///#################################################################################
        public static DataSet GetDataSet(string sSQLstatement, string sTableName)
        {
            ConnectionPool cp;
            System.Data.SqlClient.SqlConnection sqlcon = null;
            System.Data.SqlClient.SqlDataAdapter sda;
            DataSet ds;
            try
            {
                cp = new ConnectionPool();
                sqlcon = cp.GetConnection();
                sda = new System.Data.SqlClient.SqlDataAdapter(sSQLstatement, sqlcon);
                //sda.SelectCommand.CommandTimeout = 180;
                ds = new DataSet();
                sda.Fill(ds, sTableName);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }
        }

        ///#################################################################################
        /// <summary>
        /// 获取sSQLstatement指定的查询数据DataSet
        /// ryo 20060321
        /// </summary>
        /// <param name="sSQLstatement">SQL语句</param>
        /// <returns>数据DataSet</returns>
        ///#################################################################################
        public static DataSet GetDataSet(string sSQLstatement,
     System.Data.SqlClient.SqlConnection sqlcon,
            System.Data.SqlClient.SqlTransaction sqlTrans)
        {
            System.Data.SqlClient.SqlDataAdapter sda;
            DataSet ds;
            try
            {
                sda = new System.Data.SqlClient.SqlDataAdapter(sSQLstatement, sqlcon);

                ds = new DataSet();
                sda.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }
        }
        #endregion

        #region Execute方法
        ///#################################################################################
        /// <summary>
        /// 执行sSQLstatement指定的SQL操作，返回受影响的行数
        /// ryo 20060321
        /// </summary>
        /// <param name="sSQLstatement">SQL语句</param>
        /// <returns>受影响的行数</returns>
        ///#################################################################################
        public static int ExecuteCommand(string sSQLstatement)
        {
            ConnectionPool cp;
            System.Data.SqlClient.SqlConnection sqlcon = null;
            System.Data.SqlClient.SqlTransaction myTrans = null;
            System.Data.SqlClient.SqlCommand sqlcmd;
            int iResult;
            try
            {
                cp = new ConnectionPool();
                sqlcon = cp.GetConnection();
                myTrans = sqlcon.BeginTransaction();
                sqlcmd = new System.Data.SqlClient.SqlCommand(sSQLstatement, sqlcon);
                sqlcmd.CommandTimeout = 180;
                sqlcmd.Transaction = myTrans;
                iResult = sqlcmd.ExecuteNonQuery();
                myTrans.Commit();
                return iResult;
            }
            catch (Exception ex)
            {
                myTrans.Rollback();
                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }
        }

        ///#################################################################################
        /// <summary>
        /// 执行sSQLstatement指定的SQL操作，返回受影响的行数
        /// ryo 20060321
        /// </summary>
        /// <param name="sSQLstatement">SQL语句</param>
        /// <param name="sSQLstatement">定义的超时时间</param>
        /// <returns>受影响的行数</returns>
        ///#################################################################################
        public static int ExecuteCommand(string sSQLstatement, int iTimeOut)
        {
            ConnectionPool cp;
            System.Data.SqlClient.SqlConnection sqlcon = null;
            System.Data.SqlClient.SqlTransaction myTrans = null;
            System.Data.SqlClient.SqlCommand sqlcmd;
            int iResult;
            try
            {
                cp = new ConnectionPool();
                sqlcon = cp.GetConnection();
                myTrans = sqlcon.BeginTransaction();
                sqlcmd = new System.Data.SqlClient.SqlCommand(sSQLstatement, sqlcon);
                sqlcmd.CommandTimeout = iTimeOut;
                sqlcmd.Transaction = myTrans;
                iResult = sqlcmd.ExecuteNonQuery();
                myTrans.Commit();
                return iResult;
            }
            catch (Exception ex)
            {
                myTrans.Rollback();
                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }
        }


        ///#################################################################################
        /// <summary>
        /// 执行sSQLstatement指定的SQL操作，返回受影响的行数
        /// ryo 20060321
        /// </summary>
        /// <param name="sSQLstatement">SQL语句</param>
        /// <returns>受影响的行数</returns>
        ///#################################################################################
        public static int ExecuteCommand(string sSQLstatement, System.Data.SqlClient.SqlConnection sqlcon, System.Data.SqlClient.SqlTransaction sqlTrans)
        {
            System.Data.SqlClient.SqlCommand sqlcmd;
            int iResult = 0;
            sqlcmd = new System.Data.SqlClient.SqlCommand(sSQLstatement, sqlcon);
            sqlcmd.CommandTimeout = 180;
            sqlcmd.Transaction = sqlTrans;
            iResult = sqlcmd.ExecuteNonQuery();
            return iResult;
        }

        ///#################################################################################
        /// <summary>
        /// 执行sSQLstatement指定的SQL操作，返回受影响的行数
        /// ryo 20060321
        /// </summary>
        /// <param name="sSQLstatement">SQL语句</param>
        /// <returns>受影响的行数</returns>
        ///#################################################################################
        public static int ExecuteCommand(string sSQLstatement, System.Data.SqlClient.SqlConnection sqlcon)
        {
            System.Data.SqlClient.SqlTransaction myTrans = null;
            System.Data.SqlClient.SqlCommand sqlcmd;
            int iResult;
            try
            {
                myTrans = sqlcon.BeginTransaction();
                sqlcmd = new System.Data.SqlClient.SqlCommand(sSQLstatement, sqlcon);
                sqlcmd.Transaction = myTrans;
                iResult = sqlcmd.ExecuteNonQuery();
                myTrans.Commit();
                return iResult;
            }
            catch (Exception ex)
            {
                myTrans.Rollback();
                throw ex;
            }
        }

        ///##################################################################################
        /// <summary>
        /// 对数据库进行特定的插入操作，返回插入的@@IDENTITY
        /// Coder: Gary Xie(2008-02-14) 
        /// </summary>
        public static int ExecuteCommandWithIdReturn(string sSQLstatement)
        {
            ConnectionPool cp;
            System.Data.SqlClient.SqlConnection sqlcon = null;
            System.Data.SqlClient.SqlTransaction myTrans = null;
            System.Data.SqlClient.SqlCommand sqlcmd;

            int iResult;
            try
            {
                cp = new ConnectionPool();
                sqlcon = cp.GetConnection();
                myTrans = sqlcon.BeginTransaction();
                sqlcmd = new System.Data.SqlClient.SqlCommand(sSQLstatement + " SELECT @@IDENTITY", sqlcon);
                sqlcmd.Transaction = myTrans;
                iResult = Int32.Parse(sqlcmd.ExecuteScalar().ToString());
                myTrans.Commit();
                return iResult;
            }
            catch (Exception ex)
            {
                myTrans.Rollback();
                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }
        }

        ///#################################################################################
        /// <summary>
        /// 执行sSQLstatement指定的SQL操作，返回受影响的行数
        /// ryo 20060321
        /// </summary>
        /// <param name="sSQLstatement">SQL语句</param>
        /// <returns>受影响的行数</returns>
        ///#################################################################################
        public static void ExecuteCommandImport(string sSQLstatement)
        {
            ConnectionPool cp;
            System.Data.SqlClient.SqlConnection sqlcon = null;
            System.Data.SqlClient.SqlTransaction myTrans = null;
            System.Data.SqlClient.SqlCommand sqlcmd = null;
            int iResult;
            try
            {
                cp = new ConnectionPool();
                sqlcon = cp.GetConnection();
                myTrans = sqlcon.BeginTransaction();
                sqlcmd = new System.Data.SqlClient.SqlCommand(sSQLstatement, sqlcon);
                sqlcmd.CommandTimeout = 180;
                sqlcmd.Transaction = myTrans;
                iResult = sqlcmd.ExecuteNonQuery();
                myTrans.Commit();
            }
            catch
            {
                try
                {
                    sSQLstatement = sSQLstatement.Remove(0, sSQLstatement.IndexOf(';') + 1);
                    sSQLstatement = sSQLstatement.Remove(sSQLstatement.LastIndexOf(';'));
                    sqlcmd.CommandText = sSQLstatement;
                    sqlcmd.ExecuteNonQuery();
                }
                catch
                {

                }

                //myTrans.Rollback();
                //throw ex;
            }
            finally
            {
                sqlcon.Close();
            }
        }

        ///#################################################################################
        /// <summary>
        /// 执行sSQLstatement指定的SQL操作
        /// ryo 20060321
        /// </summary>
        /// <param name="sSQLstatement">SQL语句</param>
        ///#################################################################################
        public static void ExecuteCommandNoneQuery(string sSQLstatement)
        {
            ConnectionPool cp;
            System.Data.SqlClient.SqlConnection sqlcon = null;
            System.Data.SqlClient.SqlTransaction myTrans = null;
            System.Data.SqlClient.SqlCommand sqlcmd;
            int iResult;
            try
            {
                cp = new ConnectionPool();
                sqlcon = cp.GetConnection();
                myTrans = sqlcon.BeginTransaction();
                sqlcmd = new System.Data.SqlClient.SqlCommand(sSQLstatement, sqlcon);
                sqlcmd.CommandTimeout = 180;
                sqlcmd.Transaction = myTrans;
                iResult = sqlcmd.ExecuteNonQuery();
                myTrans.Commit();
            }
            catch (Exception ex)
            {
                myTrans.Rollback();
                throw ex;
            }
            finally
            {
                sqlcon.Close();
            }
        }

        ///#################################################################################
        /// <summary>
        /// 执行sSQLstatement指定的SQL操作(参与事务)
        /// 执行后命令后sql连接不会被关闭，事务不会被commit。
        /// Coder:Ryo Wu 2007-07-05
        /// </summary>
        /// <param name="sSQLstatement">SQL语句</param>
        /// <param name="sqlcon">SQL连接</param>
        /// <param name="sqlTrans">SQL事务</param>
        public static void ExecuteCommandNoneQuery(string sSQLstatement, System.Data.SqlClient.SqlConnection sqlcon, System.Data.SqlClient.SqlTransaction sqlTrans)
        {
            System.Data.SqlClient.SqlCommand sqlcmd;
            int iResult = 0;
            sqlcmd = new System.Data.SqlClient.SqlCommand(sSQLstatement, sqlcon);
            sqlcmd.Transaction = sqlTrans;
            iResult = sqlcmd.ExecuteNonQuery();
        }

        ///#################################################################################
        /// <summary>
        /// 执行sSQLstatement指定的SQL操作,使用dbfamily对多个数据库同时执行
        /// ryo 20070312
        /// for 海信
        /// </summary>
        /// <param name="sSQLstatement">SQL语句</param>
        ///#################################################################################
        public static void ExecuteCommandNoneQueryFamily(string sSQLstatement)
        {
            string CONNECTSTRING_CONFIG_FILENAME = "config.ini";

            ConnectionPool cp;
            System.Data.SqlClient.SqlConnection sqlcon = null;
            System.Data.SqlClient.SqlTransaction myTrans = null;
            System.Data.SqlClient.SqlCommand sqlcmd;
            int iResult;

            //如果存在dbfamily,则循环每一个执行
            string sDBFamily = Config.ConfigManager.GetConfigKeys("dbfamily", CONNECTSTRING_CONFIG_FILENAME);
            if (sDBFamily != "")
            {
                string sSqlConnectionString = "";
                string sConString1 = "server=" + Config.ConfigManager.GetConfigKeys("server", CONNECTSTRING_CONFIG_FILENAME) +
            ((Config.ConfigManager.GetConfigKeys("instance", CONNECTSTRING_CONFIG_FILENAME) == "") ? "" : "\\" + Config.ConfigManager.GetConfigKeys("instance", CONNECTSTRING_CONFIG_FILENAME)) + ";" +
            "timeout=" + Config.ConfigManager.GetConfigKeys("timeout", CONNECTSTRING_CONFIG_FILENAME) + ";" +
            "database=";
                string sConString2 = ";" +
            "uid=" + Config.ConfigManager.GetConfigKeys("uid", CONNECTSTRING_CONFIG_FILENAME) + ";" +
            "pwd=" + BasicFacility.Crypt.BasicCrypt.DecryptIt(Config.ConfigManager.GetConfigKeys("pwd", CONNECTSTRING_CONFIG_FILENAME));
                foreach (string stmp in sDBFamily.Split(','))
                {
                    sSqlConnectionString = sConString1 + stmp + sConString2;
                    sqlcon = new System.Data.SqlClient.SqlConnection(sSqlConnectionString);
                    sqlcon.Open();
                    sqlcmd = new System.Data.SqlClient.SqlCommand(sSQLstatement, sqlcon);
                    sqlcmd.ExecuteNonQuery();
                    sqlcon.Close();
                }
            }
            else
            {
                try
                {
                    cp = new ConnectionPool();
                    sqlcon = cp.GetConnection();
                    myTrans = sqlcon.BeginTransaction();
                    sqlcmd = new System.Data.SqlClient.SqlCommand(sSQLstatement, sqlcon);
                    sqlcmd.Transaction = myTrans;
                    iResult = sqlcmd.ExecuteNonQuery();
                    myTrans.Commit();
                }
                catch (Exception ex)
                {
                    myTrans.Rollback();
                    throw ex;
                }
                finally
                {
                    sqlcon.Close();
                }
            }


        }

        ///#################################################################################
        /// <summary>
        /// 执行sSQLstatement指定的SQL操作，返回受影响的行数
        /// ryo 20060321
        /// </summary>
        /// <param name="sSQLstatement">SQL语句</param>
        /// <returns>受影响的行数</returns>
        ///#################################################################################
        public static void ExecuteCommandImport(string sSQLstatement,
     System.Data.SqlClient.SqlConnection sqlcon,
            System.Data.SqlClient.SqlTransaction sqlTrans)
        {
            ConnectionPool cp;
            System.Data.SqlClient.SqlCommand sqlcmd = null;
            int iResult;
            try
            {
                cp = new ConnectionPool();
                sqlcon = cp.GetConnection();
                sqlcmd = new System.Data.SqlClient.SqlCommand(sSQLstatement, sqlcon);
                sqlcmd.CommandTimeout = 180;
                sqlcmd.Transaction = sqlTrans;
                iResult = sqlcmd.ExecuteNonQuery();
            }
            catch
            {
                try
                {
                    sSQLstatement = sSQLstatement.Remove(0, sSQLstatement.IndexOf(';') + 1);
                    sSQLstatement = sSQLstatement.Remove(sSQLstatement.LastIndexOf(';'));
                    sqlcmd.CommandText = sSQLstatement;
                    sqlcmd.ExecuteNonQuery();
                }
                catch
                {

                }

                //myTrans.Rollback();
                //throw ex;
            }
            finally
            {
                sqlcon.Close();
            }
        }
        #endregion

        #region 其他方法
        ///##################################################################################
        /// <summary>
        /// 测试是否存在patentsearcher数据库
        /// Coder：Kevin Wang（2009-06-30）
        /// </summary>
        /// <returns>连接成功，返回true；否则返回false</returns>
        ///##################################################################################
        public static bool TryDBConnect(string sServer, string sDatabase, string sUser, string sPwd)
        {
            try
            {
                System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                conn.ConnectionString = "server=" + sServer + ";user id=" + sUser + ";password=" + sPwd + ";database=" + sDatabase + ";";
                conn.Open();
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                BasicFacility.Exceptions.ExManager.ReportException(ex);
                return false;
            }
        }
        #endregion
    }
}
