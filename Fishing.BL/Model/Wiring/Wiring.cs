﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing.BL.Model.Wiring
{
    abstract class Wiring
    {
        public bool IsBottomTouched { get; set; }
        public int HeightOverBottom { get; set; }

        public Wiring(int heightoverbottom, bool isbottomtouched)
        {
            this.HeightOverBottom = heightoverbottom;
            this.IsBottomTouched = isbottomtouched;
        }
        public abstract void DoWiring();

    }
}