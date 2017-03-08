/*****************************************************/
/*      FileName: PTMessageBoxIcon.cs                */
/*      Function: PatentStar的messagebox图标         */
/*        Author: ryo                                */
/*          Date: 2006-03-30                         */
/*      Modified:                                    */
/*****************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicFacility.MessageBox
{
    /// <summary>
    /// PatentStar的信息提示框图标
    /// </summary>
    public enum PTMessageBoxIcon
    { 
        /// <summary>
        /// 错误
        /// </summary>
        Error,
        /// <summary>
        /// 警告
        /// </summary>
        Warning,
        /// <summary>
        /// 问号
        /// </summary>
        Question,
        /// <summary>
        /// 正确
        /// </summary>
        Right
    }
}
