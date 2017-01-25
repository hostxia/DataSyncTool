using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataSyncTool.CP.BLL;

namespace DataSyncTool
{
    public partial class XFrmMain : Form
    {
        public XFrmMain()
        {
            InitializeComponent();
        }

        private void XFrmMain_Load(object sender, EventArgs e)
        {
            CASEOTHERTEXT generalInstruction = new CASEOTHERTEXT();
            gridControl1.DataSource = generalInstruction.DataTableToList(generalInstruction.GetAllList().Tables[0]);
        }
    }
}
