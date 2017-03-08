/// <copyright from='2000' to='2010' company='����������Ϣ�������޹�˾'>        
///    Copyright(c) ����������Ϣ�������޹�˾��Ȩ����.                           
/// </copyright>                                                                
///*******************************************************************************/
///      FileName: ConfigManager.cs					     
///      Function: Config�ļ��Ķ�д������                                            
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
        /// ��ȡ�����ļ��еļ�ֵ
        /// ryo 20060320
        /// ���ڼ���ר��֮�������
        /// </summary>
        /// <param name="KeyName">����</param>
        /// <param name="ConfigFileName">�����ļ���</param>
        /// <returns>��ֵ</returns>
        ///#################################################################################
        public static string GetConfigKeys(string sKeyName, string sConfigFileName)
        {
            StreamReader sr;
            //��Ҫ�����������
            sKeyName = sKeyName.Trim();
            sConfigFileName = sConfigFileName.Trim();
            try
            {
                sr = new StreamReader(Application.StartupPath + "\\Config\\" + sConfigFileName, Encoding.UTF8);
                while (true)
                {
                    string tmpstr = sr.ReadLine();
                    //�����ȡ��ĩβ�򷵻�null
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
    /// ����XML�������ļ��Ĳ�����
    /// </summary>
    public class XMLConfigManager
    {
        #region ����

        //====================================================================================================================================
        /// <summary>
        /// SystemEnvironment��xml�ļ�����
        /// </summary>
        public string SYSTEM_ENVIRONMENT_FILENAME = "SystemEnvironment.xml";

        /// <summary>
        /// SystemEnvironment�б�1 - ���ݿ��������ü�ftp���ñ�
        /// </summary>
        private const string SYSTEM_ENVIRONMENT_TABLE1 = "Connection";

        /// <summary>
        /// ���ݿ��������ü�ftp���ñ� �ṹ
        /// </summary>
        private const string SYSTEM_ENVIRONMENT_TABLE1_STRUCT = "server,database,uid,pwd,instance,ftpserver,ftpuser,ftppwd,ftpport,timeout";
        //====================================================================================================================================
        #endregion

        #region ö��
        /// <summary>
        /// config�ļ�������
        /// </summary>
        public enum XMLConfigFile
        {
            /// <summary>
            /// ϵͳ��������
            /// </summary>
            SystemEnvironment,
        }
        #endregion

        #region �ֶ�
        /// <summary>
        /// ��ȡ���ݵ�dataset
        /// </summary>
        private DataSet dsConfigData;

        /// <summary>
        /// config�ļ�·��������
        /// </summary>
        private string sFilePath;
        #endregion

        #region ����
        /// <summary>
        /// config�ļ�·��������
        /// </summary>
        public string ConfigFilePath
        {
            get { return sFilePath; }
            set { sFilePath = value; }
        }
        #endregion

        #region ���캯��
        ///#################################################################################
        /// <summary>
        /// ���캯��
        /// Coder:Ryo wu 2007-07-12
        /// </summary>
        ///#################################################################################
        public XMLConfigManager()
        {
            dsConfigData = new DataSet();
        }

        ///#################################################################################
        /// <summary>
        /// ���캯��
        /// Coder:Ryo wu 2007-07-12
        /// </summary>
        /// <param name="sFilePath">xml config�ļ�·��</param>
        ///#################################################################################
        public XMLConfigManager(string FilePath)
        {
            dsConfigData = new DataSet();
            sFilePath = FilePath;
        }
        #endregion

        #region ����
        ///#################################################################################
        /// <summary>
        /// ��ȡ����key��ֵ(Ĭ���ڵ�һ�����ñ��в���)
        /// Coder:Ryo wu 2007-07-12
        /// </summary>
        /// <param name="sKeyName">key����</param>
        /// <returns>keyֵ</returns>
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
        /// ��ȡ����key��ֵ��ָ���ı���
        /// Coder:Ryo wu 2007-07-12
        /// </summary>
        /// <param name="sTableName">������</param>
        /// <param name="sKeyName">key����</param>
        /// <returns>keyֵ</returns>
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
        /// ��������key��ֵ(Ĭ���ڵ�һ�����ñ��в���)
        /// Coder:Ryo wu 2007-07-12
        /// </summary>
        /// <param name="sKeyName">key����</param>
        /// <param name="sKeyValue">keyֵ</param>
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
        /// ��������key��ֵ��ָ���ı���
        /// Coder:Ryo wu 2007-07-12
        /// </summary>
        /// <param name="sTableName">������</param>
        /// <param name="sKeyName">key����</param>
        /// <param name="sKeyValue">keyֵ</param>
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
        /// ��ȡconfig�ļ�
        /// </summary>
        /// <param name="sFilePath">xml config�ļ�</param>
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
        /// ��ȡconfig�ļ�
        /// </summary>
        /// <param name="sFilePath">xml config�ļ�</param>
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
        /// ����config�ļ�
        /// </summary>
        ///#################################################################################
        public void SaveConfig()
        {
            SaveConfig(false);
        }

        ///#################################################################################
        /// <summary>
        /// ����config�ļ�
        /// <param name="bCheckExist">true:����������������  false:ֱ�Ӹ���</param>
        /// </summary>
        ///#################################################################################
        public void SaveConfig(bool bCheckExist)
        {
            dsConfigData.WriteXml(sFilePath);

        }

        ///#################################################################################
        /// <summary>
        /// ��ʼ��XMLConfig�ļ����ָ����հ�װ������״̬(config�ļ����� \config\�ļ�����)
        /// Coder:Ryo wu 2007-07-12
        /// </summary>
        /// <param name="xmlConfigFile">�����ļ�������</param>
        /// <returns>true:�ɹ� false:ʧ��</returns>
        ///#################################################################################
        public void InitXMLConfigFile(XMLConfigFile xmlConfigFile)
        {
            InitXMLConfigFile(xmlConfigFile, false);
        }

        ///#################################################################################
        /// <summary>
        /// ��ʼ��XMLConfig�ļ����ָ����հ�װ������״̬(config�ļ����� \config\�ļ�����)
        /// Coder:Ryo wu 2007-07-12
        /// </summary>
        /// <param name="xmlConfigFile">�����ļ�������</param>
        /// <param name="bCheckExist">true:����������������  false:ֱ�Ӹ���</param>
        /// <returns>true:�ɹ� false:ʧ��</returns>
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
        /// ��ָ����config�ļ��Ƿ����
        /// Coder:Ryo wu 2007-07-12
        /// </summary>
        /// <param name="xmlConfigFile">xml�ļ�</param>
        /// <returns>true:���� false:������</returns>
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
        /// �����������ݱ�
        /// Coder:Ryo wu 2007-07-12
        /// </summary>
        /// <returns>�������ݱ�</returns>
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
