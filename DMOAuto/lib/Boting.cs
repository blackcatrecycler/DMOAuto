using DMOAuto.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DMOAuto.lib
{
    class Boting
    {
        public MyConfig cfg=new MyConfig();

        

        public void Start()
        {
            if (!cfg.state)
            {
                cfg.state = true;
                Thread t = new Thread(new ThreadStart(Go));
                t.Start();
            }
            else
            {
                mainForm.gogogo("bot already starting!");
            }
        }

        private void Go()
        {
            ProcessHandler.AwakeWnd(true);
            Thread.Sleep(800);
            while (cfg.state)
            {
                ProcessHandler.SendKey(cfg.a);
                Thread.Sleep(100);

            }
            ProcessHandler.AwakeWnd(false);
        }
    }
}
