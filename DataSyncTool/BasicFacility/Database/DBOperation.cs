/// <copyright from='2000' to='2010' company='����������Ϣ�������޹�˾'>        
///    Copyright(c) ����������Ϣ�������޹�˾��Ȩ����.                           
/// </copyright>     
///*******************************************************************/
///*  FileName: DBOperation.cs                                       */
///*  Function: ���ݲ����                                    */
///*    Coder: ryo.wu                                                */
///*      Date: 2006-3-21                                            */
///*  Modified:                                                      */
///*  �ṩ���ݲ�Ļ��������������ȡDataSet�����ݼ����������� */
///*  ִ��SQL���ȡ��ײ����ӻ������ӳ��ṩ�Ĺ��ܣ����ݲ��е� */
///*  ����֧��������                                     */
///*******************************************************************/

using System;
using System.Data;

namespace BasicFacility.Database
{
    /// <summary>
    /// ���ݿ����
    /// </summary>
    public class DBOperation
    {
        /////#################################################################################
        ///// <summary>
        ///// ��ȡsSQLstatementָ���Ĳ�ѯ���ݼ���
        ///// ryo 20060321
        ///// </summary>
        ///// <param name="sSQLstatement">SQL���</param>
        ///// <returns>���ݼ���</returns>
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
        ///// ��ȡsSQLstatementָ���Ĳ�ѯ���ݼ���
        ///// ryo 20060321
        ///// Modify:Alex 2010-04-01  ���ӶԲ�ͬ�����ļ���֧��
        ///// </summary>
        ///// <param name="sSQLstatement">SQL���</param>
        ///// <param name="sConfigFileName">�����ļ�����</param>
        ///// <returns>���ݼ���</returns>
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
        ///// ��ȡsSQLstatementָ���Ĳ�ѯ���ݵ�һ�е�һ��
        ///// ryo 20060321
        ///// </summary>
        ///// <param name="sSQLstatement">SQL���</param>
        ///// <returns>��һ�е�һ�е�ֵ</returns>
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
        ///// ��ȡsSQLstatementָ���Ĳ�ѯ���ݵ�һ�е�һ��
        ///// ryo 20060321
        ///// Modify:Alex 2010-04-01  ���ӶԲ�ͬ�����ļ���֧��
        ///// </summary>
        ///// <param name="sSQLstatement">SQL���</param>
        ///// <param name="sConfigFileName">�����ļ�����</param>
        ///// <returns>��һ�е�һ�е�ֵ</returns>
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
        ///// ��ȡsSQLstatementָ���Ĳ�ѯ���ݵ�һ�е�һ��(��������)
        ///// ִ�к������sql���Ӳ��ᱻ�رգ����񲻻ᱻcommit��
        ///// Coder:Ryo Wu 2007-07-05
        ///// </summary>
        ///// <param name="sSQLstatement">SQL���</param>
        ///// <param name="sqlcon">SQL����</param>
        ///// <param name="sqlTrans">SQL����</param>
        ///// <returns>��һ�е�һ�е�ֵ��ʧ���򷵻�null</returns>
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
        ///// ��ȡsSQLstatementָ���Ĳ�ѯ����DataSet
        ///// ryo 20060321
        ///// </summary>
        ///// <param name="sSQLstatement">SQL���</param>
        ///// <returns>����DataSet</returns>
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
        ///// ִ��sSQLstatementָ����SQL������������Ӱ�������
        ///// ryo 20060321
        ///// </summary>
        ///// <param name="sSQLstatement">SQL���</param>
        ///// <returns>��Ӱ�������</returns>
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
        ///// ִ��sSQLstatementָ����SQL������������Ӱ�������
        ///// ryo 20060321
        ///// Modify:Alex 2010-04-01  ���ӶԲ�ͬ�����ļ���֧��
        ///// </summary>
        ///// <param name="sSQLstatement">SQL���</param>
        ///// <param name="sConfigFileName">�����ļ�����</param>
        ///// <returns>��Ӱ�������</returns>
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
        ///// ִ��sSQLstatementָ����SQL������������Ӱ�������
        ///// ryo 20060321
        ///// </summary>
        ///// <param name="sSQLstatement">SQL���</param>
        ///// <returns>��Ӱ�������</returns>
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
        ///// ִ��sSQLstatementָ����SQL������������Ӱ�������
        ///// ryo 20060321
        ///// </summary>
        ///// <param name="sSQLstatement">SQL���</param>
        ///// <returns>��Ӱ�������</returns>
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
        ///// ִ��sSQLstatementָ����SQL������������Ӱ�������
        ///// ryo 20060321
        ///// Modify:Alex 2010-04-01  ���ӶԲ�ͬ�����ļ���֧��
        ///// </summary>
        ///// <param name="sSQLstatement">SQL���</param>
        ///// <param name="sConfigFileName">�����ļ�����</param>
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
        ///// ִ��sSQLstatementָ����SQL����
        ///// ryo 20060321
        ///// </summary>
        ///// <param name="sSQLstatement">SQL���</param>
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
        ///// ִ��sSQLstatementָ����SQL����
        ///// Modify:Alex 2010-04-01  ���ӶԲ�ͬ�����ļ���֧��
        ///// </summary>
        ///// <param name="sSQLstatement">SQL���</param>
        ///// <param name="sConfigFileName">�����ļ�����</param>
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
        ///// ִ��sSQLstatementָ����SQL����,ʹ��dbfamily�Զ�����ݿ�ͬʱִ��
        ///// ryo 20070312
        ///// for ����
        ///// </summary>
        ///// <param name="sSQLstatement">SQL���</param>
        /////#################################################################################
        //public static void ExecuteCommandNoneQueryFamily(string sSQLstatement)
        //{
        //    string CONNECTSTRING_CONFIG_FILENAME = "config.ini";

