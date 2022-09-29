using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;

namespace SampleProject.Utility
{
    public interface IUtilRepository : IDisposable
    {
         Bitmap ResizeImage(Stream streamImage, int resizeWidth, int resizeHeight);
    }
}