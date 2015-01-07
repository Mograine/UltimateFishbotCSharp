﻿using CoreAudioApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltimateFishBot.Forms
{
    public partial class frmSettings : Form
    {
        private MMDevice SndDevice;

        public frmSettings()
        {
            InitializeComponent();
            SndDevice = null;

            tmeAudio.Tick += new EventHandler(tmeAudio_Tick);
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            /// General
            txtCastDelay.Text = Properties.Settings.Default.CastingDelay.ToString();
            txtLootingDelay.Text = Properties.Settings.Default.LootingDelay.ToString();
            txtFishWait.Text = Properties.Settings.Default.FishWait.ToString();

            /// Finding the Cursor
            txtDelay.Text = Properties.Settings.Default.ScanningDelay.ToString();
            txtRetries.Text = Properties.Settings.Default.ScanningRetries.ToString();
            txtScanSteps.Text = Properties.Settings.Default.ScanningSteps.ToString();

            /// Hearing the Fish
            txtSplash.Text = Properties.Settings.Default.SplashLimit.ToString();
            LoadAudioDevices();

            /// Premium Settings
            txtProcName.Text = Properties.Settings.Default.ProcName;
            cbAutoLure.Checked = Properties.Settings.Default.AutoLure;
            cbHearth.Checked = Properties.Settings.Default.SwapGear;
            cbAlt.Checked = Properties.Settings.Default.UseAltKey;

            txtFishKey.Text = Properties.Settings.Default.FishKey;
            txtLureKey.Text = Properties.Settings.Default.LureKey;
            txtHearthKey.Text = Properties.Settings.Default.HearthKey;
            cbHearth.Checked = Properties.Settings.Default.AutoHearth;
            txtHearthTime.Text = Properties.Settings.Default.HearthTime.ToString();

            // MoP Premium (Angler's Raft & Ancient Pandaren Fishing Charm)
            txtCharmKey.Text = Properties.Settings.Default.CharmKey;
            txtRaftKey.Text = Properties.Settings.Default.RaftKey;
            cbApplyRaft.Checked = Properties.Settings.Default.AutoRaft;
            cbApplyCharm.Checked = Properties.Settings.Default.AutoCharm;
            cbShiftLoot.Checked = Properties.Settings.Default.ShiftLoot;

            // WoD Premium (Bait)
            txtBaitKey1.Text = Properties.Settings.Default.BaitKey1;
            txtBaitKey2.Text = Properties.Settings.Default.BaitKey2;
            txtBaitKey3.Text = Properties.Settings.Default.BaitKey3;
            txtBaitKey4.Text = Properties.Settings.Default.BaitKey4;
            txtBaitKey5.Text = Properties.Settings.Default.BaitKey5;
            txtBaitKey6.Text = Properties.Settings.Default.BaitKey6;
            txtBaitKey7.Text = Properties.Settings.Default.BaitKey7;
            cbAutoBait.Checked = Properties.Settings.Default.AutoBait;
            cbRandomBait.Checked = Properties.Settings.Default.randomBait;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /// General
            Properties.Settings.Default.CastingDelay = int.Parse(txtCastDelay.Text);
            Properties.Settings.Default.LootingDelay = int.Parse(txtLootingDelay.Text);
            Properties.Settings.Default.FishWait = int.Parse(txtFishWait.Text);
            
            /// Finding the Cursor
            Properties.Settings.Default.ScanningDelay = int.Parse(txtDelay.Text);
            Properties.Settings.Default.ScanningRetries = int.Parse(txtRetries.Text);
            Properties.Settings.Default.ScanningSteps = int.Parse(txtScanSteps.Text);
            
            /// Hearing the Fish
            Properties.Settings.Default.SplashLimit = int.Parse(txtSplash.Text);
            Properties.Settings.Default.AudioDevice = (string)cmbAudio.SelectedValue;

            /// Premium Settings

            Properties.Settings.Default.ProcName = txtProcName.Text;
            Properties.Settings.Default.AutoLure = cbAutoLure.Checked;
            Properties.Settings.Default.SwapGear = cbHearth.Checked;
            Properties.Settings.Default.UseAltKey = cbAlt.Checked;

            Properties.Settings.Default.FishKey = txtFishKey.Text;
            Properties.Settings.Default.LureKey = txtLureKey.Text;
            Properties.Settings.Default.HearthKey = txtHearthKey.Text;
            Properties.Settings.Default.AutoHearth = cbHearth.Checked;
            Properties.Settings.Default.HearthTime = int.Parse(txtHearthTime.Text);

            // MoP Premium (Angler's Raft & Ancient Pandaren Fishing Charm)
            Properties.Settings.Default.CharmKey = txtCharmKey.Text;
            Properties.Settings.Default.RaftKey = txtRaftKey.Text;
            Properties.Settings.Default.AutoRaft = cbApplyRaft.Checked;
            Properties.Settings.Default.AutoCharm = cbApplyCharm.Checked;
            Properties.Settings.Default.ShiftLoot = cbShiftLoot.Checked;

            // WoD Premium (Bait)
            Properties.Settings.Default.BaitKey1 = txtBaitKey1.Text;
            Properties.Settings.Default.BaitKey2 = txtBaitKey2.Text;
            Properties.Settings.Default.BaitKey3 = txtBaitKey3.Text;
            Properties.Settings.Default.BaitKey4 = txtBaitKey4.Text;
            Properties.Settings.Default.BaitKey5 = txtBaitKey5.Text;
            Properties.Settings.Default.BaitKey6 = txtBaitKey6.Text;
            Properties.Settings.Default.BaitKey7 = txtBaitKey7.Text;
            Properties.Settings.Default.AutoBait = cbAutoBait.Checked;
            Properties.Settings.Default.randomBait = cbRandomBait.Checked;

            Properties.Settings.Default.Save();
            this.Close();
        }

        private void tabSettings_SelectedIndexChanged(Object sender, EventArgs e)
        {
            tmeAudio.Enabled = (tabSettings.SelectedIndex == 2);
        }

        private void LoadAudioDevices()
        {
            List<Tuple<string, string>> audioDevices = new List<Tuple<string, string>>();
            audioDevices.Add(new Tuple<string, string>("Default", ""));

            try
            {
                MMDeviceEnumerator sndDevEnum = new MMDeviceEnumerator();
                MMDeviceCollection audioCollection = sndDevEnum.EnumerateAudioEndPoints(EDataFlow.eRender, EDeviceState.DEVICE_STATEMASK_ALL);

                // Try to add each audio endpoint to our collection
                for (int i = 0; i < audioCollection.Count; ++i)
                {
                    MMDevice device = audioCollection[i];
                    audioDevices.Add(new Tuple<string, string>(device.FriendlyName, device.ID));
                }
            }
            catch (Exception)
            { }

            // Setup the display
            cmbAudio.Items.Clear();
            cmbAudio.DisplayMember = "Item1";
            cmbAudio.ValueMember = "Item2";
            cmbAudio.DataSource = audioDevices;
            cmbAudio.SelectedValue = Properties.Settings.Default.AudioDevice;
        }
        
        private void tmeAudio_Tick(Object sender, EventArgs e)
        {
            if (SndDevice != null)
            {
                try
                {
                    int currentVolumnLevel = (int)(SndDevice.AudioMeterInformation.MasterPeakValue * 100);
                    pgbSoundLevel.Value = currentVolumnLevel;
                    lblAudioLevel.Text = currentVolumnLevel.ToString();
                }
                catch (Exception)
                {
                    pgbSoundLevel.Value = 0;
                    lblAudioLevel.Text = "0";
                }
            }
            else
            {
                pgbSoundLevel.Value = 0;
                lblAudioLevel.Text = "0";
            }
        }

        private void cmbAudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            MMDeviceEnumerator sndDevEnum = new MMDeviceEnumerator();

            if (!string.IsNullOrEmpty((string)cmbAudio.SelectedValue))
                SndDevice = sndDevEnum.GetDevice((string)cmbAudio.SelectedValue);
            else
                SndDevice = sndDevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia);
        }
    }
}