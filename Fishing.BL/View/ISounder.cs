﻿using System;
using System.Windows.Forms;

namespace Fishing.BL.View
{
    public interface ISounder
    {
        event PaintEventHandler SounderPaint;

        event EventHandler RefreshSounder;
    }
}