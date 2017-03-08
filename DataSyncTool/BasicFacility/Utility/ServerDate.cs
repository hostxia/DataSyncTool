/// <copyright from='2003' to='2010' company='Bizsolution'>
///    Copyright(c) Bizsolution All rights reserved
/// </copyright>
//******************************************************************************
// File Name: ServerDate.cs
//  Function: 日期处理
//    coder:Jone(2010-04-23)
//      Date: 2010-04-21
//******************************************************************************
using System;
using BasicFacility.Database;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System.Data.SqlClient;
using BasicFacility.Exceptions;

namespace BasicFacility.Utility
{
    public class ServerDate
    {
        /// ##################################################
        /// <summary>
        /// 获取服务器时间
        /// coder:Jone(2010-04-22)
        /// </summary>
        /// <returns></returns>
        public static DateTime GetServerDateTime()
        {
            //XPO获取服务器时间的方法
            try
            {
                using (UnitOfWork _theUow = new UnitOfWork())
                {
                    return (DateTime)_theUow.Evaluate(typeof(XPObjectType), new FunctionOperator(FunctionOperatorType.Now), null);// 英文版的时候出现过问题，暂时不用，还是用SQL
                }
            }
            catch (Exception exception)
            {
                ExManager.ReportException(exception);
                //ConnectionPool pool = new ConnectionPool();
                //using (SqlConnection conn = pool.GetConnection())
                //{
                //    try
                //    {
                //        SqlCommand cmd = new SqlCommand("SELECT GETDATE()", conn);
                //        return (DateTime)cmd.ExecuteScalar();
                //    }
                //    catch (Exception ex)
                //    {
                //        ExManager.ReportException(ex);
                //        return DateTime.Now;
                //    }
                //    finally
                //    {
                //        if (conn != null && conn.State == System.Data.ConnectionState.Open)
                //            conn.Close();
                //    }
                //}
                return DateTime.Now;
            }
        }
        /// <summary>
        /// 验证时间是否合法
        /// coder:likai(2010-05-07)
        /// </summary>
        /// <param name="dateTime">要处理的时间</param>
        /// <returns>如果合法，直接返回datetime的字符串，如果不合法，返回空字符串</returns>
        public static string ValidateDateTime(DateTime dateTime)
        {
            if (dateTime == DateTime.MinValue)
                return null;
            if (dateTime == new DateTime(1900, 1, 1))
                return null;
            return dateTime.ToString("yyyy/M/d");
        }

        /// <summary>
        /// 验证时间是否合法
        /// coder:likai(2010-05-07)
        /// </summary>
        /// <param name="dateTime">要处理的时间</param>
        /// <returns>如果合法，直接返回datetime的字符串，如果不合法，返回空字符串</returns>
        public static string ValidateDateTimeSystemFormat(DateTime dateTime)
        {
            if (dateTime == DateTime.MinValue)
                return null;
            if (dateTime == new DateTime(1900, 1, 1))
                return null;

            return dateTime.ToString("M/d/yyyy");
        }

        /// <summary>
        /// 验证时间是否合法
        /// coder:likai(2010-05-07)
        /// </summary>
        /// <param name="dateTime">要处理的时间</param>
        /// <param name="mode">
        /// 0表示带时间的日期格式，
        /// 1表示只有日期的格式，
        /// 2表示只有时间的格式
        /// coder:likai(2010-05-19)
        /// </param>
        /// <returns>如果合法，直接返回datetime的字符串，如果不合法，返回空字符串</returns>
        public static string ValidateDateTime(DateTime dateTime, int mode)
        {
            if (dateTime == DateTime.MinValue)
                return null;
            if (dateTime == new DateTime(1900, 1, 1))
                return null;

            switch (mode)
            {
                case 0:
                    return dateTime.ToString();
                case 1:
                    return dateTime.ToShortDateString();
                case 2:
                    return dateTime.ToShortTimeString();
                default:
                    return null;
            }
        }

