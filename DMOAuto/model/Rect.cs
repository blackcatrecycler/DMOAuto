using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMOAuto.model
{
    class Rect
    {
        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set; }
        public int height { get; set; }

        public Rect() { }
        public Rect(int x1,int y1,int width1,int height1)
        {
            x = x1;y = y1;width = width1;height = height1;
        }
    }
}
