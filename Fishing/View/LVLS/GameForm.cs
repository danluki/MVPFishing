﻿using Fishing.BL.Resources.Sounds;
using Fishing.Presenter;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using Fishing.BL.Presenter;
using Fishing.BL.View;

namespace Fishing {

    public partial class GameForm : Form, IGameForm {

        public GameForm() {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.UserPaint, true);
            UpdateStyles();
        }

        public Point CurPoint { get => PointToClient(Cursor.Position); set => throw new ArgumentException(); }
        public BasePresenter Presenter { private get; set; }
        public Image BackImage { get => BackgroundImage; set => BackgroundImage = value; }
        public LVLPresenter LVLPresenter { private get; set; }

        public event MouseEventHandler FormMouseClick;

        public event PaintEventHandler RepaintScreen;

        public event KeyEventHandler KeyDOWN;

        public event KeyEventHandler KeyUP;

        public event EventHandler MainTimerTick;

        public event EventHandler FormClose;

        public event EventHandler DecSacietyTimerTick;

        private void GameForm_Paint(object sender, PaintEventArgs e) {
            RepaintScreen?.Invoke(this, e);
        }

        private void MainTaskTimer_Tick(object sender, EventArgs e) {
            MainTimerTick?.Invoke(this, e);
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e) {
            KeyDOWN?.Invoke(this, e);
        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e) {
            KeyUP?.Invoke(this, e);
        }

        private void GameForm_MouseClick(object sender, MouseEventArgs e) {
            FormMouseClick?.Invoke(this, e);
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e) {
            FormClose?.Invoke(this, EventArgs.Empty);
            UI.Gui.Close();
        }

        private void DecrementSatiety_Tick(object sender, EventArgs e) {
            DecSacietyTimerTick?.Invoke(this, EventArgs.Empty);
        }

        private void SoundPlayerTimer_Tick(object sender, EventArgs e) {
            var r = new Random();
            var name = "day" + r.Next(1, 9);
            var player = new SoundPlayer(SoundsRes.ResourceManager.GetStream(name));
            player.Play();
        }

        public void UpdateForm() {
            Refresh();
        }

        public void CreateCurrentFish(Fish fish) {
            var f = new CurrentFish(fish);
            f.Show();
        }

        public void Open() {
            Show();
        }

        public void Down() {
            Close();
        }
    }
}