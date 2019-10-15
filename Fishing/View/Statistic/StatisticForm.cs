﻿using Fishing.BL.Presenter;
using Fishing.BL.View;
using Fishing.Presenter;
using System;
using System.Windows.Forms;

namespace Fishing.View.Statistic
{
    public partial class StatisticForm : Form, IStatistic
    {
        public StatisticForm()
        {
            InitializeComponent();
            
        }
        public string NameLText { get => NameLabel.Text; set => NameLabel.Text = value; }
        public string MoneyLText { get => MoneyLabel.Text; set => MoneyLabel.Text += value; }
        public string GatheringLText { get => GatheringLabel.Text; set => GatheringLabel.Text += value; }
        public string BrokenRoadsLText { get => BrokenRoadsLabel.Text; set => BrokenRoadsLabel.Text += value; }
        public string TornFLineLText { get => TornsFLineLabel.Text; set => TornsFLineLabel.Text += value; }
        public string TakeFishesLText { get => TakenFishes.Text; set => TakenFishes.Text += value; }
        public BasePresenter Presenter { private get; set; }

        public event EventHandler LoadForm;

        public void addEventToView(ListViewItem i)
        {
            EventView.Items.Add(i);
        }

        public void Down()
        {
            this.Close();
        }

        public void Open()
        {
            this.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StatisticForm_Load(object sender, EventArgs e)
        {
            LoadForm?.Invoke(this, EventArgs.Empty);
        }
    }
}
