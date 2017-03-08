/// <copyright from='2000' to='2010' company='北京彼速信息技术有限公司'>        
///    Copyright(c) 北京彼速信息技术有限公司版权所有.                           
/// </copyright>                                                                
///*******************************************************************************/
///      FileName: FileManager.cs					     
///      Function: 基本文件操作                                            
///         Coder: Jone Zhang                                                         
///          Date: 2010-4-15                                                 
///*******************************************************************************/

using System;
using System.IO;
using BasicFacility.Exceptions;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip;

namespace BasicFacility.IOOperation
{
    public class FileManager
    {
        public string cutStr = "";

        /// <summary>
        /// 依次删除文件夹下的文件，如果文件正在使用，则删除下一条
        /// Jone 2009-12-9
        /// </summary>
        /// <param name="sFileDir">指定的目录</param>
        public static void DeleteTempDirEveryFile(string FileDir)
        {
            if (!Directory.Exists(FileDir))
            {
                return;
            }
            DirectoryInfo info = new DirectoryInfo(FileDir);
            FileInfo[] sFileList = info.GetFiles();

            if (sFileList != null && sFileList.Length >= 0)
            {
                foreach (FileInfo sFile in sFileList)
                {
                    try
                    {
                        File.Delete(sFile.FullName);
                    }
                    catch
                    {
                        continue;
                    }

                }
            }
            string[] directorys = Directory.GetDirectories(FileDir);
            if (directorys != null && directorys.Length > 0)
            {
                foreach (string i in directorys)
                {
                    try
                    {
                        DeleteTempDirFile(i);
                    }
                    catch
                    {
                        continue;
                    }
                }
            }

        }
        /// <summary>
        /// 删除指定文件夹，及文件夹下的文件
        /// Jone 2009-12-9
        /// </summary>
        /// <param name="sFile">指定的文件</param>
        public static void DeleteTempDirFile(string FileDir)
        {
            try
            {
                DirectoryInfo info = new DirectoryInfo(FileDir);
                info.Delete(true);
            }
            catch (Exception ex)
            {
                ExceptionLog.LogException(ex);
            }
        }

        #region zip


        ///####################################################################
        /// <summary>
        /// 将指定目录下所有子目录的文件添加到压缩流里
        /// Coder:Arthur2010-2-25
        /// </summary>
        /// <param name="di"></param>
        /// <param name="s"></param>
        /// <param name="crc"></param>
        /// ###################################################################
        private void direct(DirectoryInfo di, ref ZipOutputStream s, Crc32 crc)
        {
            //DirectoryInfo di = new DirectoryInfo(filenames);
            DirectoryInfo[] dirs = di.GetDirectories("*");

            //遍历目录下面的所有的子目录
            foreach (DirectoryInfo dirNext in dirs)
            {
                //将该目录下的所有文件添加到 ZipOutputStream s 压缩流里面
                FileInfo[] a = dirNext.GetFiles();
                this.writeStream(ref s, a, crc);

                //递归调用直到把所有的目录遍历完成
                direct(dirNext, ref s, crc);
            }
        }

        /// <summary>
        /// 压缩指定目录下所有文件
        /// Coder:Arthur2010-2-25
        /// </summary>
        /// <param name="s"></param>
        /// <param name="a"></param>
        /// <param name="crc"></param>
        private void writeStream(ref ZipOutputStream s, FileInfo[] a, Crc32 crc)
        {
            foreach (FileInfo fi in a)
            {
                //string fifn = fi.FullName;
                FileStream fs = fi.OpenRead();

                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);


                //ZipEntry entry = new ZipEntry(file);    Path.GetFileName(file)
                string file = fi.FullName;
                file = file.Replace(cutStr, "");

                ZipEntry entry = new ZipEntry(file);

                entry.DateTime = DateTime.Now;
                entry.Size = fs.Length;
                fs.Close();

                crc.Reset();
                crc.Update(buffer);

                entry.Crc = crc.Value;

                s.PutNextEntry(entry);

                s.Write(buffer, 0, buffer.Length);
            }
        }

