using DMOAuto.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DMOAuto.lib
{
    public delegate void ImgTask(Bitmap bt); 

    class Boting
    {
        public MyConfig cfg=new MyConfig();
        public Bitmap monsterBt = null;

        public static Boting botInstanse=null;

        public static Boting GetInstance()
        {
            if (botInstanse == null) botInstanse = new Boting();
            return botInstanse;
        } 
        

        public void Start()
        {
            if (!cfg.state)
            {
                cfg.state = true;
                Thread t = new Thread(new ThreadStart(Go));
                t.IsBackground = true;
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
            Thread t = new Thread(check);
            
            t.Start();
            while (cfg.state)
            {
                //ProcessHandler.SendKey(cfg.a);

                Bitmap bt=ProcessHandler.GetWindowImg();
                bt.Dispose();
                Thread.Sleep(1000);

            }
            ProcessHandler.AwakeWnd(false);
            t.Abort();
        }

        public void check()
        {
            int a = 0;
            while (true)
            {
                a++;
                mainForm.uPL("Alive");
                Thread.Sleep(5000);
            }
        }

        public void setBit(Bitmap bt)
        {
            monsterBt = bt;
        }

        public void matchMonster(Bitmap bt)
        {
            
        }
    }
}
