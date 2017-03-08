/*******************************************************************************/
/*      FileName: GTMessageBox.cs											   */
/*      Function: 通用方法模块												   */
/*        Author: 张志国                                                */
/*          Date: 2004-04-13                                                   */
/*      Modified: ryo                                                          */
/*      Modified Date: 20060330                                                */
/*******************************************************************************/
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using BasicFacility.WindowsAPI;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using System;
using DevExpress.LookAndFeel.Helpers;
using DevExpress.Skins;

namespace BasicFacility.MessageBox
{

    /// <summary>
    ///	Class Name : GTMessageBox
    ///	Functions  : 显示各类信息对话框
    ///	Author	   : 谢国利
    /// </summary>
    public class BizMessageBox
    {
        private static string _defaultSkinName;
        public static string DefaultSkinName
        {
            get
            {
                if (string.IsNullOrEmpty(_defaultSkinName))
                {
                    _defaultSkinName = SetSkinStyle();
                }
                return _defaultSkinName;
            }
        }

        /// #####################################################################
        /// <summary>
        /// 设置软件和左侧导航栏皮肤
        /// coder:likai(2010-06-08)
        /// </summary>
        public static string SetSkinStyle()
        {
            StringBuilder sSkin = new StringBuilder(100);
            string sFilePath = Application.StartupPath + "\\Config\\DefaultLoadConfig.ini";
            const string sSetion = "Skin";
            const string sKey = "Skin";
            const string missValue = "Whiteprint";

            APIFunctions.GetPrivateProfileString(sSetion, sKey, missValue, sSkin, 100,
                                                                          sFilePath);
            if (sSkin.ToString() == string.Empty) sSkin.Append(missValue);
            switch (sSkin.ToString())
            {
                case "DevExpress Style":
                    return "DevExpress Style";
                case "DevExpress Dark Style":
                    return "DevExpress Dark Style";
                case "Seven Classic":
                    return "Seven Classic";
                case "Office 2010 Black":
                    return "Office 2010 Black";
                case "Office 2010 Blue":
                    return "Office 2010 Blue";
                case "Office 2010 Silver":
                    return "Office 2010 Silver";
                case "Office 2013":
                    return "Office 2013";
                case "VS2010":
                    return "VS2010";
                case "Seven":
                    return "Seven";
                case "Darkroom":
                    return "Darkroom";
                case "Metropolis Dark":
                    return "Metropolis Dark";
                case "Foggy":
                    return "Foggy";
                case "Sharp":
                    return "Sharp";
                case "Whiteprint":
                    return "Whiteprint";

            }
            return string.Empty;
        }

        //private static FrmMessageBox _frmMessage;

        ///######################################################################
        /// <summary>
        /// 构造函数
        /// Author: 张志国（2004-04-13）
        /// </summary>
        ///######################################################################
        static BizMessageBox()
        {
            //_frmMessage = new FrmMessageBox();
        }

