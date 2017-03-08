/*****************************************************/
/*  FileName: PTInputBox.cs                          */
/*  Function: 输入框封装                             */
/*     Coder: ryo.wu                                 */
/*      Date: 2006-5-19                              */
/*  Modified:                                        */
/*****************************************************/
using System;
using System.Collections.Generic;
using System.Text;
using BasicFacility.Exceptions;

namespace BasicFacility.MessageBox
{
    public class PTInputBox
    {
        ///#################################################################################
        /// <summary>
        /// 默认的输入框
        /// Coder:ryo 20060519
        /// </summary>
        /// <returns></returns>
        ///#################################################################################
        public static string GetText()
        {
            try
            {
                FrmInputBox frmib = new FrmInputBox();
                frmib.ShowDialog();
                if (frmib.tbText.EditValue == null)
                {
                    return null;
                }
                else
                {
                    return frmib.tbText.EditValue.ToString();
                }
            }
            catch (Exception ex)
            {
                ExManager.ReportException(ex, true);
                return "";
            }
        }
        ///#################################################################################
        /// <summary>
        /// 带提示文字以及最大输入长度的输入框
        /// Coder:ryo 20060519
        /// </summary>
        /// <returns></returns>
        ///#################################################################################
        public static string GetText(string Note, int MaxLength)
        {
            try
            {
                FrmInputBox frmib = new FrmInputBox();
                frmib.lbText.Text = Note;
                frmib.tbText.Properties.MaxLength = MaxLength;
                frmib.ShowDialog();
                if (frmib.tbText.EditValue == null)
                {
                    return null;
                }
                else
                {
                    return frmib.tbText.EditValue.ToString();
                }
            }
            catch (Exception ex)
            {
                ExManager.ReportException(ex, true);
                return "";
            }
        }
        ///#################################################################################
        /// <summary>
        /// 带标题和提示文字以及最大输入长度的输入框
        /// Coder:ryo 20060519
        /// </summary>
        /// <returns></returns>
        ///#################################################################################
        public static string GetText(string Title, string Note, int MaxLength)
        {
            try
            {
                FrmInputBox frmib = new FrmInputBox();
                frmib.Text = Title;
                frmib.lbText.Text = Note;
                frmib.tbText.Properties.MaxLength = MaxLength;
                frmib.ShowDialog();
                if (frmib.tbText.EditValue == null)
                {
                    return null;
                }
                else
                {
                    return frmib.tbText.EditValue.ToString();
                }
            }
            catch (Exception ex)
            {
                ExManager.ReportException(ex, true);
                return "";
            }
        }
    }
}
