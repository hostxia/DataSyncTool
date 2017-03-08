/*****************************************************/
/*  FileName: FrmInputBox.cs                         */
/*  Function: ��ȡ������Ϣ����                       */
/*     Coder: ryo.wu                                 */
/*      Date: 2006-5-19                              */
/*  Modified:                                        */
/*****************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BasicFacility.MessageBox
{
    partial class FrmInputBox : Form
    {
        ///#################################################################################
        /// <summary>
        /// ���캯��
        /// Coder:ryo 20060707
        /// </summary>
        ///#################################################################################
        public FrmInputBox()
        {
            InitializeComponent();
        }
        ///=================================================================================
        /// <summary>
        /// ȷ�ϰ�ť����
        /// Coder:ryo 20060707
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///=================================================================================
        private void btOK_Click(object sender, EventArgs e)
        {
            if (tbText.Text.Trim() == "")
            {
                PTMessageBox.Show("�������ֲ���Ϊ��", MessageBoxButtons.OK, MessageBoxIconEnum.Warning);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        ///=================================================================================
        /// <summary>
        /// ȡ����ť����
        /// Coder:ryo 20060707
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///=================================================================================
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.tbText.EditValue = null;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}