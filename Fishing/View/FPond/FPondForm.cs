﻿using Fishing.Presenter;
using Fishing.View.FPond;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fishing {

    public partial class fishesForm : Form, IFPond {
        private FPondPresenter presenter;
        public Image RightImage { get => FishImage.BackgroundImage; set => FishImage.BackgroundImage = value; }
        public int SelectedIndex { get => FishList.SelectedIndex; set => throw new NotImplementedException(); }
        public string DescriptionText { get => fishDescription.Text; set => fishDescription.Text = value; }

        public fishesForm() {
            InitializeComponent();
            FishList.DataSource = Player.GetPlayer().Fishlist;
            presenter = new FPondPresenter(this, UI.gui);
        }

        public event EventHandler SelectedIndexChanged;

        public event EventHandler SellButtonClick;

        private void FishList_SelectedIndexChanged(object sender, EventArgs e) {
            SelectedIndexChanged?.Invoke(this, EventArgs.Empty);
        }

        private void FishesForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Space)
                this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void SellButton_Click(object sender, EventArgs e) {
            SellButtonClick?.Invoke(sender, EventArgs.Empty);
        }

        private void FishesForm_Load(object sender, EventArgs e) {
        }
    }
}