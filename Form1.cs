using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ReverseRepetitiveClicker
{
    public partial class Form1 : Form
    {
        private const int HOTKEY_ID = 1;
        private const uint MOD_NONE = 0x0000;
        private const uint VK_TAB = 0x09;

        private int initialMaxN;
        private int maxN; // current MaxN
        private bool initialized = false;

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;




        public Form1()
        {
            InitializeComponent();
            RegisterTabHotkey();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load last saved MaxN into TextBox
            textBoxMaxN.Text = SettingsManager.GetMaxN().ToString();
        }

        private void RegisterTabHotkey()
        {
            RegisterHotKey(this.Handle, HOTKEY_ID, MOD_NONE, VK_TAB);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            if (m.Msg == WM_HOTKEY && m.WParam.ToInt32() == HOTKEY_ID)
            {
                // Tab pressed → perform one item selection
                SingleItemSelect();
            }
            base.WndProc(ref m);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, HOTKEY_ID);
            base.OnFormClosing(e);
        }

        private void SingleItemSelect()
        {
            // Initialize maxN from textbox if not done yet
            if (!initialized)
            {
                // <-- Paste your code here
                if (int.TryParse(textBoxMaxN.Text, out int value) && value > 0)
                {
                    maxN = value;
                    initialMaxN = value;
                    initialized = true;

                    SettingsManager.SetMaxN(value); // Save to INI
                    label2.Text = $"MaxN initialized to {maxN}";
                }
                else
                {
                    label2.Text = "Enter a valid number > 0!";
                    return;
                }
            }

            // If maxN is 1, auto-reset
            if (maxN == 1)
            {
                maxN = initialMaxN;
                label2.Text = $"Resetting to MaxN={maxN}";
                Application.DoEvents();
                return;
            }

            // Perform clicks for this item
            int clicksNeeded = maxN - 1;
            label2.Text = $"Selecting item for MaxN={maxN}, clicks={clicksNeeded}";
            Application.DoEvents();

            for (int i = 1; i <= clicksNeeded; i++)
            {
                ClickAtCurrentPosition();
                System.Threading.Thread.Sleep(200);
            }

            maxN--;
            label2.Text = $"Item selected! New MaxN={maxN}";
        }

        private void ClickAtCurrentPosition()
        {
            var pos = Cursor.Position;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP,
                        (uint)pos.X, (uint)pos.Y, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxMaxN.Text, out int value) && value > 0)
            {
                maxN = value;
                initialMaxN = value;
                SettingsManager.SetMaxN(value);
                label2.Text = $"Manually reset to MaxN={maxN}";
                initialized = true;
            }
        }
    }
}
