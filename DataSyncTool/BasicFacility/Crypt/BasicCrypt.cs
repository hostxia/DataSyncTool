/// <copyright from='2000' to='2010' company='����������Ϣ�������޹�˾'>        
///    Copyright(c) ����������Ϣ�������޹�˾��Ȩ����.                           
/// </copyright>                                                                
///*******************************************************************************/
///      FileName: BasicCrypt.cs					     
///      Function: �������ܽ��ܲ���                                            
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
        /// ���ַ������ܷ��ؼ��ܺ���ַ���
        /// Coder:л������2005-12-15��
        /// </summary>
        ///#################################################################################
        public static string CryptIt(string aString)
        {
            if (string.IsNullOrEmpty(aString)) return string.Empty;
            try
            {
                Byte[] byteInput = (new UnicodeEncoding()).GetBytes(aString);
                //���������Կ�� DES ʵ��
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                //�Ӵ�ʵ������ DES ������
                byte[] rijnKey = null;
                byte[] rijnIV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
                string deencryptKey = "I Hate Net";
                rijnKey = System.Text.Encoding.UTF8.GetBytes(deencryptKey.Substring(0, 8));
                ICryptoTransform desEncrypt = des.CreateEncryptor(rijnKey, rijnIV);
                //����ʹ�� des ������
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
        /// �Ѽ����ַ������ܣ����ؽ��ܺ���ַ���
        /// Coder:л������2005-12-15��
        /// </summary>
        ///#################################################################################
        public static string DecryptIt(string aString)
        {
            if (string.IsNullOrEmpty(aString)) return string.Empty;
            try
            {
                //�Ӵ�ʵ������ DES ������
                byte[] rijnKey = null;
                byte[] rijnIV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
                string deencryptKey = "I Hate Net";
                rijnKey = System.Text.Encoding.UTF8.GetBytes(deencryptKey.Substring(0, 8));
                //���������Կ�� DES ʵ��
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                //�Ӵ� des ʵ������ DES ������
                ICryptoTransform desDecrypt = des.CreateDecryptor(rijnKey, rijnIV);
                //���������������Ա�Դ�����ֽڽ��ж�ȡ��ִ�� des ����ת��
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


