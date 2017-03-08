/// <copyright from='2000' to='2010' company='北京彼速信息技术有限公司'>        
///    Copyright(c) 北京彼速信息技术有限公司版权所有.                           
/// </copyright>     
///*******************************************************************************/
///*      FileName: SQLStatement.cs                                              */
///*      Function: SQL语句附加功能类                                     */
///*      Coder: Ryo.Wu                                                          */
///*      Date: 2006-3-22 17:32:58                                               */
///*      Description: auto created by ComTools v1.0                             */
///*******************************************************************************/
namespace BasicFacility.Database
{
    public class SQLStatement
    {
        ///#################################################################################
        /// <summary>
        /// 更正要进行update和insert的值，替换其中的“‘”号
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        ///#################################################################################
        public static string ConvertUpdateValue(string value)
        {
            if (value != null)
            {
                return value.Replace("'", "''");
            }
            else
            {
                return value;
            }
        }
        ///#################################################################################
        /// <summary>
        /// 更正要进行查询中的字符串值，替换其中的特殊符号，共有5个
        /// Modified by Haul (2006-06-27)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        ///#################################################################################
        public static string ConvertSearchValue(string value)
        {
            if (value != null)
            {
                value = value.Replace("[", "[[]");
                //value = value.Replace("]", "[]]");
                value = value.Replace("%", "[%]");
                value = value.Replace("_", "[_]");
                value = value.Replace("'", "''");
                return value;
            }
            else
            {
                return value;
            }
        }
        ///#################################################################################
        /// <summary>
        /// 更正要进行查询中的字符串值，替换其中的特殊符号，共有5个
        /// Modified by Haul (2006-06-27)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        ///#################################################################################
        public static string ConvertDataBaseSQL(string value)
        {
            if (value != null)
            {
                value = value.Replace("'", "''");
                value = "[" + value + "]";
                return value;
            }
            else
            {
                return value;
            }
        }
    }
}
