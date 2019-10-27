﻿using Fishing.BL.View;
using Fishing.Presenter;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fishing.View.LVLS.Ozero
{
    public interface IGameForm : IView
    {
        Point CurPoint { get; set; }
        Image BackImage { get; set; }

        event EventHandler MouseLeftClick;

        event PaintEventHandler RepaintScreen;

        event EventHandler CountGathering;

        event EventHandler CountFishMoves;

        event KeyEventHandler KeyDOWN;

        event KeyEventHandler KeyUP;

        event EventHandler MainTimerTick;

        event EventHandler BaitTimerTick;

        event EventHandler FormClose;

        event EventHandler DecSacietyTimerTick;

        LVLPresenter LVLPresenter { set; }
        void UpdateForm();
        void StopBaitTimer();
        void StartBaitTimer();
        void StartGatheringTimer();
        void StopGatheringTimer();
        void CreateCurrentFish();
        void StopMainTimer();
        void StartMainTimer();
    }
}