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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        int a = -1;

        private void  ProSearch(object sender, EventArgs e)
        {
            try
            {
                int pId=lib.ProcessHandler.GetProcess("GDMO.exe");
                if (pId != -1) { int resp = (int)MessageBox.Show("There is no game process.","ERROR"); }

            }
            catch(Exception exp)
            {
                int resp = (int)MessageBox.Show("Some thing went wrong.", "ERROR");
            }
        }

        
    
}

    

}
