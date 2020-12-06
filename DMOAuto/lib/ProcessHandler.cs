using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DMOAuto.lib
{
    class ProcessHandler
    {



        // Get a handle to an application window.
        [DllImport("USER32.DLL", CharSet = CharSet.Auto)]
        private static extern IntPtr FindWindow(string lpClassName,
        string lpWindowName);

        // Activate an application window.
        [DllImport("USER32.DLL")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        // Activate an application window.
        [DllImport("USER32.DLL")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("USER32.DLL")]
        private static extern int GetWindowThreadProcessId(IntPtr hWnd, out int id);

        [DllImport("USER32.DLL")]
        private static extern IntPtr GetWindow(IntPtr hWnd, uint wCmd);

        [DllImport("USER32.DLL")]
        private static extern bool IsWindow(IntPtr hWnd);

        private delegate bool CheckWndProcessId(IntPtr hWnd, int id);

        [DllImport("USER32.DLL", CharSet = CharSet.Auto)]
        private static extern int EnumWindows(CheckWndProcessId hWnd, int lParam);

        [DllImport("User32.dll")]
        private static extern int PostMessage(IntPtr hWnd, int Msg, int wParam, uint lParam);
        [DllImport("User32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, uint lParam);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        public static IntPtr myPtr = IntPtr.Zero;
        public static List<IntPtr> mp = new List<IntPtr>();

        public static int opc = 0;

        public static int GetProcess(string pName)
        {
            Process[] lisP = Process.GetProcesses();

            foreach (Process ap in lisP)
            {
                if (ap.ProcessName == pName)
                {
                    mainForm.uPD(ap.Id);
                    return ap.Id;
                }
            }
            mainForm.uPD(-1);
            return -1;
        }

        public static int GetProcess(int pId)
        {
            if (pId == -1) { return -1; }
            try
            {
                Process p = Process.GetProcessById(pId);
                mainForm.uPD(pId);
                return pId;
            }
            catch
            {
                mainForm.uPD(-1);
                return -1;
            }
        }

        public static IntPtr GetMyWindow(int pId)
        {
            int res = GetProcess(pId);
            if (res == -1) { myPtr = IntPtr.Zero; return IntPtr.Zero; }
            //MainForm.gogogo(Process.GetProcessById(pId).ProcessName);
            res = EnumWindows(CheckWndProcessIdSPEC, res);
            return myPtr;
        }


        private static bool CheckWndProcessIdSPEC(IntPtr hWnd, int id)
        {
            int nowid = -1;
            try
            {
                GetWindowThreadProcessId(hWnd, out nowid);
                if (nowid == id)
                {
                    
                    StringBuilder a = new StringBuilder(1000+1);
                    GetWindowText(hWnd, a, a.Capacity);
                    mainForm.uPL(hWnd.ToInt32().ToString("x8") +"  "+a);
                    opc++;
                    if (opc == 1) myPtr = hWnd;
                    
                    return true;
                }

                return true;
            }
            catch
            {
                return true;
            }
        }

        private static bool CheckWnd()
        {
            if (myPtr != IntPtr.Zero || IsWindow(myPtr)) return true;
            return false;
        }

        public static void AwakeWnd(bool ifstat)
        {
            if (CheckWnd())
            {
                if (ifstat)
                {
                    SendMessage(myPtr, Consts.WM_ACTIVATEAPP, 1, 0);
                    SendMessage(myPtr, Consts.WM_ACTIVATE, 2, 0);
                    SendMessage(myPtr, Consts.WM_IMT_SETCONTEXT, Consts.I_SHOW, Consts.WM_DF);
                    SendMessage(myPtr, Consts.WM_IMT_NOTIFY, Consts.OPEN_WINDOWS, 0);
                }
                else
                {
                    SendMessage(myPtr, Consts.WM_IMT_SETCONTEXT, Consts.I_CLOSE, Consts.WM_DF);
                    SendMessage(myPtr, Consts.WM_IMT_NOTIFY, Consts.CLOSE_WINDOWS, 0);
                }
            }
        }

        public static void SendKey(int a)
        {
            if (CheckWnd() && a != -1)
            {
                AwakeWnd(true);
                Thread.Sleep(100);
                PostMessage(myPtr, Consts.WM_KEYDOWN, a,Consts.WM_DD);
                PostMessage(myPtr, Consts.WM_CHAR, a+32, Consts.WM_DD);
                Thread.Sleep(300);
                PostMessage(myPtr, Consts.WM_KEYUP, a, Consts.WM_DU);
                Thread.Sleep(100);
                AwakeWnd(false);
            }
        }



    }
}
