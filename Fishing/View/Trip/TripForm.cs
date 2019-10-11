﻿using Fishing.BL.Model.Game;
using Fishing.BL.Model.Trip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing.View.Trip
{
    public partial class TripForm : Form
    {
        private TripToWater trip;
        public TripForm()
        {
            InitializeComponent();
            trip = new TripToWater();
            timeLabel.Text = Game.GetGame().Time.ToString();
            watersBox.DataSource = Game.GetGame().Waters;
            trip.DaysCount = 1;
            moneyLabel.Text = "Деньги: " + Player.GetPlayer().Money;
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateHours_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = Game.GetGame().Time.ToString();
        }

        private void TripBox_MouseEnter(object sender, EventArgs e)
        {
            tripBox.Text = trip.ToString();
        }

        private void CarButton_Click(object sender, EventArgs e)
        {
            trip.TripTransport = Transport.Car;
            trip.CountPrice();
            trip.CountTime();
            tripBox.Text = trip.ToString();

        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            trip.TripTransport = Transport.Train;
            trip.CountPrice();
            trip.CountTime();
            tripBox.Text = trip.ToString();
        }

        private void PlaneButton_Click(object sender, EventArgs e)
        {
            trip.TripTransport = Transport.Plane;
            trip.CountPrice();
            trip.CountTime();
            tripBox.Text = trip.ToString();
        }

        private void DaysUpDown_SelectedItemChanged(object sender, EventArgs e)
        {
            int res = 0;
            Int32.TryParse(daysUpDown.Items[daysUpDown.SelectedIndex].ToString(), out res);
            trip.DaysCount = res;
            trip.CountPrice();
            tripBox.Text = trip.ToString();
        }

        private void WatersBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            trip = new TripToWater();
            trip.TripWater = Game.GetGame().Waters[watersBox.SelectedIndex];
            mapBox.BackgroundImage = trip.TripWater.MapImage;
            trip.CountPrice();
            trip.CountTime();
            tripBox.Text = trip.ToString();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            Game.GetGame().CurrentWater = trip.TripWater;
            Game.GetGame().Time.Hours += trip.DaysCount;
        }
    }
}