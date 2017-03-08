/// <copyright from='2003' to='2010' company='Bizsolution'>
///    Copyright(c) Bizsolution All rights reserved
/// </copyright>
//******************************************************************************
// File Name: StringProccessor.cs
//  Function: 字符串处理类
//    coder:LiKai(2010-08-05)
//******************************************************************************

using System.Text;

namespace BasicFacility.Utility
{
    /// <summary>
    /// 字符串处理类
    /// </summary>
    public class StringProccessor
    {
        ///############################################################
        /// <summary>
        /// 计算字符的Unicode编码下的长度
        /// coder:LiKai(2010-08-05)
        /// </summary>
        /// <param name="str">要计算的字符串</param>
        /// <returns>字符串的长度</returns>
        public static int GetStrLength(string str)
        {
            int len = 0;
            for (int i = 0; i < str.Length; i++)
            {
                byte[] byte_len = Encoding.Default.GetBytes(str.Substring(i, 1));
                if (byte_len.Length > 1)
                {
                    len += 2;
                }
                else
                {
                    len += 1;
                }
            }
            return len;
        }

        ///############################################################
        /// <summary>
        /// 获取替换后的字符串(主要处理资源文件中的换行符)
        /// coder:zhangjiechen(2010-4-14)
        /// </summary>
        /// <returns></returns>
        public static string GetString(string sName)
        {
            return sName.Replace("\\r\\n", "\r\n").Replace("\\n", "\r\n").Replace("\\n\\n", "\r\n\r\n").Replace("\\t", "\t");
        }
    }
}
