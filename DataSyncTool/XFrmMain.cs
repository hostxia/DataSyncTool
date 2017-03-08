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

            //Task.Run(() =>
            //{
            //    while (DateTime.Now >= ConfigHelper.NextDate)
            //        Invoke(new Action(() => { xsbSync.PerformClick(); }));
            //});
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
            _syncResultInfoSet.Clear();
            xsbSync.Enabled = false;
            xbbiConnectionConfig.Enabled = false;
            xbiCommonConfig.Enabled = false;
            Task.Run(() =>
                {
                    //new SyncClientList { SyncResultInfoSet = _syncResultInfoSet }.DataSync();
                    //new SyncApplicantList { SyncResultInfoSet = _syncResultInfoSet }.DataSync();
                    //new SyncAgencyList { SyncResultInfoSet = _syncResultInfoSet }.DataSync();
                    new SyncPatentList { SyncResultInfoSet = _syncResultInfoSet }.DataSync();
                })
                .ContinueWith(t =>
                {
                    Invoke(new Action(() =>
                    {
                        CalcNewSyncDate();
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

        private void CalcNewSyncDate()
        {
            ConfigHelper.FinishDate = DateTime.Now;
            ConfigHelper.BeginDate = ConfigHelper.NextDate;
            xdeNextBeginDate.DateTime = ConfigHelper.NextDate;
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
                    AutoCreateOption.SchemaAlreadyExists);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}