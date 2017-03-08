/// <copyright from='2000' to='2010' company='����������Ϣ�������޹�˾'>        
///    Copyright(c) ����������Ϣ�������޹�˾��Ȩ����.                           
/// </copyright>     
///*******************************************************************************/
///*      FileName: SQLStatement.cs                                              */
///*      Function: SQL��丽�ӹ�����                                     */
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
        /// ����Ҫ����update��insert��ֵ���滻���еġ�������
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
        /// ����Ҫ���в�ѯ�е��ַ���ֵ���滻���е�������ţ�����5��
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
        /// ����Ҫ���в�ѯ�е��ַ���ֵ���滻���е�������ţ�����5��
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
