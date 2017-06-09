using System;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataSyncTool.Common;
using DataSyncTool.DBUtility;
using DataSyncTool.FormConfig;
using DataSyncTool.Log;
using DataSyncTool.Sync.Case;
using DataSyncTool.Sync.Contact;
using DataSyncTool.Sync.Element;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace DataSyncTool
{
    public partial class XFrmMain : Form
    {
        private SyncResultInfoSet _syncResultInfoSet;

        public XFrmMain()
        {
            InitializeComponent();
        }

        private void XFrmMain_Load(object sender, EventArgs e)
        {
            if (!TestPCConnection() || !TestIPSPConnection() || !CreateConnection())
            {
                XtraMessageBox.Show("数据库连接失败！", "错误");
                return;
            }
            _syncResultInfoSet = new SyncResultInfoSet(xgridResult);
            GetSyncDate();

            Task.Run(() =>
            {
                while (DateTime.Now >= ConfigHelper.NextDate)
                    Invoke(new Action(() => { xsbSync.PerformClick(); }));
            });
        }

        private void xbbiConnectionConfig_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new XFrmConnection();
            frm.ShowDialog(this);
        }

        private void xbiCommonConfig_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new XFrmConfig();
            frm.ShowDialog(this);
        }

        private void xsbSync_Click(object sender, EventArgs e)
        {
            ConfigHelper.BeginDate = xdeBeginDate.DateTime;
            var dtBegin = DateTime.Now;
            _syncResultInfoSet.Clear();
            _syncResultInfoSet.AddInfo($"同步时间段为：{ConfigHelper.BeginDate}至{ConfigHelper.NextDate}");
            xsbSync.Enabled = false;
            xbbiConnectionConfig.Enabled = false;
            xbiCommonConfig.Enabled = false;
            Task.Run(() =>
                {
                    new SyncClientList { SyncResultInfoSet = _syncResultInfoSet }.DataSync();//同步客户信息
                    new SyncApplicantList { SyncResultInfoSet = _syncResultInfoSet }.DataSync();//同步申请人
                    new SyncAgencyList { SyncResultInfoSet = _syncResultInfoSet }.DataSync();//同步外所
                    new SyncPatentList { SyncResultInfoSet = _syncResultInfoSet }.DataSync();//同步国内专利
                    new SyncPatentAbroadList { SyncResultInfoSet = _syncResultInfoSet }.DataSync();//同步国外专利
                    new SyncPatentHKList { SyncResultInfoSet = _syncResultInfoSet }.DataSync();//同步香港专利
                    new SyncDemandList { SyncResultInfoSet = _syncResultInfoSet }.DataSync();//同步要求
                    new SyncInFileList { SyncResultInfoSet = _syncResultInfoSet }.DataSync();//同步来文（官方、客户）
                    new SyncAnnualFeeList { SyncResultInfoSet = _syncResultInfoSet }.DataSync();//同步年费
                    new SyncCustomFieldList { SyncResultInfoSet = _syncResultInfoSet }.DataSync();//同步自定义属性
                    new SyncOAList { SyncResultInfoSet = _syncResultInfoSet }.DataSync();//同步OA
                    _syncResultInfoSet.AddInfo("同步完成！");
                })
                .ContinueWith(t =>
                {
                    Invoke(new Action(() =>
                    {
                        CalcNewSyncDate(dtBegin);
                        GetSyncDate();
                        _syncResultInfoSet.SendEmailByCondition();
                        xsbSync.Enabled = true;
                        xbbiConnectionConfig.Enabled = true;
                        xbiCommonConfig.Enabled = true;
                    }));
                });
        }

        private void GetSyncDate()
        {
            xdeBeginDate.DateTime = ConfigHelper.BeginDate;
            xdeFinishDate.DateTime = ConfigHelper.FinishDate;
            xdeNextBeginDate.DateTime = ConfigHelper.NextDate;
        }

        private void CalcNewSyncDate(DateTime dtBegin)
        {
            ConfigHelper.FinishDate = DateTime.Now;
            ConfigHelper.BeginDate = dtBegin < ConfigHelper.NextDate ? dtBegin : ConfigHelper.NextDate;
        }

        private bool TestPCConnection()
        {
            using (var oracleConnection = new OracleConnection(PubConstant.ConnectionStringPC))
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
            using (var sqlConnection = new SqlConnection(PubConstant.ConnectionStringIPSP))
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

        private static bool CreateConnection()
        {
            try
            {
                XpoDefault.DataLayer = XpoDefault.GetDataLayer(PubConstant.ConnectionStringIPSP,
                    AutoCreateOption.None);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void XFrmMain_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized) HideForm();
        }

        private void OpenForm()
        {
            Show();
            WindowState = FormWindowState.Normal;
            Activate();
        }

        private void HideForm()
        {
            ShowInTaskbar = false;
            Hide();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            if (!Visible)
                OpenForm();
            else
                HideForm();
        }
    }
}