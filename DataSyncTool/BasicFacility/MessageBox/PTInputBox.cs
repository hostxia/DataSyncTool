/*****************************************************/
/*  FileName: PTInputBox.cs                          */
/*  Function: ������װ                             */
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
        /// Ĭ�ϵ������
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
        /// ����ʾ�����Լ�������볤�ȵ������
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
        /// ���������ʾ�����Լ�������볤�ȵ������
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
