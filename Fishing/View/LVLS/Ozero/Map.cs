﻿using Fishing.BL.Model.Game;
using Fishing.BL.Model.LVLS;
using Fishing.BL.Resources.Images;
using Fishing.BL.View;
using Fishing.Presenter;
using Fishing.View.DeepField;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fishing {

    public partial class Map : Form, IMap {
        public static GameForm ozero;

        public Map() {
            InitializeComponent();
            BackgroundImage = Game.GetGame().CurrentWater.MapImage;
            foreach (var p in Game.GetGame().CurrentWater.Locations) {
                PictureBox box = new PictureBox() {
                    Left = p.Left,
                    Top = p.Top,
                    Width = p.Width,
                    Height = p.Height,
                    BackgroundImage = Images.blackkrug,
                    BackColor = Color.Transparent,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Tag = p.LocName,
                    BorderStyle = BorderStyle.None,
                };
                box.Click += Box_Click;
                Controls.Add(box);
            }
        }

        private void Box_Click(object sender, EventArgs e) {
            var lvlrealisation = new LvlImplementation();
            lvlrealisation.GetLVLData((sender as PictureBox).Tag.ToString());
            Create(lvlrealisation);
        }

        public Image BackImage { get => BackgroundImage; set => BackgroundImage = value; }

        public void Open() {
            this.Show();
        }

        public void Down() {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        public void Create(LvlImplementation lvl) {
            UI.Gui = new UI(lvl);
            Game.GetGame().View = new GameForm();
            var presenter = new LVLPresenter(Game.GetGame().View, UI.Gui, lvl);
            presenter.Run();
            var field = new DeepField(lvl);
            UI.Gui.Show();
            this.Close();
        }
    }
}