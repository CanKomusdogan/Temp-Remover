using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp4
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipText = "Temp Remover Minimized.";
            notifyIcon1.BalloonTipTitle = "test";
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        // temp button
        public void button2_Click(object sender, EventArgs e)
        {
            Directory.Delete("C:\\Windows\\Temp", true);
            Directory.CreateDirectory("C:\\Windows\\Temp");
        }

        // %temp% button
        public void button1_Click(object sender, EventArgs e)
        {
            Directory.Delete("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Temp", true);
            Directory.CreateDirectory("C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Temp");
        }

        // prefetch button
        public void button3_Click(object sender, EventArgs e)
        {
            Directory.Delete("C:\\Windows\\Prefetch", true);
            Directory.CreateDirectory("C:\\Windows\\Prefetch");
        }
    }
}
