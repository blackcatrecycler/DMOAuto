using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DMOAuto.lib
{
    class ProcessHandler
    {

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
            res = Win32Api.EnumWindows(CheckWndProcessIdSPEC, res);
            return myPtr;
        }


        private static bool CheckWndProcessIdSPEC(IntPtr hWnd, int id)
        {
            int nowid = -1;
            try
            {
                Win32Api.GetWindowThreadProcessId(hWnd, out nowid);
                if (nowid == id)
                {

                    StringBuilder a = new StringBuilder(1000 + 1);
                    Win32Api.GetWindowText(hWnd, a, a.Capacity);
                    //mainForm.uPL(hWnd.ToInt32().ToString("x8") + "  " + a);
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
            if (myPtr != IntPtr.Zero || Win32Api.IsWindow(myPtr)) return true;
            return false;
        }

        public static void AwakeWnd(bool ifstat)
        {
            if (CheckWnd())
            {
                if (ifstat)
                {
                    Win32Api.SendMessage(myPtr, Consts.WM_ACTIVATEAPP, 1, 0);
                    Win32Api.SendMessage(myPtr, Consts.WM_ACTIVATE, 2, 0);
                    Win32Api.SendMessage(myPtr, Consts.WM_IMT_SETCONTEXT, Consts.I_SHOW, Consts.WM_DF);
                    Win32Api.SendMessage(myPtr, Consts.WM_IMT_NOTIFY, Consts.OPEN_WINDOWS, 0);
                }
                else
                {
                    Win32Api.SendMessage(myPtr, Consts.WM_IMT_SETCONTEXT, Consts.I_CLOSE, Consts.WM_DF);
                    Win32Api.SendMessage(myPtr, Consts.WM_IMT_NOTIFY, Consts.CLOSE_WINDOWS, 0);
                }
            }
        }

        public static void SendKey(int keycode,int keyvalue)
        {
            if (CheckWnd())
            {
                AwakeWnd(true);
                Thread.Sleep(100);
                Win32Api.PostMessage(myPtr, Consts.WM_KEYDOWN, keyvalue, 0);
                Win32Api.PostMessage(myPtr, Consts.WM_CHAR, keycode, 0);
                Thread.Sleep(100);
                Win32Api.PostMessage(myPtr, Consts.WM_KEYUP, keyvalue, 0);
                Thread.Sleep(100);
                AwakeWnd(false);
            }
        }

        public static Bitmap GetWindowImg()
        {
            AwakeWnd(true);
            int a = 0;
            Bitmap bt = new Bitmap(1000, 200);
            Graphics gp = Graphics.FromImage(bt);
            IntPtr imgptr = IntPtr.Zero;
            gp.Clear(Color.Black);
            IntPtr gphd = gp.GetHdc();
            bool x1 = Win32Api.PrintWindow(myPtr, gphd, 0);
            gp.ReleaseHdc(gphd);
            gp.Dispose();
            Thread.Sleep(500);
            // mainForm.uPL(x1.ToString());
            return bt;
        }



    }
}
