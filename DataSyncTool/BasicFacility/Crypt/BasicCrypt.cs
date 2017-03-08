/// <copyright from='2000' to='2010' company='北京彼速信息技术有限公司'>        
///    Copyright(c) 北京彼速信息技术有限公司版权所有.                           
/// </copyright>                                                                
///*******************************************************************************/
///      FileName: BasicCrypt.cs					     
///      Function: 基本加密解密操作                                            
///         Coder: Gary.Xie                                                         
///          Date: 2005-12-15                                                 
///*******************************************************************************/
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace BasicFacility.Crypt
{
    public class BasicCrypt
    {
        ///#################################################################################
        /// <summary>
        /// 把字符串加密返回加密后的字符串
        /// Coder:谢国利（2005-12-15）
        /// </summary>
        ///#################################################################################
        public static string CryptIt(string aString)
        {
            if (string.IsNullOrEmpty(aString)) return string.Empty;
            try
            {
                Byte[] byteInput = (new UnicodeEncoding()).GetBytes(aString);
                //具有随机密钥的 DES 实例
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                //从此实例创建 DES 加密器
                byte[] rijnKey = null;
                byte[] rijnIV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
                string deencryptKey = "I Hate Net";
                rijnKey = System.Text.Encoding.UTF8.GetBytes(deencryptKey.Substring(0, 8));
                ICryptoTransform desEncrypt = des.CreateEncryptor(rijnKey, rijnIV);
                //创建使用 des 加密流
                MemoryStream mStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(mStream, desEncrypt, CryptoStreamMode.Write);
                cryptoStream.Write(byteInput, 0, byteInput.Length);
                cryptoStream.FlushFinalBlock();
                byte[] byteOutString = mStream.ToArray();
                cryptoStream.Close();
                return Convert.ToBase64String(byteOutString);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        ///#################################################################################
        /// <summary>
        /// 把加密字符串解密，返回解密后的字符串
        /// Coder:谢国利（2005-12-15）
        /// </summary>
        ///#################################################################################
        public static string DecryptIt(string aString)
        {
            if (string.IsNullOrEmpty(aString)) return string.Empty;
            try
            {
                //从此实例创建 DES 加密器
                byte[] rijnKey = null;
                byte[] rijnIV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
                string deencryptKey = "I Hate Net";
                rijnKey = System.Text.Encoding.UTF8.GetBytes(deencryptKey.Substring(0, 8));
                //具有随机密钥的 DES 实例
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                //从此 des 实例创建 DES 解密器
                ICryptoTransform desDecrypt = des.CreateDecryptor(rijnKey, rijnIV);
                //创建加密流集合以便对传入的字节进行读取并执行 des 解密转换
                MemoryStream mStream = new MemoryStream();
                CryptoStream cryptoStreamDecr = new CryptoStream(mStream, desDecrypt, CryptoStreamMode.Write);
                byte[] byteInstring = Convert.FromBase64String(aString);
                cryptoStreamDecr.Write(byteInstring, 0, byteInstring.Length);
                cryptoStreamDecr.FlushFinalBlock();
                cryptoStreamDecr.Close();
                byte[] byteOutString = mStream.ToArray();
                return (new UnicodeEncoding()).GetString(byteOutString);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}


