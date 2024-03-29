﻿using Fishing.BL.Model.Waters;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using Fishing.BL.View;

namespace Fishing.BL.Model.Game {

    public enum PartsOfDay {
        Morning,
        Day,
        Evening,
        Night
    }

    [Serializable]
    public class Game {
        private static Game game;
        public BindingList<string> Waters = new BindingList<string>();

        public event EventHandler HoursInc;

        public IGameForm View { get; set; }
        public Timer HoursTimer { get; set; }
        public Water CurrentWater { get; set; }

        public Time Time;

        private Game() {
            HoursTimer = new Timer() {
                Interval = 30000
            };
            HoursTimer.Tick += HoursTimer_Tick;
            HoursTimer.Start();
        }

        public static Game GetGame() {
            if (game == null) {
                game = new Game();
            }
            return game;
        }

        private void HoursTimer_Tick(object sender, EventArgs e) {
            Time.IncHours(1);
            HoursInc?.Invoke(this, EventArgs.Empty);
        }
    }
}