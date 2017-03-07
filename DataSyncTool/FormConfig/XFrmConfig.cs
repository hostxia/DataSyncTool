using System;
using System.Collections;
using System.Configuration;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace DataSyncTool.FormConfig
{
    public partial class XFrmConfig : XtraForm
    {
        public XFrmConfig()
        {
            InitializeComponent();
        }

        private void XFrmConfig_Load(object sender, EventArgs e)
        {
            InitControl();
            AssignDataToControl();
        }

        private void xsbSave_Click(object sender, EventArgs e)
        {
            SaveData();
            DialogResult = DialogResult.OK;
        }

        private void xsbCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void InitControl()
        {
            var htTrigger = new Hashtable { { "A", "同步完成后发送日志" }, { "B", "仅在同步出现错误时发送日志" } };
            xlueSendLogTrigger.Properties.DataSource = htTrigger;
            xlueSendLogTrigger.Properties.DisplayMember = "Value";
            xlueSendLogTrigger.Properties.ValueMember = "Key";
            xlueSendLogTrigger.Properties.Columns.Clear();
            xlueSendLogTrigger.Properties.Columns.Add(new LookUpColumnInfo("Value"));
        }

        private void AssignDataToControl()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            xseDayInterval.Value = string.IsNullOrWhiteSpace(config.AppSettings.Settings["Interval"].Value)
                ? 0
                : Convert.ToInt32(config.AppSettings.Settings["Interval"].Value);
            xteBeginTime.Time = DateTime.Parse(config.AppSettings.Settings["BeginTime"].Value);
            xteSendEmail.Text = config.AppSettings.Settings["SendEmail"].Value;
            xteSendServer.Text = config.AppSettings.Settings["SendServer"].Value;
            xteSendUser.Text = config.AppSettings.Settings["SendUser"].Value;
            xteSendPassword.Text = config.AppSettings.Settings["SendPassword"].Value;
            xlueSendLogTrigger.EditValue = config.AppSettings.Settings["SendTrigger"].Value;
            xmemoReceiveEmail.Text = config.AppSettings.Settings["ReceivedEmail"].Value;
        }

        private void SaveData()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings["Interval"].Value = xseDayInterval.Value.ToString(CultureInfo.InvariantCulture);
            config.AppSettings.Settings["BeginTime"].Value = xteBeginTime.Time.ToString("HH:mm");
            config.AppSettings.Settings["SendEmail"].Value = xteSendEmail.Text;
            config.AppSettings.Settings["SendServer"].Value = xteSendServer.Text;
            config.AppSettings.Settings["SendUser"].Value = xteSendUser.Text;
            config.AppSettings.Settings["SendPassword"].Value = xteSendPassword.Text;
            config.AppSettings.Settings["SendTrigger"].Value = xlueSendLogTrigger.EditValue.ToString();
            config.AppSettings.Settings["ReceivedEmail"].Value = xmemoReceiveEmail.Text;

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}