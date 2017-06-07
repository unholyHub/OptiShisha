using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClientFormApplication
{
    public partial class MainClientForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;

        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public MainClientForm()
        {
            InitializeComponent();

        }        

        private void MainClientForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ShowConnectionResult()
        {
            if (Client.StartClient())
            {
                this.btnSuccessfulConnect.Text = "Connected";
                this.btnSuccessfulConnect.ForeColor = Color.Green;
                this.btnSuccessfulConnect.BackColor = Color.GreenYellow;
            }
            else
            {
                this.btnSuccessfulConnect.Text = "Failed";
                this.btnSuccessfulConnect.ForeColor = Color.White;
                this.btnSuccessfulConnect.BackColor = Color.IndianRed;
            }
        }

        private void MainClientForm_Load(object sender, EventArgs e)
        {
            ShowConnectionResult();
            this.Location = Properties.Settings.Default.StartPosition;
        }

        private void btnMouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            btn.BackColor = Color.LightGreen;
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            Client.SendMessage("Call");
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            btn.BackColor = Color.Transparent;
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            Client.SendMessage("Maintenance");
        }

        private void MainClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.StartPosition = this.Location;
            Properties.Settings.Default.Save();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Client.SendMessage("Menu");
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            Client.SendMessage("Bill");
        }

        private void btnCoal_Click(object sender, EventArgs e)
        {
            Client.SendMessage("Coal");

        }
    }
}