        ///############################################
        /// <summary>
        /// 获取撰写日期中文格式，带年月日
        /// coder: Kevin Wang(2010-10-12)
        /// </summary>
        /// <param name="dt">输入时间</param>
        /// <returns>时间的年月日格式</returns>
        public static string GetDateInCNFormat(DateTime dt)
        {
            if (dt == DateTime.MinValue)
            {
                return string.Empty;
            }
            return dt.Year + "年" + dt.Month + "月" + dt.Day + "日";
        }
        /// <summary>
        /// 获取中文日期（日月年格式）
        /// Coder:zhangxinyuan(2010-11-17)
        /// </summary>
        /// <returns>时间的中文日月年格式</returns>
        public static string GetDateInCNDayMonthYear(DateTime dt)
        {
            if (dt == DateTime.MinValue)
            {
                return string.Empty;
            }
            return dt.Day.ToString() + "日" + dt.Month + "月" + dt.Year + "年";
        }
        ///############################################
        /// <summary>
        /// 获取日期英文格式，带年月日
        /// coder: Kevin Wang(2010-10-12)
        /// </summary>
        /// <returns>时间英文日期格式</returns>
        public static string GetDateInENFormat(DateTime dt)
        {
            if (dt == DateTime.MinValue)
            {
                return string.Empty;
            }
            string sMonth = "";
            switch (dt.Month)
            {
                case 1:
                    sMonth = "January";
                    break;
                case 2:
                    sMonth = "February";
                    break;
                case 3:
                    sMonth = "March";
                    break;
                case 4:
                    sMonth = "April";
                    break;
                case 5:
                    sMonth = "May";
                    break;
                case 6:
                    sMonth = "June";
                    break;
                case 7:
                    sMonth = "July";
                    break;
                case 8:
                    sMonth = "August";
                    break;
                case 9:
                    sMonth = "September";
                    break;
                case 10:
                    sMonth = "October";
                    break;
                case 11:
                    sMonth = "November";
                    break;
                case 12:
                    sMonth = "December";
                    break;
            }
            return sMonth + " " + dt.Day + ", " + dt.Year;
        }

        ///############################################
        /// <summary>
        /// 获取日期英文格式，只带月日
        /// </summary>
        /// <returns>时间英文日期格式</returns>
        public static string GetDateMonthAndDayInENFormat(DateTime dt)
        {
            if (dt == DateTime.MinValue)
            {
                return string.Empty;
            }
            string sMonth = "";
            switch (dt.Month)
            {
                case 1:
                    sMonth = "January";
                    break;
                case 2:
                    sMonth = "February";
                    break;
                case 3:
                    sMonth = "March";
                    break;
                case 4:
                    sMonth = "April";
                    break;
                case 5:
                    sMonth = "May";
                    break;
                case 6:
                    sMonth = "June";
                    break;
                case 7:
                    sMonth = "July";
                    break;
                case 8:
                    sMonth = "August";
                    break;
                case 9:
                    sMonth = "September";
                    break;
                case 10:
                    sMonth = "October";
                    break;
                case 11:
                    sMonth = "November";
                    break;
                case 12:
                    sMonth = "December";
                    break;
            }
            return sMonth + " " + dt.Day;
        }

        /// ###############################################################
        /// <summary>
        /// 处理Between方法两个日期的时间部分（将开始时间转换为00:00:00，结束时间转换为23:59:59）
        /// Coder: Sum(20120806)
        /// </summary>
        /// <param name="dtBeginDate">开始时间</param>
        /// <param name="dtEndDate">结束时间</param>
        /// <returns>是否成功转换</returns>
        public static bool GetBetweenDate(ref DateTime dtBeginDate, ref DateTime dtEndDate)
        {
            try
            {
                if (dtBeginDate != DateTime.MinValue && dtEndDate != DateTime.MinValue)
                {
                    dtBeginDate = dtBeginDate.Date;
                    dtEndDate = dtBeginDate.Date.AddDays(+1).AddSeconds(-1);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                ExManager.ReportException(ex);
                return false;
            }
        }

        /// ###############################################################
        /// <summary>
        /// 通过相隔日期天数计算Between表达式的两个日期，即N天之前/后。只要传入相隔天数和一个日期即可，另外一个日期参数赋值为DateTime.MinValue
        /// Coder: Sum(20120806)
        /// </summary>
        /// <param name="nDayCount">相隔天数（正数，当天传0）</param>
        /// <param name="dtBeginDate">开始时间，赋值即为计算N天之后的两个日期</param>
        /// <param name="dtEndDate">结束时间，赋值即为计算N天之前的两个日期</param>
        /// <returns>是否成功转换</returns>
        public static bool GetBetweenDateByDayCount(int nDayCount, ref DateTime dtBeginDate, ref DateTime dtEndDate)
        {
            try
            {
                if (nDayCount < 0)
                {
                    return false;
                }
                if (dtBeginDate != DateTime.MinValue)
                {
                    dtBeginDate = dtBeginDate.Date;
                    dtEndDate = nDayCount == 0 ? dtBeginDate.Date.AddDays(nDayCount + 1).AddSeconds(-1) : dtBeginDate.Date.AddDays(nDayCount).AddSeconds(-1);
                    return true;
                }
                if (dtEndDate != DateTime.MinValue)
                {
                    dtEndDate = nDayCount == 0 ? dtBeginDate.Date.AddDays(nDayCount + 1).AddSeconds(-1) : dtBeginDate.Date.AddDays(nDayCount).AddSeconds(-1);
                    dtBeginDate = dtEndDate.Date;
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                ExManager.ReportException(ex);
                return false;
            }
        }
    }
}