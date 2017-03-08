/// <copyright from='2003'' to='2010' company='Bizsolution'>
///    Copyright(c) Bizsolution All rights reserved 
/// </copyright>                                                                
//*******************************************************************************/
//*      FileName: ImageClass.cs  
//*      Function: 处理图片类常用方法  
//*        Author:  
//*          Date: 2007-11-01  
//*      Modified: 
//*******************************************************************************/
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System;
using System.Collections;

namespace BasicFacility.ImageHandler
{
    /// <summary>    
    /// 图片处理类    
    /// 1、生成缩略图片或按照比例改变图片的大小和画质    
    /// 2、将生成的缩略图放到指定的目录下    
    /// </summary>    
    public class ImageProcessor
    {
        #region 字段
        public Image ResourceImage;
        private int ImageWidth;
        private int ImageHeight;
        public string ErrMessage;
        #region 合成图片使用的变量
        Graphics myGraphics = null;
        Bitmap bMain = null;
        int iEndWidth = 235;
        int iEndHeight = 140;
        static int siEndWidth = 235;
        static int siEndHeight = 140;
        ArrayList arrTemp = new ArrayList();
        private Image[] sSourceFiles;
        #endregion
        #endregion

        #region 属性

        #endregion

        #region 构造函数
        /// <summary>    
        /// 类的构造函数    
        /// </summary>    
        /// <param name="imageFileName">图片文件的全路径名称</param>    
        public ImageProcessor(string imageFileName)
        {
            ResourceImage = Image.FromFile(imageFileName);
            ErrMessage = "";
        }
        /// <summary>
        /// 构造函数2
        /// </summary>
        public ImageProcessor()
        {
            ErrMessage = "";
        }
        /// <summary>    
        /// 类的构造函数    
        /// </summary>    
        /// <param name="ImageFileName">图片文件的全路径名称</param>    
        public ImageProcessor(Image[] imagesName)
        {
            sSourceFiles = imagesName;
            ErrMessage = "";
        }
        #endregion

        #region 方法

        #region 对图片的基本处理
        public static bool ThumbnailCallback()
        {
            return false;
        }

        ///#################################################################################
        /// <summary>
        /// 根据给定的Frame进行等比例缩放
        /// Coder:Ryo wu 2007-08-22
        /// </summary>
        /// <param name="frameWidth">框架宽度</param>
        /// <param name="frameHeight">框架高度</param>
        /// <returns>缩略图image对象</returns>
        ///#################################################################################
        public Image GetReducedImage(int frameWidth, int frameHeight)
        {
            double dPercent = 1;
            double dFrameWidth = Convert.ToDouble(frameWidth);
            double dFrameHeight = Convert.ToDouble(frameHeight);
            double dSourceWidth = Convert.ToDouble(ResourceImage.Width);
            double dSourceHeight = Convert.ToDouble(ResourceImage.Height);
            double a1 = dSourceWidth / dSourceHeight;
            double a2 = dFrameWidth / dFrameHeight;
            if (Math.Min(dSourceWidth, dSourceHeight) > Math.Max(dFrameWidth, dFrameHeight))
            {
                if (a1 >= a2)
                {
                    dPercent = Math.Max(dSourceWidth, dSourceHeight) / Math.Max(dFrameWidth, dFrameHeight);
                }
                else
                {
                    dPercent = Math.Min(dSourceWidth, dSourceHeight) / Math.Min(dFrameWidth, dFrameHeight);
                }
            }
            return GetReducedImage(1 / dPercent);
        }

        ///#################################################################################
        /// <summary>
        /// 根据给定的Frame进行等比例缩放
        /// Coder:Ryo wu 2007-08-22
        /// </summary>
        /// <param name="frameWidth">框架宽度</param>
        /// <param name="frameHeight">框架高度</param>
        /// <param name="img"></param>
        /// <returns>缩略图image对象</returns>
        ///#################################################################################
        public Image GetReducedImage(int frameWidth, int frameHeight, Image img)
        {
            if (img == null)
                return null;
            double dPercent = 1;
            double dFrameWidth = Convert.ToDouble(frameWidth);
            double dFrameHeight = Convert.ToDouble(frameHeight);
            double dSourceWidth = Convert.ToDouble(img.Width);
            double dSourceHeight = Convert.ToDouble(img.Height);
            double a1 = dSourceWidth / dSourceHeight;
            double a2 = dFrameWidth / dFrameHeight;
            if (Math.Min(dSourceWidth, dSourceHeight) > Math.Max(dFrameWidth, dFrameHeight))
            {
                if (a1 >= a2)
                {
                    dPercent = Math.Max(dSourceWidth, dSourceHeight) / Math.Max(dFrameWidth, dFrameHeight);
                }
                else
                {
                    dPercent = Math.Min(dSourceWidth, dSourceHeight) / Math.Min(dFrameWidth, dFrameHeight);
                }
            }

            return GetReducedImage(1 / dPercent, img);
        }

