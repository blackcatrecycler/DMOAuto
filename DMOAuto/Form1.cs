using DMOAuto.lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMOAuto
{
    public delegate void UpdateMe(int a);

    public delegate void Loge(string a);

    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            MyInit();
            
        }

        Boting bot;

        protected int nowPId = -1;

        public static UpdateMe uPD;
        public static Loge uPL;

        private void MyInit()
        {
            lblProId.Text = "Not active";
            lblProId.ForeColor = Color.Red;
            bot = new Boting();
            uPD = ChangeLabel;
            uPL = OutLog;
        }


        public void ChangeLabel(int pId)
        {
            nowPId = pId;
            if (pId == -1)
            {
                int resp = (int)MessageBox.Show("There is no game process.", "ERROR");
                lblProId.Text = "Not active";
                lblProId.ForeColor = Color.Red;
            }
            else
            {
                lblProId.Text = "Active "+ nowPId.ToString();
                lblProId.ForeColor = Color.Green;
            }

        }

        public void OutLog(String a)
        {
            if (txtBox.InvokeRequired) {
                txtBox.Invoke(new Loge(OutLog), a);
            }
            else { txtBox.Text += a + "\r\n"; }
        }

        public static void gogogo(string a)
        {
            MessageBox.Show(a, "gogogo");
        }

        private void ProSearch(object sender, EventArgs e)
        {
            try
            {
                int pId = ProcessHandler.GetProcess("GDMO");
            }
            catch (Exception exp)
            {
                int resp = (int)MessageBox.Show("Some thing went wrong.", "ERROR");
            }
        }

        private void AllStart(object sender,EventArgs e)
        {
            IntPtr ipt=ProcessHandler.GetMyWindow(nowPId);
            OutLog("目前控制句柄 " + ipt.ToString());
            bot.Start();
        }

        private void AllStop(object sender, EventArgs e)
        {
            bot.cfg.state = false;
        }

        private void Mody(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            int keycode=-1;
            Consts.KEY_CODE.TryGetValue(bt.Text, out keycode);
            bot.cfg.a = keycode;
        }




    }



}
