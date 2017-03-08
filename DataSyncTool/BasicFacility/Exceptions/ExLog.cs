/*****************************************************/
/*  FileName: ExLog.cs                               */
/*  Function: �쳣��Log����                     */
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
        /// ��¼ex�ṩ���쳣��Ϣ
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
            {/*������Ϣ��׽�в��ٽ����쳣����*/ }
        }
        ///#################################################################################
        /// <summary>
        /// ��¼ex�ṩ���쳣��Ϣ,����¼��ǰϵͳ��Ϣ
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
                //��¼��ǰ��Ļ��ͼ
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
            {/*������Ϣ��׽�в��ٽ����쳣����*/ }
        }
        ///#################################################################################
        /// <summary>
        /// ��¼������Ա�Զ������Ϣ
        /// Coder:Kevin (2008-02-26)
        /// </summary>
        /// <param name="sMessage">��Ҫ��¼����Ϣ1</param>
        /// <param name="sMessage2">��Ҫ��¼����Ϣ2</param>
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
            {/*������Ϣ��׽�в��ٽ����쳣����*/ }
        }

        ///#################################################################################
        /// <summary>
        /// ��¼ex�ṩ���쳣��Ϣ Saint ������
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
            catch {/*������Ϣ��׽�в��ٽ����쳣����*/ }
        }

        ///#################################################################################
        /// <summary>
        /// ��¼ex�ṩ���쳣��Ϣ Saint ������
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
            catch {/*������Ϣ��׽�в��ٽ����쳣����*/ }
        }
    }
}