        /// <summary>
        /// 压缩指定目录下指定文件(包括子目录下的文件)
        /// </summary>
        /// <param name="zippath">args[0]为你要压缩的目录所在的路径 
        /// 例如：D:\\temp\\   (注意temp 后面加 \\ )</param>
        /// <param name="zipfilename">args[1]为压缩后的文件名及其路径
        /// 例如：D:\\temp.zip</param>
        /// <param name="fileFilter">文件过滤, 例如*.xml,这样只压缩.xml文件.</param>
        public bool ZipFileMain(string zippath, string zipfilename, string fileFilter)
        {
            try
            {
                //string filenames = Directory.GetFiles(args[0]);

                Crc32 crc = new Crc32();
                ZipOutputStream s = new ZipOutputStream(File.Create(zipfilename));

                s.SetLevel(6); // 0 - store only to 9 - means best compression

                DirectoryInfo di = new DirectoryInfo(zippath);

                FileInfo[] a = di.GetFiles();

                cutStr = zippath.Trim();
                //压缩这个目录下的所有文件
                writeStream(ref s, a, crc);
                //压缩这个目录下子目录及其文件
                direct(di, ref s, crc);

                s.Finish();
                s.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 压缩指定文件
        /// </summary>
        /// <param name="FileToZip">被压缩的文件</param>
        /// <param name="ZipedFile">压缩后的文件</param>
        /// <param name="CompressionLevel">压缩级别</param>
        /// <param name="BlockSize">压缩块大小</param>
        public void ZipFile(string FileToZip, string ZipedFile, int CompressionLevel, int BlockSize)
        {
            //如果文件没有找到则报错。
            if (!System.IO.File.Exists(FileToZip))
            {
                throw new FileNotFoundException("The specified file " + FileToZip + " could not be found. Zipping aborderd");
            }

            FileStream streamToZip = new FileStream(FileToZip, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            FileStream zipFile = System.IO.File.Create(ZipedFile);
            ZipOutputStream ZipStream = new ZipOutputStream(zipFile);
            ZipEntry ZipEntry = new ZipEntry("ZippedFile");
            ZipStream.PutNextEntry(ZipEntry);
            ZipStream.SetLevel(CompressionLevel);
            byte[] buffer = new byte[BlockSize];
            System.Int32 size = streamToZip.Read(buffer, 0, buffer.Length);
            ZipStream.Write(buffer, 0, size);
            try
            {
                while (size < streamToZip.Length)
                {
                    int sizeRead = streamToZip.Read(buffer, 0, buffer.Length);
                    ZipStream.Write(buffer, 0, sizeRead);
                    size += sizeRead;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            ZipStream.Finish();
            ZipStream.Close();
            streamToZip.Close();
        }

        #endregion

        ///#######################################################################
        /// <summary>
        /// 检查文件是否正在使用
        /// Author: 夏宜蕃
        /// </summary>
        /// <param name="sFilePath">文件的路径</param>
        /// <returns>true: 正在使用 false: 不在使用中</returns>
        ///#######################################################################
        public static bool ChkFileIsUsing(string sFilePath)
        {
            bool bRe = false;
            try
            {
                FileStream stream = File.Open(sFilePath, FileMode.Open, FileAccess.Read, FileShare.None);
                stream.Close();

            }
            catch//(System.Exception ex)
            {
                bRe = true;
            }

            return bRe;
        }

        ///#########################################################################
        /// <summary>
        /// 根据月、日、时、分、秒产生文件名后缀字串例如：　0501150123(5月1日15点01分23秒）
        /// Coder： Kevin Wang(2010-09-09)
        /// </summary>
        public static string GetFileNameSuffixByDate()
        {
            string sSuffix = "";
            DateTime dtCurDatetime = DateTime.Now;
            string sYear = dtCurDatetime.Year.ToString();
            string sMonth = dtCurDatetime.Month.ToString();
            string sDay = dtCurDatetime.Day.ToString();
            string sHour = dtCurDatetime.Hour.ToString();
            string sMinute = dtCurDatetime.Minute.ToString();
            string sSecond = dtCurDatetime.Second.ToString();
            string sMillisecond = dtCurDatetime.Millisecond.ToString();

            //
            // 使月、日、时、分、秒的位数为两位)
            if (sMonth.Length == 1) sMonth = "0" + sMonth;
            if (sDay.Length == 1) sDay = "0" + sDay;
            if (sHour.Length == 1) sHour = "0" + sHour;
            if (sMinute.Length == 1) sMinute = "0" + sMinute;
            if (sSecond.Length == 1) sSecond = "0" + sSecond;
            if (sMillisecond.Length == 1) sMillisecond = "0" + sMillisecond;
            sSuffix = sYear + sMonth + sDay + sHour + sMinute + sSecond + sMillisecond;
            return sSuffix;
        }

        ///#########################################################################
        /// <summary>
        /// 复制文件到指定目录。 如果指定目录不存在，则创建该目录
        /// Coder： Kevin Wang(2010-09-23)
        /// </summary>
        /// <param name="sSource">源文件路径，全路径+文件名</param>
        /// <param name="sTarget">目标文件路径，全路径+文件名</param>
        ///<param name="bOverride">如果目标目录下有同名文件，是否覆盖</param>
        ///<returns>成功返回true，否则返回false</returns>
        public static bool CopyFile(string sSource, string sTarget, bool bOverride)
        {
            try
            {
                if (!Directory.Exists(Path.GetDirectoryName(sTarget)))
                {   // 如果目标路径不存在，则创建目标路径
                    Directory.CreateDirectory(Path.GetDirectoryName(sTarget));
                }
                //如果目标文件已存在，先将其设为非只读
                SetFileReadOnly(sTarget, false);
                File.Copy(sSource, sTarget, bOverride);
                //保存后再次设为非只读
                SetFileReadOnly(sTarget, false);
                return true;
            }
            catch (Exception ex)
            {
                ExManager.ReportException(ex);
                return false;
            }
            return true;
        }

        ///########################################################################
        /// <summary>
        /// 设置文件的只读属性
        /// Coder：lixin(2010-11-17)
        /// </summary>
        /// <param name="sPath">文件的绝对路径</param>
        /// <param name="bReadOnly">true：设为只读 false：设为非只读</param>
        /// <returns>true：设置成功 false：失败</returns>
        public static bool SetFileReadOnly(string sPath, bool bReadOnly)
        {
            if (File.Exists(sPath) == false)
            {
                return false;
            }
            try
            {
                FileInfo fileInfo = new FileInfo(sPath);

                if (fileInfo.Attributes.ToString().IndexOf("ReadOnly") != -1)

                    fileInfo.Attributes = bReadOnly ? FileAttributes.ReadOnly : FileAttributes.Normal;
            }
            catch (Exception ex)
            {
                ExManager.ReportException(ex);
                return false;
            }

            return true;

        }

        ///#########################################################################
        /// <summary>
        /// 创建文件
        /// coder:zhangjiechen(2010-09-25)
        /// </summary>
        /// <param name="objData">要创建文件的内容</param>
        /// <param name="sPath">文件的路径</param>
        /// <param name="sFileName">文件的名字</param>
        /// <returns>true 成功 false 失败</returns>
        public static bool CreateFile(object objData, string sDirPath, string sFileName)
        {
            try
            {
                if (objData == null) return false;
                if (!Directory.Exists(sDirPath))
                {
                    Directory.CreateDirectory(sDirPath);
                }
                byte[] bytes = null;
                if (objData.GetType() == typeof(String))
                {
                    bytes = System.Text.Encoding.Default.GetBytes((string)objData);
                }
                else if (objData.GetType() == typeof(byte[]))
                {
                    bytes = (byte[])objData;
                }
                FileStream fileStream = new FileStream(sDirPath + "\\" + sFileName, FileMode.Create);  
                fileStream.Write(bytes, 0, bytes.Length);
                fileStream.Close();
            }
            catch (Exception ex)
            {
                ExManager.ReportException(ex);
                return false;
            }
            return true;
        }
        ///#########################################################################
        /// <summary>
        /// 处理文件/目录名称。替换路径非法字符
        /// coder:Kevin Wang(2010-09-25)
        /// </summary>
        /// <param name="sFileName">被处理的路径</param>
        /// <returns>处理后的路径</returns>
        public static string GetGoodPathName(string sPathName)
        {
            string sReturnPath =sPathName;
            sReturnPath = sReturnPath.Replace("\"", "_");
            sReturnPath = sReturnPath.Replace("/", "-");
            sReturnPath = sReturnPath.Replace(":", "-");
            sReturnPath = sReturnPath.Replace("*", "-");
            sReturnPath = sReturnPath.Replace("?", "-");
            sReturnPath = sReturnPath.Replace("\\", "-");
            sReturnPath = sReturnPath.Replace("<", "-");
            sReturnPath = sReturnPath.Replace(">", "-");
            sReturnPath = sReturnPath.Replace("|", "-");
            sReturnPath = sReturnPath.Replace("#", "-");
            sReturnPath = sReturnPath.Replace("$", "-");
            return sReturnPath;
        }

        public static bool CheckFileIsInUse(string sFileName)
        {
            bool result = false;
            try
            {
                FileStream fs = File.OpenWrite(sFileName);
                fs.Close();
            }
            catch (Exception)
            {
                result = true;
            }
            return result;
        }
    }
}
