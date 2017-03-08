

/*****************************************************/
/*  FileName: ExManager.cs                           */
/*  Function: 异常的主操作类                    */
/*     Coder: ryo.wu                                 */
/*      Date: 2006-3-28                              */
/*  Modified:                                        */
/*****************************************************/
using System;
using System.Windows.Forms;
using System.IO;
using BasicFacility.MessageBox;

namespace BasicFacility.Exceptions
{
    public enum MessageBoxMode
    {
        /// <summary>
        /// 专利之星的对话框模式
        /// </summary>
        PT,
        /// <summary>
        /// 全能助理的对话框模式
        /// </summary>
        PA,
        /// <summary>
        /// 外观设计搜索引擎的对话框模式
        /// </summary>
        DS
    }

    public class ExManager
    {
        public static MessageBoxMode ReportMode;

        /// <summary>
        /// 模式代码
        /// 0 - 正常模式
        /// 1 - 调试模式（弹出显示所有错误信息）
        /// 2 - 客户反馈模式（记录更为详尽的客户环境信息）
        /// </summary>
        static readonly int iRunMode;
        /// <summary>
        /// 构造函数，根据配置文件决定是否启用调试模式
        /// </summary>
        static ExManager()
        {
            try
            {
                //从配置文件中读取运行模式
                //var sr = new StreamReader(string.Format("{0}\\Config\\runmode.ini", Application.StartupPath));
                iRunMode = 0;//默认为正常模式
                //iRunMode = Convert.ToInt32(sr.ReadLine());
            }
            catch (Exception)
            { }
        }
        ///###################################################################
        /// <summary>
        /// 记录异常信息，不显示任何提示
        /// ryo 20060327
        /// </summary>
        /// <param name="ex"></param>
        ///###################################################################
        public static void ReportException(Exception ex)
        {
            ExceptionLog.LogException(ex);
        }
        ///###################################################################
        /// <summary>
        /// 记录异常信息，不显示任何提示，确认是否抛出异常
        /// ryo 20060403
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="throwIt"></param>
        ///###################################################################
        public static void ReportException(Exception ex,bool throwIt)
        {
            ExceptionLog.LogException(ex);

            if (throwIt)
            {
                throw ex;
            }
        }
        ///#################################################################################
        /// <summary>
        /// 记录异常信息，显示msg提示
        /// ryo 20060327
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="msg"></param>
        ///#################################################################################
        public static void ReportException(Exception ex, string msg)
        {
            ExceptionLog.LogException(ex);
            switch (ReportMode)
            {
                case MessageBoxMode.PT:
                    PTMessageBox.Show(msg);
                    break;
                case MessageBoxMode.PA:
                    BizMessageBox.ShowErrorOKForm(msg);
                    break;
            }
            
        }
    }
}