        //    ConnectionPool cp;
        //    System.Data.SqlClient.SqlConnection sqlcon = null;
        //    System.Data.SqlClient.SqlTransaction myTrans = null;
        //    System.Data.SqlClient.SqlCommand sqlcmd;
        //    int iResult;

        //    //�������dbfamily,��ѭ��ÿһ��ִ��
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
        ///// ��ȡsSQLstatementָ���Ĳ�ѯ����DataSet
        ///// shawn 20060330
        ///// </summary>
        ///// <param name="sSQLstatement">SQL���</param>
        ///// <returns>����DataSet</returns>
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
        ///// ��ȡsSQLstatementָ���Ĳ�ѯ����DataSet
        ///// shawn 20060330
        ///// Modify:Alex 2010-04-01  ���ӶԲ�ͬ�����ļ���֧��
        ///// </summary>
        ///// <param name="sSQLstatement">SQL���</param>
        ///// <param name="sConfigFileName">�����ļ�����</param>
        ///// <returns>����DataSet</returns>
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

        #region Get����
        ///#################################################################################
        /// <summary>
        /// ��ȡsSQLstatementָ���Ĳ�ѯ���ݼ���
        /// ryo 20060321
        /// </summary>
        /// <param name="sSQLstatement">SQL���</param>
        /// <returns>���ݼ���</returns>
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
        /// ��ȡsSQLstatementָ���Ĳ�ѯ���ݵ�һ�е�һ��
        /// ryo 20060321
        /// </summary>
        /// <param name="sSQLstatement">SQL���</param>
        /// <param name="sSQLstatement">���峬ʱʱ��</param>
        /// <returns>��һ�е�һ�е�ֵ</returns>
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
        /// ��ȡsSQLstatementָ���Ĳ�ѯ���ݼ���(��������)
        /// Coder:Ryo Wu 2007-07-05
        /// </summary>
        /// <param name="sSQLstatement">SQL���</param>
        /// <param name="sqlcon">SQL����</param>
        /// <returns>���ݼ���</returns>
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
        /// ��ȡsSQLstatementָ���Ĳ�ѯ���ݵ�һ�е�һ��
        /// ryo 20060321
        /// </summary>
        /// <param name="sSQLstatement">SQL���</param>
        /// <returns>��һ�е�һ�е�ֵ</returns>
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
        /// ��ȡsSQLstatementָ���Ĳ�ѯ���ݵ�һ�е�һ��
        /// ryo 20060321
        /// Modify:Alex 2010-04-01  ���ӶԲ�ͬ�����ļ���֧��
        /// </summary>
        /// <param name="sSQLstatement">SQL���</param>
        /// <param name="sConfigFileName">�����ļ�����</param>
        /// <returns>��һ�е�һ�е�ֵ</returns>
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
        /// ��ȡsSQLstatementָ���Ĳ�ѯ���ݵ�һ�е�һ��(��������)
        /// ִ�к������sql���Ӳ��ᱻ�رգ����񲻻ᱻcommit��
        /// Coder:Ryo Wu 2007-07-05
        /// </summary>
        /// <param name="sSQLstatement">SQL���</param>
        /// <param name="sqlcon">SQL����</param>
        /// <param name="sqlTrans">SQL����</param>
        /// <returns>��һ�е�һ�е�ֵ��ʧ���򷵻�null</returns>
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
        /// ��ȡsSQLstatementָ���Ĳ�ѯ���ݵ�һ�е�һ��(��������)
        /// ִ�к������sql���Ӳ��ᱻ�رգ����񲻻ᱻcommit��
        /// Coder:Ryo Wu 2007-07-05
        /// </summary>
        /// <param name="sSQLstatement">SQL���</param>
        /// <param name="sqlcon">SQL����</param>
        /// <param name="sqlTrans">SQL����</param>
        /// <returns>��һ�е�һ�е�ֵ��ʧ���򷵻�null</returns>
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
        /// ��ȡsqlcmd��ѯ���ݵ�һ�е�һ��
        /// ryo 2007-07-25
        /// </summary>
        /// <param name="sqlcmd">SQLCommandʵ��</param>
        /// <returns>��һ�е�һ�е�ֵ</returns>
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
        /// ��ȡsSQLstatementָ���Ĳ�ѯ����DataSet
        /// ryo 20060321
        /// </summary>
        /// <param name="sSQLstatement">SQL���</param>
        /// <returns>����DataSet</returns>
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
        /// ִ�в�ѯ���������񷽷���
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
        /// ��ȡsSQLstatementָ���Ĳ�ѯ����DataSet
        /// shawn 20060330
        /// </summary>
        /// <param name="sSQLstatement">SQL���</param>
        /// <returns>����DataSet</returns>
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
        /// ��ȡsSQLstatementָ���Ĳ�ѯ����DataSet
        /// ryo 20060321
        /// </summary>
        /// <param name="sSQLstatement">SQL���</param>
        /// <returns>����DataSet</returns>
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

