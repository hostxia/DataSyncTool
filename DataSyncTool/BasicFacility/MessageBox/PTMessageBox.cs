/*****************************************************/
/*      FileName: PTMessageBox.cs                    */
/*       Function: PatentStar����Ϣ��ʾ��         */
/*          Author: ryo                              */
/*             Date: 2006-03-28                      */
/*        Modified:                                  */
/*****************************************************/
using System;
using System.Windows.Forms;

namespace BasicFacility.MessageBox
{
    public class PTMessageBox
    {
        private static FrmMessageBox frmMessage;
        static PTMessageBox()
        {
            frmMessage = new FrmMessageBox();
        }
        ///#################################################################################
        /// <summary>
        /// ��ʾ��ͨ�Ի���ֻ����һ��ȷ����ť��û��ͼƬ
        /// </summary>
        /// <param name="Text">Ҫ��ʾ������</param>
        ///#################################################################################
        public static void Show(string msg)
        {
            frmMessage = new FrmMessageBox();
            frmMessage.ShowMessageBox(msg);
            frmMessage.ShowDialog();
        }
        ///#################################################################################
        /// <summary>
        ///  ר��\�᰸��ʾ
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Caption"></param>
        ///#################################################################################
        public static DialogResult Show(int temp, string Text)
        {
            frmMessage = new FrmMessageBox();
            frmMessage.ShowMessageBox(temp, Text);
            return frmMessage.ShowDialog();
        }
        ///#################################################################################
        /// <summary>
        ///  ר��\�᰸��ʾ
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Caption"></param>
        ///#################################################################################
        public static DialogResult Show(int temp, int tmp, int itemp, string Text)
        {
            frmMessage = new FrmMessageBox();
            frmMessage.ShowMessageBox(temp, tmp, itemp, Text);
            return frmMessage.ShowDialog();
        }

        ///#################################################################################
        /// <summary>
        ///  ר�������ʾ
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Caption"></param>
        ///#################################################################################
        public static DialogResult Show(int temp, int tmp, string Text)
        {
            frmMessage = new FrmMessageBox();
            frmMessage.ShowMessageBox(temp, tmp, Text);
            return frmMessage.ShowDialog();
        }

        ///#################################################################################
        /// <summary>
        /// ��ʾ�б������ͨ�Ի���
        /// </summary>
        /// <param name="Text">Ҫ��ʾ������</param>
        /// <param name="Caption">��������</param>
        ///#################################################################################
        public static void Show(string msg, string Caption)
        {
            frmMessage = new FrmMessageBox();
            frmMessage.ShowMessageBox(msg, Caption);
            frmMessage.ShowDialog();
        }
        ///#################################################################################
        /// <summary>
        /// ��ʾ��ťѡ��Ի���
        /// </summary>
        /// <param name="Text">Ҫ��ʾ������</param>
        /// <param name="Caption">��������</param>
        /// <param name="buttons">��ť����</param>
        /// <returns>�Ի��򷵻�ֵ</returns>
        ///#################################################################################
        public static DialogResult Show(string msg, string Caption, MessageBoxButtons buttons)
        {
            frmMessage = new FrmMessageBox();
            frmMessage.ShowMessageBox(msg, Caption, buttons);
            return frmMessage.ShowDialog();
        }
        ///#################################################################################
        /// <summary>
        /// ��ʾ��ťѡ��Ի��򣬿��Զ���ͼ
        /// </summary>
        /// <param name="msg">Ҫ��ʾ������</param>
        /// <param name="buttons">��ť����</param>
        /// <param name="micon">ͼ������</param>
        /// <returns>�Ի��򷵻�ֵ</returns>
        ///#################################################################################
        public static DialogResult Show(string msg, MessageBoxButtons buttons, MessageBoxIconEnum micon)
        {
            frmMessage = new FrmMessageBox();
            frmMessage.ShowMessageBox(msg, buttons, micon);
            return frmMessage.ShowDialog();
        }
        ///#################################################################################
        /// <summary>
        /// ��ʾ��ťѡ��Ի��򣬿��Զ���ͼ
        /// </summary>
        /// <param name="msg">Ҫ��ʾ������</param>
        /// <param name="buttons">��ť����</param>
        /// <param name="micon">ͼ������</param>
        /// <returns>�Ի��򷵻�ֵ</returns>
        ///#################################################################################
        public static DialogResult Show(IWin32Window owner, string msg, MessageBoxButtons buttons, MessageBoxIconEnum micon)
        {
            frmMessage = new FrmMessageBox();
            frmMessage.ShowMessageBox(msg, buttons, micon);
            return frmMessage.ShowDialog(owner);
        }
        ///#################################################################################
        /// <summary>
        /// ��ʾ��ťѡ��Ի��򣬿��Զ���ͼ
        /// </summary>
        /// <param name="msg">Ҫ��ʾ������</param>
        /// <param name="buttons">��ť����</param>
        /// <param name="micon">ͼ������</param>
        /// <returns>�Ի��򷵻�ֵ</returns>
        ///#################################################################################
        public static DialogResult Show(string msg, MessageBoxButtons buttons, MessageBoxIconEnum micon, bool bnewDialog)
        {
            if (bnewDialog)
            {
                frmMessage = new FrmMessageBox();
            }
            frmMessage.ShowMessageBox(msg, buttons, micon);
            return frmMessage.ShowDialog();
        }
        ///#################################################################################
        /// <summary>
        /// ��ʾ��ťѡ��Ի��򣬿��Զ���ͼ
        /// </summary>
        /// <param name="msg">Ҫ��ʾ������</param>
        /// <param name="buttons">��ť����</param>
        /// <param name="micon">ͼ������</param>
        /// <returns>�Ի��򷵻�ֵ</returns>
        ///#################################################################################
        public static DialogResult Show(string msg, MessageBoxButtons buttons, PTMessageBoxIcon micon)
        {
            frmMessage = new FrmMessageBox();
            frmMessage.ShowMessageBox(msg, buttons, micon);
            return frmMessage.ShowDialog();
        }
        ///#################################################################################
        /// <summary>
        /// ��ʾ��ťѡ��Ի��򣬿��Զ���ͼ
        /// </summary>
        /// <param name="msg">Ҫ��ʾ������</param>
        /// <param name="buttons">��ť����</param>
        /// <param name="micon">ͼ������</param>
        /// <returns>�Ի��򷵻�ֵ</returns>
        ///#################################################################################
        public static DialogResult Show(string msg, MessageBoxButtons buttons, PTMessageBoxIcon micon, bool bnewDialog)
        {
            if (bnewDialog)
            {
                frmMessage = new FrmMessageBox();
            }
            frmMessage.ShowMessageBox(msg, buttons, micon);
            return frmMessage.ShowDialog();
        }


    }
}
