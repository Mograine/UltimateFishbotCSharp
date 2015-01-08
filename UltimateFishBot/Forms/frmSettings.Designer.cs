﻿namespace UltimateFishBot.Forms
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LabelScanningDelayDesc = new System.Windows.Forms.Label();
            this.txtScanSteps = new System.Windows.Forms.TextBox();
            this.LabelScanningStepsDesc = new System.Windows.Forms.Label();
            this.LabelScanningSteps = new System.Windows.Forms.Label();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.lblAudioLevel = new System.Windows.Forms.Label();
            this.pgbSoundLevel = new System.Windows.Forms.ProgressBar();
            this.LabelAudioDeviceDesc = new System.Windows.Forms.Label();
            this.cmbAudio = new System.Windows.Forms.ComboBox();
            this.LabelAudioDevice = new System.Windows.Forms.Label();
            this.txtSplash = new System.Windows.Forms.TextBox();
            this.LabelSplashThresholdDesc = new System.Windows.Forms.Label();
            this.LabelSplashThreshold = new System.Windows.Forms.Label();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.cbRandomBait = new System.Windows.Forms.CheckBox();
            this.LabelBaitKey7 = new System.Windows.Forms.Label();
            this.txtBaitKey7 = new System.Windows.Forms.TextBox();
            this.LabelBaitKey6 = new System.Windows.Forms.Label();
            this.txtBaitKey6 = new System.Windows.Forms.TextBox();
            this.LabelBaitKey5 = new System.Windows.Forms.Label();
            this.txtBaitKey5 = new System.Windows.Forms.TextBox();
            this.LabelBaitKey4 = new System.Windows.Forms.Label();
            this.txtBaitKey4 = new System.Windows.Forms.TextBox();
            this.LabelBaitKey3 = new System.Windows.Forms.Label();
            this.txtBaitKey3 = new System.Windows.Forms.TextBox();
            this.LabelBaitKey2 = new System.Windows.Forms.Label();
            this.txtBaitKey2 = new System.Windows.Forms.TextBox();
            this.cbShiftLoot = new System.Windows.Forms.CheckBox();
            this.cbApplyCharm = new System.Windows.Forms.CheckBox();
            this.cbApplyRaft = new System.Windows.Forms.CheckBox();
            this.txtCharmKey = new System.Windows.Forms.TextBox();
            this.LabelCharmKey = new System.Windows.Forms.Label();
            this.txtRaftKey = new System.Windows.Forms.TextBox();
            this.LabelRaftKey = new System.Windows.Forms.Label();
            this.txtHearthTime = new System.Windows.Forms.TextBox();
            this.cbAlt = new System.Windows.Forms.CheckBox();
            this.cbHearth = new System.Windows.Forms.CheckBox();
            this.LabelCustomizeDesc = new System.Windows.Forms.Label();
            this.txtProcName = new System.Windows.Forms.TextBox();
            this.LabelProcessNameDesc = new System.Windows.Forms.Label();
            this.LabelProcessName = new System.Windows.Forms.Label();
            this.cbAutoLure = new System.Windows.Forms.CheckBox();
            this.txtHearthKey = new System.Windows.Forms.TextBox();
            this.LabelHearthKey = new System.Windows.Forms.Label();
            this.txtLureKey = new System.Windows.Forms.TextBox();
            this.LabelLureKey = new System.Windows.Forms.Label();
            this.txtFishKey = new System.Windows.Forms.TextBox();
            this.LabelCastKey = new System.Windows.Forms.Label();
            this.LabelBaitKey1 = new System.Windows.Forms.Label();
            this.txtBaitKey1 = new System.Windows.Forms.TextBox();
            this.cbAutoBait = new System.Windows.Forms.CheckBox();
            this.LabelScanningDelay = new System.Windows.Forms.Label();
            this.tmeAudio = new System.Windows.Forms.Timer(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.txtFishWait = new System.Windows.Forms.TextBox();
            this.LabelFishWaitDesc = new System.Windows.Forms.Label();
            this.LabelDelayLooting = new System.Windows.Forms.Label();
            this.txtLootingDelay = new System.Windows.Forms.TextBox();
            this.LabelDelayLootingDesc = new System.Windows.Forms.Label();
            this.LabelFishWait = new System.Windows.Forms.Label();
            this.txtCastDelay = new System.Windows.Forms.TextBox();
            this.LabelDelayCastDesc = new System.Windows.Forms.Label();
            this.LabelDelayCast = new System.Windows.Forms.Label();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.txtRetries = new System.Windows.Forms.TextBox();
            this.LabelScanningRetriesDesc = new System.Windows.Forms.Label();
            this.LabelScanningRetries = new System.Windows.Forms.Label();
            this.TabPage5 = new System.Windows.Forms.TabPage();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.labelLanguageDesc = new System.Windows.Forms.Label();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbCompareIcon = new System.Windows.Forms.CheckBox();
            this.LabelCheckCursorIcon = new System.Windows.Forms.Label();
            this.TabPage3.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelScanningDelayDesc
            // 
            this.LabelScanningDelayDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScanningDelayDesc.Location = new System.Drawing.Point(8, 102);
            this.LabelScanningDelayDesc.Name = "LabelScanningDelayDesc";
            this.LabelScanningDelayDesc.Size = new System.Drawing.Size(423, 51);
            this.LabelScanningDelayDesc.TabIndex = 13;
            this.LabelScanningDelayDesc.Text = "The number of milliseconds to wait before checking if the cursor has changed.  To" +
    " slow and you might not detect the bobber; but a bigger number goes slower.";
            // 
            // txtScanSteps
            // 
            this.txtScanSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScanSteps.Location = new System.Drawing.Point(129, 9);
            this.txtScanSteps.Name = "txtScanSteps";
            this.txtScanSteps.Size = new System.Drawing.Size(32, 20);
            this.txtScanSteps.TabIndex = 11;
            // 
            // LabelScanningStepsDesc
            // 
            this.LabelScanningStepsDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScanningStepsDesc.Location = new System.Drawing.Point(6, 32);
            this.LabelScanningStepsDesc.Name = "LabelScanningStepsDesc";
            this.LabelScanningStepsDesc.Size = new System.Drawing.Size(423, 42);
            this.LabelScanningStepsDesc.TabIndex = 10;
            this.LabelScanningStepsDesc.Text = "The greater number of steps, the less likely you are to miss the cursor; but the " +
    "slower your scan will be.";
            // 
            // LabelScanningSteps
            // 
            this.LabelScanningSteps.AutoSize = true;
            this.LabelScanningSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScanningSteps.Location = new System.Drawing.Point(3, 12);
            this.LabelScanningSteps.Name = "LabelScanningSteps";
            this.LabelScanningSteps.Size = new System.Drawing.Size(100, 13);
            this.LabelScanningSteps.TabIndex = 9;
            this.LabelScanningSteps.Text = "Scanning Steps:";
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.lblAudioLevel);
            this.TabPage3.Controls.Add(this.pgbSoundLevel);
            this.TabPage3.Controls.Add(this.LabelAudioDeviceDesc);
            this.TabPage3.Controls.Add(this.cmbAudio);
            this.TabPage3.Controls.Add(this.LabelAudioDevice);
            this.TabPage3.Controls.Add(this.txtSplash);
            this.TabPage3.Controls.Add(this.LabelSplashThresholdDesc);
            this.TabPage3.Controls.Add(this.LabelSplashThreshold);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new System.Drawing.Size(487, 309);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "Hearing The Fish";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // lblAudioLevel
            // 
            this.lblAudioLevel.AutoSize = true;
            this.lblAudioLevel.Location = new System.Drawing.Point(466, 102);
            this.lblAudioLevel.Name = "lblAudioLevel";
            this.lblAudioLevel.Size = new System.Drawing.Size(13, 13);
            this.lblAudioLevel.TabIndex = 19;
            this.lblAudioLevel.Text = "0";
            // 
            // pgbSoundLevel
            // 
            this.pgbSoundLevel.Location = new System.Drawing.Point(278, 99);
            this.pgbSoundLevel.Name = "pgbSoundLevel";
            this.pgbSoundLevel.Size = new System.Drawing.Size(182, 21);
            this.pgbSoundLevel.TabIndex = 18;
            // 
            // LabelAudioDeviceDesc
            // 
            this.LabelAudioDeviceDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAudioDeviceDesc.Location = new System.Drawing.Point(11, 123);
            this.LabelAudioDeviceDesc.Name = "LabelAudioDeviceDesc";
            this.LabelAudioDeviceDesc.Size = new System.Drawing.Size(423, 73);
            this.LabelAudioDeviceDesc.TabIndex = 17;
            this.LabelAudioDeviceDesc.Text = "Select the audio device that WoW is Using.  If the bot cannot \'hear\' the game, it" +
    " will never catch any fish.  If you are unsure, play some music and select each " +
    "device until you find the right one.\r\n";
            // 
            // cmbAudio
            // 
            this.cmbAudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAudio.FormattingEnabled = true;
            this.cmbAudio.Items.AddRange(new object[] {
            "Default"});
            this.cmbAudio.Location = new System.Drawing.Point(173, 99);
            this.cmbAudio.Name = "cmbAudio";
            this.cmbAudio.Size = new System.Drawing.Size(99, 21);
            this.cmbAudio.TabIndex = 16;
            this.cmbAudio.SelectedIndexChanged += new System.EventHandler(this.cmbAudio_SelectedIndexChanged);
            // 
            // LabelAudioDevice
            // 
            this.LabelAudioDevice.AutoSize = true;
            this.LabelAudioDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAudioDevice.Location = new System.Drawing.Point(8, 102);
            this.LabelAudioDevice.Name = "LabelAudioDevice";
            this.LabelAudioDevice.Size = new System.Drawing.Size(87, 13);
            this.LabelAudioDevice.TabIndex = 15;
            this.LabelAudioDevice.Text = "Audio Device:";
            // 
            // txtSplash
            // 
            this.txtSplash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSplash.Location = new System.Drawing.Point(173, 8);
            this.txtSplash.Name = "txtSplash";
            this.txtSplash.Size = new System.Drawing.Size(32, 20);
            this.txtSplash.TabIndex = 14;
            // 
            // LabelSplashThresholdDesc
            // 
            this.LabelSplashThresholdDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSplashThresholdDesc.Location = new System.Drawing.Point(11, 31);
            this.LabelSplashThresholdDesc.Name = "LabelSplashThresholdDesc";
            this.LabelSplashThresholdDesc.Size = new System.Drawing.Size(423, 65);
            this.LabelSplashThresholdDesc.TabIndex = 13;
            this.LabelSplashThresholdDesc.Text = "Determines if a given sound is loud enough to be a fish or not.  Too low and the " +
    "bot will mistake non-fish for fish.  Too high and the bot will ignore the real f" +
    "ish.";
            // 
            // LabelSplashThreshold
            // 
            this.LabelSplashThreshold.AutoSize = true;
            this.LabelSplashThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSplashThreshold.Location = new System.Drawing.Point(8, 11);
            this.LabelSplashThreshold.Name = "LabelSplashThreshold";
            this.LabelSplashThreshold.Size = new System.Drawing.Size(109, 13);
            this.LabelSplashThreshold.TabIndex = 12;
            this.LabelSplashThreshold.Text = "Splash Threshold:";
            // 
            // TabPage4
            // 
            this.TabPage4.Controls.Add(this.cbRandomBait);
            this.TabPage4.Controls.Add(this.LabelBaitKey7);
            this.TabPage4.Controls.Add(this.txtBaitKey7);
            this.TabPage4.Controls.Add(this.LabelBaitKey6);
            this.TabPage4.Controls.Add(this.txtBaitKey6);
            this.TabPage4.Controls.Add(this.LabelBaitKey5);
            this.TabPage4.Controls.Add(this.txtBaitKey5);
            this.TabPage4.Controls.Add(this.LabelBaitKey4);
            this.TabPage4.Controls.Add(this.txtBaitKey4);
            this.TabPage4.Controls.Add(this.LabelBaitKey3);
            this.TabPage4.Controls.Add(this.txtBaitKey3);
            this.TabPage4.Controls.Add(this.LabelBaitKey2);
            this.TabPage4.Controls.Add(this.txtBaitKey2);
            this.TabPage4.Controls.Add(this.cbShiftLoot);
            this.TabPage4.Controls.Add(this.cbApplyCharm);
            this.TabPage4.Controls.Add(this.cbApplyRaft);
            this.TabPage4.Controls.Add(this.txtCharmKey);
            this.TabPage4.Controls.Add(this.LabelCharmKey);
            this.TabPage4.Controls.Add(this.txtRaftKey);
            this.TabPage4.Controls.Add(this.LabelRaftKey);
            this.TabPage4.Controls.Add(this.txtHearthTime);
            this.TabPage4.Controls.Add(this.cbAlt);
            this.TabPage4.Controls.Add(this.cbHearth);
            this.TabPage4.Controls.Add(this.LabelCustomizeDesc);
            this.TabPage4.Controls.Add(this.txtProcName);
            this.TabPage4.Controls.Add(this.LabelProcessNameDesc);
            this.TabPage4.Controls.Add(this.LabelProcessName);
            this.TabPage4.Controls.Add(this.cbAutoLure);
            this.TabPage4.Controls.Add(this.txtHearthKey);
            this.TabPage4.Controls.Add(this.LabelHearthKey);
            this.TabPage4.Controls.Add(this.txtLureKey);
            this.TabPage4.Controls.Add(this.LabelLureKey);
            this.TabPage4.Controls.Add(this.txtFishKey);
            this.TabPage4.Controls.Add(this.LabelCastKey);
            this.TabPage4.Controls.Add(this.LabelBaitKey1);
            this.TabPage4.Controls.Add(this.txtBaitKey1);
            this.TabPage4.Controls.Add(this.cbAutoBait);
            this.TabPage4.Location = new System.Drawing.Point(4, 22);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Size = new System.Drawing.Size(487, 309);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "Premium Settings";
            this.TabPage4.UseVisualStyleBackColor = true;
            // 
            // cbRandomBait
            // 
            this.cbRandomBait.AutoSize = true;
            this.cbRandomBait.Location = new System.Drawing.Point(267, 206);
            this.cbRandomBait.Name = "cbRandomBait";
            this.cbRandomBait.Size = new System.Drawing.Size(203, 17);
            this.cbRandomBait.TabIndex = 48;
            this.cbRandomBait.Text = "Random bait between the 7 possibles";
            this.cbRandomBait.UseVisualStyleBackColor = true;
            // 
            // LabelBaitKey7
            // 
            this.LabelBaitKey7.AutoSize = true;
            this.LabelBaitKey7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBaitKey7.Location = new System.Drawing.Point(144, 115);
            this.LabelBaitKey7.Name = "LabelBaitKey7";
            this.LabelBaitKey7.Size = new System.Drawing.Size(101, 13);
            this.LabelBaitKey7.TabIndex = 47;
            this.LabelBaitKey7.Text = "WoD Bait Key 7:";
            // 
            // txtBaitKey7
            // 
            this.txtBaitKey7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaitKey7.Location = new System.Drawing.Point(244, 112);
            this.txtBaitKey7.Name = "txtBaitKey7";
            this.txtBaitKey7.Size = new System.Drawing.Size(22, 20);
            this.txtBaitKey7.TabIndex = 46;
            this.txtBaitKey7.Text = "=";
            // 
            // LabelBaitKey6
            // 
            this.LabelBaitKey6.AutoSize = true;
            this.LabelBaitKey6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBaitKey6.Location = new System.Drawing.Point(144, 93);
            this.LabelBaitKey6.Name = "LabelBaitKey6";
            this.LabelBaitKey6.Size = new System.Drawing.Size(101, 13);
            this.LabelBaitKey6.TabIndex = 45;
            this.LabelBaitKey6.Text = "WoD Bait Key 6:";
            // 
            // txtBaitKey6
            // 
            this.txtBaitKey6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaitKey6.Location = new System.Drawing.Point(244, 90);
            this.txtBaitKey6.Name = "txtBaitKey6";
            this.txtBaitKey6.Size = new System.Drawing.Size(22, 20);
            this.txtBaitKey6.TabIndex = 44;
            this.txtBaitKey6.Text = ")";
            // 
            // LabelBaitKey5
            // 
            this.LabelBaitKey5.AutoSize = true;
            this.LabelBaitKey5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBaitKey5.Location = new System.Drawing.Point(144, 71);
            this.LabelBaitKey5.Name = "LabelBaitKey5";
            this.LabelBaitKey5.Size = new System.Drawing.Size(101, 13);
            this.LabelBaitKey5.TabIndex = 43;
            this.LabelBaitKey5.Text = "WoD Bait Key 5:";
            // 
            // txtBaitKey5
            // 
            this.txtBaitKey5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaitKey5.Location = new System.Drawing.Point(244, 68);
            this.txtBaitKey5.Name = "txtBaitKey5";
            this.txtBaitKey5.Size = new System.Drawing.Size(22, 20);
            this.txtBaitKey5.TabIndex = 42;
            this.txtBaitKey5.Text = "0";
            // 
            // LabelBaitKey4
            // 
            this.LabelBaitKey4.AutoSize = true;
            this.LabelBaitKey4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBaitKey4.Location = new System.Drawing.Point(8, 115);
            this.LabelBaitKey4.Name = "LabelBaitKey4";
            this.LabelBaitKey4.Size = new System.Drawing.Size(101, 13);
            this.LabelBaitKey4.TabIndex = 41;
            this.LabelBaitKey4.Text = "WoD Bait Key 4:";
            // 
            // txtBaitKey4
            // 
            this.txtBaitKey4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaitKey4.Location = new System.Drawing.Point(108, 112);
            this.txtBaitKey4.Name = "txtBaitKey4";
            this.txtBaitKey4.Size = new System.Drawing.Size(22, 20);
            this.txtBaitKey4.TabIndex = 40;
            this.txtBaitKey4.Text = "9";
            // 
            // LabelBaitKey3
            // 
            this.LabelBaitKey3.AutoSize = true;
            this.LabelBaitKey3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBaitKey3.Location = new System.Drawing.Point(8, 93);
            this.LabelBaitKey3.Name = "LabelBaitKey3";
            this.LabelBaitKey3.Size = new System.Drawing.Size(101, 13);
            this.LabelBaitKey3.TabIndex = 39;
            this.LabelBaitKey3.Text = "WoD Bait Key 3:";
            // 
            // txtBaitKey3
            // 
            this.txtBaitKey3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaitKey3.Location = new System.Drawing.Point(108, 90);
            this.txtBaitKey3.Name = "txtBaitKey3";
            this.txtBaitKey3.Size = new System.Drawing.Size(22, 20);
            this.txtBaitKey3.TabIndex = 38;
            this.txtBaitKey3.Text = "8";
            // 
            // LabelBaitKey2
            // 
            this.LabelBaitKey2.AutoSize = true;
            this.LabelBaitKey2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBaitKey2.Location = new System.Drawing.Point(8, 71);
            this.LabelBaitKey2.Name = "LabelBaitKey2";
            this.LabelBaitKey2.Size = new System.Drawing.Size(101, 13);
            this.LabelBaitKey2.TabIndex = 37;
            this.LabelBaitKey2.Text = "WoD Bait Key 2:";
            // 
            // txtBaitKey2
            // 
            this.txtBaitKey2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaitKey2.Location = new System.Drawing.Point(108, 68);
            this.txtBaitKey2.Name = "txtBaitKey2";
            this.txtBaitKey2.Size = new System.Drawing.Size(22, 20);
            this.txtBaitKey2.TabIndex = 36;
            this.txtBaitKey2.Text = "7";
            // 
            // cbShiftLoot
            // 
            this.cbShiftLoot.AutoSize = true;
            this.cbShiftLoot.Location = new System.Drawing.Point(11, 229);
            this.cbShiftLoot.Name = "cbShiftLoot";
            this.cbShiftLoot.Size = new System.Drawing.Size(254, 17);
            this.cbShiftLoot.TabIndex = 34;
            this.cbShiftLoot.Text = "Shift-Loot? (If AutoLoot is Disabled, Enable This)";
            this.cbShiftLoot.UseVisualStyleBackColor = true;
            // 
            // cbApplyCharm
            // 
            this.cbApplyCharm.AutoSize = true;
            this.cbApplyCharm.Location = new System.Drawing.Point(267, 185);
            this.cbApplyCharm.Name = "cbApplyCharm";
            this.cbApplyCharm.Size = new System.Drawing.Size(180, 17);
            this.cbApplyCharm.TabIndex = 33;
            this.cbApplyCharm.Text = "Refresh Charm Every 60 minutes";
            this.cbApplyCharm.UseVisualStyleBackColor = true;
            // 
            // cbApplyRaft
            // 
            this.cbApplyRaft.AutoSize = true;
            this.cbApplyRaft.Location = new System.Drawing.Point(11, 185);
            this.cbApplyRaft.Name = "cbApplyRaft";
            this.cbApplyRaft.Size = new System.Drawing.Size(164, 17);
            this.cbApplyRaft.TabIndex = 32;
            this.cbApplyRaft.Text = "Refresh Raft Every 8 minutes";
            this.cbApplyRaft.UseVisualStyleBackColor = true;
            // 
            // txtCharmKey
            // 
            this.txtCharmKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharmKey.Location = new System.Drawing.Point(267, 38);
            this.txtCharmKey.Name = "txtCharmKey";
            this.txtCharmKey.Size = new System.Drawing.Size(22, 20);
            this.txtCharmKey.TabIndex = 31;
            this.txtCharmKey.Text = "5";
            // 
            // LabelCharmKey
            // 
            this.LabelCharmKey.AutoSize = true;
            this.LabelCharmKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCharmKey.Location = new System.Drawing.Point(150, 41);
            this.LabelCharmKey.Name = "LabelCharmKey";
            this.LabelCharmKey.Size = new System.Drawing.Size(100, 13);
            this.LabelCharmKey.TabIndex = 30;
            this.LabelCharmKey.Text = "MoP Charm Key:";
            // 
            // txtRaftKey
            // 
            this.txtRaftKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaftKey.Location = new System.Drawing.Point(108, 38);
            this.txtRaftKey.Name = "txtRaftKey";
            this.txtRaftKey.Size = new System.Drawing.Size(22, 20);
            this.txtRaftKey.TabIndex = 29;
            this.txtRaftKey.Text = "4";
            // 
            // LabelRaftKey
            // 
            this.LabelRaftKey.AutoSize = true;
            this.LabelRaftKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRaftKey.Location = new System.Drawing.Point(5, 41);
            this.LabelRaftKey.Name = "LabelRaftKey";
            this.LabelRaftKey.Size = new System.Drawing.Size(89, 13);
            this.LabelRaftKey.TabIndex = 28;
            this.LabelRaftKey.Text = "MoP Raft Key:";
            // 
            // txtHearthTime
            // 
            this.txtHearthTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHearthTime.Location = new System.Drawing.Point(443, 160);
            this.txtHearthTime.Name = "txtHearthTime";
            this.txtHearthTime.Size = new System.Drawing.Size(30, 20);
            this.txtHearthTime.TabIndex = 27;
            this.txtHearthTime.Text = "3";
            // 
            // cbAlt
            // 
            this.cbAlt.AutoSize = true;
            this.cbAlt.Location = new System.Drawing.Point(365, 17);
            this.cbAlt.Name = "cbAlt";
            this.cbAlt.Size = new System.Drawing.Size(119, 17);
            this.cbAlt.TabIndex = 6;
            this.cbAlt.Text = "Use Alt-Key Modifer";
            this.cbAlt.UseVisualStyleBackColor = true;
            // 
            // cbHearth
            // 
            this.cbHearth.AutoSize = true;
            this.cbHearth.Location = new System.Drawing.Point(267, 163);
            this.cbHearth.Name = "cbHearth";
            this.cbHearth.Size = new System.Drawing.Size(170, 17);
            this.cbHearth.TabIndex = 8;
            this.cbHearth.Text = "Hearth To Inn After X Minutes:";
            this.cbHearth.UseVisualStyleBackColor = true;
            // 
            // LabelCustomizeDesc
            // 
            this.LabelCustomizeDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCustomizeDesc.Location = new System.Drawing.Point(8, 135);
            this.LabelCustomizeDesc.Name = "LabelCustomizeDesc";
            this.LabelCustomizeDesc.Size = new System.Drawing.Size(423, 17);
            this.LabelCustomizeDesc.TabIndex = 26;
            this.LabelCustomizeDesc.Text = "Customize shortkeys to avoid rearranging your bars before/after fishing.";
            // 
            // txtProcName
            // 
            this.txtProcName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcName.Location = new System.Drawing.Point(141, 256);
            this.txtProcName.Name = "txtProcName";
            this.txtProcName.Size = new System.Drawing.Size(255, 20);
            this.txtProcName.TabIndex = 9;
            this.txtProcName.Text = "Wow-64";
            // 
            // LabelProcessNameDesc
            // 
            this.LabelProcessNameDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProcessNameDesc.Location = new System.Drawing.Point(8, 278);
            this.LabelProcessNameDesc.Name = "LabelProcessNameDesc";
            this.LabelProcessNameDesc.Size = new System.Drawing.Size(423, 31);
            this.LabelProcessNameDesc.TabIndex = 23;
            this.LabelProcessNameDesc.Text = "The name of the process to activate (this rarely changes) but has been updated wi" +
    "th new expansions in the past.";
            // 
            // LabelProcessName
            // 
            this.LabelProcessName.AutoSize = true;
            this.LabelProcessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProcessName.Location = new System.Drawing.Point(8, 259);
            this.LabelProcessName.Name = "LabelProcessName";
            this.LabelProcessName.Size = new System.Drawing.Size(127, 13);
            this.LabelProcessName.TabIndex = 22;
            this.LabelProcessName.Text = "WoW Process Name:";
            // 
            // cbAutoLure
            // 
            this.cbAutoLure.AutoSize = true;
            this.cbAutoLure.Location = new System.Drawing.Point(11, 163);
            this.cbAutoLure.Name = "cbAutoLure";
            this.cbAutoLure.Size = new System.Drawing.Size(160, 17);
            this.cbAutoLure.TabIndex = 7;
            this.cbAutoLure.Text = "Apply Lure Every 10 minutes";
            this.cbAutoLure.UseVisualStyleBackColor = true;
            // 
            // txtHearthKey
            // 
            this.txtHearthKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHearthKey.Location = new System.Drawing.Point(337, 16);
            this.txtHearthKey.Name = "txtHearthKey";
            this.txtHearthKey.Size = new System.Drawing.Size(22, 20);
            this.txtHearthKey.TabIndex = 3;
            this.txtHearthKey.Text = "3";
            // 
            // LabelHearthKey
            // 
            this.LabelHearthKey.AutoSize = true;
            this.LabelHearthKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHearthKey.Location = new System.Drawing.Point(241, 19);
            this.LabelHearthKey.Name = "LabelHearthKey";
            this.LabelHearthKey.Size = new System.Drawing.Size(74, 13);
            this.LabelHearthKey.TabIndex = 19;
            this.LabelHearthKey.Text = "Hearth Key:";
            // 
            // txtLureKey
            // 
            this.txtLureKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLureKey.Location = new System.Drawing.Point(213, 16);
            this.txtLureKey.Name = "txtLureKey";
            this.txtLureKey.Size = new System.Drawing.Size(22, 20);
            this.txtLureKey.TabIndex = 2;
            this.txtLureKey.Text = "2";
            // 
            // LabelLureKey
            // 
            this.LabelLureKey.AutoSize = true;
            this.LabelLureKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLureKey.Location = new System.Drawing.Point(115, 19);
            this.LabelLureKey.Name = "LabelLureKey";
            this.LabelLureKey.Size = new System.Drawing.Size(61, 13);
            this.LabelLureKey.TabIndex = 17;
            this.LabelLureKey.Text = "Lure Key:";
            // 
            // txtFishKey
            // 
            this.txtFishKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFishKey.Location = new System.Drawing.Point(87, 15);
            this.txtFishKey.Name = "txtFishKey";
            this.txtFishKey.Size = new System.Drawing.Size(22, 20);
            this.txtFishKey.TabIndex = 1;
            this.txtFishKey.Text = "1";
            // 
            // LabelCastKey
            // 
            this.LabelCastKey.AutoSize = true;
            this.LabelCastKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCastKey.Location = new System.Drawing.Point(5, 19);
            this.LabelCastKey.Name = "LabelCastKey";
            this.LabelCastKey.Size = new System.Drawing.Size(61, 13);
            this.LabelCastKey.TabIndex = 15;
            this.LabelCastKey.Text = "Cast Key:";
            // 
            // LabelBaitKey1
            // 
            this.LabelBaitKey1.AutoSize = true;
            this.LabelBaitKey1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBaitKey1.Location = new System.Drawing.Point(295, 41);
            this.LabelBaitKey1.Name = "LabelBaitKey1";
            this.LabelBaitKey1.Size = new System.Drawing.Size(101, 13);
            this.LabelBaitKey1.TabIndex = 35;
            this.LabelBaitKey1.Text = "WoD Bait Key 1:";
            // 
            // txtBaitKey1
            // 
            this.txtBaitKey1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaitKey1.Location = new System.Drawing.Point(402, 38);
            this.txtBaitKey1.Name = "txtBaitKey1";
            this.txtBaitKey1.Size = new System.Drawing.Size(22, 20);
            this.txtBaitKey1.TabIndex = 29;
            this.txtBaitKey1.Text = "6";
            // 
            // cbAutoBait
            // 
            this.cbAutoBait.AutoSize = true;
            this.cbAutoBait.Location = new System.Drawing.Point(11, 207);
            this.cbAutoBait.Name = "cbAutoBait";
            this.cbAutoBait.Size = new System.Drawing.Size(151, 17);
            this.cbAutoBait.TabIndex = 32;
            this.cbAutoBait.Text = "Apply Bait Every 5 minutes";
            this.cbAutoBait.UseVisualStyleBackColor = true;
            // 
            // LabelScanningDelay
            // 
            this.LabelScanningDelay.AutoSize = true;
            this.LabelScanningDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScanningDelay.Location = new System.Drawing.Point(2, 82);
            this.LabelScanningDelay.Name = "LabelScanningDelay";
            this.LabelScanningDelay.Size = new System.Drawing.Size(100, 13);
            this.LabelScanningDelay.TabIndex = 12;
            this.LabelScanningDelay.Text = "Scanning Delay:";
            // 
            // tmeAudio
            // 
            this.tmeAudio.Interval = 250;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(157, 341);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDelay
            // 
            this.txtDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelay.Location = new System.Drawing.Point(128, 79);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(32, 20);
            this.txtDelay.TabIndex = 14;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.TabPage2);
            this.tabSettings.Controls.Add(this.TabPage1);
            this.tabSettings.Controls.Add(this.TabPage3);
            this.tabSettings.Controls.Add(this.TabPage4);
            this.tabSettings.Controls.Add(this.TabPage5);
            this.tabSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabSettings.Location = new System.Drawing.Point(0, 0);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(495, 335);
            this.tabSettings.TabIndex = 12;
            this.tabSettings.SelectedIndexChanged += new System.EventHandler(this.tabSettings_SelectedIndexChanged);
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.txtFishWait);
            this.TabPage2.Controls.Add(this.LabelFishWaitDesc);
            this.TabPage2.Controls.Add(this.LabelDelayLooting);
            this.TabPage2.Controls.Add(this.txtLootingDelay);
            this.TabPage2.Controls.Add(this.LabelDelayLootingDesc);
            this.TabPage2.Controls.Add(this.LabelFishWait);
            this.TabPage2.Controls.Add(this.txtCastDelay);
            this.TabPage2.Controls.Add(this.LabelDelayCastDesc);
            this.TabPage2.Controls.Add(this.LabelDelayCast);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(487, 309);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "General Fishing";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // txtFishWait
            // 
            this.txtFishWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFishWait.Location = new System.Drawing.Point(153, 77);
            this.txtFishWait.Name = "txtFishWait";
            this.txtFishWait.Size = new System.Drawing.Size(53, 20);
            this.txtFishWait.TabIndex = 20;
            // 
            // LabelFishWaitDesc
            // 
            this.LabelFishWaitDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFishWaitDesc.Location = new System.Drawing.Point(11, 100);
            this.LabelFishWaitDesc.Name = "LabelFishWaitDesc";
            this.LabelFishWaitDesc.Size = new System.Drawing.Size(423, 31);
            this.LabelFishWaitDesc.TabIndex = 19;
            this.LabelFishWaitDesc.Text = "The number of milliseconds to listen for a fish before giving up. Too long decrea" +
    "se bots effectiveness, too short and you miss fish.";
            // 
            // LabelDelayLooting
            // 
            this.LabelDelayLooting.AutoSize = true;
            this.LabelDelayLooting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDelayLooting.Location = new System.Drawing.Point(8, 144);
            this.LabelDelayLooting.Name = "LabelDelayLooting";
            this.LabelDelayLooting.Size = new System.Drawing.Size(120, 13);
            this.LabelDelayLooting.TabIndex = 18;
            this.LabelDelayLooting.Text = "Delay After Looting:";
            // 
            // txtLootingDelay
            // 
            this.txtLootingDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLootingDelay.Location = new System.Drawing.Point(153, 141);
            this.txtLootingDelay.Name = "txtLootingDelay";
            this.txtLootingDelay.Size = new System.Drawing.Size(53, 20);
            this.txtLootingDelay.TabIndex = 17;
            // 
            // LabelDelayLootingDesc
            // 
            this.LabelDelayLootingDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDelayLootingDesc.Location = new System.Drawing.Point(11, 164);
            this.LabelDelayLootingDesc.Name = "LabelDelayLootingDesc";
            this.LabelDelayLootingDesc.Size = new System.Drawing.Size(423, 20);
            this.LabelDelayLootingDesc.TabIndex = 16;
            this.LabelDelayLootingDesc.Text = "The number of milliseconds to wait after looting a fish.";
            // 
            // LabelFishWait
            // 
            this.LabelFishWait.AutoSize = true;
            this.LabelFishWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFishWait.Location = new System.Drawing.Point(8, 80);
            this.LabelFishWait.Name = "LabelFishWait";
            this.LabelFishWait.Size = new System.Drawing.Size(94, 13);
            this.LabelFishWait.TabIndex = 15;
            this.LabelFishWait.Text = "Fish Wait Limit:";
            // 
            // txtCastDelay
            // 
            this.txtCastDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCastDelay.Location = new System.Drawing.Point(153, 12);
            this.txtCastDelay.Name = "txtCastDelay";
            this.txtCastDelay.Size = new System.Drawing.Size(53, 20);
            this.txtCastDelay.TabIndex = 14;
            // 
            // LabelDelayCastDesc
            // 
            this.LabelDelayCastDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDelayCastDesc.Location = new System.Drawing.Point(11, 35);
            this.LabelDelayCastDesc.Name = "LabelDelayCastDesc";
            this.LabelDelayCastDesc.Size = new System.Drawing.Size(423, 31);
            this.LabelDelayCastDesc.TabIndex = 13;
            this.LabelDelayCastDesc.Text = "The number of milliseconds to wait after the cast before searching. Too short and" +
    " you\'ll skip the bobber, too long and you\'ll waste time.";
            // 
            // LabelDelayCast
            // 
            this.LabelDelayCast.AutoSize = true;
            this.LabelDelayCast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDelayCast.Location = new System.Drawing.Point(8, 15);
            this.LabelDelayCast.Name = "LabelDelayCast";
            this.LabelDelayCast.Size = new System.Drawing.Size(103, 13);
            this.LabelDelayCast.TabIndex = 12;
            this.LabelDelayCast.Text = "Delay After Cast:";
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.LabelCheckCursorIcon);
            this.TabPage1.Controls.Add(this.cmbCompareIcon);
            this.TabPage1.Controls.Add(this.txtRetries);
            this.TabPage1.Controls.Add(this.LabelScanningRetriesDesc);
            this.TabPage1.Controls.Add(this.LabelScanningRetries);
            this.TabPage1.Controls.Add(this.txtDelay);
            this.TabPage1.Controls.Add(this.LabelScanningDelayDesc);
            this.TabPage1.Controls.Add(this.LabelScanningDelay);
            this.TabPage1.Controls.Add(this.txtScanSteps);
            this.TabPage1.Controls.Add(this.LabelScanningStepsDesc);
            this.TabPage1.Controls.Add(this.LabelScanningSteps);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(487, 309);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Finding The Cursor";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // txtRetries
            // 
            this.txtRetries.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetries.Location = new System.Drawing.Point(129, 154);
            this.txtRetries.Name = "txtRetries";
            this.txtRetries.Size = new System.Drawing.Size(32, 20);
            this.txtRetries.TabIndex = 17;
            // 
            // LabelScanningRetriesDesc
            // 
            this.LabelScanningRetriesDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScanningRetriesDesc.Location = new System.Drawing.Point(6, 177);
            this.LabelScanningRetriesDesc.Name = "LabelScanningRetriesDesc";
            this.LabelScanningRetriesDesc.Size = new System.Drawing.Size(423, 38);
            this.LabelScanningRetriesDesc.TabIndex = 16;
            this.LabelScanningRetriesDesc.Text = "How many times to run the search pattern.";
            // 
            // LabelScanningRetries
            // 
            this.LabelScanningRetries.AutoSize = true;
            this.LabelScanningRetries.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScanningRetries.Location = new System.Drawing.Point(3, 157);
            this.LabelScanningRetries.Name = "LabelScanningRetries";
            this.LabelScanningRetries.Size = new System.Drawing.Size(108, 13);
            this.LabelScanningRetries.TabIndex = 15;
            this.LabelScanningRetries.Text = "Scanning Retries:";
            // 
            // TabPage5
            // 
            this.TabPage5.Controls.Add(this.cmbLanguage);
            this.TabPage5.Controls.Add(this.labelLanguageDesc);
            this.TabPage5.Controls.Add(this.labelLanguage);
            this.TabPage5.Location = new System.Drawing.Point(4, 22);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage5.Size = new System.Drawing.Size(487, 309);
            this.TabPage5.TabIndex = 4;
            this.TabPage5.Text = "Language";
            this.TabPage5.UseVisualStyleBackColor = true;
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Items.AddRange(new object[] {
            "Default"});
            this.cmbLanguage.Location = new System.Drawing.Point(181, 133);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(99, 21);
            this.cmbLanguage.TabIndex = 17;
            // 
            // labelLanguageDesc
            // 
            this.labelLanguageDesc.AutoSize = true;
            this.labelLanguageDesc.Location = new System.Drawing.Point(127, 157);
            this.labelLanguageDesc.Name = "labelLanguageDesc";
            this.labelLanguageDesc.Size = new System.Drawing.Size(271, 26);
            this.labelLanguageDesc.TabIndex = 16;
            this.labelLanguageDesc.Text = "Select the language file that you want to use.\r\nLanguage XML Files must be found " +
    "in Resources folder.";
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Location = new System.Drawing.Point(114, 137);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(61, 13);
            this.labelLanguage.TabIndex = 0;
            this.labelLanguage.Text = "Language :";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(255, 341);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbCompareIcon
            // 
            this.cmbCompareIcon.AutoSize = true;
            this.cmbCompareIcon.Location = new System.Drawing.Point(5, 228);
            this.cmbCompareIcon.Name = "cmbCompareIcon";
            this.cmbCompareIcon.Size = new System.Drawing.Size(114, 17);
            this.cmbCompareIcon.TabIndex = 18;
            this.cmbCompareIcon.Text = "Check Cursor Icon";
            this.cmbCompareIcon.UseVisualStyleBackColor = true;
            // 
            // LabelCheckCursorIcon
            // 
            this.LabelCheckCursorIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCheckCursorIcon.Location = new System.Drawing.Point(3, 248);
            this.LabelCheckCursorIcon.Name = "LabelCheckCursorIcon";
            this.LabelCheckCursorIcon.Size = new System.Drawing.Size(423, 58);
            this.LabelCheckCursorIcon.TabIndex = 19;
            this.LabelCheckCursorIcon.Text = "Specify if the bot must check the icon before fishing. Avoid clicking when it\'s n" +
    "ot a bobber. May not work on some computer, disable if the bot don\'t find your b" +
    "obber.";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 371);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabSettings);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmSettings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            this.TabPage4.ResumeLayout(false);
            this.TabPage4.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage5.ResumeLayout(false);
            this.TabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label LabelScanningDelayDesc;
        internal System.Windows.Forms.TextBox txtScanSteps;
        internal System.Windows.Forms.Label LabelScanningStepsDesc;
        internal System.Windows.Forms.Label LabelScanningSteps;
        internal System.Windows.Forms.TabPage TabPage3;
        internal System.Windows.Forms.Label lblAudioLevel;
        internal System.Windows.Forms.ProgressBar pgbSoundLevel;
        internal System.Windows.Forms.Label LabelAudioDeviceDesc;
        internal System.Windows.Forms.ComboBox cmbAudio;
        internal System.Windows.Forms.Label LabelAudioDevice;
        internal System.Windows.Forms.TextBox txtSplash;
        internal System.Windows.Forms.Label LabelSplashThresholdDesc;
        internal System.Windows.Forms.Label LabelSplashThreshold;
        internal System.Windows.Forms.TabPage TabPage4;
        internal System.Windows.Forms.CheckBox cbRandomBait;
        internal System.Windows.Forms.Label LabelBaitKey7;
        internal System.Windows.Forms.TextBox txtBaitKey7;
        internal System.Windows.Forms.Label LabelBaitKey6;
        internal System.Windows.Forms.TextBox txtBaitKey6;
        internal System.Windows.Forms.Label LabelBaitKey5;
        internal System.Windows.Forms.TextBox txtBaitKey5;
        internal System.Windows.Forms.Label LabelBaitKey4;
        internal System.Windows.Forms.TextBox txtBaitKey4;
        internal System.Windows.Forms.Label LabelBaitKey3;
        internal System.Windows.Forms.TextBox txtBaitKey3;
        internal System.Windows.Forms.Label LabelBaitKey2;
        internal System.Windows.Forms.TextBox txtBaitKey2;
        internal System.Windows.Forms.CheckBox cbShiftLoot;
        internal System.Windows.Forms.CheckBox cbApplyCharm;
        internal System.Windows.Forms.CheckBox cbApplyRaft;
        internal System.Windows.Forms.TextBox txtCharmKey;
        internal System.Windows.Forms.Label LabelCharmKey;
        internal System.Windows.Forms.TextBox txtRaftKey;
        internal System.Windows.Forms.Label LabelRaftKey;
        internal System.Windows.Forms.TextBox txtHearthTime;
        internal System.Windows.Forms.CheckBox cbAlt;
        internal System.Windows.Forms.CheckBox cbHearth;
        internal System.Windows.Forms.Label LabelCustomizeDesc;
        internal System.Windows.Forms.TextBox txtProcName;
        internal System.Windows.Forms.Label LabelProcessNameDesc;
        internal System.Windows.Forms.Label LabelProcessName;
        internal System.Windows.Forms.CheckBox cbAutoLure;
        internal System.Windows.Forms.TextBox txtHearthKey;
        internal System.Windows.Forms.Label LabelHearthKey;
        internal System.Windows.Forms.TextBox txtLureKey;
        internal System.Windows.Forms.Label LabelLureKey;
        internal System.Windows.Forms.TextBox txtFishKey;
        internal System.Windows.Forms.Label LabelCastKey;
        internal System.Windows.Forms.Label LabelBaitKey1;
        internal System.Windows.Forms.TextBox txtBaitKey1;
        internal System.Windows.Forms.CheckBox cbAutoBait;
        internal System.Windows.Forms.Label LabelScanningDelay;
        internal System.Windows.Forms.Timer tmeAudio;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.TextBox txtDelay;
        internal System.Windows.Forms.TabControl tabSettings;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.TextBox txtFishWait;
        internal System.Windows.Forms.Label LabelFishWaitDesc;
        internal System.Windows.Forms.Label LabelDelayLooting;
        internal System.Windows.Forms.TextBox txtLootingDelay;
        internal System.Windows.Forms.Label LabelDelayLootingDesc;
        internal System.Windows.Forms.Label LabelFishWait;
        internal System.Windows.Forms.TextBox txtCastDelay;
        internal System.Windows.Forms.Label LabelDelayCastDesc;
        internal System.Windows.Forms.Label LabelDelayCast;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.TextBox txtRetries;
        internal System.Windows.Forms.Label LabelScanningRetriesDesc;
        internal System.Windows.Forms.Label LabelScanningRetries;
        internal System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabPage TabPage5;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.Label labelLanguageDesc;
        internal System.Windows.Forms.ComboBox cmbLanguage;
        internal System.Windows.Forms.Label LabelCheckCursorIcon;
        internal System.Windows.Forms.CheckBox cmbCompareIcon;

    }
}