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

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnStart.Text       = Translate.GetTranslate("frmMain", "BUTTON_START");
            btnStop.Text        = Translate.GetTranslate("frmMain", "BUTTON_STOP");
            btnSettings.Text    = Translate.GetTranslate("frmMain", "BUTTON_SETTINGS");
            btnHowTo.Text       = Translate.GetTranslate("frmMain", "BUTTON_HTU");
            btnClose.Text       = Translate.GetTranslate("frmMain", "BUTTON_EXIT");
            lblStatus.Text      = Translate.GetTranslate("frmMain", "LABEL_STOPPED");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (   m_manager.GetActualState() != Manager.FishingState.Stopped
                && m_manager.GetActualState() != Manager.FishingState.Paused)
                return;

            if (m_manager.GetActualState() == Manager.FishingState.Stopped)
            {
                m_manager.Start();
                btnStart.Text = Translate.GetTranslate("frmMain", "BUTTON_START");
                btnStop.Text = Translate.GetTranslate("frmMain", "BUTTON_PAUSE");
                lblStatus.Text = Translate.GetTranslate("frmMain", "LABEL_STARTED");
            }
            else
            {
                m_manager.Resume();
                lblStatus.Text = Translate.GetTranslate("frmMain", "LABEL_RESUMED");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (m_manager.GetActualState() == Manager.FishingState.Stopped)
                return;

            if (m_manager.GetActualState() == Manager.FishingState.Paused)
            {
                m_manager.Stop();
                btnStart.Text = Translate.GetTranslate("frmMain", "BUTTON_START");
                btnStop.Text = Translate.GetTranslate("frmMain", "BUTTON_STOP");
                lblStatus.Text = Translate.GetTranslate("frmMain", "LABEL_STOPPED");
            }
            else
            {
                m_manager.Pause();
                btnStart.Text = Translate.GetTranslate("frmMain", "BUTTON_RESUME");
                btnStop.Text = Translate.GetTranslate("frmMain", "BUTTON_STOP");
                lblStatus.Text = Translate.GetTranslate("frmMain", "LABEL_PAUSED");
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
