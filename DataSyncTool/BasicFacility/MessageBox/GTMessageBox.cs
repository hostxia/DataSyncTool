/*******************************************************************************/
/*      FileName: GTMessageBox.cs											   */
/*      Function: ͨ�÷���ģ��												   */
/*        Author: ��־��                                                */
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
	///	Functions  : ��ʾ������Ϣ�Ի���
	///	Author	   : л����
	/// </summary>
	public class GTMessageBox
	{
        private static FrmMessageBox frmMessage;

		//======================================================================
		/// <summary>
		/// ���캯��
		/// Author: ��־����2004-04-13��
		/// </summary>
		//======================================================================
		static GTMessageBox()
		{
            frmMessage = new FrmMessageBox();
        }
		
		//######################################################################
		/// <summary>
		/// ��ʾ����Ϣ���Ի���ֻ�С�ȷ������ť�� ֻ�����ַ���
		/// Author: ��־����2004-04-13��
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
        /// ��ʾ����Ϣ���Ի���ֻ�С�ȷ������ť�� ֻ�����ַ���
        /// Author: ��־����2004-04-13��
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
		/// ��ʾ��������Ϣ���Ի���ֻ�С�ȷ������ť, ֻ�����ַ���
		/// Author: ��־����2004-04-13��
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
        /// ��ʾ��������Ϣ���Ի���ֻ�С�ȷ������ť, ֻ�����ַ���
        /// Author: ��־����2004-04-13��
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
		/// ��ʾ��������Ϣ���Ի����С�ȷ������ȡ������ť
		/// Author: ��־����2004-04-13��
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
        /// ��ʾ��������Ϣ���Ի����С�ȷ������ȡ������ť
        /// Author: ��־����2004-04-13��
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
		/// ��ʾ��������Ϣ���Ի����С��ǡ����񡱰�ť
		/// Author: ��־����2004-04-13��
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
		/// ��ʾ��������Ϣ���Ի���ֻ�С��ǡ����񡱡�ȡ������ť
		/// Author: ��־����2004-04-13��
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
		/// ��ʾ��������Ϣ���Ի����С��ǡ����񡱰�ť
		/// Author: ��־����2004-04-13��
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
		/// ��ʾ�����桱�Ի�����ʾ��ȷ������ȡ������ť����ʾ����ͼ��
		/// Author: ��־����2004-04-13��
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
		/// ��ʾ�����桱�Ի�����ʾ���ǡ����񡱡�ȡ������ť����ʾ����ͼ��
		/// Author: ��־����2004-04-13��
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
		/// // ��ʾ�����桱�Ի�����ʾ�����ԡ���ȡ������ť����ʾ����ͼ�� 
		/// Author: ��־����2004-04-13��
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
		/// ��ʾ�����桱�Ի�����ʾ��Yes����No����ť����ʾ����ͼ�� 
		/// Author: ��־����2004-04-13��
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
