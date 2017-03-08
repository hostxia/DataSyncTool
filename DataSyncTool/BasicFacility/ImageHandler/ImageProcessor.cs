/// <copyright from='2003'' to='2010' company='Bizsolution'>
///    Copyright(c) Bizsolution All rights reserved 
/// </copyright>                                                                
//*******************************************************************************/
//*      FileName: ImageClass.cs  
//*      Function: ����ͼƬ�ೣ�÷���  
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
    /// ͼƬ������    
    /// 1����������ͼƬ���ձ����ı�ͼƬ�Ĵ�С�ͻ���    
    /// 2�������ɵ�����ͼ�ŵ�ָ����Ŀ¼��    
    /// </summary>    
    public class ImageProcessor
    {
        #region �ֶ�
        public Image ResourceImage;
        private int ImageWidth;
        private int ImageHeight;
        public string ErrMessage;
        #region �ϳ�ͼƬʹ�õı���
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

        #region ����

        #endregion

        #region ���캯��
        /// <summary>    
        /// ��Ĺ��캯��    
        /// </summary>    
        /// <param name="imageFileName">ͼƬ�ļ���ȫ·������</param>    
        public ImageProcessor(string imageFileName)
        {
            ResourceImage = Image.FromFile(imageFileName);
            ErrMessage = "";
        }
        /// <summary>
        /// ���캯��2
        /// </summary>
        public ImageProcessor()
        {
            ErrMessage = "";
        }
        /// <summary>    
        /// ��Ĺ��캯��    
        /// </summary>    
        /// <param name="ImageFileName">ͼƬ�ļ���ȫ·������</param>    
        public ImageProcessor(Image[] imagesName)
        {
            sSourceFiles = imagesName;
            ErrMessage = "";
        }
        #endregion

        #region ����

        #region ��ͼƬ�Ļ�������
        public static bool ThumbnailCallback()
        {
            return false;
        }

        ///#################################################################################
        /// <summary>
        /// ���ݸ�����Frame���еȱ�������
        /// Coder:Ryo wu 2007-08-22
        /// </summary>
        /// <param name="frameWidth">��ܿ��</param>
        /// <param name="frameHeight">��ܸ߶�</param>
        /// <returns>����ͼimage����</returns>
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
        /// ���ݸ�����Frame���еȱ�������
        /// Coder:Ryo wu 2007-08-22
        /// </summary>
        /// <param name="frameWidth">��ܿ��</param>
        /// <param name="frameHeight">��ܸ߶�</param>
        /// <param name="img"></param>
        /// <returns>����ͼimage����</returns>
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
        /// ���ݸ�����Frame���еȱ�������,������
        /// Coder:Ryo wu 2007-08-22
        /// </summary>
        /// <param name="frameWidth">��ܿ��</param>
        /// <param name="frameHeight">��ܸ߶�</param>
        /// <param name="filePath"></param>
        /// <returns>����ͼimage����</returns>
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
        /// ��������ͼ���ط���3����������ͼ��Image����    
        /// </summary>    
        /// <param name="percent">����ͼ�Ŀ�Ȱٷֱ� �磺��Ҫ�ٷ�֮80������0.8</param>      
        /// <returns>����ͼ��Image����</returns>    
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
        /// ��������ͼ���ط���3����������ͼ��Image����    
        /// </summary>    
        /// <param name="percent">����ͼ�Ŀ�Ȱٷֱ� �磺��Ҫ�ٷ�֮80������0.8</param>      
        /// <param name="iReducedImage"></param>
        /// <returns>����ͼ��Image����</returns>  
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
        /// ��������ͼ���ط���4����������ͼ��Image����    
        /// </summary>    
        /// <param name="percent">����ͼ�Ŀ�Ȱٷֱ� �磺��Ҫ�ٷ�֮80������0.8</param>      
        /// <param name="targetFilePath">����ͼ�����ȫ�ļ�����(��·��)��������ʽ��D:Images ilename.jpg</param>    
        /// <returns>�ɹ�����true,���򷵻�false</returns> 
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
        /// ��byte[]ת��ΪImage   
        /// Coder:Ryo wu 2007-08-22
        /// </summary>   
        /// <param name="bytes">�ֽ�����</param>   
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
        /// ���ļ�ת��ΪImage   
        /// Coder:Ryo wu 2007-08-22
        /// </summary>   
        /// <param name="sFilePath">�ļ�·��</param>   
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
        /// ���ļ�ת��Ϊbyte[] 
        /// Coder:Ryo wu 2007-08-22
        /// </summary>   
        /// <param name="sFilePath">�ļ�·��</param>   
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
        /// ��Imageת��Ϊbyte[]
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
        /// ��ȡ���ƴ�С��ͼƬ
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
                // ��ֵ����
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

        #region �ϳ�ͼƬ
        ///#################################################################################
        /// <summary>
        /// ��ȡ���������ź��ͼƬ��ʼλ��
        /// Coder: Dingweibo (2008-01-25)
        /// </summary>
        /// <param name="iWidth">ͼƬ���</param>
        /// <param name="iHeight">ͼƬ�߶�</param>
        /// <returns></returns>
        ///#################################################################################
        private Rectangle GetAotuSize(int iWidth, int iHeight)
        {
            var expansionRectangle = new Rectangle(0, 0, iWidth, iHeight);
            //��ȵı������ڸ߶ȵı���
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
        /// ����һ������
        /// Coder: Dingweibo (2008-01-25)
        /// </summary>
        /// <param name="iWidth">���</param>
        /// <param name="iHeight">�߶�</param>
        ///#################################################################################
        private void CreateBitmap(int iWidth, int iHeight)
        {
            bMain = new Bitmap(iWidth, iHeight);
        }
        ///#################################################################################
        /// <summary>
        /// ��ȡ�����
        /// Coder: Dingweibo (2008-01-25)
        /// </summary>
        /// <param name="iArrValue">��Ҫ��ȡ������</param>
        /// <returns>���������е������ֵ</returns>
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
        /// �ϳ�ԭʼ��С��ͼƬ
        /// Coder: Dingweibo (2008-01-25)
        /// </summary>
        /// <param name="arrObject">Bitmap�Ķ���ʵ������</param>
        /// <param name="cBackground"></param>
        /// <param name="iMapWidth"></param>
        /// <param name="iMapHeight"></param>
        ///#################################################################################
        private Bitmap CombineOriginMap(ArrayList arrObject, int[] iMapWidth, int[] iMapHeight)
        {
            //if (arrObject.Count < 1)
            //    return ;
            #region �����ͼƬ�ϳ�Ϊһ��ͼƬ���߶�ȡ��󣬿���������
            //��ȡ���߶�
            int iMaxHeight = GetMaxValue(iMapHeight);
            //��������
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
        /// �ϳ�ͼƬ
        /// </summary>
        /// <returns></returns>
        ///#################################################################################
        public Image CombinePicture()
        {
            Bitmap btmTemp = null;
            //�ж����ͼƬ�Ƿ�Ϊ��
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
            //������Bitmap����Ŀ�͸߶�
            int[] iMapWidth = new int[arrTemp.Count];
            int[] iMapHeight = new int[arrTemp.Count];

            for (int i = 0; i < arrTemp.Count; i++)
            {
                btmTemp = (Bitmap)arrTemp[i];
                iMapWidth[i] = btmTemp.Width;
                iMapHeight[i] = btmTemp.Height;
            }

            //��ȡ��ɫ
            btmTemp = (Bitmap)arrTemp[0];

            Bitmap iOrigion = CombineOriginMap(arrTemp, iMapWidth, iMapHeight);

            #region ��ͼƬ���������ź��������Ĺ��
            //�����»���
            CreateBitmap(iEndWidth, iEndHeight);
            myGraphics = Graphics.FromImage(bMain);

            Rectangle autoRectangle = GetAotuSize(iOrigion.Width, iOrigion.Height);
            //���ͼƬ��һ�������
            myGraphics.DrawImage(iOrigion, autoRectangle);
            bMain.Dispose();
            #endregion

            //�ͷ���Դ
            btmTemp.Dispose();
            myGraphics.Dispose();

            return iOrigion;
        }

        ///#################################################################################
        /// <summary>
        ///������ʱĿ¼
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
        ///����ͼƬ������
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
        ///����ͼƬ������
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

        #region ��̬����
        ///#################################################################################
        /// <summary>
        /// �ϳ�ͼƬ
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

            //�ж����ͼƬ�Ƿ�Ϊ��
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

            //������Bitmap����Ŀ�͸߶�
            int[] iMapWidth = new int[arrTemp.Length];
            int[] iMapHeight = new int[arrTemp.Length];

            for (int i = 0; i < arrTemp.Length; i++)
            {
                iMapWidth[i] = arrTemp[i].Width;
                iMapHeight[i] = arrTemp[i].Height;
            }

            //��ȡ��ɫ
            btmTemp = arrTemp[0];

            Image iOrigion = sCombineOriginMap(arrTemp, iMapWidth, iMapHeight);

            #region ��ͼƬ���������ź��������Ĺ��
            //�����»���
            bMain = new Bitmap(siEndWidth, siEndHeight);
            myGraphics = Graphics.FromImage(bMain);

            Rectangle autoRectangle = sGetAotuSize(iOrigion.Width, iOrigion.Height);
            //���ͼƬ��һ�������
            myGraphics.DrawImage(iOrigion, autoRectangle);
            iOrigion.Dispose();
            #endregion

            //�ͷ���Դ
            btmTemp.Dispose();
            myGraphics.Dispose();

            return bMain;
        }


        ///#################################################################################
        /// <summary>
        /// �ϳ�ԭʼ��С��ͼƬ
        /// Coder: Dingweibo (2008-01-25)
        /// </summary>
        /// <param name="arrObject">Bitmap�Ķ���ʵ������</param>
        ///#################################################################################
        private static Image sCombineOriginMap(Image[] arrObject, int[] iMapWidth, int[] iMapHeight)
        {
            //if (arrObject.Count < 1)
            //    return ;
            Image bMain = null;
            Graphics myGraphics = null;
            #region �����ͼƬ�ϳ�Ϊһ��ͼƬ���߶�ȡ��󣬿���������
            //��ȡ���߶�
            int iMaxHeight = sGetMaxValue(iMapHeight);
            //��������
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
        /// ��ȡ���������ź��ͼƬ��ʼλ��
        /// Coder: Dingweibo (2008-01-25)
        /// </summary>
        /// <param name="iWidth">ͼƬ���</param>
        /// <param name="iHeight">ͼƬ�߶�</param>
        /// <returns></returns>
        ///#################################################################################
        private static Rectangle sGetAotuSize(int iWidth, int iHeight)
        {

            Rectangle expansionRectangle = new Rectangle(0, 0, iWidth, iHeight);
            //��ȵı������ڸ߶ȵı���
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
        /// ��ȡ�����
        /// Coder: Dingweibo (2008-01-25)
        /// </summary>
        /// <param name="iArrValue">��Ҫ��ȡ������</param>
        /// <returns>���������е������ֵ</returns>
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
        /// ��ȡ������ҳͼƬ
        /// Coder: Kevin Wang (2008-03-06)
        /// </summary>
        /// <param name="sSourceFiles">ԭʼͼƬ���顣��ʹ�õ�һ��Ԫ��</param>
        /// <returns>��ȡ���ͼƬ</returns>
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
            Bitmap myBitmap = new System.Drawing.Bitmap(siEndWidth, siEndHeight);   //���廭��

            //�����ȡ����
            Rectangle sourceRectangle = new Rectangle(iStartX, iStartY, iNewWidth, iNewHeight);

            //��С�������
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
        /// ��ȡ����ͼ����С������ʹ������ͼ������10k
        /// Coder: Kevin Wang (2008-03-29)
        /// </summary>
        /// <param name="sCopyedPic">ԭʼͼƬ</param>
        /// <returns>��С�ı���</returns>
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