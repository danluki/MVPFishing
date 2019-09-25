﻿using Fishing.View.LureSelector.Presenter;
using Fishing.View.LureSelector.View;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fishing.View.LureSelector
{
    public partial class LureSelector : Form, ISelector
    {
        SelectorPresenter presenter;
        public LureSelector()
        {
            InitializeComponent();
            presenter = new SelectorPresenter(this, Fishing.GUI.gui);           
        }

        public Lure Lure { get => Player.getPlayer().GetLures()[lureList.SelectedIndex]; set => throw new NotImplementedException(); }
        public Image Picture { get => lureImage.Image; set => lureImage.Image = Lure.Pict; }
        public string NameBoxText { get => nameBox.Text; set => nameBox.Text = value; }
        public string TypeBoxText { get => typeBox.Text; set => typeBox.Text = value; }

        public event EventHandler LureListIndexChanged;
        public event EventHandler LureListDoubleClick;

        private void LureList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LureListIndexChanged?.Invoke(this, EventArgs.Empty);
        }

        private void LureSelector_Load(object sender, EventArgs e)
        {
            lureList.DataSource = Player.getPlayer().GetLures();
        }

        private void LureList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LureListDoubleClick?.Invoke(this, EventArgs.Empty);
        }
    }
}