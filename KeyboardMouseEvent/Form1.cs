using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardMouse
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")] private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")] private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")] private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")] private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")] private static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")] private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [DllImport("user32.dll")] private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

        [DllImport("user32.dll")] private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndlnsertAfter, int X, int Y, int cx, int cy, uint Flags);

        //ShowWindow参数
        private const int SW_SHOWNORMAL = 1;

        private const int SW_RESTORE = 9;
        private const int SW_SHOWNOACTIVATE = 4;

        //SendMessage参数
        private const int WM_KEYDOWN = 0X100;

        private const int WM_KEYUP = 0X101;
        private const int WM_SYSCHAR = 0X106;
        private const int WM_SYSKEYUP = 0X105;
        private const int WM_SYSKEYDOWN = 0X104;
        private const int WM_CHAR = 0X102;
        private const int WM_LBUTTONDOWN = 0x0201;
        private const int WM_LBUTTONUP = 0x0202;
        private const int WM_MBUTTONDOWN = 0x0207;
        private const int WM_MBUTTONUP = 0x0208;
        private const int WM_RBUTTONDOWN = 0x0204;
        private const int WM_RBUTTONUP = 0x0205;

        [Flags]
        public enum MouseEventFlags : uint
        {
            LEFTDOWN = 0x00000002,
            LEFTUP = 0x00000004,
            MIDDLEDOWN = 0x00000020,
            MIDDLEUP = 0x00000040,
            MOVE = 0x00000001,
            ABSOLUTE = 0x00008000,
            RIGHTDOWN = 0x00000008,
            RIGHTUP = 0x00000010,
            WHEEL = 0x00000800,
            XDOWN = 0x00000080,
            XUP = 0x00000100
        }

        //Use the values of this enum for the 'dwData' parameter
        //to specify an X button when using MouseEventFlags.XDOWN or
        //MouseEventFlags.XUP for the dwFlags parameter.
        public enum MouseEventDataXButtons : uint
        {
            XBUTTON1 = 0x00000001,
            XBUTTON2 = 0x00000002
        }

        public delegate bool CallBack(int hwnd, int lParam);

        [DllImport("user32")] public static extern int EnumWindows(CallBack x, int y);

        [DllImport("user32.dll")] private static extern int GetWindowTextW(IntPtr hWnd, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll")] private static extern int GetClassNameW(IntPtr hWnd, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpString, int nMaxCount);

        private IntPtr hwnd;

        public Form1()
        {
            InitializeComponent();
            cmbMouseKey.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            hwnd = FindWindow(txtClassname.Text, txtAppTitle.Text); //null为类名，可以用Spy++得到，也可以为空
            txtHwnd.Text = hwnd.ToString("X");
            ShowWindow(hwnd, SW_RESTORE);
            SetForegroundWindow(hwnd);
        }

        public bool Recall(int hwnd, int lParam)
        {
            StringBuilder sb = new StringBuilder(256);
            IntPtr PW = new IntPtr(hwnd);

            GetWindowTextW(PW, sb, sb.Capacity); //得到窗口名并保存在strName中
            string strName = sb.ToString();
            Console.WriteLine(strName);

            GetClassNameW(PW, sb, sb.Capacity); //得到窗口类名并保存在strClass中
            string strClass = sb.ToString();

            if (strName.IndexOf(txtAppTitle.Text) >= 0)
            {
                return false; //返回false中止EnumWindows遍历
            }
            else
            {
                return true; //返回true继续EnumWindows遍历
            }
        }

        private void PressKey(Keys key)
        {
            const int KEYEVENTF_EXTENDEDKEY = 0x1;
            const int KEYEVENTF_KEYUP = 0x2;
            // I had some Compile errors until I Casted the final 0 to UIntPtr like this...
            keybd_event((byte)key, 0x45, KEYEVENTF_EXTENDEDKEY, 0);
            keybd_event((byte)key, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
        }

        private void PressKeyArray(Keys[] keys)
        {
            foreach (Keys key in keys)
            {
                PressKey(key);
            }
        }

        private void btnSendMouseKey_Click(object sender, EventArgs e)
        {
            int mouseKeyDown = (int)(cmbMouseKey.SelectedIndex == 0 ? WM_LBUTTONDOWN : cmbMouseKey.SelectedIndex == 1 ? WM_MBUTTONDOWN : WM_RBUTTONDOWN);
            int mouseKeyUp = (int)(cmbMouseKey.SelectedIndex == 0 ? WM_LBUTTONUP : cmbMouseKey.SelectedIndex == 1 ? WM_MBUTTONUP : WM_RBUTTONUP);
            int x = Convert.ToInt32(txtMouseX.Text);
            int y = Convert.ToInt32(txtMouseY.Text);
            int lparam = x | (y << 16);
            SendMessage(hwnd, mouseKeyDown, 0, lparam);
            SendMessage(hwnd, mouseKeyUp, 0, lparam);
        }

        private void btnSendKey_Click(object sender, EventArgs e)
        {
            int key = Convert.ToInt32(txtKey.Text);
            SendMessage(hwnd, WM_KEYDOWN, key, 0);
            SendMessage(hwnd, WM_KEYUP, key, 0);
        }

        private void txtKey_KeyDown(object sender, KeyEventArgs e)
        {
            txtKey.Text = e.KeyValue.ToString();
        }

        private void btnGroupSend_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(txtRepeatTimes.Text);
            for (int t = 0; t < count; t++)
            {
                //txtMouseX.Text = "800";
                //txtMouseY.Text = "150";
                txtKey.Text = "33";
                btnSendMouseKey_Click(null, null);
                for (int i = 0; i < 10; i++)
                {
                    btnSendKey_Click(null, null);
                }

                //txtMouseX.Text = "600";
                //txtMouseY.Text = "80";
                //btnSendMouseKey_Click(null, null);
            }
        }
    }
}