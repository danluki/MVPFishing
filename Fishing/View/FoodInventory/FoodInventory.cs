﻿using Fishing.BL.Model.Eating;
using Fishing.BL.View;
using Fishing.Presenter;
using System;
using System.Windows.Forms;
using Fishing.BL.Presenter;

namespace Fishing.View.FoodInventory {

    public partial class FoodInventory : Form, IFoodInventory {

        public FoodInventory() {
            InitializeComponent();
            foodsBox.DataSource = Player.GetPlayer().FoodInv;
        }

        public string FoodProductivityTextBox { get => foodProductBox.Text; set => foodProductBox.Text = "Восполняет: %" + value; }
        public BasePresenter Presenter { private get; set; }
        public string FoodsSelectedItem { get => foodsBox.SelectedItem.ToString(); set => throw new NotImplementedException(); }

        public event EventHandler ListSelectedIndexChanged;

        public event EventHandler ListDoubleClick;

        public void ShowFood(Food food) {
            FoodBox.BackgroundImage = food.Pict;
            foodProductBox.Text = "Восполняет " + food.Productivity + "%";
        }

        private void FoodsBox_SelectedIndexChanged(object sender, EventArgs e) {
            ListSelectedIndexChanged?.Invoke(this, EventArgs.Empty);
        }

        private void FoodsBox_DoubleClick(object sender, EventArgs e) {
            ListDoubleClick?.Invoke(this, EventArgs.Empty);
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            Down();
        }

        public void Open() {
            Show();
        }

        public void Down() {
            Close();
        }
    }
}