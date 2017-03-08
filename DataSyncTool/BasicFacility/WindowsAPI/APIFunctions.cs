/// <copyright from='2003' to='2004' company='����������Ϣ�������޹�˾'>
///    Copyright(c) ����������Ϣ�������޹�˾��Ȩ����.                
/// </copyright>                                                                  
//------------------------------------------------------------------------------
/*******************************************************************************/
/*      FileName: APIFunctions.cs                                             */
/*      Function: API������,����ΪWindows������.Net�µķ�װ�����MSDN         */
/*        Author: ��־��                                                      */
/*          Date: 2004-04-13                                                  */
/*******************************************************************************/
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace BasicFacility.WindowsAPI
{
    /// <summary>
    /// API������
    /// </summary>
    public class APIFunctions
    {
        public const Int32 SW_HIDE = 0;
        public const Int32 SW_SHOWNORMAL = 1;
        public const Int32 SW_NORMAL = 1;
        public const Int32 SW_SHOWMINIMIZED = 2;
        public const Int32 SW_SHOWMAXIMIZED = 3;
        public const Int32 SW_MAXIMIZE = 3;
        public const Int32 SW_SHOWNOACTIVATE = 4;
        public const Int32 SW_SHOW = 5;
        public const Int32 SW_MINIMIZE = 6;
        public const Int32 SW_SHOWMINNOACTIVE = 7;
        public const Int32 SW_SHOWNA = 8;
        public const Int32 SW_RESTORE = 9;
        public const Int32 SW_SHOWDEFAULT = 10;
        public const Int32 SW_FORCEMINIMIZE = 11;
        public const Int32 SW_MAX = 11;
        public const Int32 AW_HOR_POSITIVE = 0x00000001; // �����Ҵ򿪴���
        public const Int32 AW_HOR_NEGATIVE = 0x00000002; // ���ҵ���򿪴���
        public const Int32 AW_VER_POSITIVE = 0x00000004; // ���ϵ��´򿪴���
        public const Int32 AW_VER_NEGATIVE = 0x00000008; // ���µ��ϴ򿪴���
        public const Int32 AW_CENTER = 0x00000010;
        public const Int32 AW_HIDE = 0x00010000; // �ڴ���ж��ʱ����ʹ�ñ������͵ü��ϴ˳���
        public const Int32 AW_ACTIVATE = 0x00020000; //�ڴ���ͨ���������򿪺�Ĭ������»�ʧȥ���㣬���Ǽ��ϱ�����
        public const Int32 AW_SLIDE = 0x00040000;
        public const Int32 AW_BLEND = 0x00080000; // ���뵭��Ч��


        public APIFunctions()
        {
        }
        ///######################################################################
        /// <summary>
        /// ͨ��������ʹ��ڱ��⣬���ش��ڵľ��
        /// Author: ��־�� ��2004-04-21�� 
        /// </summary>
        /// <param name="lpClassName">����������</param>
        /// <param name="lpWindowName">���ڱ�������</param>
        /// <returns>���ھ��</returns>
        ///######################################################################
        [DllImport("user32.dll")]
        public static extern int FindWindow(
            string lpClassName,  // class name 
            string lpWindowName  // window name 
            );

        ///######################################################################
        /// <summary>
        /// ��ȡ������ӿؼ�
        /// </summary>
        /// <param name="hwndParent"></param>
        /// <param name="hwndChildAfter"></param>
        /// <param name="lpszClass"></param>
        /// <param name="lpszWindow"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern int FindWindowEx(
            int hwndParent, //��������
            int hwndChildAfter, //һ����д0
            string lpszClass, //������һ��ΪNULL�������д��������GlobalAtomע��
            string lpszWindow//�ӿؼ�����
            );

        ///######################################################################
        /// <summary>
        /// ��ָ���Ĵ��ڷ�����Ϣ
        /// Author: ��־�� ��2004-04-21�� 
        /// </summary>
        /// <param name="hWnd">�ض����ڵľ��</param>
        /// <param name="Msg">��Ϣ�ı��</param>
        /// <param name="wParam">��һ����Ϣ����</param>
        /// <param name="lParam">�ڶ�����Ϣ����</param>
        /// <returns>��Ϣ���͵ķ���ֵ</returns>
        ///######################################################################
        [DllImport("user32.dll")]
        public static extern int SendMessage(
            int hWnd,      // handle to destination window 
            uint Msg,     // message 
            int wParam,  // first message parameter 
            int lParam   // second message parameter 
            );


        ///######################################################################
        /// <summary>
        /// ��ָ���Ĵ��ڷ�����Ϣ
        /// Author: ��־�� ��2004-04-21�� 
        /// </summary>
        /// <param name="hWnd">�ض����ڵľ��</param>
        /// <param name="Msg">��Ϣ�ı��</param>
        /// <param name="wParam">��һ����Ϣ����</param>
        /// <param name="lParam">�ڶ�����Ϣ����</param>
        /// <param name="sCaption">���ڱ���</param>
        /// <returns>��Ϣ���͵ķ���ֵ</returns>
        ///######################################################################
        public static int SendWindowMessage(
            uint Msg,     // message 
            int wParam,  // first message parameter 
            int lParam,   // second message parameter 
            string sCaption
            )
        {
            int handle = 0;
            handle = APIFunctions.FindWindow(null, sCaption);
            if (handle != 0 && handle > 0)
            {
                return APIFunctions.SendMessage(handle, Msg, wParam, lParam);
            }
            else
            {
                return -1;
            }
        }

        ///######################################################################
        /// <summary>
        /// ����Ҫ��ʾ��״̬����󻯣���С����ʾ����
        /// Author: ��־�� ��2004-04-21�� 
        /// </summary>
        /// <param name="hWnd">Ҫ��ʾ�Ĵ���</param>
        /// <param name="mCmd">������ʾ״̬</param>
        /// <returns>�����Ƿ�ɹ���ʾ��ı�ʶ</returns>
        ///######################################################################
        [DllImport("user32.dll")]
        public static extern int ShowWindow(
            int hWnd,      // handle to destination window 
            int mCmd       //cmd
            );

        ///######################################################################
        /// <summary>
        /// ���趨д�������ļ���
        /// Author: ��־�� ��2004-04-21�� 
        /// </summary>
        /// <param name="section">�������</param>
        /// <param name="key">�ؼ���</param>
        /// <param name="val">ֵ</param>
        /// <param name="filePath">�ļ�·����</param>
        /// <returns></returns>
        ///######################################################################
        [DllImport("kernel32")]
        public static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        ///######################################################################
        /// <summary>
        /// �������ļ��ж����趨ֵ
        /// Author: ��־�� ��2004-04-21�� 
        /// </summary>
        /// <param name="section">�������</param>
        /// <param name="key">�ؼ���</param>
        /// <param name="def">���û�ж���ָ���Ĺؼ��֣�ȱʡ����ֵ</param>
        /// <param name="retVal">����ֵ</param>
        /// <param name="size">��ȡ�ֽڴ�С</param>
        /// <param name="filePath">�ļ�·����</param>
        /// <returns></returns>
        ///######################################################################
        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        ///######################################################################
        /// <summary>
        /// ���ü��ǰ����
        /// coder:likai(2010-06-07)
        /// </summary>
        /// <param name="formHandler">���ڵľ��</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern int SetActiveWindow(
            IntPtr formHandler           // handle to destination window 
            );
        ///######################################################################
        /// <summary>
        /// �رմ���
        /// coder:LiKai(2010-11-25)
        /// </summary>
        /// <param name="formHandler"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern int DestroyWindow(
            IntPtr formHandler           // handle to destination window 
            );
        ///######################################################################
        /// <summary>
        /// ���뵭��Ч��
        /// </summary>
        /// <param name="hwnd"></param>
        /// <param name="dwTime"></param>
        /// <param name="dwFlags"></param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool AnimateWindow(
        IntPtr hwnd, // handle to window 
        int dwTime, // duration of animation 
        int dwFlags // animation type 
        );

        [DllImport("shell32.dll")]
        public static extern IntPtr ShellExecute(
            IntPtr hwnd,
            string lpOperation,
            string lpFile,
            string lpParameters,
            string lpDirectory,
            ShowCommands nShowCmd);

        [DllImportAttribute("gdi32.dll")]
        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        [DllImport("user32.dll")]
        public static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);

        /// <summary>
        ///  �ú���������ָ�����ڵ��߳����õ�ǰ̨�����Ҽ���ô��ڡ���������ת��ô��ڣ���Ϊ�û��ĸ��ֿ��ӵļǺš�
        ///  ϵͳ������ǰ̨���ڵ��̷߳����Ȩ���Ը��������̡߳� 
        /// </summary>
        /// <param name="hWnd">�������������ǰ̨�Ĵ��ھ��</param>
        /// <returns>�������������ǰ̨������ֵΪ���㣻�������δ������ǰ̨������ֵΪ��</returns>
        [DllImport("User32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
    }

    public enum ShowCommands : int
    {
        SW_HIDE = 0,
        SW_SHOWNORMAL = 1,
        SW_NORMAL = 1,
        SW_SHOWMINIMIZED = 2,
        SW_SHOWMAXIMIZED = 3,
        SW_MAXIMIZE = 3,
        SW_SHOWNOACTIVATE = 4,
        SW_SHOW = 5,
        SW_MINIMIZE = 6,
        SW_SHOWMINNOACTIVE = 7,
        SW_SHOWNA = 8,
        SW_RESTORE = 9,
        SW_SHOWDEFAULT = 10,
        SW_FORCEMINIMIZE = 11,
        SW_MAX = 11
    }
}
