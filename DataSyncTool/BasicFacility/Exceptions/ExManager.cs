

/*****************************************************/
/*  FileName: ExManager.cs                           */
/*  Function: �쳣����������                    */
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
        /// ר��֮�ǵĶԻ���ģʽ
        /// </summary>
        PT,
        /// <summary>
        /// ȫ������ĶԻ���ģʽ
        /// </summary>
        PA,
        /// <summary>
        /// ��������������ĶԻ���ģʽ
        /// </summary>
        DS
    }

    public class ExManager
    {
        public static MessageBoxMode ReportMode;

        /// <summary>
        /// ģʽ����
        /// 0 - ����ģʽ
        /// 1 - ����ģʽ��������ʾ���д�����Ϣ��
        /// 2 - �ͻ�����ģʽ����¼��Ϊ�꾡�Ŀͻ�������Ϣ��
        /// </summary>
        static readonly int iRunMode;
        /// <summary>
        /// ���캯�������������ļ������Ƿ����õ���ģʽ
        /// </summary>
        static ExManager()
        {
            try
            {
                //�������ļ��ж�ȡ����ģʽ
                //var sr = new StreamReader(string.Format("{0}\\Config\\runmode.ini", Application.StartupPath));
                iRunMode = 0;//Ĭ��Ϊ����ģʽ
                //iRunMode = Convert.ToInt32(sr.ReadLine());
            }
            catch (Exception)
            { }
        }
        ///###################################################################
        /// <summary>
        /// ��¼�쳣��Ϣ������ʾ�κ���ʾ
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
        /// ��¼�쳣��Ϣ������ʾ�κ���ʾ��ȷ���Ƿ��׳��쳣
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
        /// ��¼�쳣��Ϣ����ʾmsg��ʾ
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
