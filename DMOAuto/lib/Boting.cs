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
        public MyConfig cfg = new MyConfig();
        public Bitmap monsterBt = null;
        public Bitmap monAttackBt = null;
        public Bitmap monPeaceBt = null;

        public static Boting botInstanse = null;

        public static Boting GetInstance()
        {
            if (botInstanse == null) botInstanse = new Boting();
            return botInstanse;
        }

        public Boting()
        {
            string path = System.Windows.Forms.Application.StartupPath;
            monPeaceBt = (Bitmap)Image.FromFile(path + "/checkp.bmp", false);
            monAttackBt = (Bitmap)Image.FromFile(path + "/checka.bmp", false);
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
            Thread t = new Thread(CheckALL);

            t.Start();
            while (cfg.state)
            {
                //ProcessHandler.SendKey(cfg.a);
                GoAttack();
                GoPick();
                //Thread.Sleep(1000);

            }
            ProcessHandler.AwakeWnd(false);
        }

        public void CheckALL()
        {
            ImgTask imk = null;
            imk += MatchHealth;
            imk += MatchMonster;
            while (cfg.state)
            {
                Bitmap bt = ProcessHandler.GetWindowImg();
                imk(bt);
                bt.Dispose();
                if (!cfg.monAlive) GoSwitch();
                //mainForm.uPL(cfg.monAlive.ToString());
                Thread.Sleep(500);

            }
        }

        public void SetBit(Bitmap bt)
        {
            monsterBt = bt;
        }

        public void MatchMonster(Bitmap bt)
        {
            if (cfg.monSelect && cfg.monAlive)
            {
                Bitmap bbt = bt.Clone(Consts.MONSTER_RECT, bt.PixelFormat);

                if (!ImgTool.MaxSame(bbt, monsterBt))
                {
                    cfg.monAlive = false;
                    //mainForm.uPL("不是目标怪物");
                }
                bbt.Dispose();
            }
        }
        public void MatchHealth(Bitmap bt)
        {
            Bitmap bbt = bt.Clone(Consts.OBJECT_RECT, bt.PixelFormat);

            if (ImgTool.WhereDiff(monAttackBt, bbt) || ImgTool.WhereDiff(monPeaceBt, bbt))
            {
                cfg.monAlive = true;
                //mainForm.uPL("是怪物");
            }
            else
            {
                cfg.monAlive = false;
                //mainForm.uPL("不是怪物");
            }
            bbt.Dispose();
        }

        public void GoAttack()
        {
            if (cfg.monAlive)
            {
                int a = -1, b = -1;
                Consts.KEY_CODE.TryGetValue("1", out a);
                Consts.KEY_VALUE.TryGetValue("1", out b);
                ProcessHandler.SendKey(a, b);
                Thread.Sleep(100);
            }
        }
        public void GoPick()
        {
            int a = -1, b = -1;
            Consts.KEY_CODE.TryGetValue("Z", out a);
            Consts.KEY_VALUE.TryGetValue("Z", out b);
            ProcessHandler.SendKey(a, b);
            Thread.Sleep(100);
        }
        public void GoSwitch()
        {
            int a = -1, b = -1;
            Consts.KEY_CODE.TryGetValue("Tab", out a);
            Consts.KEY_VALUE.TryGetValue("Tab", out b);
            ProcessHandler.SendKey(a, b);
            Thread.Sleep(100);
        }
    }
}
