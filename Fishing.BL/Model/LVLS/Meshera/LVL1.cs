﻿using Fishing.BL.Resources.Images;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing.BL.Model.LVLS.Meshera
{
    public class LVL1 : LVL
    {
        public LVL1() : base(Images.MesheraLVL1)
        {
            Widgth = 51;
            Height = 21;
            LabelStartY = 330;

        }
        public override void AddFishes()
        {
            for (int i = 0; i < 1000; i++)
            {
                if (i < 500)
                {
                    Fishes.Add(new Pike(170, 250, 0.9, new HashSet<Lure>() { Lure.jig4, Lure.jelezo1, Lure.vob2 }));
                }
                if (i >= 500 && i <= 1000)
                {
                    Fishes.Add(new Perch(100, 300, 0.8, new HashSet<Lure>() { Lure.vert1, Lure.vert2 }));
                }
            }
        }

        public override void GetFish()
        {
            Random randomGathering = new Random();
            Random randomFish = new Random();
            if (Player.GetPlayer().Assembly.Lure is Lure)
            {
                if (Player.GetPlayer().CurPoint.Y > Deeparr[0, 0].Location.Y && Player.GetPlayer().CurPoint.Y < 800 && !Player.GetPlayer().isFishAttack)
                {
                    Player.GetPlayer().CFish = Fishes[randomFish.Next(1, 994)];
                    if (IsFishAttackAbble(Player.GetPlayer().CFish) && Player.GetPlayer().IsBaitMoving)
                    {
                        Player.GetPlayer().isFishAttack = true;
                        Player.GetPlayer().IncValue = Player.GetPlayer().CFish.Weight * 20 / (Player.GetPlayer().Assembly.Proad.Power);
                        StopBaitTimer?.Invoke(this, EventArgs.Empty);
                        int Gathering = randomGathering.Next(1, 100);
                        if (Gathering <= 5)
                        {
                            GatheringisTrue?.Invoke(this, EventArgs.Empty);
                        }
                    }
                }
            }
        }

        public override void SetDeep()
        {
            for (int x = 0; x < 51; x++)
            {
                Deeparr[x, 0].Tag = 250;
                Deeparr[x, 1].Tag = 270;
                Deeparr[x, 2].Tag = 290;
                Deeparr[x, 3].Tag = 290;
                Deeparr[x, 4].Tag = 290;
                Deeparr[x, 5].Tag = 220;
                Deeparr[x, 6].Tag = 240;
                Deeparr[x, 7].Tag = 210;
                Deeparr[x, 8].Tag = 170;
                Deeparr[x, 9].Tag = 180;
                Deeparr[x, 10].Tag = 220;
                Deeparr[x, 11].Tag = 240;
                Deeparr[x, 12].Tag = 170;
                Deeparr[x, 13].Tag = 140;
                Deeparr[x, 14].Tag = 140;
                Deeparr[x, 15].Tag = 120;
                Deeparr[x, 16].Tag = 110;
                Deeparr[x, 17].Tag = 100;
                Deeparr[x, 18].Tag = 100;
                Deeparr[x, 19].Tag = 100;
                Deeparr[x, 20].Tag = 100;
            }
        }
    }
}