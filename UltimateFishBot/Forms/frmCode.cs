using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltimateFishBot.Forms
{
    public partial class frmCode : Form
    {
        private int m_count;

        public frmCode()
        {
            InitializeComponent();
        }

        private void frmCode_Load(object sender, EventArgs e)
        {
            Process.Start("http://www.fishbot.net/code.html");
            Label1.Text = "You've used the Ultimate Fishbot " + Properties.Settings.Default.Startup + " times.  To continue using it; you need to visit the Fishbot website and enter the 3-5 digit code in the box below.  If a browser window didn't open, you can find it at www.fishbot.net/code.html - or click the link below.  I promise, it's quick and painless.";
            this.Activate();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            System.DateTime myDate = System.DateTime.Now;
            string Expected = (Convert.ToInt32(myDate.DayOfWeek) * myDate.Day * (myDate.Month - 1) * 26).ToString();

            if (Expected.Length > 3)
                Expected = Expected.Substring(0, 3);

            if (TextBox1.Text == Expected)
                DialogResult = DialogResult.OK;
            else
                MessageBox.Show("Try again!");
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.fishbot.net/code.html");
        }
    }
}