        #region ShowInfoOK
        ///######################################################################
        /// <summary>
        /// 显示“信息”对话框，只有“确定”按钮， 只输入字符串
        /// Author: 张志国（2004-04-13）
        /// </summary>
        /// <param name="msg"></param>
        ///######################################################################
        static public void ShowInfoOKForm(string msg)
        {
            //UserLookAndFeel.Default.SetSkinStyle(DefaultSkinName);
            XtraMessageBox.Show(msg, Properties.Resource.BASICFACILITY_TIPS, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //_frmMessage.ShowMessageBox(msg);
            //_frmMessage.ShowDialog();
        }

        ///######################################################################
        /// <summary>
        /// 显示“信息”对话框，只有“确定”按钮， 只输入字符串
        /// Author: 张志国（2004-04-13）
        /// </summary>
        /// <param name="iOwner"></param>
        /// <param name="msg"></param>
        ///######################################################################
        static public void ShowInfoOKForm(IWin32Window iOwner, string msg)
        {
            //UserLookAndFeel.Default.SetSkinStyle(DefaultSkinName);
            XtraMessageBox.Show(iOwner, msg, Properties.Resource.BASICFACILITY_TIPS, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //_frmMessage.ShowMessageBox(msg);
            //_frmMessage.ShowDialog();
        }

        ///######################################################################
        /// <summary>
        /// 显示“信息”对话框，只有“确定”按钮， 只输入字符串
        /// Author: 张志国（2004-04-13）
        /// </summary>
        /// <param name="msg"></param>
        ///######################################################################
        [Obsolete("True")]
        static public void ShowInfoOKFormLeft(string msg)
        {
            //UserLookAndFeel.Default.SetSkinStyle(DefaultSkinName);
            XtraMessageBox.Show(msg, Properties.Resource.BASICFACILITY_TIPS, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //_frmMessage.ShowMessageBox(msg, ContentAlignment.MiddleLeft);
            //_frmMessage.ShowDialog();
        }
        #endregion


        #region ShowErrorOK
        ///######################################################################
        /// <summary>
        /// 显示“错误信息”对话框，只有“确定”按钮, 只输入字符串
        /// Author: 张志国（2004-04-13）
        /// </summary>
        /// <param name="msg"></param>
        ///######################################################################
        static public void ShowErrorOKForm(string msg)
        {
            //UserLookAndFeel.Default.SetSkinStyle(DefaultSkinName);
            XtraMessageBox.Show(msg, Properties.Resource.BASICFACILITY_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //_frmMessage.ShowMessageBox(msg, MessageBoxButtons.OK, MessageBoxIconEnum.Error);
            //_frmMessage.ShowDialog();
        }
        ///######################################################################
        /// <summary>
        /// 显示“错误信息”对话框，只有“确定”按钮, 只输入字符串
        /// Author: 张志国（2004-04-13）
        /// </summary>
        /// <param name="msg"></param>
        ///######################################################################
        static public void ShowErrorOKForm(IWin32Window iOwner, string msg)
        {
            //UserLookAndFeel.Default.SetSkinStyle(DefaultSkinName);
            XtraMessageBox.Show(iOwner, msg, Properties.Resource.BASICFACILITY_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //_frmMessage.ShowMessageBox(msg, MessageBoxButtons.OK, MessageBoxIconEnum.Error);
            //_frmMessage.ShowDialog();
        }
        #endregion


        #region  ShowQuestionOKCancel
        ///######################################################################
        /// <summary>
        /// 显示“问题信息”对话框，有“确定”“取消”按钮
        /// Author: 张志国（2004-04-13）
        /// </summary>
        /// <param name="iOwner"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        ///######################################################################
        static public DialogResult ShowQuestionOKCancelForm(IWin32Window iOwner, string msg)
        {
            //UserLookAndFeel.Default.SetSkinStyle(DefaultSkinName);
            return XtraMessageBox.Show(iOwner, msg, Properties.Resource.BASICFACILITY_QUESTION, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //_frmMessage.ShowMessageBox(msg, MessageBoxButtons.OKCancel, MessageBoxIconEnum.Question);
            //return _frmMessage.ShowDialog();
        }
        ///######################################################################
        /// <summary>
        /// 显示“问题信息”对话框，有“确定”“取消”按钮
        /// Author: 张志国（2004-04-13）
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        ///######################################################################
        static public DialogResult ShowQuestionOKCancelForm(string msg)
        {
            //UserLookAndFeel.Default.SetSkinStyle(DefaultSkinName);
            return XtraMessageBox.Show(msg, Properties.Resource.BASICFACILITY_QUESTION, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //_frmMessage.ShowMessageBox(msg, MessageBoxButtons.OKCancel, MessageBoxIconEnum.Question);
            //return _frmMessage.ShowDialog();
        }
        #endregion

        #region  ShowQuestionYesNo
        ///######################################################################
        /// <summary>
        /// 显示“问题信息”对话框，有“是”“否”按钮
        /// Author: 张志国（2004-04-13）
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        ///######################################################################
        static public DialogResult ShowQuestionYesNoForm(string msg)
        {
            //UserLookAndFeel.Default.SetSkinStyle(DefaultSkinName);
            return XtraMessageBox.Show(msg, Properties.Resource.BASICFACILITY_QUESTION, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //_frmMessage.ShowMessageBox(msg, "", MessageBoxButtons.YesNo);
            //return _frmMessage.ShowDialog();
        }

        ///######################################################################
        /// <summary>
        /// 显示“问题信息”对话框，有“是”“否”按钮
        /// Author: 张志国（2004-04-13）
        /// </summary>
        /// <param name="iOwner"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        ///######################################################################
        static public DialogResult ShowQuestionYesNoForm(IWin32Window iOwner, string msg)
        {
            //UserLookAndFeel.Default.SetSkinStyle(DefaultSkinName);
            return XtraMessageBox.Show(iOwner, msg, Properties.Resource.BASICFACILITY_QUESTION, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //_frmMessage.ShowMessageBox(msg, MessageBoxButtons.YesNo, MessageBoxIconEnum.Question);
            //return _frmMessage.ShowDialog();
        }

        ///######################################################################
        /// <summary>
        /// 显示“问题信息”对话框，有“是”“否”按钮
        /// Author: 张志国（2004-04-13）
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        ///######################################################################
        [Obsolete("True")]
        static public DialogResult ShowQuestionYesNoFormLeft(string msg)
        {
            //UserLookAndFeel.Default.SetSkinStyle(DefaultSkinName);
            return XtraMessageBox.Show(msg, Properties.Resource.BASICFACILITY_QUESTION, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //_frmMessage.ShowMessageBox(msg, MessageBoxButtons.YesNo, MessageBoxIconEnum.Question, ContentAlignment.MiddleLeft);
            //return _frmMessage.ShowDialog();
        }

        ///######################################################################
        /// <summary>
        /// 显示“问题信息”对话框，有“是”“否”按钮
        /// Author: 张志国（2004-04-13）
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        ///######################################################################
        [Obsolete("True")]
        static public DialogResult ShowQuestionYesNoForm(string msg, ContentAlignment textAlign)
        {
            //UserLookAndFeel.Default.SetSkinStyle(DefaultSkinName);
            return XtraMessageBox.Show(msg, Properties.Resource.BASICFACILITY_QUESTION, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //_frmMessage.ShowMessageBox(msg, "", MessageBoxButtons.YesNo, textAlign);
            //return _frmMessage.ShowDialog();
        }
        #endregion

        #region  ShowQuestionYesNoCancel
        ///######################################################################
        /// <summary>
        /// 显示“问题信息”对话框，只有“是”“否”“取消”按钮
        /// Author: 张志国（2004-04-13）
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        ///######################################################################
        static public DialogResult ShowQuestionYesNoCancelForm(string msg)
        {
            //UserLookAndFeel.Default.SetSkinStyle(DefaultSkinName);
            return XtraMessageBox.Show(msg, Properties.Resource.BASICFACILITY_QUESTION, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            //_frmMessage.ShowMessageBox(msg, "", MessageBoxButtons.YesNoCancel);
            //return _frmMessage.ShowDialog();
        }

        ///######################################################################
        /// <summary>
        /// 显示“问题信息”对话框，只有“是”“否”“取消”按钮
        /// Author: 张志国（2004-04-13）
        /// </summary>
        /// <param name="iOwner"></param>
        /// <param name="msg"></param>
        /// <returns></returns>

        ///######################################################################
        static public DialogResult ShowQuestionYesNoCancelForm(IWin32Window iOwner, string msg)
        {
            //UserLookAndFeel.Default.SetSkinStyle(DefaultSkinName);
            return XtraMessageBox.Show(iOwner, msg, Properties.Resource.BASICFACILITY_QUESTION, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            //_frmMessage.ShowMessageBox(msg, "", MessageBoxButtons.YesNoCancel);
            //return _frmMessage.ShowDialog();
        }

        ///######################################################################
        /// <summary>
        /// 显示“问题信息”对话框，只有“是”“否”“取消”按钮
        /// Author: 张志国（2004-04-13）
        /// </summary>
        /// <param name="iOwner"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        ///######################################################################
        [Obsolete("True")]
        static public DialogResult ShowQuestionYesNoCancelForm(IWin32Window iOwner, string msg, ContentAlignment textAlign)
        {
            //UserLookAndFeel.Default.SetSkinStyle(DefaultSkinName);
            return XtraMessageBox.Show(iOwner, msg, Properties.Resource.BASICFACILITY_QUESTION, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            //_frmMessage.ShowMessageBox(msg, "", MessageBoxButtons.YesNoCancel, textAlign);
            //return _frmMessage.ShowDialog();
        }
        #endregion

        #region  ShowWarningOKCancel

        ///######################################################################
        /// <summary>
        /// 显示“警告”对话框，显示“确定”“取消”按钮，显示警告图标
        /// Author: 张志国（2004-04-13）
        /// </summary>
        /// <param name="iOwner"></param>
        /// <param name="msg"></param>
        ///<param name="messageBoxDefaultButton"></param>
        ///<returns></returns>
        ///######################################################################
        static public DialogResult ShowWarningOKCancelForm(IWin32Window iOwner, string msg, MessageBoxDefaultButton messageBoxDefaultButton = MessageBoxDefaultButton.Button1)
        {
            //_frmMessage.ShowMessageBox(msg, MessageBoxButtons.OKCancel, MessageBoxIconEnum.Warning);
            //return _frmMessage.ShowDialog();
            //UserLookAndFeel.Default.SetSkinStyle(DefaultSkinName);
            return XtraMessageBox.Show(iOwner, msg, Properties.Resource.BASICFACILITY_WARNING, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, messageBoxDefaultButton);
        }
        ///######################################################################
        /// <summary>
        /// 显示“警告”对话框，显示“确定”“取消”按钮，显示警告图标
        /// Author: 张志国（2004-04-13）
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        ///######################################################################
        static public DialogResult ShowWarningOKCancelForm(string msg)
        {
            //_frmMessage.ShowMessageBox(msg, MessageBoxButtons.OKCancel, MessageBoxIconEnum.Warning);
            //return _frmMessage.ShowDialog();
            //UserLookAndFeel.Default.SetSkinStyle(DefaultSkinName);
            return XtraMessageBox.Show(msg, Properties.Resource.BASICFACILITY_WARNING, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
        #endregion

        #region ShowWarningYesNoCancel
        ///######################################################################
        /// <summary>
        /// 显示“警告”对话框，显示“是”“否”“取消”按钮，显示警告图标
        /// Author: 张志国（2004-04-13）
        /// </summary>
        /// <param name="iOwner"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        ///######################################################################
        static public DialogResult ShowWarningYesNoCancelForm(IWin32Window iOwner, string msg)
        {
            //UserLookAndFeel.Default.SetSkinStyle(DefaultSkinName);
            return XtraMessageBox.Show(msg, Properties.Resource.BASICFACILITY_WARNING, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            //_frmMessage.ShowMessageBox(msg, MessageBoxButtons.YesNoCancel, MessageBoxIconEnum.Warning);
            //return _frmMessage.ShowDialog();
        }
        #endregion

        #region ShowWarningRetryCancel
        ///######################################################################
        /// <summary>
        /// // 显示“警告”对话框，显示“重试”“取消”按钮，显示警告图标 
        /// Author: 张志国（2004-04-13）
        /// </summary>
        /// <param name="iOwner"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        ///######################################################################
        [Obsolete("True")]
        static public DialogResult ShowWarningRetryCancelForm(IWin32Window iOwner, string msg)
        {
            //UserLookAndFeel.Default.SetSkinStyle(DefaultSkinName);
            return XtraMessageBox.Show(iOwner, msg, Properties.Resource.BASICFACILITY_WARNING, MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            //_frmMessage.ShowMessageBox(msg, MessageBoxButtons.RetryCancel, MessageBoxIconEnum.Warning);
            //return _frmMessage.ShowDialog();
        }
        #endregion

        #region ShowWarningYesNo
        ///######################################################################
        /// <summary>
        /// 显示“警告”对话框，显示“Yes”“No”按钮，显示警告图标 
        /// Author: 张志国（2004-04-13）
        /// </summary>
        /// <param name="iOwner"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        ///######################################################################
        static public DialogResult ShowWarningYesNoForm(string msg)
        {
            //UserLookAndFeel.Default.SetSkinStyle(DefaultSkinName);
            return XtraMessageBox.Show(msg, Properties.Resource.BASICFACILITY_WARNING, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //_frmMessage.ShowMessageBox(msg, MessageBoxButtons.YesNo, MessageBoxIconEnum.Warning);
            //return _frmMessage.ShowDialog();
        }

        ///######################################################################
        /// <summary>
        /// 显示“警告”对话框，显示“Yes”“No”按钮，显示警告图标 
        /// Author: 张志国（2004-04-13）
        /// </summary>
        /// <param name="iOwner"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        ///######################################################################
        static public DialogResult ShowWarningYesNoForm(IWin32Window iOwner, string msg)
        {
            //UserLookAndFeel.Default.SetSkinStyle(DefaultSkinName);
            return XtraMessageBox.Show(iOwner, msg, Properties.Resource.BASICFACILITY_WARNING, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //_frmMessage.ShowMessageBox(msg, MessageBoxButtons.YesNo, MessageBoxIconEnum.Warning);
            //return _frmMessage.ShowDialog();
        }
        #endregion
    }
}
