using System;
using System.Configuration;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DataSyncTool.FormConfig
{
    public partial class XFrmConnection : XtraForm
    {
        public XFrmConnection()
        {
            InitializeComponent();
        }

        private void XFrmConnection_Load(object sender, EventArgs e)
        {
            SetConnectionInfo();
        }

        private void xsbSave_Click(object sender, EventArgs e)
        {
            if (!TestPCConnection() || !TestIPSPConnection())
            {
                XtraMessageBox.Show("数据库连接失败！", "连接错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveConnectionInfo();
            DialogResult = DialogResult.OK;
        }

        private void xsbTestConnection_Click(object sender, EventArgs e)
        {
            if (!TestPCConnection() || !TestIPSPConnection())
            {
                XtraMessageBox.Show("数据库连接失败！", "连接错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XtraMessageBox.Show("连接成功！", "连接成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void xsbCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private bool TestPCConnection()
        {
            var connectionString =
                $"Data Source={xtePCAddress.Text.Trim()};User ID={xtePCUser.Text.Trim()};Password={xtePCPassword.Text.Trim()};";
            using (var oracleConnection = new OracleConnection(connectionString))
            {
                try
                {
                    oracleConnection.Open();
                    oracleConnection.Close();
                    return true;
                }
                catch (Exception exception)
                {
                    return false;
                }
            }

        }

        private bool TestIPSPConnection()
        {
            var connectionString =
                $"Data Source={xteIPSPAddress.Text.Trim()};User Id={xteIPSPUser.Text.Trim()};Password={xteIPSPPassword.Text.Trim()};Initial Catalog={xteIPSPDatabase.Text.Trim()};";
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    sqlConnection.Close();
                    return true;
                }
                catch (Exception exception)
                {
                    return false;
                }
            }
        }

        private void SetConnectionInfo()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            var sPCInfos = config.AppSettings.Settings["ConnectionStringPC"].Value.Split(';');
            xtePCAddress.Text = sPCInfos.First(s => s.Contains("Data Source=")).Split('=')[1];
            xtePCUser.Text = sPCInfos.First(s => s.Contains("User ID=")).Split('=')[1];
            xtePCPassword.Text = sPCInfos.First(s => s.Contains("Password=")).Split('=')[1];

            var sIPSPInfos = config.AppSettings.Settings["ConnectionStringIPSP"].Value.Split(';');
            xteIPSPAddress.Text = sIPSPInfos.First(s => s.Contains("Data Source=")).Split('=')[1];
            xteIPSPUser.Text = sIPSPInfos.First(s => s.Contains("User ID=")).Split('=')[1];
            xteIPSPPassword.Text = sIPSPInfos.First(s => s.Contains("Password=")).Split('=')[1];
            xteIPSPDatabase.Text = sIPSPInfos.First(s => s.Contains("Initial Catalog=")).Split('=')[1];
        }

        private string GenerateConnectionString(string sConnection, string sDBAddress, string sUser, string sPassword,
            string sDBName = null)
        {
            var sNewConnectionString = Regex.Replace(sConnection, @"(?<=Data Source=).*?(?=;)", sDBAddress);
            sNewConnectionString = Regex.Replace(sNewConnectionString, @"(?<=User ID=).*?(?=;)", sUser);
            sNewConnectionString = Regex.Replace(sNewConnectionString, @"(?<=Password=).*?(?=;)", sPassword);
            if (sDBName != null)
                sNewConnectionString = Regex.Replace(sNewConnectionString, @"(?<=Initial Catalog=).*?(?=;)", sDBName);
            return sNewConnectionString;
        }

        private void SaveConnectionInfo()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings["ConnectionStringPC"].Value =
                GenerateConnectionString(
                    config.AppSettings.Settings["ConnectionStringPC"].Value,
                    xtePCAddress.Text.Trim(), xtePCUser.Text.Trim(), xtePCPassword.Text.Trim());

            config.AppSettings.Settings["ConnectionStringIPSP"].Value =
                GenerateConnectionString(
                    config.AppSettings.Settings["ConnectionStringIPSP"].Value,
                    xteIPSPAddress.Text.Trim(), xteIPSPUser.Text.Trim(), xteIPSPPassword.Text.Trim(),
                    xteIPSPDatabase.Text.Trim());

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}