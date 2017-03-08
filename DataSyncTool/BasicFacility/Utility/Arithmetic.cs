/// <copyright from='2003' to='2010' company='Bizsolution'>
///    Copyright(c) Bizsolution All rights reserved
/// </copyright>
//******************************************************************************
// File Name: Arithmetic.cs
//  Function: 数字处理
//    coder:Jone(2010-04-23)
//      Date: 2010-04-21
//******************************************************************************
using System;

namespace BasicFacility.Utility
{
    public class Arithmetic
    {
        /// ########################################################
        /// <summary>
        /// 四舍六入 五保留
        /// coder:Jone(2010-03-22)
        /// </summary>
        /// <param name="dValue"></param>
        /// <returns></returns>
        public static double Round(double dValue)
        {
            double iReturn;
            ////如果是整数
            //if(IsNumberId(dValue.ToString())==true)
            //{
            //    return dValue;
            //}
            ////如果是带小数的，
            //if (Math.IEEERemainder(Math.Truncate(dValue * 10), 5.0)==0)
            //{
            //    iReturn = Math.Truncate(dValue)+0.5;
            //}
            //else
            //{
            //    iReturn = Math.Round(dValue, 0);
            //}
            iReturn = Math.Round(dValue, 2);
            return iReturn;
        }
        /// ########################################################
        /// <summary>
        /// 四舍六入 五保留
        /// coder:Jone(2010-03-22)
        /// </summary>
        /// <param name="dValue">需要处理的数字</param>
        /// <returns>四舍五入后的结果</returns>
        public static decimal Round(Decimal dValue, int fractionalPartLength)
        {
            decimal iReturn;
            iReturn = Math.Round(dValue, fractionalPartLength);
            return iReturn;
        }

        /// <summary>
        /// 判断其是否是整数
        /// coder:Jone(2010-03-22)
        /// </summary>
        /// <param name="value"></param>
        /// <returns>如果是返回true,否则False</returns>
        public static bool IsNumberId(string value)
        {
            System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(@"^[1-9]*[0-9]*$");
            return reg.IsMatch(value);
        }

        /// <summary>
        /// 四舍五入算法
        /// </summary>
        /// <param name="v">要进行处理的数据</param>
        /// <param name="x">保留的小数位数</param>
        /// <returns>四舍五入后的结果</returns>
        public static double RoundToFive(double v, int x)
        {
            bool isNegative = false;
            //如果是负数
            if (v < 0)
            {
                isNegative = true;
                v = -v;
            }

            int IValue = 1;
            for (int i = 1; i <= x; i++)
            {
                IValue = IValue * 10;
            }
            double Int = Math.Floor(v * IValue + 0.5);
            v = Int / IValue;

            if (isNegative)
            {
                v = -v;
            }
            return v;
        }


    }
}
