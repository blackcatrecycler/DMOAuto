using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMOAuto.lib
{
    class ProcessHandler
    {
        public static int GetProcess(string pName)
        {
            Process[] lisP = Process.GetProcesses();
            foreach (Process ap in lisP)
            {
                if (ap.ProcessName == pName) return ap.Id;
            }
            return -1;
        }
    }
}
