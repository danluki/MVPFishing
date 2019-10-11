﻿using Fishing.Presenter;
using Fishing.View.Assembly;
using Fishing.View.Inventory;
using Fishing.View.LureSelector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing
{
    public partial class Inventory : Form, IInventory
    {
        InventoryPresenter presenter;
        public Inventory()
        {
            InitializeComponent();
            presenter = new InventoryPresenter(this, UI.gui);

            if (Player.GetPlayer().Assemblies.Count == 0)
            {
                AddAssembly add = new AddAssembly();
                add.Show();
            }
        }

        public void showAssembly(Assembly ass)
        {
            if (ass != null)
            {
                try
                {
                    RoadBox.BackgroundImage = ass.Proad.Pict;
                    ReelBox.BackgroundImage = ass.Reel.Pict;
                    BaitBox.BackgroundImage = ass.Lure.Pict;
                    FLineBox.BackgroundImage = ass.FLine.Pict;
                    RoadText = ass.Proad.Name;
                    ReelText = ass.Reel.Name;
                    LureText = ass.Lure.Name;
                    FLineText = ass.FLine.Name;
                }
                catch (ArgumentOutOfRangeException) { }
                catch (NullReferenceException) { }
            }
            
        }       

        public Road Road_P
        {
            get
            {
                try
                {
                    return Player.GetPlayer().RoadInv[RoadsList.SelectedIndex];
                }
                catch (ArgumentOutOfRangeException) { }

                return null;
            }
            set
            {

            }
        }
        public Reel Reel_P
        {
            get
            {
                try
                {
                    return Player.GetPlayer().ReelInv[ReelsList.SelectedIndex];
                }
                catch (ArgumentOutOfRangeException) { }

                return null;
            }
            set
            {

            }
        }
        public FLine FLine_P
        {
            get
            {
                try
                {
                    return Player.GetPlayer().FLineInv[FLineList.SelectedIndex];
                }
                catch (ArgumentOutOfRangeException) { }

                return null;
            }
            set
            {

            }
        }
        public Lure Lure_P
        {
            get
            {
                try
                {
                    return Player.GetPlayer().LureInv[LuresList.SelectedIndex];
                }
                catch (ArgumentOutOfRangeException) { }

                return null;
            }
            set
            {
                
            }
        }

        public Assembly Assembly_P
        {
            get
            {
                try
                {
                    return Player.GetPlayer().Assemblies[assembliesBox.SelectedIndex];
                }
                catch (ArgumentOutOfRangeException) { }

                return null;
            }
            set{}
        }

        public string RoadText { get => roadTextBox.Text; set => roadTextBox.Text = value; }
        public string ReelText { get => reelTextBox.Text; set => reelTextBox.Text = value; }
        public string FLineText { get => flineTextBox.Text; set => flineTextBox.Text = value; }
        public string LureText { get => lureTextBox.Text; set => lureTextBox.Text = value; }

        public event EventHandler FLineSelectedIndexChanged;
        public event EventHandler RoadSelectedIndexChanged;
        public event EventHandler ReelSelectedIndexChanged;
        public event EventHandler LureSelectedIndexChanged;
        public event EventHandler FLineDoubleClick;
        public event EventHandler RoadDoubleClick;
        public event EventHandler ReelDoubleClick;
        public event EventHandler LureDoubleClick;
        public event EventHandler CloseButtonClick;
        public event EventHandler FetchButtonClick;
        public event EventHandler AddButtonClick;
        public event EventHandler AssemblyDoubleClick;
        public event EventHandler MakeOutClick;
        public event EventHandler BaitPicClick;
        private void RoadsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoadSelectedIndexChanged?.Invoke(this, EventArgs.Empty);
        }

        private void FLineList_SelectedIndexChanged(object sender, EventArgs e)
        {
            FLineSelectedIndexChanged?.Invoke(this, EventArgs.Empty);
        }

        private void ReelsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReelSelectedIndexChanged?.Invoke(this, EventArgs.Empty);
        }
        private void LuresList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LureSelectedIndexChanged?.Invoke(this, EventArgs.Empty);
        }
        private void AssembliesBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AssemblyDoubleClick?.Invoke(this, EventArgs.Empty);
        }

        private void LuresList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LureDoubleClick?.Invoke(this, EventArgs.Empty);
        }

        private void ReelsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ReelDoubleClick?.Invoke(this, EventArgs.Empty);
        }

        private void FLineList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FLineDoubleClick?.Invoke(this, EventArgs.Empty);
        }

        private void RoadsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RoadDoubleClick?.Invoke(this, EventArgs.Empty);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            LuresList.DataSource = Player.GetPlayer().LureInv;
            FLineList.DataSource = Player.GetPlayer().FLineInv;
            ReelsList.DataSource = Player.GetPlayer().ReelInv;
            RoadsList.DataSource = Player.GetPlayer().RoadInv;
            assembliesBox.DataSource = Player.GetPlayer().Assemblies;        
        }

        private void FetchButton_Click(object sender, EventArgs e)
        {
            FetchButtonClick?.Invoke(this, EventArgs.Empty);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddAssembly add = new AddAssembly();
            add.Show();
        }
        public void addItemToRightView(Item item)
        {
            try
            {
                if (Item.selectItemType(item) is Road)
                {
                    Road r = (Road)item;
                    this.pictureBox5.BackgroundImage = r.Pict;
                    this.nameBox.Text = r.Name;
                    this.powerBox.Text = r.Power.ToString();
                    this.typeBox.Text = r.Type.ToString();
                }
                if (Item.selectItemType(item) is Reel)
                {
                    Reel r = (Reel)item;
                    this.pictureBox5.Image = r.Pict;
                    this.nameBox.Text = r.Name;
                    this.powerBox.Text = r.Power.ToString();
                    this.typeBox.Text = " ";
                }
                if (Item.selectItemType(item) is FLine)
                {
                    FLine r = (FLine)item;
                    this.pictureBox5.Image = r.Pict;
                    this.nameBox.Text = r.Name;
                    this.powerBox.Text = r.Power.ToString();
                    this.typeBox.Text = " ";
                }
                if (Item.selectItemType(item) is Lure)
                {

                    Lure r = (Lure)item;
                    this.pictureBox5.BackgroundImage = r.Pict;
                    this.nameBox.Text = r.Name;
                    this.powerBox.Text = " ";
                    this.typeBox.Text = " ";
                }
            }
            catch (ArgumentOutOfRangeException) { }
        }

        private void MakeOutButton_Click(object sender, EventArgs e)
        {
            MakeOutClick?.Invoke(this, EventArgs.Empty);
        }

        private void BaitBox_Click(object sender, EventArgs e)
        {
            LureSelector selector = new LureSelector();
            selector.Show();
        }
    }
}
