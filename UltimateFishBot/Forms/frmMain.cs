using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UltimateFishBot.Classes;
using UltimateFishBot.Forms;

namespace UltimateFishBot
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            m_manager = new Manager(this);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (   m_manager.GetActualState() != Manager.FishingState.Stopped
                && m_manager.GetActualState() != Manager.FishingState.Paused)
                return;

            if (m_manager.GetActualState() == Manager.FishingState.Stopped)
            {
                m_manager.Start();
                btnStart.Text = "Resume";
                btnStop.Text = "Pause";
                lblStatus.Text = "Started";
            }
            else
            {
                m_manager.Resume();
                lblStatus.Text = "Resumed";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (m_manager.GetActualState() == Manager.FishingState.Stopped)
                return;

            if (m_manager.GetActualState() == Manager.FishingState.Paused)
            {
                m_manager.Stop();
                btnStart.Text = "Start";
                btnStop.Text = "Stop";
                lblStatus.Text = "Stopped";
            }
            else
            {
                m_manager.Pause();
                btnStop.Text = "Stop";
                lblStatus.Text = "Paused";
            }
        }

        public void StopFishing()
        {
            btnStop_Click(null, null);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            new frmSettings().Show();
        }

        private Manager m_manager;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHowTo_Click(object sender, EventArgs e)
        {
            new frmDirections().Show();
        }
    }
}
