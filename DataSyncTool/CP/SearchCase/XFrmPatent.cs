using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataSyncTool.DBUtility;
using DevExpress.XtraEditors;

namespace DataSyncTool.CP.SearchCase
{
    public partial class XFrmPatent : DevExpress.XtraEditors.XtraForm
    {
        public XFrmPatent()
        {
            InitializeComponent();
        }

        private void xsbSearch_Click(object sender, EventArgs e)
        {
            dataNavigator1.DataSource = DbHelperOra.Query("select * from realpatentcase where ourno like '16PI%'").Tables[0];
            dataLayoutControl1.DataSource = dataNavigator1.DataSource;
            dataLayoutControl1.RetrieveFields();
        }

    }
}