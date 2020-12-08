using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMOAuto.model
{
    class MyConfig
    {
        public bool state { get; set; }
        public int a { get; set; }
        public bool monSelect { get; set; }
        public bool monAlive { get; set; }

        public MyConfig()
        {
            state = false;
            monSelect = false;
            monAlive = false;
            a = -1;
        }
    }
}
