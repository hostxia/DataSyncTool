/*****************************************************/
/*      FileName: PTMessageBox.cs                    */
/*       Function: PatentStar的信息提示框         */
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
        /// 显示普通对话框，只包含一个确定按钮，没有图片
        /// </summary>
        /// <param name="Text">要显示的文字</param>
        ///#################################################################################
        public static void Show(string msg)
        {
            frmMessage = new FrmMessageBox();
            frmMessage.ShowMessageBox(msg);
            frmMessage.ShowDialog();
        }
        ///#################################################################################
        /// <summary>
        ///  专利\提案提示
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
        ///  专利\提案提示
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
        ///  专利年费提示
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
        /// 显示有标题的普通对话框
        /// </summary>
        /// <param name="Text">要显示的文字</param>
        /// <param name="Caption">标题文字</param>
        ///#################################################################################
        public static void Show(string msg, string Caption)
        {
            frmMessage = new FrmMessageBox();
            frmMessage.ShowMessageBox(msg, Caption);
            frmMessage.ShowDialog();
        }
        ///#################################################################################
        /// <summary>
        /// 显示按钮选择对话框
        /// </summary>
        /// <param name="Text">要显示的文字</param>
        /// <param name="Caption">标题文字</param>
        /// <param name="buttons">按钮种类</param>
        /// <returns>对话框返回值</returns>
        ///#################################################################################
        public static DialogResult Show(string msg, string Caption, MessageBoxButtons buttons)
        {
            frmMessage = new FrmMessageBox();
            frmMessage.ShowMessageBox(msg, Caption, buttons);
            return frmMessage.ShowDialog();
        }
        ///#################################################################################
        /// <summary>
        /// 显示按钮选择对话框，可自定义图
        /// </summary>
        /// <param name="msg">要显示的文字</param>
        /// <param name="buttons">按钮种类</param>
        /// <param name="micon">图标种类</param>
        /// <returns>对话框返回值</returns>
        ///#################################################################################
        public static DialogResult Show(string msg, MessageBoxButtons buttons, MessageBoxIconEnum micon)
        {
            frmMessage = new FrmMessageBox();
            frmMessage.ShowMessageBox(msg, buttons, micon);
            return frmMessage.ShowDialog();
        }
        ///#################################################################################
        /// <summary>
        /// 显示按钮选择对话框，可自定义图
        /// </summary>
        /// <param name="msg">要显示的文字</param>
        /// <param name="buttons">按钮种类</param>
        /// <param name="micon">图标种类</param>
        /// <returns>对话框返回值</returns>
        ///#################################################################################
        public static DialogResult Show(IWin32Window owner, string msg, MessageBoxButtons buttons, MessageBoxIconEnum micon)
        {
            frmMessage = new FrmMessageBox();
            frmMessage.ShowMessageBox(msg, buttons, micon);
            return frmMessage.ShowDialog(owner);
        }
        ///#################################################################################
        /// <summary>
        /// 显示按钮选择对话框，可自定义图
        /// </summary>
        /// <param name="msg">要显示的文字</param>
        /// <param name="buttons">按钮种类</param>
        /// <param name="micon">图标种类</param>
        /// <returns>对话框返回值</returns>
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
        /// 显示按钮选择对话框，可自定义图
        /// </summary>
        /// <param name="msg">要显示的文字</param>
        /// <param name="buttons">按钮种类</param>
        /// <param name="micon">图标种类</param>
        /// <returns>对话框返回值</returns>
        ///#################################################################################
        public static DialogResult Show(string msg, MessageBoxButtons buttons, PTMessageBoxIcon micon)
        {
            frmMessage = new FrmMessageBox();
            frmMessage.ShowMessageBox(msg, buttons, micon);
            return frmMessage.ShowDialog();
        }
        ///#################################################################################
        /// <summary>
        /// 显示按钮选择对话框，可自定义图
        /// </summary>
        /// <param name="msg">要显示的文字</param>
        /// <param name="buttons">按钮种类</param>
        /// <param name="micon">图标种类</param>
        /// <returns>对话框返回值</returns>
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
