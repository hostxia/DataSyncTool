/// <copyright from='2000' to='2010' company='北京彼速信息技术有限公司'>        
///    Copyright(c) 北京彼速信息技术有限公司版权所有.                           
/// </copyright>                                                                
///*******************************************************************************/
///      FileName: ConfigManager.cs					     
///      Function: Config文件的读写函数库                                            
///         Coder: Ryo                                                         
///          Date: 2005-12-1                                                   
///*******************************************************************************/


using System;
using System.Data;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace BasicFacility.Config
{
    public class ConfigManager
    {
        ///#################################################################################
        /// <summary>
        /// 获取配置文件中的键值
        /// ryo 20060320
        /// 用于兼容专利之星软件。
        /// </summary>
        /// <param name="KeyName">键名</param>
        /// <param name="ConfigFileName">配置文件名</param>
        /// <returns>键值</returns>
        ///#################################################################################
        public static string GetConfigKeys(string sKeyName, string sConfigFileName)
        {
            StreamReader sr;
            //简要规整输入参数
            sKeyName = sKeyName.Trim();
            sConfigFileName = sConfigFileName.Trim();
            try
            {
                sr = new StreamReader(Application.StartupPath + "\\Config\\" + sConfigFileName, Encoding.UTF8);
                while (true)
                {
                    string tmpstr = sr.ReadLine();
                    //如果读取到末尾则返回null
                    if (tmpstr == null)
                    {
                        throw new Exception("Can not find this key");
                    }
                    else
                    {
                        if (tmpstr.IndexOf(sKeyName) > -1)
                        {
                            if (tmpstr.Trim().Length > sKeyName.Length + 1)
                            {
                                sr.Close();
                                return tmpstr.Substring(tmpstr.IndexOf('=') + 1).Trim();
                            }
                            else
                            {
                                sr.Close();
                                return "";
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            catch
            {
                return "";
            }
        }
    }

    /// <summary>
    /// 管理XML类配置文件的操作类
    /// </summary>
    public class XMLConfigManager
    {
        #region 常数

        //====================================================================================================================================
        /// <summary>
        /// SystemEnvironment的xml文件名称
        /// </summary>
        public string SYSTEM_ENVIRONMENT_FILENAME = "SystemEnvironment.xml";

        /// <summary>
        /// SystemEnvironment中表1 - 数据库连接配置及ftp配置表
        /// </summary>
        private const string SYSTEM_ENVIRONMENT_TABLE1 = "Connection";

        /// <summary>
        /// 数据库连接配置及ftp配置表 结构
        /// </summary>
        private const string SYSTEM_ENVIRONMENT_TABLE1_STRUCT = "server,database,uid,pwd,instance,ftpserver,ftpuser,ftppwd,ftpport,timeout";
        //====================================================================================================================================
        #endregion

        #region 枚举
        /// <summary>
        /// config文件的类型
        /// </summary>
        public enum XMLConfigFile
        {
            /// <summary>
            /// 系统环境配置
            /// </summary>
            SystemEnvironment,
        }
        #endregion

        #region 字段
        /// <summary>
        /// 读取数据的dataset
        /// </summary>
        private DataSet dsConfigData;

        /// <summary>
        /// config文件路径及名称
        /// </summary>
        private string sFilePath;
        #endregion

        #region 属性
        /// <summary>
        /// config文件路径及名称
        /// </summary>
        public string ConfigFilePath
        {
            get { return sFilePath; }
            set { sFilePath = value; }
        }
        #endregion

        #region 构造函数
        ///#################################################################################
        /// <summary>
        /// 构造函数
        /// Coder:Ryo wu 2007-07-12
        /// </summary>
        ///#################################################################################
        public XMLConfigManager()
        {
            dsConfigData = new DataSet();
        }

        ///#################################################################################
        /// <summary>
        /// 构造函数
        /// Coder:Ryo wu 2007-07-12
        /// </summary>
        /// <param name="sFilePath">xml config文件路径</param>
        ///#################################################################################
        public XMLConfigManager(string FilePath)
        {
            dsConfigData = new DataSet();
            sFilePath = FilePath;
        }
        #endregion

        #region 方法
        ///#################################################################################
        /// <summary>
        /// 获取配置key的值(默认在第一个配置表中查找)
        /// Coder:Ryo wu 2007-07-12
        /// </summary>
        /// <param name="sKeyName">key名称</param>
        /// <returns>key值</returns>
        ///#################################################################################
        public string GetKeyValue(string sKeyName)
        {
            string sValue = null;
            if (dsConfigData.Tables.Count > 0)
            {
                for (int i = 0; i < dsConfigData.Tables.Count; i++)
                {
                    DataRow[] dr = dsConfigData.Tables[i].Select(dsConfigData.Tables[i].Columns[0].Caption + " = '" + sKeyName + "'");
                    for (int iCnt = 0; iCnt < dr.Length; iCnt++)
                    {
                        sValue = dr[iCnt][1].ToString();
                    }
                }
            }
            return sValue;
        }

        ///#################################################################################
        /// <summary>
        /// 获取配置key的值在指定的表中
        /// Coder:Ryo wu 2007-07-12
        /// </summary>
        /// <param name="sTableName">表名称</param>
        /// <param name="sKeyName">key名称</param>
        /// <returns>key值</returns>
        ///#################################################################################
        public string GetKeyValue(string sTableName, string sKeyName)
        {
            string sValue = null;
            if (dsConfigData.Tables.Count > 0)
            {
                DataRow[] dr = dsConfigData.Tables[sTableName].Select(dsConfigData.Tables[sTableName].Columns[0].Caption + " = '" + sKeyName + "'");
                if (dr.Length > 0)
                {
                    sValue = dr[0][1].ToString();
                }
            }
            return sValue;
        }

        ///#################################################################################
        /// <summary>
        /// 设置配置key的值(默认在第一个配置表中查找)
        /// Coder:Ryo wu 2007-07-12
        /// </summary>
        /// <param name="sKeyName">key名称</param>
        /// <param name="sKeyValue">key值</param>
        ///#################################################################################
        public void SetKeyValue(string sKeyName, string sKeyValue)
        {
            if (dsConfigData.Tables.Count > 0)
            {
                for (int i = 0; i < dsConfigData.Tables.Count; i++)
                {
                    DataRow[] dr = dsConfigData.Tables[i].Select(dsConfigData.Tables[i].Columns[0].Caption + " = '" + sKeyName + "'");
                    for (int iCnt = 0; iCnt < dr.Length; iCnt++)
                    {
                        dr[iCnt][1] = sKeyValue;
                    }
                }
            }
        }

        ///#################################################################################
        /// <summary>
        /// 设置配置key的值在指定的表中
        /// Coder:Ryo wu 2007-07-12
        /// </summary>
        /// <param name="sTableName">表名称</param>
        /// <param name="sKeyName">key名称</param>
        /// <param name="sKeyValue">key值</param>
        ///#################################################################################
        public void SetKeyValue(string sTableName, string sKeyName, string sKeyValue)
        {
            if (dsConfigData.Tables.Count > 0)
            {
                DataRow[] dr = dsConfigData.Tables[sTableName].Select(dsConfigData.Tables[sTableName].Columns[0].Caption + " = '" + sKeyName + "'");
                if (dr.Length > 0)
                {
                    dr[0][1] = sKeyValue;
                }
            }
        }

        ///#################################################################################
        /// <summary>
        /// 读取config文件
        /// </summary>
        /// <param name="sFilePath">xml config文件</param>
        ///#################################################################################
        public void LoadConfig(string FilePath)
        {
            dsConfigData.Clear();
            dsConfigData.Reset();
            this.sFilePath = FilePath;
            dsConfigData.ReadXml(this.sFilePath, XmlReadMode.Auto);
        }

        ///#################################################################################
        /// <summary>
        /// 读取config文件
        /// </summary>
        /// <param name="sFilePath">xml config文件</param>
        ///#################################################################################
        public void LoadConfig(XMLConfigFile xmlConfigFile)
        {
            string FilePath = "";
            switch (xmlConfigFile)
            {
                case XMLConfigFile.SystemEnvironment:
                    {
                        FilePath = Application.StartupPath + "\\config\\" + SYSTEM_ENVIRONMENT_FILENAME;
                        break;
                    }
            }
            this.sFilePath = FilePath;
            dsConfigData.ReadXml(this.sFilePath, XmlReadMode.Auto);
        }

        ///#################################################################################
        /// <summary>
        /// 保存config文件
        /// </summary>
        ///#################################################################################
        public void SaveConfig()
        {
            SaveConfig(false);
        }

        ///#################################################################################
        /// <summary>
        /// 保存config文件
        /// <param name="bCheckExist">true:检查如果存在则跳过  false:直接覆盖</param>
        /// </summary>
        ///#################################################################################
        public void SaveConfig(bool bCheckExist)
        {
            dsConfigData.WriteXml(sFilePath);

        }

        ///#################################################################################
        /// <summary>
        /// 初始化XMLConfig文件，恢复到刚安装软件后的状态(config文件都在 \config\文件夹中)
        /// Coder:Ryo wu 2007-07-12
        /// </summary>
        /// <param name="xmlConfigFile">配置文件的名字</param>
        /// <returns>true:成功 false:失败</returns>
        ///#################################################################################
        public void InitXMLConfigFile(XMLConfigFile xmlConfigFile)
        {
            InitXMLConfigFile(xmlConfigFile, false);
        }

        ///#################################################################################
        /// <summary>
        /// 初始化XMLConfig文件，恢复到刚安装软件后的状态(config文件都在 \config\文件夹中)
        /// Coder:Ryo wu 2007-07-12
        /// </summary>
        /// <param name="xmlConfigFile">配置文件的名字</param>
        /// <param name="bCheckExist">true:检查如果存在则跳过  false:直接覆盖</param>
        /// <returns>true:成功 false:失败</returns>
        ///#################################################################################
        public void InitXMLConfigFile(XMLConfigFile xmlConfigFile, bool bCheckExist)
        {
            if (!Directory.Exists(Application.StartupPath + "\\config"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\config");
            }
            dsConfigData.Clear();
            dsConfigData.Reset();
            switch (xmlConfigFile)
            {
                case XMLConfigFile.SystemEnvironment:
                    {
                        dsConfigData.Tables.Add(BuildConfigTable("Connection"));
                        this.sFilePath = Application.StartupPath + "\\config\\" + SYSTEM_ENVIRONMENT_FILENAME;
                        break;
                    }
            }

            //this.SaveConfig();
        }

        ///#################################################################################
        /// <summary>
        /// 所指定的config文件是否存在
        /// Coder:Ryo wu 2007-07-12
        /// </summary>
        /// <param name="xmlConfigFile">xml文件</param>
        /// <returns>true:存在 false:不存在</returns>
        ///#################################################################################
        public bool ExistXMLConfigFile(XMLConfigFile xmlConfigFile)
        {
            bool bExist = false;
            switch (xmlConfigFile)
            {
                case XMLConfigFile.SystemEnvironment:
                    {
                        bExist = File.Exists(Application.StartupPath + "\\config\\" + SYSTEM_ENVIRONMENT_FILENAME);
                        break;
                    }
            }
            return bExist;
        }

        ///#################################################################################
        /// <summary>
        /// 构建配置内容表
        /// Coder:Ryo wu 2007-07-12
        /// </summary>
        /// <returns>配置内容表</returns>
        ///#################################################################################
        private DataTable BuildConfigTable(string sTableName)
        {
            DataTable dttmp = new DataTable();
            dttmp.Columns.Add("key");
            dttmp.Columns.Add("value");
            dttmp.TableName = sTableName;

            string stmpStruct = "";
            switch (sTableName)
            {
                case SYSTEM_ENVIRONMENT_TABLE1:
                    {
                        stmpStruct = SYSTEM_ENVIRONMENT_TABLE1_STRUCT;
                        break;
                    }
            }

            string[] sKeys = stmpStruct.Split(',');

            foreach (string stmp in sKeys)
            {
                DataRow dr = dttmp.NewRow();
                dr["key"] = stmp;
                dr["value"] = "";
                dttmp.Rows.Add(dr);
            }
            return dttmp;
        }
        #endregion
    }
}
