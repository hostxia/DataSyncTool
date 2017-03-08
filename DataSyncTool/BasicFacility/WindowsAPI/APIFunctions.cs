/// <copyright from='2003' to='2004' company='北京彼速信息技术有限公司'>
///    Copyright(c) 北京彼速信息技术有限公司版权所有.                
/// </copyright>                                                                  
//------------------------------------------------------------------------------
/*******************************************************************************/
/*      FileName: APIFunctions.cs                                             */
/*      Function: API函数集,此下为Windows函数在.Net下的封装，详见MSDN         */
/*        Author: 张志国                                                      */
/*          Date: 2004-04-13                                                  */
/*******************************************************************************/
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace BasicFacility.WindowsAPI
{
    /// <summary>
    /// API函数集
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
        public const Int32 AW_HOR_POSITIVE = 0x00000001; // 从左到右打开窗口
        public const Int32 AW_HOR_NEGATIVE = 0x00000002; // 从右到左打开窗口
        public const Int32 AW_VER_POSITIVE = 0x00000004; // 从上到下打开窗口
        public const Int32 AW_VER_NEGATIVE = 0x00000008; // 从下到上打开窗口
        public const Int32 AW_CENTER = 0x00000010;
        public const Int32 AW_HIDE = 0x00010000; // 在窗体卸载时若想使用本函数就得加上此常量
        public const Int32 AW_ACTIVATE = 0x00020000; //在窗体通过本函数打开后，默认情况下会失去焦点，除非加上本常量
        public const Int32 AW_SLIDE = 0x00040000;
        public const Int32 AW_BLEND = 0x00080000; // 淡入淡出效果


        public APIFunctions()
        {
        }
        ///######################################################################
        /// <summary>
        /// 通过窗口类和窗口标题，返回窗口的句柄
        /// Author: 张志国 （2004-04-21） 
        /// </summary>
        /// <param name="lpClassName">窗口类名称</param>
        /// <param name="lpWindowName">窗口标题名称</param>
        /// <returns>窗口句柄</returns>
        ///######################################################################
        [DllImport("user32.dll")]
        public static extern int FindWindow(
            string lpClassName,  // class name 
            string lpWindowName  // window name 
            );

        ///######################################################################
        /// <summary>
        /// 获取窗体的子控件
        /// </summary>
        /// <param name="hwndParent"></param>
        /// <param name="hwndChildAfter"></param>
        /// <param name="lpszClass"></param>
        /// <param name="lpszWindow"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern int FindWindowEx(
            int hwndParent, //父窗体句柄
            int hwndChildAfter, //一般填写0
            string lpszClass, //类名，一般为NULL，如果填写，请先用GlobalAtom注册
            string lpszWindow//子控件名称
            );

        ///######################################################################
        /// <summary>
        /// 向指定的窗口发送消息
        /// Author: 张志国 （2004-04-21） 
        /// </summary>
        /// <param name="hWnd">特定窗口的句柄</param>
        /// <param name="Msg">消息的编号</param>
        /// <param name="wParam">第一个消息参数</param>
        /// <param name="lParam">第二个消息参数</param>
        /// <returns>消息发送的返回值</returns>
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
        /// 向指定的窗口发送消息
        /// Author: 张志国 （2004-04-21） 
        /// </summary>
        /// <param name="hWnd">特定窗口的句柄</param>
        /// <param name="Msg">消息的编号</param>
        /// <param name="wParam">第一个消息参数</param>
        /// <param name="lParam">第二个消息参数</param>
        /// <param name="sCaption">窗口标题</param>
        /// <returns>消息发送的返回值</returns>
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
        /// 根据要显示的状态如最大化，最小化显示窗口
        /// Author: 张志国 （2004-04-21） 
        /// </summary>
        /// <param name="hWnd">要显示的窗口</param>
        /// <param name="mCmd">窗口显示状态</param>
        /// <returns>窗口是否成功显示后的标识</returns>
        ///######################################################################
        [DllImport("user32.dll")]
        public static extern int ShowWindow(
            int hWnd,      // handle to destination window 
            int mCmd       //cmd
            );

        ///######################################################################
        /// <summary>
        /// 把设定写入配置文件中
        /// Author: 张志国 （2004-04-21） 
        /// </summary>
        /// <param name="section">节区标记</param>
        /// <param name="key">关键字</param>
        /// <param name="val">值</param>
        /// <param name="filePath">文件路径名</param>
        /// <returns></returns>
        ///######################################################################
        [DllImport("kernel32")]
        public static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        ///######################################################################
        /// <summary>
        /// 从配置文件中读出设定值
        /// Author: 张志国 （2004-04-21） 
        /// </summary>
        /// <param name="section">节区标记</param>
        /// <param name="key">关键字</param>
        /// <param name="def">如果没有读到指定的关键字，缺省返回值</param>
        /// <param name="retVal">返回值</param>
        /// <param name="size">读取字节大小</param>
        /// <param name="filePath">文件路径名</param>
        /// <returns></returns>
        ///######################################################################
        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        ///######################################################################
        /// <summary>
        /// 设置激活当前窗口
        /// coder:likai(2010-06-07)
        /// </summary>
        /// <param name="formHandler">窗口的句柄</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern int SetActiveWindow(
            IntPtr formHandler           // handle to destination window 
            );
        ///######################################################################
        /// <summary>
        /// 关闭窗口
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
        /// 淡入淡出效果
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
        ///  该函数将创建指定窗口的线程设置到前台，并且激活该窗口。键盘输入转向该窗口，并为用户改各种可视的记号。
        ///  系统给创建前台窗口的线程分配的权限稍高于其他线程。 
        /// </summary>
        /// <param name="hWnd">将被激活并被调入前台的窗口句柄</param>
        /// <returns>如果窗口设入了前台，返回值为非零；如果窗口未被设入前台，返回值为零</returns>
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
