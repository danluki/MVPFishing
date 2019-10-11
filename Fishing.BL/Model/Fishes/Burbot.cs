﻿using Fishing.BL.Model.Game;
using Fishing.BL.Resources.Images;
using Fishing.BL.Resources.Messages;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing.BL.Model.Fishes
{
    [Serializable]
    class Burbot : Fish
    {
        private readonly static HashSet<Size> lures = new HashSet<Size>()
        {
            Size.Small,
            Size.Large,
        };
        private readonly static HashSet<PartsOfDay> activParts = new HashSet<PartsOfDay>()
        {
            PartsOfDay.Morning,
            PartsOfDay.Night,
        };
        private readonly static int power = 5;
        private readonly static string name = "Налим";
        private readonly static int price = 6;
        private readonly static int trophyWeight = 8000;
        private readonly static string description = Messages.BURBOT_DESCRIPTION;
        private readonly static Bitmap bit = Images.nalim;
        public Burbot(int minD, int maxD, double maxSizeCoef, HashSet<Lure> lu)
            : base(name, randWigth.Next(100, Convert.ToInt32(10000 * maxSizeCoef)), power, price, trophyWeight, lures, activParts, description, bit)
        {
            MinDeep = minD;
            MaxDeep = maxD;
            MaxSizeCoef = maxSizeCoef;
            WorkingLures = lu;
        }
    }
}