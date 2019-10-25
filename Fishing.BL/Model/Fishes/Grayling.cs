﻿using Fishing.BL.Model.Game;
using Fishing.BL.Resources.Images;
using Fishing.BL.Resources.Messages;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Fishing
{
    [Serializable]
    public class Grayling : Fish
    {
        private readonly static HashSet<Size> lures = new HashSet<Size>()
        {
          Size.Small,
          Size.Large,
        };

        private readonly static HashSet<PartsOfDay> activParts = new HashSet<PartsOfDay>()
        {
            PartsOfDay.Evening,
            PartsOfDay.Morning,
            PartsOfDay.Night
        };

        private readonly static string name = "Хариус";
        private readonly static int price = 5;
        private readonly static int trophyWeight = 1600;
        private readonly static string description = Messages.GRAYLING_DESCRIPTION;
        private readonly static Bitmap bit = Images.xariys;

        public Grayling(int minD, int maxD, double maxSizeCoef, HashSet<Lure> lu) : base(name, randWigth.Next(500, 2000), Power.SetPower(4, 2), price, trophyWeight, lures, activParts, description, bit)
        {
            MinDeep = minD;
            MaxDeep = maxD;
            MaxSizeCoef = maxSizeCoef;
            WorkingLures = lu;
        }
    }
}