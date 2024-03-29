﻿using Fishing.BL.Model.Baits;
using Fishing.BL.Model.Game;
using Fishing.BL.Resources.Images;
using Fishing.BL.Resources.Messages;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Fishing.BL.Model.Fishes {

    [Serializable]
    internal class Burbot : Fish {

        private readonly static HashSet<PartsOfDay> activParts = new HashSet<PartsOfDay>()
        {
            PartsOfDay.Morning,
            PartsOfDay.Night,
        };

        private readonly static string name = "Налим";
        private readonly static int price = 6;
        private readonly static int trophyWeight = 8000;
        private readonly static string description = Messages.BURBOT_DESCRIPTION;
        private readonly static Bitmap bit = Images.nalim;

        public Burbot(int minD, int maxD, double maxSizeCoef, HashSet<FishBait> lu)
            : base(name, randomWeight.Next(100, Convert.ToInt32(10000 * maxSizeCoef)), Power.SetPower(5, 2), price, trophyWeight, activParts, description, bit) {
            MinDeep = minD;
            MaxDeep = maxD;
            MaxSizeCoef = maxSizeCoef;
            WorkingLures = lu;
        }
    }
}