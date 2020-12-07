using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMOAuto.lib
{
    class ImgTool
    {
        public static bool IsSame(Bitmap bt1,Bitmap bt2)
        {
            MemoryStream ms = new MemoryStream();
            bt1.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            String firstBitmap = Convert.ToBase64String(ms.ToArray());
            ms.Position = 0;

            bt2.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            String secondBitmap = Convert.ToBase64String(ms.ToArray());
            //mainForm.uPL(firstBitmap);
            //mainForm.uPL(secondBitmap);
            if (firstBitmap.Equals(secondBitmap))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool WhereDiff(Bitmap bt1,Bitmap bt2)
        {
            int r = -1;
            Size s = bt1.Size;
            for(int i = 0; i < s.Height; i++)
            {
                for (int j = 0; j < s.Width; j++)
                {
                    int a = bt1.GetPixel(i, j).ToArgb();
                    int b = bt2.GetPixel(i, j).ToArgb();
                    if (a != b) return false;//r = i * s.Width + j;
                }
            }
            return true;
        }
    }
}
