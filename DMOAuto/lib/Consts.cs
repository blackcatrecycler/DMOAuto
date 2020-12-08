using DMOAuto.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMOAuto.lib
{
    class Consts
    {
        public static int WM_CHAR = 0x0102;
        public static int WM_KEYDOWN = 0x0100;
        public static int WM_KEYUP = 0x0101;

        public static uint WM_DU = 0xC0110001;
        public static uint WM_DD = 0x00110001;
        public static uint WM_DF = 0xC000000F;
        public static int WM_IMT_NOTIFY = 0x0282;
        public static int WM_IMT_SETCONTEXT = 0x0281;

       

        public static int WM_ACTIVATEAPP = 0x001C;
        public static int WM_ACTIVATE = 0x0006;
        public static int OPEN_WINDOWS = 2;
        public static int CLOSE_WINDOWS = 1;
        public static int I_SHOW = 1;
        public static int I_CLOSE = 0;

        public static Rectangle ALL_RECT = new Rectangle(0, 0, 1000, 200);
        public static Rectangle MONSTER_RECT = new Rectangle(930, 60, 40, 40);
        public static Rectangle OBJECT_RECT = new Rectangle(767, 107, 5, 5);

        public static Dictionary<String, int> KEY_CODE = new Dictionary<String, int>
        {
            { "W",119},
            { "S",115},
            { "A",97},
            { "D",100},
            { "Z",122},
            { "1",49},
            { "Enter",13},
            { "Tab",9}
        };

        public static Dictionary<String, int> KEY_VALUE = new Dictionary<String, int>
        {
            { "W",87},
            { "S",115-32},
            { "A",97-32},
            { "D",100-32},
            { "Z",90},
            { "1",49},
            { "Enter",13},
            { "Tab",9}
        };

    }
}
