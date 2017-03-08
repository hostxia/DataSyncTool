/*****************************************************/
/*  FileName: ExLog.cs                               */
/*  Function: 异常的Log操作                     */
/*     Coder: ryo.wu                                 */
/*      Date: 2006-3-28                              */
/*  Modified:                                        */
/*****************************************************/
using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Drawing;

namespace BasicFacility.Exceptions
{
    public class ExceptionLog
    {
        private const string EXCEPTION_FILENAME = "\\Log\\Errors.log";

        static ExceptionLog()
        {
            if (!Directory.Exists(string.Format("{0}\\Log", Application.StartupPath)))
            {
                Directory.CreateDirectory(string.Format("{0}\\Log", Application.StartupPath));
            }
        }
        ///#################################################################################
        /// <summary>
        /// 记录ex提供的异常信息
        /// </summary>
        /// <param name="ex"></param>
        ///#################################################################################
        public static void LogException(Exception ex)
        {
            try
            {
                var sw = new StreamWriter(Application.StartupPath + EXCEPTION_FILENAME, true, Encoding.Default);
                sw.WriteLine("--------------------------------------------------------------------");
                sw.WriteLine("Time:{0}  {1}", DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString());
                sw.WriteLine("Message:{0}", ex.Message);
                sw.WriteLine("Function:{0}", ex.Source);
                sw.WriteLine("StackTrace:{0}", ex.StackTrace);
                sw.WriteLine();
                sw.Close();
            }
            catch (Exception)
            {/*错误信息捕捉中不再进行异常处理*/ }
        }
        ///#################################################################################
        /// <summary>
        /// 记录ex提供的异常信息,并记录当前系统信息
        /// Coder:ryo 20060707
        /// </summary>
        /// <param name="ex"></param>
        ///#################################################################################
        public static void LogExceptionDetail(Exception ex)
        {
            try
            {
                var sw = new StreamWriter(string.Format("{0}\\Log\\FeedBack.txt", Application.StartupPath), true, Encoding.Default);
                sw.WriteLine("--------------------------------------------------------------------");
                sw.WriteLine("Time:{0}  {1}", DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString());
                sw.WriteLine("Message:{0}", ex.Message);
                sw.WriteLine("Function:{0}", ex.Source);
                sw.WriteLine("StackTrace:{0}", ex.StackTrace);
                sw.WriteLine();
                Process[] tmpP = Process.GetProcesses();
                foreach (Process p in tmpP)
                {
                    sw.WriteLine(p.ProcessName);
                }
                sw.Close();
                //记录当前屏幕截图
                SendKeys.SendWait("^{PRTSC}");
                IDataObject iData = Clipboard.GetDataObject();
                if (iData != null)
                {
                    if (iData.GetDataPresent(DataFormats.Bitmap))
                    {
                        var tmpimg = (Image)iData.GetData(DataFormats.Bitmap);
                        tmpimg.Save(string.Format("{0}\\Log\\FeedBack.jpg", Application.StartupPath), System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                }
            }
            catch (Exception)
            {/*错误信息捕捉中不再进行异常处理*/ }
        }
        ///#################################################################################
        /// <summary>
        /// 记录开发人员自定义的信息
        /// Coder:Kevin (2008-02-26)
        /// </summary>
        /// <param name="sMessage">需要记录的信息1</param>
        /// <param name="sMessage2">需要记录的信息2</param>
        ///#################################################################################
        public static void LogIofmation(string sMessage, string sMessage2)
        {
            try
            {
                var sw = new StreamWriter(Application.StartupPath + EXCEPTION_FILENAME, true, Encoding.Default);
                sw.WriteLine("--------------------------------------------------------------------");
                sw.WriteLine("Time:{0}  {1}", DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString());
                sw.WriteLine("Message:{0}", sMessage);
                sw.WriteLine("Message2:{0}", sMessage2);
                sw.WriteLine();
                sw.Close();
            }
            catch (Exception)
            {/*错误信息捕捉中不再进行异常处理*/ }
        }

        ///#################################################################################
        /// <summary>
        /// 记录ex提供的异常信息 Saint 测试用
        /// </summary>
        /// <param name="ex"></param>
        public static void LogInfomation(string sInfomation)
        {
            try
            {
                StreamWriter sw = new StreamWriter(Application.StartupPath + EXCEPTION_FILENAME, true, Encoding.Default);
                sw.WriteLine("--------------------------------------------------------------------");
                sw.WriteLine("Time:" + DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString());
                sw.WriteLine(sInfomation);
                sw.WriteLine();
                sw.Close();
            }
            catch {/*错误信息捕捉中不再进行异常处理*/ }
        }

        ///#################################################################################
        /// <summary>
        /// 记录ex提供的异常信息 Saint 测试用
        /// </summary>
        /// <param name="ex"></param>
        public static void LogException1(Exception ex, string sAdd)
        {
            try
            {
                StreamWriter sw = new StreamWriter(Application.StartupPath + EXCEPTION_FILENAME, true, Encoding.Default);
                sw.WriteLine("--------------------------------------------------------------------");
                sw.WriteLine("Time:" + DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString());
                sw.WriteLine("Message:" + ex.Message);
                sw.WriteLine("Function:" + ex.Source);
                sw.WriteLine("StackTrace:" + ex.StackTrace);
                sw.WriteLine(sAdd);
                sw.WriteLine();
                sw.Close();
            }
            catch {/*错误信息捕捉中不再进行异常处理*/ }
        }
    }
}
