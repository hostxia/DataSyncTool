/*******************************************************************************/
/*      FileName: GTMessageBox.cs											   */
/*      Function: 通用方法模块												   */
/*        Author: 张志国                                                */
/*          Date: 2004-04-13                                                   */
/*      Modified: ryo                                                          */
/*      Modified Date: 20060330                                                */
/*******************************************************************************/                                                        
using System;
using System.Windows.Forms;

namespace BasicFacility.MessageBox
{
	/// <summary>
	///	Class Name : GTMessageBox
	///	Functions  : 显示各类信息对话框
	///	Author	   : 谢国利
	/// </summary>
	public class GTMessageBox
	{
        private static FrmMessageBox frmMessage;

		//======================================================================
		/// <summary>
		/// 构造函数
		/// Author: 张志国（2004-04-13）
		/// </summary>
		//======================================================================
		static GTMessageBox()
		{
            frmMessage = new FrmMessageBox();
        }
		
		//######################################################################
		/// <summary>
		/// 显示“信息”对话框，只有“确定”按钮， 只输入字符串
		/// Author: 张志国（2004-04-13）
		/// </summary>
        /// <param name="msg"></param>
		//######################################################################
        static public void ShowInfoOKForm(string msg)
		{
            frmMessage.ShowMessageBox(msg);
            frmMessage.ShowDialog();
		}

        //######################################################################
        /// <summary>
        /// 显示“信息”对话框，只有“确定”按钮， 只输入字符串
        /// Author: 张志国（2004-04-13）
        /// </summary>
        /// <param name="msg"></param>
        //######################################################################
        static public void ShowInfoOKForm(System.Windows.Forms.IWin32Window iOwner, string msg)
        {
            frmMessage.ShowMessageBox(msg);
            frmMessage.ShowDialog();
        }

		//######################################################################
		/// <summary>
		/// 显示“错误信息”对话框，只有“确定”按钮, 只输入字符串
		/// Author: 张志国（2004-04-13）
		/// </summary>
		/// <param name="msg"></param>
		//######################################################################
        static public void ShowErrorOKForm(string msg)
		{
            frmMessage.ShowMessageBox(msg, MessageBoxButtons.OK, MessageBoxIconEnum.Error);
            frmMessage.ShowDialog();
        }
        //######################################################################
        /// <summary>
        /// 显示“错误信息”对话框，只有“确定”按钮, 只输入字符串
        /// Author: 张志国（2004-04-13）
        /// </summary>
        /// <param name="msg"></param>
        //######################################################################
        static public void ShowErrorOKForm(System.Windows.Forms.IWin32Window iOwner, string msg)
        {
            frmMessage.ShowMessageBox(msg, MessageBoxButtons.OK, MessageBoxIconEnum.Error);
            frmMessage.ShowDialog();
        }
		//######################################################################
		/// <summary>
		/// 显示“问题信息”对话框，有“确定”“取消”按钮
		/// Author: 张志国（2004-04-13）
		/// </summary>
		/// <param name="iOwner"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		//######################################################################
        static public DialogResult ShowQuestionOKCancelForm(System.Windows.Forms.IWin32Window iOwner, string msg)
		{
            frmMessage.ShowMessageBox(msg, MessageBoxButtons.OKCancel, MessageBoxIconEnum.Question);
            return frmMessage.ShowDialog();
		}

        //######################################################################
        /// <summary>
        /// 显示“问题信息”对话框，有“确定”“取消”按钮
        /// Author: 张志国（2004-04-13）
        /// </summary>
        /// <param name="iOwner"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        //######################################################################
        static public DialogResult ShowQuestionOKCancelForm(string msg)
        {
            frmMessage.ShowMessageBox(msg, MessageBoxButtons.OKCancel, MessageBoxIconEnum.Question);
            return frmMessage.ShowDialog();
        }

		//######################################################################
		/// <summary>
		/// 显示“问题信息”对话框，有“是”“否”按钮
		/// Author: 张志国（2004-04-13）
		/// </summary>
		/// <param name="iOwner"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		//######################################################################
        static public DialogResult ShowQuestionYesNoForm(System.Windows.Forms.IWin32Window iOwner, string msg)
		{
            frmMessage.ShowMessageBox(msg, MessageBoxButtons.YesNo, MessageBoxIconEnum.Question);
            return frmMessage.ShowDialog();
		}

		//######################################################################
		/// <summary>
		/// 显示“问题信息”对话框，只有“是”“否”“取消”按钮
		/// Author: 张志国（2004-04-13）
		/// </summary>
		/// <param name="iOwner"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		
		//######################################################################
		static public DialogResult ShowQuestionYesNoCancelForm( System.Windows.Forms.IWin32Window iOwner, string msg )
		{
            frmMessage.ShowMessageBox(msg,"", MessageBoxButtons.YesNoCancel);
            return frmMessage.ShowDialog();
        }

		//######################################################################
		/// <summary>
		/// 显示“问题信息”对话框，有“是”“否”按钮
		/// Author: 张志国（2004-04-13）
		/// </summary>
		/// <param name="msg"></param>
		/// <returns></returns>
		//######################################################################
		static public DialogResult ShowQuestionYesNoForm(string msg)
		{
            frmMessage.ShowMessageBox(msg, "", MessageBoxButtons.YesNo);
            return frmMessage.ShowDialog();
		}

		//######################################################################
		/// <summary>
		/// 显示“警告”对话框，显示“确定”“取消”按钮，显示警告图标
		/// Author: 张志国（2004-04-13）
		/// </summary>
		/// <param name="iOwner"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		//######################################################################
		static public DialogResult ShowWarningOKCancelForm( System.Windows.Forms.IWin32Window iOwner, string msg )
		{
            frmMessage.ShowMessageBox(msg, MessageBoxButtons.OKCancel,MessageBoxIconEnum.Warning);
            return frmMessage.ShowDialog();
		}
		
		
		//######################################################################
		/// <summary>
		/// 显示“警告”对话框，显示“是”“否”“取消”按钮，显示警告图标
		/// Author: 张志国（2004-04-13）
		/// </summary>
		/// <param name="iOwner"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		//######################################################################
		static public DialogResult ShowWarningYesNoCancelForm( System.Windows.Forms.IWin32Window iOwner, string msg )
		{
            frmMessage.ShowMessageBox(msg, MessageBoxButtons.YesNoCancel, MessageBoxIconEnum.Warning);
            return frmMessage.ShowDialog();
		}
		
		//######################################################################
		/// <summary>
		/// // 显示“警告”对话框，显示“重试”“取消”按钮，显示警告图标 
		/// Author: 张志国（2004-04-13）
		/// </summary>
		/// <param name="iOwner"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		//######################################################################
		static public DialogResult ShowWarningRetryCancelForm( System.Windows.Forms.IWin32Window iOwner, string msg )
		{
            frmMessage.ShowMessageBox(msg, MessageBoxButtons.RetryCancel, MessageBoxIconEnum.Warning);
            return frmMessage.ShowDialog();
		}
		//######################################################################
		/// <summary>
		/// 显示“警告”对话框，显示“Yes”“No”按钮，显示警告图标 
		/// Author: 张志国（2004-04-13）
		/// </summary>
		/// <param name="iOwner"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		//######################################################################
		static public DialogResult ShowWarningYesNoForm( System.Windows.Forms.IWin32Window iOwner, string msg )
		{
            frmMessage.ShowMessageBox(msg, MessageBoxButtons.YesNo, MessageBoxIconEnum.Warning);
            return frmMessage.ShowDialog();
		}
	}
}