        ///#################################################################################
        /// <summary>
        /// 根据给定的Frame进行等比例缩放,并保存
        /// Coder:Ryo wu 2007-08-22
        /// </summary>
        /// <param name="frameWidth">框架宽度</param>
        /// <param name="frameHeight">框架高度</param>
        /// <param name="filePath"></param>
        /// <returns>缩略图image对象</returns>
        ///#################################################################################
        public bool GetReducedImage(int frameWidth, int frameHeight, string filePath)
        {
            double dPercent = 1;
            double dFrameWidth = Convert.ToDouble(frameWidth);
            double dFrameHeight = Convert.ToDouble(frameHeight);
            double dSourceWidth = Convert.ToDouble(ResourceImage.Width);
            double dSourceHeight = Convert.ToDouble(ResourceImage.Height);
            double a1 = dSourceWidth / dSourceHeight;
            double a2 = dFrameWidth / dFrameHeight;
            if (Math.Min(dSourceWidth, dSourceHeight) > Math.Max(dFrameWidth, dFrameHeight))
            {
                if (a1 >= a2)
                {
                    dPercent = Math.Max(dSourceWidth, dSourceHeight) / Math.Max(dFrameWidth, dFrameHeight);
                }
                else
                {
                    dPercent = Math.Min(dSourceWidth, dSourceHeight) / Math.Min(dFrameWidth, dFrameHeight);
                }
            }
            return GetReducedImage(1 / dPercent, filePath);
        }

        ///#################################################################################
        /// <summary>    
        /// 生成缩略图重载方法3，返回缩略图的Image对象    
        /// </summary>    
        /// <param name="percent">缩略图的宽度百分比 如：需要百分之80，就填0.8</param>      
        /// <returns>缩略图的Image对象</returns>    
        ///#################################################################################
        public Image GetReducedImage(double percent)
        {
            try
            {
                var callb = new Image.GetThumbnailImageAbort(ThumbnailCallback);

                ImageWidth = Convert.ToInt32(ResourceImage.Width * percent);
                ImageHeight = Convert.ToInt32(ResourceImage.Height * percent);

                Image reducedImage = ResourceImage.GetThumbnailImage(ImageWidth, ImageHeight, callb, IntPtr.Zero);

                return reducedImage;
            }
            catch (Exception e)
            {
                ErrMessage = e.Message;
                return null;
            }
        }

