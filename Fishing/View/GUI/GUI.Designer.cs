﻿using Fishing.BL;

namespace Fishing
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.SounderUpdater = new System.Windows.Forms.Timer(this.components);
            this.SpeedBar = new System.Windows.Forms.TrackBar();
            this.eventsList = new System.Windows.Forms.ImageList(this.components);
            this.sounderBack = new System.Windows.Forms.Panel();
            this.SounderPanel = new System.Windows.Forms.Panel();
            this.LureDeep = new System.Windows.Forms.Label();
            this.TextDeepLabel = new System.Windows.Forms.Label();
            this.DeepLabel = new System.Windows.Forms.Label();
            this.LowerPanel = new System.Windows.Forms.Panel();
            this.WiringTypeLabel = new System.Windows.Forms.Label();
            this.StatsBox = new System.Windows.Forms.PictureBox();
            this.InventoryBox = new System.Windows.Forms.PictureBox();
            this.eventsView = new System.Windows.Forms.ListView();
            this.ReelBar = new System.Windows.Forms.ProgressBar();
            this.FLineBar = new System.Windows.Forms.ProgressBar();
            this.BaitsPicture = new System.Windows.Forms.PictureBox();
            this.FpondBox = new System.Windows.Forms.PictureBox();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.MenuLabel = new System.Windows.Forms.Label();
            this.InventoryLabel = new System.Windows.Forms.Label();
            this.MoneyLabel = new System.Windows.Forms.Label();
            this.SettingLabel = new System.Windows.Forms.Label();
            this.MapLabel = new System.Windows.Forms.Label();
            this.eatingBar = new VerticalProgressBar.VerticalProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedBar)).BeginInit();
            this.sounderBack.SuspendLayout();
            this.SounderPanel.SuspendLayout();
            this.LowerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaitsPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FpondBox)).BeginInit();
            this.UpperPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SounderUpdater
            // 
            this.SounderUpdater.Enabled = true;
            this.SounderUpdater.Interval = 10;
            this.SounderUpdater.Tick += new System.EventHandler(this.SounderUpdater_Tick);
            // 
            // SpeedBar
            // 
            this.SpeedBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.SpeedBar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.SpeedBar.LargeChange = 1;
            this.SpeedBar.Location = new System.Drawing.Point(5, 161);
            this.SpeedBar.Minimum = 1;
            this.SpeedBar.Name = "SpeedBar";
            this.SpeedBar.Size = new System.Drawing.Size(240, 45);
            this.SpeedBar.TabIndex = 22;
            this.SpeedBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.SpeedBar.Value = 1;
            // 
            // eventsList
            // 
            this.eventsList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("eventsList.ImageStream")));
            this.eventsList.TransparentColor = System.Drawing.Color.Transparent;
            this.eventsList.Images.SetKeyName(0, "break.png");
            this.eventsList.Images.SetKeyName(1, "hvastun.png");
            this.eventsList.Images.SetKeyName(2, "spoon.png");
            this.eventsList.Images.SetKeyName(3, "vert.png");
            this.eventsList.Images.SetKeyName(4, "deepvobler.png");
            this.eventsList.Images.SetKeyName(5, "sriv.png");
            this.eventsList.Images.SetKeyName(6, "vibro.png");
            // 
            // sounderBack
            // 
            this.sounderBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sounderBack.BackgroundImage")));
            this.sounderBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sounderBack.Controls.Add(this.SounderPanel);
            this.sounderBack.Location = new System.Drawing.Point(852, 115);
            this.sounderBack.Name = "sounderBack";
            this.sounderBack.Size = new System.Drawing.Size(179, 126);
            this.sounderBack.TabIndex = 24;
            // 
            // SounderPanel
            // 
            this.SounderPanel.BackColor = System.Drawing.Color.Wheat;
            this.SounderPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SounderPanel.Controls.Add(this.LureDeep);
            this.SounderPanel.Controls.Add(this.TextDeepLabel);
            this.SounderPanel.Controls.Add(this.DeepLabel);
            this.SounderPanel.Location = new System.Drawing.Point(5, 3);
            this.SounderPanel.Name = "SounderPanel";
            this.SounderPanel.Size = new System.Drawing.Size(171, 120);
            this.SounderPanel.TabIndex = 22;
            this.SounderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SounderPanel_Paint);
            // 
            // LureDeep
            // 
            this.LureDeep.AutoSize = true;
            this.LureDeep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LureDeep.ForeColor = System.Drawing.Color.Red;
            this.LureDeep.Location = new System.Drawing.Point(3, 99);
            this.LureDeep.Name = "LureDeep";
            this.LureDeep.Size = new System.Drawing.Size(19, 20);
            this.LureDeep.TabIndex = 22;
            this.LureDeep.Text = "0";
            // 
            // TextDeepLabel
            // 
            this.TextDeepLabel.AutoSize = true;
            this.TextDeepLabel.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextDeepLabel.Location = new System.Drawing.Point(67, 100);
            this.TextDeepLabel.Name = "TextDeepLabel";
            this.TextDeepLabel.Size = new System.Drawing.Size(60, 17);
            this.TextDeepLabel.TabIndex = 21;
            this.TextDeepLabel.Text = "Глубина:";
            // 
            // DeepLabel
            // 
            this.DeepLabel.AutoSize = true;
            this.DeepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeepLabel.ForeColor = System.Drawing.Color.Red;
            this.DeepLabel.Location = new System.Drawing.Point(133, 100);
            this.DeepLabel.Name = "DeepLabel";
            this.DeepLabel.Size = new System.Drawing.Size(19, 20);
            this.DeepLabel.TabIndex = 18;
            this.DeepLabel.Text = "0";
            // 
            // LowerPanel
            // 
            this.LowerPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LowerPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LowerPanel.BackgroundImage")));
            this.LowerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LowerPanel.Controls.Add(this.eatingBar);
            this.LowerPanel.Controls.Add(this.WiringTypeLabel);
            this.LowerPanel.Controls.Add(this.StatsBox);
            this.LowerPanel.Controls.Add(this.InventoryBox);
            this.LowerPanel.Controls.Add(this.eventsView);
            this.LowerPanel.Controls.Add(this.ReelBar);
            this.LowerPanel.Controls.Add(this.FLineBar);
            this.LowerPanel.Controls.Add(this.BaitsPicture);
            this.LowerPanel.Controls.Add(this.FpondBox);
            this.LowerPanel.Location = new System.Drawing.Point(-13, 827);
            this.LowerPanel.Name = "LowerPanel";
            this.LowerPanel.Size = new System.Drawing.Size(1062, 123);
            this.LowerPanel.TabIndex = 20;
            // 
            // WiringTypeLabel
            // 
            this.WiringTypeLabel.AutoSize = true;
            this.WiringTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WiringTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WiringTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.WiringTypeLabel.Location = new System.Drawing.Point(118, 95);
            this.WiringTypeLabel.Name = "WiringTypeLabel";
            this.WiringTypeLabel.Size = new System.Drawing.Size(0, 20);
            this.WiringTypeLabel.TabIndex = 25;
            // 
            // StatsBox
            // 
            this.StatsBox.BackColor = System.Drawing.Color.Transparent;
            this.StatsBox.BackgroundImage = global::Fishing.Properties.Resources.data_a;
            this.StatsBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StatsBox.Location = new System.Drawing.Point(106, 7);
            this.StatsBox.Name = "StatsBox";
            this.StatsBox.Size = new System.Drawing.Size(77, 85);
            this.StatsBox.TabIndex = 25;
            this.StatsBox.TabStop = false;
            this.StatsBox.Click += new System.EventHandler(this.StatsBox_Click);
            // 
            // InventoryBox
            // 
            this.InventoryBox.BackColor = System.Drawing.Color.Transparent;
            this.InventoryBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InventoryBox.BackgroundImage")));
            this.InventoryBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.InventoryBox.Location = new System.Drawing.Point(189, 3);
            this.InventoryBox.Name = "InventoryBox";
            this.InventoryBox.Size = new System.Drawing.Size(86, 89);
            this.InventoryBox.TabIndex = 25;
            this.InventoryBox.TabStop = false;
            this.InventoryBox.Click += new System.EventHandler(this.InventoryBox_Click);
            // 
            // eventsView
            // 
            this.eventsView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.eventsView.BackColor = System.Drawing.Color.Wheat;
            this.eventsView.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventsView.Location = new System.Drawing.Point(662, 6);
            this.eventsView.Name = "eventsView";
            this.eventsView.Scrollable = false;
            this.eventsView.Size = new System.Drawing.Size(329, 114);
            this.eventsView.SmallImageList = this.eventsList;
            this.eventsView.StateImageList = this.eventsList;
            this.eventsView.TabIndex = 23;
            this.eventsView.UseCompatibleStateImageBehavior = false;
            this.eventsView.View = System.Windows.Forms.View.SmallIcon;
            // 
            // ReelBar
            // 
            this.ReelBar.Location = new System.Drawing.Point(427, 7);
            this.ReelBar.MarqueeAnimationSpeed = 1;
            this.ReelBar.Name = "ReelBar";
            this.ReelBar.Size = new System.Drawing.Size(226, 15);
            this.ReelBar.Step = 1;
            this.ReelBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ReelBar.TabIndex = 14;
            // 
            // FLineBar
            // 
            this.FLineBar.Location = new System.Drawing.Point(427, 23);
            this.FLineBar.MarqueeAnimationSpeed = 1;
            this.FLineBar.Name = "FLineBar";
            this.FLineBar.Size = new System.Drawing.Size(226, 15);
            this.FLineBar.Step = 1;
            this.FLineBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.FLineBar.TabIndex = 15;
            // 
            // BaitsPicture
            // 
            this.BaitsPicture.BackColor = System.Drawing.Color.Transparent;
            this.BaitsPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BaitsPicture.Location = new System.Drawing.Point(577, 44);
            this.BaitsPicture.Name = "BaitsPicture";
            this.BaitsPicture.Size = new System.Drawing.Size(74, 76);
            this.BaitsPicture.TabIndex = 19;
            this.BaitsPicture.TabStop = false;
            this.BaitsPicture.Click += new System.EventHandler(this.BaitsPicture_Click);
            // 
            // FpondBox
            // 
            this.FpondBox.BackColor = System.Drawing.Color.Transparent;
            this.FpondBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FpondBox.BackgroundImage")));
            this.FpondBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FpondBox.Location = new System.Drawing.Point(281, 7);
            this.FpondBox.Name = "FpondBox";
            this.FpondBox.Size = new System.Drawing.Size(79, 85);
            this.FpondBox.TabIndex = 23;
            this.FpondBox.TabStop = false;
            this.FpondBox.Click += new System.EventHandler(this.FpondBox_Click);
            // 
            // UpperPanel
            // 
            this.UpperPanel.BackColor = System.Drawing.Color.Transparent;
            this.UpperPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpperPanel.BackgroundImage")));
            this.UpperPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpperPanel.Controls.Add(this.MenuLabel);
            this.UpperPanel.Controls.Add(this.InventoryLabel);
            this.UpperPanel.Controls.Add(this.MoneyLabel);
            this.UpperPanel.Controls.Add(this.SettingLabel);
            this.UpperPanel.Controls.Add(this.MapLabel);
            this.UpperPanel.Location = new System.Drawing.Point(2, 115);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(536, 40);
            this.UpperPanel.TabIndex = 11;
            // 
            // MenuLabel
            // 
            this.MenuLabel.AutoSize = true;
            this.MenuLabel.BackColor = System.Drawing.Color.Transparent;
            this.MenuLabel.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuLabel.Location = new System.Drawing.Point(105, 3);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(77, 34);
            this.MenuLabel.TabIndex = 15;
            this.MenuLabel.Text = "Меню";
            this.MenuLabel.Click += new System.EventHandler(this.MenuLabel_Click);
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.AutoSize = true;
            this.InventoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.InventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InventoryLabel.Location = new System.Drawing.Point(95, 9);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(0, 25);
            this.InventoryLabel.TabIndex = 14;
            // 
            // MoneyLabel
            // 
            this.MoneyLabel.AutoSize = true;
            this.MoneyLabel.BackColor = System.Drawing.Color.Transparent;
            this.MoneyLabel.Location = new System.Drawing.Point(345, 18);
            this.MoneyLabel.Name = "MoneyLabel";
            this.MoneyLabel.Size = new System.Drawing.Size(0, 13);
            this.MoneyLabel.TabIndex = 13;
            // 
            // SettingLabel
            // 
            this.SettingLabel.AutoSize = true;
            this.SettingLabel.BackColor = System.Drawing.Color.Transparent;
            this.SettingLabel.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingLabel.Location = new System.Drawing.Point(188, 0);
            this.SettingLabel.Name = "SettingLabel";
            this.SettingLabel.Size = new System.Drawing.Size(147, 34);
            this.SettingLabel.TabIndex = 12;
            this.SettingLabel.Text = "Настройки";
            this.SettingLabel.Click += new System.EventHandler(this.SettingLabel_Click);
            // 
            // MapLabel
            // 
            this.MapLabel.AutoSize = true;
            this.MapLabel.BackColor = System.Drawing.Color.Transparent;
            this.MapLabel.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MapLabel.Location = new System.Drawing.Point(7, 0);
            this.MapLabel.Name = "MapLabel";
            this.MapLabel.Size = new System.Drawing.Size(96, 34);
            this.MapLabel.TabIndex = 11;
            this.MapLabel.Text = "Карта";
            this.MapLabel.Click += new System.EventHandler(this.MapLabel_Click);
            // 
            // eatingBar
            // 
            this.eatingBar.BackColor = System.Drawing.Color.Transparent;
            this.eatingBar.BorderStyle = VerticalProgressBar.BorderStyles.Classic;
            this.eatingBar.Color = System.Drawing.Color.Gold;
            this.eatingBar.Location = new System.Drawing.Point(34, 16);
            this.eatingBar.Maximum = 100;
            this.eatingBar.Minimum = 0;
            this.eatingBar.Name = "eatingBar";
            this.eatingBar.Size = new System.Drawing.Size(23, 83);
            this.eatingBar.Step = 10;
            this.eatingBar.Style = VerticalProgressBar.Styles.Solid;
            this.eatingBar.TabIndex = 27;
            this.eatingBar.Value = 0;
            this.eatingBar.Click += new System.EventHandler(this.EatingBar_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1033, 947);
            this.ControlBox = false;
            this.Controls.Add(this.sounderBack);
            this.Controls.Add(this.LowerPanel);
            this.Controls.Add(this.UpperPanel);
            this.Controls.Add(this.SpeedBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.DimGray;
            ((System.ComponentModel.ISupportInitialize)(this.SpeedBar)).EndInit();
            this.sounderBack.ResumeLayout(false);
            this.SounderPanel.ResumeLayout(false);
            this.SounderPanel.PerformLayout();
            this.LowerPanel.ResumeLayout(false);
            this.LowerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaitsPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FpondBox)).EndInit();
            this.UpperPanel.ResumeLayout(false);
            this.UpperPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel UpperPanel;
        protected internal System.Windows.Forms.Label InventoryLabel;
        protected internal System.Windows.Forms.Label MoneyLabel;
        protected internal System.Windows.Forms.Label MapLabel;
        protected internal System.Windows.Forms.ProgressBar ReelBar;
        protected internal System.Windows.Forms.ProgressBar FLineBar;
        protected internal System.Windows.Forms.Label MenuLabel;
        protected internal System.Windows.Forms.PictureBox BaitsPicture;
        private System.Windows.Forms.Panel LowerPanel;
        protected internal System.Windows.Forms.Label DeepLabel;
        protected internal System.Windows.Forms.TrackBar SpeedBar;
        protected internal System.Windows.Forms.Timer SounderUpdater;
        protected internal System.Windows.Forms.Panel SounderPanel;
        protected internal System.Windows.Forms.Label SettingLabel;
        protected internal System.Windows.Forms.Label TextDeepLabel;
        protected internal System.Windows.Forms.PictureBox FpondBox;
        private System.Windows.Forms.ImageList eventsList;
        private System.Windows.Forms.Panel sounderBack;
        private System.Windows.Forms.ListView eventsView;
        private System.Windows.Forms.PictureBox InventoryBox;
        private System.Windows.Forms.PictureBox StatsBox;
        protected internal System.Windows.Forms.Label LureDeep;
        protected internal System.Windows.Forms.Label WiringTypeLabel;
        private VerticalProgressBar.VerticalProgressBar eatingBar;
    }
}