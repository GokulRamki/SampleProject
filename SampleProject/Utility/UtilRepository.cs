using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Drawing.Drawing2D;
using System.Text;
using System.Drawing.Imaging;


namespace SampleProject.Utility
{
    public class UtilRepository :IUtilRepository ,IDisposable
    {
        public Bitmap ResizeImage(Stream streamImage, int resizeWidth, int resizeHeight)
        {
            Image originalpic = Image.FromStream(streamImage);
            int height = resizeHeight, width = resizeWidth;
            int originalW = originalpic.Width, originalH = originalpic.Height;
            float percentW, percentH, percent;

            percentW = (float)resizeWidth / (float)originalW;
            percentH = (float)resizeHeight / (float)originalH;

            if(percentH < percentW)
            {
                percent = percentH;
                width = (int)(originalW * percent);
            }
            else
            {
                percent = percentW;
                height = (int)(originalH * percent);
            }

            Bitmap thumbnailBitmap = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            thumbnailBitmap.SetResolution(originalpic.HorizontalResolution, originalpic.VerticalResolution);
            using(Graphics g = Graphics.FromImage(thumbnailBitmap))
            {
                g.Clear(Color.White);
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(originalpic,
                    new Rectangle(0, 0, width, height),
                    new Rectangle(0, 0, originalW, originalH),
                    GraphicsUnit.Pixel);
            }
            return thumbnailBitmap;
        }
        #region Dispose Objects
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {

                }

            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}