        ///#################################################################################
        /// <summary>    
        /// 生成缩略图重载方法3，返回缩略图的Image对象    
        /// </summary>    
        /// <param name="percent">缩略图的宽度百分比 如：需要百分之80，就填0.8</param>      
        /// <param name="iReducedImage"></param>
        /// <returns>缩略图的Image对象</returns>  
        ///#################################################################################  
        public static Image GetReducedImage(double percent, Image iReducedImage)
        {
            try
            {
                if (iReducedImage == null)
                    return null;
                var callb = new Image.GetThumbnailImageAbort(ThumbnailCallback);
                int imageWidth = Convert.ToInt32(iReducedImage.Width * percent);
                int imageHeight = Convert.ToInt32(iReducedImage.Height * percent);
                iReducedImage = iReducedImage.GetThumbnailImage(imageWidth, imageHeight, callb, IntPtr.Zero);
                return iReducedImage;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        ///#################################################################################
        /// <summary>    
        /// 生成缩略图重载方法4，返回缩略图的Image对象    
        /// </summary>    
        /// <param name="percent">缩略图的宽度百分比 如：需要百分之80，就填0.8</param>      
        /// <param name="targetFilePath">缩略图保存的全文件名，(带路径)，参数格式：D:Images ilename.jpg</param>    
        /// <returns>成功返回true,否则返回false</returns> 
        ///#################################################################################   
        public bool GetReducedImage(double percent, string targetFilePath)
        {
            try
            {
                var callb = new Image.GetThumbnailImageAbort(ThumbnailCallback);

                ImageWidth = Convert.ToInt32(ResourceImage.Width * percent);
                ImageHeight = Convert.ToInt32(ResourceImage.Height * percent);

                Image reducedImage = ResourceImage.GetThumbnailImage(ImageWidth, ImageHeight, callb, IntPtr.Zero);

                reducedImage.Save(@targetFilePath, ImageFormat.Jpeg);

                reducedImage.Dispose();

                return true;
            }
            catch (Exception e)
            {
                ErrMessage = e.Message;
                return false;
            }
        }

        ///#################################################################################
        /// <summary>   
        /// 将byte[]转换为Image   
        /// Coder:Ryo wu 2007-08-22
        /// </summary>   
        /// <param name="bytes">字节数组</param>   
        /// <returns>Image</returns>
        ///#################################################################################
        public static Image ReadImage(byte[] bytes)
        {
            if (bytes == null)
                return null;
            var ms = new MemoryStream(bytes, 0, bytes.Length);
            return Image.FromStream(ms);
        }

        ///#################################################################################
        /// <summary>   
        /// 将文件转换为Image   
        /// Coder:Ryo wu 2007-08-22
        /// </summary>   
        /// <param name="sFilePath">文件路径</param>   
        /// <returns>Image</returns>
        ///#################################################################################
        public static Image ReadImageFromFile(string sFilePath)
        {
            Bitmap bitmap;
            using (var f = new FileStream(sFilePath, FileMode.Open, FileAccess.Read))
            {
                var byteImg = new byte[f.Length];
                f.Read(byteImg, 0, Convert.ToInt32(f.Length));
                var m = new MemoryStream(byteImg);
                bitmap = new Bitmap(m, false);
            }
            return bitmap;
        }

        ///#################################################################################
        /// <summary>   
        /// 将文件转换为byte[] 
        /// Coder:Ryo wu 2007-08-22
        /// </summary>   
        /// <param name="sFilePath">文件路径</param>   
        /// <returns>Image</returns>
        ///#################################################################################
        public static byte[] ReadImageByte(string sFilePath)
        {
            byte[] byteImg;
            using (var f = new FileStream(sFilePath, FileMode.Open, FileAccess.Read))
            {
                byteImg = new byte[f.Length];
                f.Read(byteImg, 0, Convert.ToInt32(f.Length));
            }
            return byteImg;
        }

        ///#################################################################################
        /// <summary>
        /// 将Image转换为byte[]
        /// Coder:Ryo wu 2007-08-22
        /// </summary>
        /// <param name="image">Image</param>
        /// <returns>byte[]</returns>
        ///#################################################################################
        public static byte[] ConvertImage(Image image)
        {
            if (image == null)
                return null;
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\IPSTemp\\" +
                              Guid.NewGuid();
            image.Save(filePath);
            return File.ReadAllBytes(filePath);
        }

        /// <summary>
        /// 获取定制大小的图片
        /// Coder: Jackie, 2009-11-11
        /// </summary>
        /// <param name="imgOrig"></param>
        /// <param name="newW"></param>
        /// <param name="newH"></param>
        /// <returns></returns>
        public static Image GetCustomizedSizeImage(Image imgOrig, int newW, int newH)
        {
            try
            {
                Bitmap bmp = (Bitmap)imgOrig.Clone();
                Bitmap bmpNew = new Bitmap(newW, newH);
                Graphics g = Graphics.FromImage(bmpNew);
                // 插值质量
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(bmp, new System.Drawing.Rectangle(0, 0, newW, newH), new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height), GraphicsUnit.Pixel);
                g.Dispose();
                return bmpNew;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 合成图片
        ///#################################################################################
        /// <summary>
        /// 获取按比例缩放后的图片起始位置
        /// Coder: Dingweibo (2008-01-25)
        /// </summary>
        /// <param name="iWidth">图片宽度</param>
        /// <param name="iHeight">图片高度</param>
        /// <returns></returns>
        ///#################################################################################
        private Rectangle GetAotuSize(int iWidth, int iHeight)
        {
            var expansionRectangle = new Rectangle(0, 0, iWidth, iHeight);
            //宽度的比例大于高度的比例
            double fWidthBit = (double)iEndWidth / (double)iWidth;
            double fHeightBit = (double)iEndHeight / (double)iHeight;

            if (fWidthBit < fHeightBit)
            {
                int y = Convert.ToInt32((iEndHeight - (fWidthBit) * iHeight) / 2);
                expansionRectangle = new Rectangle(0, y, Convert.ToInt32((fWidthBit) * iWidth), Convert.ToInt32((fWidthBit) * iHeight));
            }
            else if (fWidthBit > fHeightBit)
            {
                int x = Convert.ToInt32((iEndWidth - (fHeightBit) * iWidth) / 2);
                expansionRectangle = new Rectangle(x, 0, Convert.ToInt32((fHeightBit) * iWidth), Convert.ToInt32((fHeightBit) * iHeight));
            }
            return expansionRectangle;
        }
        ///#################################################################################
        /// <summary>
        /// 创建一个画布
        /// Coder: Dingweibo (2008-01-25)
        /// </summary>
        /// <param name="iWidth">宽度</param>
        /// <param name="iHeight">高度</param>
        ///#################################################################################
        private void CreateBitmap(int iWidth, int iHeight)
        {
            bMain = new Bitmap(iWidth, iHeight);
        }
        ///#################################################################################
        /// <summary>
        /// 获取最大数
        /// Coder: Dingweibo (2008-01-25)
        /// </summary>
        /// <param name="iArrValue">需要获取的数组</param>
        /// <returns>输入数组中的最大数值</returns>
        ///#################################################################################
        private static int GetMaxValue(int[] iArrValue)
        {
            int iMax = 0;
            foreach (int iValue in iArrValue)
            {
                if (iValue > iMax)
                {
                    iMax = iValue;
                }
            }
            return iMax;
        }
        ///#################################################################################
        /// <summary>
        /// 合成原始大小的图片
        /// Coder: Dingweibo (2008-01-25)
        /// </summary>
        /// <param name="arrObject">Bitmap的对象实例集合</param>
        /// <param name="cBackground"></param>
        /// <param name="iMapWidth"></param>
        /// <param name="iMapHeight"></param>
        ///#################################################################################
        private Bitmap CombineOriginMap(ArrayList arrObject, int[] iMapWidth, int[] iMapHeight)
        {
            //if (arrObject.Count < 1)
            //    return ;
            #region 将多幅图片合成为一张图片，高度取最大，宽度依次相加
            //获取最大高度
            int iMaxHeight = GetMaxValue(iMapHeight);
            //创建画布
            int iTotalWidth = 0;
            foreach (int itemp in iMapWidth)
            {
                iTotalWidth += itemp;
            }
            CreateBitmap(iTotalWidth, iMaxHeight);
            myGraphics = Graphics.FromImage(bMain);

            int iAddWidth = 0;
            for (int i = 0; i < arrObject.Count; i++)
            {
                Bitmap btmTemp = (Bitmap)arrTemp[i];
                myGraphics.DrawImage(btmTemp, (float)iAddWidth, ((float)iMaxHeight - (float)btmTemp.Height) / 2, (float)btmTemp.Width, (float)btmTemp.Height);
                iAddWidth += btmTemp.Width;
            }
            //bMain.Dispose();
            return bMain;
            #endregion
        }
        ///#################################################################################
        /// <summary>
        /// 合成图片
        /// </summary>
        /// <returns></returns>
        ///#################################################################################
        public Image CombinePicture()
        {
            Bitmap btmTemp = null;
            //判断如果图片是否为空
            if (sSourceFiles == null)
            {
                return btmTemp;
            }
            foreach (Image sImage in sSourceFiles)
            {
                if (sImage != null)
                {
                    btmTemp = new Bitmap(sImage);
                    arrTemp.Add(btmTemp);
                }
            }
            if (arrTemp.Count < 1)
            {
                return btmTemp;
            }
            //保存多个Bitmap对象的宽和高度
            int[] iMapWidth = new int[arrTemp.Count];
            int[] iMapHeight = new int[arrTemp.Count];

            for (int i = 0; i < arrTemp.Count; i++)
            {
                btmTemp = (Bitmap)arrTemp[i];
                iMapWidth[i] = btmTemp.Width;
                iMapHeight[i] = btmTemp.Height;
            }

            //获取颜色
            btmTemp = (Bitmap)arrTemp[0];

            Bitmap iOrigion = CombineOriginMap(arrTemp, iMapWidth, iMapHeight);

            #region 将图片按比例缩放后填充给定的规格
            //定义新画布
            CreateBitmap(iEndWidth, iEndHeight);
            myGraphics = Graphics.FromImage(bMain);

            Rectangle autoRectangle = GetAotuSize(iOrigion.Width, iOrigion.Height);
            //填充图片到一定规格中
            myGraphics.DrawImage(iOrigion, autoRectangle);
            bMain.Dispose();
            #endregion

            //释放资源
            btmTemp.Dispose();
            myGraphics.Dispose();

            return iOrigion;
        }

        ///#################################################################################
        /// <summary>
        ///创建临时目录
        /// Coder: Saint    (2008-02-26)
        /// </summary>
        ///#################################################################################
        public bool CreateDirectory(string sPath)
        {
            bool bRetVal = true;
            try
            {
                if (Directory.Exists(sPath))
                {
                    Directory.Delete(sPath, true);
                }
                Directory.CreateDirectory(sPath);

            }
            catch (Exception)
            {
                bRetVal = false;
            }

            return bRetVal;
        }

        ///#################################################################################
        /// <summary>
        ///保存图片到本地
        /// Coder: Saint    (2008-02-26)
        /// </summary>
        ///#################################################################################
        public void SaveImage(Image img, string sPath, string sImageName)
        {
            try
            {
                if (img == null)
                    return;
                img.Save(string.Format(@"{0}\{1}", sPath, sImageName));
            }
            catch (Exception)
            { }
        }

        ///#################################################################################
        /// <summary>
        ///保存图片到本地
        /// Coder: Saint    (2008-02-26)
        /// </summary>
        ///#################################################################################
        public void SaveImageInGif(Image img, string sPath, string sImageName)
        {
            try
            {
                if (img == null)
                    return;
                img.Save(sPath + @"\" + sImageName, ImageFormat.Gif);
            }
            catch (Exception)
            { }
        }
        #endregion

        #endregion

        #region 静态方法
        ///#################################################################################
        /// <summary>
        /// 合成图片
        /// </summary>
        /// <returns></returns>
        ///#################################################################################
        public static Image sCombinePicture(Image[] sSourceFiles)
        {

            Image btmTemp = null;
            //Image imgTemp = null;
            Graphics myGraphics = null;
            int iLength = sSourceFiles.Length;
            //Bitmap bMain = null;
            Bitmap bMain = null;

            //判断如果图片是否为空
            if (sSourceFiles == null)
            {
                return btmTemp;
            }
            for (int i = 0; i < sSourceFiles.Length; i++)
            {
                if (sSourceFiles[i] == null)
                {
                    iLength--;
                }
            }
            if (iLength < 1)
            {
                return btmTemp;
            }

            Image[] arrTemp = new Image[iLength];
            for (int i = 0; i < iLength; i++)
            {
                if (sSourceFiles[i] != null)
                {
                    arrTemp[i] = sSourceFiles[i];
                }
            }

            //保存多个Bitmap对象的宽和高度
            int[] iMapWidth = new int[arrTemp.Length];
            int[] iMapHeight = new int[arrTemp.Length];

            for (int i = 0; i < arrTemp.Length; i++)
            {
                iMapWidth[i] = arrTemp[i].Width;
                iMapHeight[i] = arrTemp[i].Height;
            }

            //获取颜色
            btmTemp = arrTemp[0];

            Image iOrigion = sCombineOriginMap(arrTemp, iMapWidth, iMapHeight);

            #region 将图片按比例缩放后填充给定的规格
            //定义新画布
            bMain = new Bitmap(siEndWidth, siEndHeight);
            myGraphics = Graphics.FromImage(bMain);

            Rectangle autoRectangle = sGetAotuSize(iOrigion.Width, iOrigion.Height);
            //填充图片到一定规格中
            myGraphics.DrawImage(iOrigion, autoRectangle);
            iOrigion.Dispose();
            #endregion

            //释放资源
            btmTemp.Dispose();
            myGraphics.Dispose();

            return bMain;
        }


        ///#################################################################################
        /// <summary>
        /// 合成原始大小的图片
        /// Coder: Dingweibo (2008-01-25)
        /// </summary>
        /// <param name="arrObject">Bitmap的对象实例集合</param>
        ///#################################################################################
        private static Image sCombineOriginMap(Image[] arrObject, int[] iMapWidth, int[] iMapHeight)
        {
            //if (arrObject.Count < 1)
            //    return ;
            Image bMain = null;
            Graphics myGraphics = null;
            #region 将多幅图片合成为一张图片，高度取最大，宽度依次相加
            //获取最大高度
            int iMaxHeight = sGetMaxValue(iMapHeight);
            //创建画布
            int iTotalWidth = 0;
            foreach (int itemp in iMapWidth)
            {
                iTotalWidth += itemp;
            }
            bMain = new System.Drawing.Bitmap(iTotalWidth, iMaxHeight);
            myGraphics = Graphics.FromImage(bMain);


            int iAddWidth = 0;
            for (int i = 0; i < arrObject.Length; i++)
            {
                myGraphics.DrawImage(arrObject[i], (float)iAddWidth, ((float)iMaxHeight - (float)arrObject[i].Height) / 2, (float)arrObject[i].Width, (float)arrObject[i].Height);
                iAddWidth += arrObject[i].Width;
            }
            //bMain.Dispose();
            return bMain;
            #endregion
        }


        ///#################################################################################
        /// <summary>
        /// 获取按比例缩放后的图片起始位置
        /// Coder: Dingweibo (2008-01-25)
        /// </summary>
        /// <param name="iWidth">图片宽度</param>
        /// <param name="iHeight">图片高度</param>
        /// <returns></returns>
        ///#################################################################################
        private static Rectangle sGetAotuSize(int iWidth, int iHeight)
        {

            Rectangle expansionRectangle = new Rectangle(0, 0, iWidth, iHeight);
            //宽度的比例大于高度的比例
            double fWidthBit = (double)siEndWidth / (double)iWidth;
            double fHeightBit = (double)siEndHeight / (double)iHeight;

            if (fWidthBit < fHeightBit)
            {
                int y = Convert.ToInt32((siEndHeight - (fWidthBit) * iHeight) / 2);
                expansionRectangle = new Rectangle(0, y, Convert.ToInt32((fWidthBit) * iWidth), Convert.ToInt32((fWidthBit) * iHeight));
            }
            else if (fWidthBit > fHeightBit)
            {
                int x = Convert.ToInt32((siEndWidth - (fHeightBit) * iWidth) / 2);
                expansionRectangle = new Rectangle(x, 0, Convert.ToInt32((fHeightBit) * iWidth), Convert.ToInt32((fHeightBit) * iHeight));
            }
            return expansionRectangle;
        }


        ///#################################################################################
        /// <summary>
        /// 获取最大数
        /// Coder: Dingweibo (2008-01-25)
        /// </summary>
        /// <param name="iArrValue">需要获取的数组</param>
        /// <returns>输入数组中的最大数值</returns>
        ///#################################################################################
        private static int sGetMaxValue(int[] iArrValue)
        {
            int iMax = 0;
            foreach (int iValue in iArrValue)
            {
                if (iValue > iMax)
                {
                    iMax = iValue;
                }
            }
            return iMax;
        }

        ///#################################################################################
        /// <summary>
        /// 截取美国首页图片
        /// Coder: Kevin Wang (2008-03-06)
        /// </summary>
        /// <param name="sSourceFiles">原始图片数组。仅使用第一个元素</param>
        /// <returns>截取后的图片</returns>
        ///#################################################################################
        public static Image sCutUSImage(Image[] sSourceFiles)
        {
            if (sSourceFiles[0] == null)
            {
                return null;
            }

            Image imgOriginal = sSourceFiles[0];

            // One hand of the runner
            int iStartX = imgOriginal.Width / 20 * 3;
            int iNewWidth = imgOriginal.Width / 20 * 14;

            int iStartY = imgOriginal.Height / 20 * 11;
            int iNewHeight = imgOriginal.Height / 20 * 8;

            //Ioriginal.Save(@"C:\ao.jpg");//debug
            Bitmap myBitmap = new System.Drawing.Bitmap(siEndWidth, siEndHeight);   //定义画布

            //定义截取区域
            Rectangle sourceRectangle = new Rectangle(iStartX, iStartY, iNewWidth, iNewHeight);

            //缩小后的区域
            Rectangle destRectangle1 = new Rectangle(0, 0, siEndWidth, siEndHeight);

            Graphics myGraphics = Graphics.FromImage(myBitmap);

            myGraphics.DrawImage(
                imgOriginal, destRectangle1, sourceRectangle, GraphicsUnit.Pixel);

            imgOriginal.Dispose();
            myGraphics.Dispose();
            return myBitmap;

        }
        ///#################################################################################
        /// <summary>
        /// 获取缩略图的缩小比例。使得缩略图不大于10k
        /// Coder: Kevin Wang (2008-03-29)
        /// </summary>
        /// <param name="sCopyedPic">原始图片</param>
        /// <returns>缩小的比例</returns>
        ///#################################################################################
        public static double GetThumPercent(string sCopyedPic)
        {
            double dPercentage = 1.0;
            var fPic = new FileInfo(sCopyedPic);
            if (fPic.Length > 10240)
            {
                dPercentage = 10240.0 / fPic.Length;
            }
            return dPercentage;
        }


        #endregion
    }
}