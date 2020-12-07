using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DMOAuto.lib
{
    class Win32Api
    {


        // Get a handle to an application window.
        [DllImport("USER32.DLL", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindow(string lpClassName,
        string lpWindowName);

        // Activate an application window.
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        // Activate an application window.
        [DllImport("USER32.DLL")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("USER32.DLL")]
        public static extern int GetWindowThreadProcessId(IntPtr hWnd, out int id);

        [DllImport("USER32.DLL")]
        public static extern IntPtr GetWindow(IntPtr hWnd, uint wCmd);

        [DllImport("USER32.DLL")]
        public static extern bool IsWindow(IntPtr hWnd);

        public delegate bool CheckWndProcessId(IntPtr hWnd, int id);

        [DllImport("USER32.DLL", CharSet = CharSet.Auto)]
        public static extern int EnumWindows(CheckWndProcessId hWnd, int lParam);

        [DllImport("USER32.DLL")]
        public static extern int PostMessage(IntPtr hWnd, int Msg, int wParam, uint lParam);
        [DllImport("USER32.DLL")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, uint lParam);

        [DllImport("USER32.DLL", CharSet = CharSet.Auto)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("USER32.DLL")]
        public static extern int GetWindowLong(IntPtr hWnd, int index);

        [DllImport("USER32.DLL")]
        public static extern bool PrintWindow(IntPtr hWnd,IntPtr hdc ,int index);
    }
}