        #region Execute����
        ///#################################################################################
        /// <summary>
        /// ִ��sSQLstatementָ����SQL������������Ӱ�������
        /// ryo 20060321
        /// </summary>
        /// <param name="sSQLstatement">SQL���</param>
        /// <returns>��Ӱ�������</returns>
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
        /// ִ��sSQLstatementָ����SQL������������Ӱ�������
        /// ryo 20060321
        /// </summary>
        /// <param name="sSQLstatement">SQL���</param>
        /// <param name="sSQLstatement">����ĳ�ʱʱ��</param>
        /// <returns>��Ӱ�������</returns>
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
        /// ִ��sSQLstatementָ����SQL������������Ӱ�������
        /// ryo 20060321
        /// </summary>
        /// <param name="sSQLstatement">SQL���</param>
        /// <returns>��Ӱ�������</returns>
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
        /// ִ��sSQLstatementָ����SQL������������Ӱ�������
        /// ryo 20060321
        /// </summary>
        /// <param name="sSQLstatement">SQL���</param>
        /// <returns>��Ӱ�������</returns>
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
        /// �����ݿ�����ض��Ĳ�����������ز����@@IDENTITY
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
        /// ִ��sSQLstatementָ����SQL������������Ӱ�������
        /// ryo 20060321
        /// </summary>
        /// <param name="sSQLstatement">SQL���</param>
        /// <returns>��Ӱ�������</returns>
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
        /// ִ��sSQLstatementָ����SQL����
        /// ryo 20060321
        /// </summary>
        /// <param name="sSQLstatement">SQL���</param>
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
        /// ִ��sSQLstatementָ����SQL����(��������)
        /// ִ�к������sql���Ӳ��ᱻ�رգ����񲻻ᱻcommit��
        /// Coder:Ryo Wu 2007-07-05
        /// </summary>
        /// <param name="sSQLstatement">SQL���</param>
        /// <param name="sqlcon">SQL����</param>
        /// <param name="sqlTrans">SQL����</param>
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
        /// ִ��sSQLstatementָ����SQL����,ʹ��dbfamily�Զ�����ݿ�ͬʱִ��
        /// ryo 20070312
        /// for ����
        /// </summary>
        /// <param name="sSQLstatement">SQL���</param>
        ///#################################################################################
        public static void ExecuteCommandNoneQueryFamily(string sSQLstatement)
        {
            string CONNECTSTRING_CONFIG_FILENAME = "config.ini";

            ConnectionPool cp;
            System.Data.SqlClient.SqlConnection sqlcon = null;
            System.Data.SqlClient.SqlTransaction myTrans = null;
            System.Data.SqlClient.SqlCommand sqlcmd;
            int iResult;

            //�������dbfamily,��ѭ��ÿһ��ִ��
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
        /// ִ��sSQLstatementָ����SQL������������Ӱ�������
        /// ryo 20060321
        /// </summary>
        /// <param name="sSQLstatement">SQL���</param>
        /// <returns>��Ӱ�������</returns>
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

        #region ��������
        ///##################################################################################
        /// <summary>
        /// �����Ƿ����patentsearcher���ݿ�
        /// Coder��Kevin Wang��2009-06-30��
        /// </summary>
        /// <returns>���ӳɹ�������true�����򷵻�false</returns>
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
