﻿using Fishing.BL.Model.Game;
using Fishing.BL.Model.UserEvent;
using Fishing.BL.Resources.Images;
using Fishing.BL.Resources.Messages;
using Fishing.BL.Resources.Sounds;
using Fishing.View.GUI;
using Fishing.View.LVLS.Ozero;
using Saver.BL.Controller;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fishing.Presenter
{
    public class LVLPresenter : BasePresenter
    {
        private readonly ILVL view;
        private readonly IGUIPresenter gui;
        private Player player;
        private SoundPlayer sp;
        public LVL CurLVL { get; set; }

        public event EventHandler StartBaitTimer;

        public event EventHandler StopBaitTimer;

        public event EventHandler StopGatheringTimer;

        public event EventHandler RefreshForm;

        public event EventHandler CreateCurrentFishF;

        public LVLPresenter(ILVL view, IGUIPresenter v, LVL curLVL)
        {
            this.CurLVL = curLVL;
            this.view = view;
            this.gui = v;
            view.LVLPresenter = this;
            view.AddPresenterSounders();
            view.BackImage = CurLVL.Image;
            view.Open();
            player = Player.GetPlayer();
            sp = new SoundPlayer();

            CurLVL.AddDeep();
            CurLVL.SetDeep();
            CurLVL.AddFishes();
            CurLVL.GatheringisTrue += View_CountGathering;
            CurLVL.StopBaitTimer += View_StopBaitTimer;

            view.RepaintScreen += View_RepaintScreen;
            view.MouseLeftClick += View_MouseLeftClick;
            view.KeyDOWN += View_KeyDOWN;
            view.KeyUP += View_KeyUP;
            view.CountFishMoves += View_CountFishMoves;
            view.CountGathering += View_CountGathering;
            view.MainTimerTick += View_MainTimerTick;
            view.BaitTimerTick += View_BaitTimerTick;
            view.FormClose += View_FormClose;
            view.DecSacietyTimerTick += View_DecSacietyTimerTick;
        }

        private void View_DecSacietyTimerTick(object sender, EventArgs e)
        {
            player.DecSatiety(5);
            gui.EatingBarValue = player.Satiety;
        }

        private void View_FormClose(object sender, EventArgs e)
        {
            BaseController.GetController().SavePlayer();
            Player.GetPlayer().CurPoint = Point.Empty;
            Player.GetPlayer().Assembly = null;
        }

        private void View_BaitTimerTick(object sender, EventArgs e)
        {
            CurLVL.GetFish();
        }

        private void View_StopBaitTimer(object sender, EventArgs e)
        {
            StopBaitTimer?.Invoke(this, EventArgs.Empty);
        }

        private void View_MainTimerTick(object sender, EventArgs e)
        {
            try
            {
                if (player.IsBaitInWater)
                {
                    gui.LureDeepValue = player.CurrentDeep;
                    player.CheckXBorders();
                    AutoDecBarValues();
                }
                if (player.isFishAttack)
                {
                    if (gui.FLineBarValue > 990)
                    {
                        player.AddNewMessage(new FLineTornEvent());
                        gui.AddEventToBox(new FLineTornEvent());
                        gui.FLineBarValue = 0;
                        player.TornFLine();
                        sp.Stream = SoundsRes.leskaobr;
                        sp.Play();
                    }
                    if (gui.RoadBarValue > 990)
                    {
                        player.AddNewMessage(new RoadBrokenEvent());
                        gui.AddEventToBox(new RoadBrokenEvent());
                        gui.RoadBarValue = 0;
                        player.BrokeRoad();
                    }
                }
                if(player.CurPoint.Y > 570)
                {
                    player.IsBaitInWater = false;
                }
                RefreshForm?.Invoke(this, EventArgs.Empty);
                if (player.IsFishAbleToGoIntoFpond())
                {
                    player.Netting.ShowNetting();
                    player.IsBaitInWater = false;
                    gui.CheckNeedsAndClearEventBox();
                    if (!player.CFish.isTrophy())
                    {
                        player.AddNewMessage(new FishEvent(player.CFish, player.Assembly.Lure));
                        gui.AddEventToBox(new FishEvent(player.CFish, player.Assembly.Lure));
                    }
                    else
                    {
                        player.AddNewMessage(new TrophyFishEvent(player.CFish, player.Assembly.Lure));
                        gui.AddEventToBox(new TrophyFishEvent(player.CFish, player.Assembly.Lure));
                    }
                    Player.GetPlayer().Statistic.TakenFishesCount++;
                    CreateCurrentFishF?.Invoke(this, EventArgs.Empty);
                    player.Netting.HideNetting();
                }
            }
            catch (NullReferenceException) { }
        }

        private void View_CountGathering(object sender, EventArgs e)
        {
            if (Player.GetPlayer().isFishAttack == true)
            {
                StopGatheringTimer?.Invoke(this, EventArgs.Empty);
                Player.GetPlayer().AddNewMessage(new GatheringEvent());
                gui.AddEventToBox(new GatheringEvent());
                Player.GetPlayer().isFishAttack = false;
                Player.GetPlayer().Statistic.GatheringCount++;
                sp.Stream = SoundsRes.sxod;
                sp.Play();
            }
        }

        private void View_CountFishMoves(object sender, EventArgs e)
        {
            Player player = Player.GetPlayer();
            Random fishMovingX = new Random();
            Random fishMovingY = new Random();
            if (player.isFishAttack)
            {
                player.CFish.Power.X = fishMovingX.Next(-player.CFish.Power.X, Math.Abs(player.CFish.Power.X) + 1);
                player.CFish.Power.Y = fishMovingY.Next(-Math.Abs(player.CFish.Power.Y), 2);
            }
        }

        private void View_KeyDOWN(object sender, KeyEventArgs e)
        {
            Player player = Player.GetPlayer();
            for (int y = 0; y < CurLVL.Height; y++)
            {
                for (int x = 0; x < CurLVL.Widgth; x++)
                {
                    Point between = new Point(player.CurPoint.X - CurLVL.Deeparr[x, y].Location.X,
                                                player.CurPoint.Y - CurLVL.Deeparr[x, y].Location.Y);
                    float distance = (float)Math.Sqrt(between.X * between.X + between.Y * between.Y);
                    if (distance < 20)
                    {
                        gui.DeepValue = Convert.ToInt32(CurLVL.Deeparr[x, y].Tag);
                        Sounder.GetSounder().Column = y;
                        Sounder.GetSounder().Row = x;
                    }
                    player.CurrentDeep = gui.DeepValue - 1 * 10;
                }
            }
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.G:
                        Player.GetPlayer().IsBaitMoving = true;
                        if (Player.GetPlayer().RoadY != 357)
                        {
                            Player.GetPlayer().RoadY += 7;
                        }
                        if (Player.GetPlayer().isFishAttack)
                        {
                            Player.GetPlayer().WindingSpeed = Player.GetPlayer().Assembly.Reel.Power;
                            if (player.isFishAttack)
                            {
                                SetRoadBend(player.Assembly.Proad, player.CFish.Weight, false, e);
                                Pictures.roadMaxBend = Images.road2;
                                if (gui.RoadBarValue > 0)
                                {
                                    gui.IncrementRoadBarValue(-(player.RoadIncValue));
                                }
                                if (gui.FLineBarValue < 1000)
                                {
                                    gui.IncrementFLineBarValue(player.FLineIncValue);
                                }
                            }
                        }
                        else
                        {
                            Player.GetPlayer().WindingSpeed = 1;
                        }
                        DoWiring();

                        break;

                    case Keys.H:
                        if (player.isFishAttack)
                        {
                            SetRoadBend(player.Assembly.Proad, player.CFish.Weight, false, e);
                            player.WindingSpeed = 2;
                            player.CurPoint.Y += player.WindingSpeed;
                            if (gui.RoadBarValue < 1000)
                            {
                                gui.IncrementRoadBarValue(player.RoadIncValue);
                            }
                            if (gui.FLineBarValue > 0)
                            {
                                gui.IncrementFLineBarValue(-(player.FLineIncValue));
                            }
                        }
                        break;

                    case Keys.Space:
                        if (player.CurPoint.Y > 570)
                        {
                            player.Netting.ShowNetting();
                        }
                        break;

                    case Keys.T:
                        player.CurPoint = player.isFishAttack == false ? player.LastCastPoint : Point.Empty;
                        player.LastCastPoint = player.CurPoint;
                        MakeCast(player.LastCastPoint);
                        break;
                }
            }
            catch (NullReferenceException) { }
        }

        private void View_KeyUP(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.G:
                    if (player.isFishAttack)
                    {
                        SetRoadBend(player.Assembly.Proad, player.CFish.Weight, true, e);
                    }
                    Player.GetPlayer().IsBaitMoving = false;
                    Player.GetPlayer().WindingSpeed = 0;
                    Player.GetPlayer().RoadY -= 7;
                    break;

                case Keys.H:
                    if (player.isFishAttack)
                    {
                        SetRoadBend(player.Assembly.Proad, player.CFish.Weight, true, e);
                    }
                    break;
            }
        }

        private void View_MouseLeftClick(object sender, EventArgs e)
        {
            MakeCast(view.CurPoint);
        }

        private void View_RepaintScreen(object sender, PaintEventArgs e)
        {
            try
            {
                Player player = Player.GetPlayer();
                Rectangle NormalRoad = new Rectangle(player.CurPoint.X, player.RoadY, Pictures.road.Width, 257);
                Rectangle BrokenRoad = new Rectangle(player.RoadX - 10, player.RoadY, Pictures.izgRoad.Width, 257);
                Rectangle Netting = new Rectangle(player.CurPoint.X, -300, 60, 200);
                Rectangle RTrigon = new Rectangle(player.RoadX + 12, 585, 18, 18);
                Graphics g = e.Graphics;
                SolidBrush sbrush = new SolidBrush(Color.White);
                if (player.isFishAttack == true)
                {
                    player.CurPoint.X += player.CFish.Power.X;
                    player.CurPoint.Y += player.CFish.Power.Y;
                }
                if (player.IsFishAbleToGoIntoFpond())
                    g.DrawImage(Pictures.netting, Netting);

                if (!player.isFishAttack && player.Assembly.Proad != null)
                {
                    g.DrawImage(Pictures.road, NormalRoad);
                    player.RoadX = player.CurPoint.X;
                }
                if (player.isFishAttack && player.Assembly.Proad != null)
                {
                    g.DrawImage(Pictures.izgRoad, BrokenRoad);
                }
                if (player.CurPoint.Y >= CurLVL.Deeparr[0, 0].Location.Y && player.Assembly.Proad != null)
                {
                    g.DrawEllipse(new Pen(sbrush), player.CurPoint.X, player.CurPoint.Y, 4, 4);
                    g.FillEllipse(sbrush, player.CurPoint.X, player.CurPoint.Y, 4, 4);
                    g.DrawImage(Pictures.trigon, RTrigon);
                }
                else if (player.CurPoint.Y < CurLVL.Deeparr[0, 0].Location.Y && player.CurPoint.Y != 0 && player.Assembly.Proad != null)
                {
                    player.CurPoint.Y = CurLVL.Deeparr[0, 0].Location.Y + 5;
                    g.DrawEllipse(new Pen(sbrush), player.CurPoint.X, player.CurPoint.Y, 4, 4);
                    g.FillEllipse(sbrush, player.CurPoint.X, player.CurPoint.Y, 4, 4);
                }
            }
            catch (NullReferenceException) { }
        }

        private void SetRoadBend(Road road, int weight, bool reverse, KeyEventArgs e)
        {
            if (Player.GetPlayer().isFishAttack && !reverse)
            {
                switch (e.KeyCode)
                {
                    case Keys.G:
                        if (weight <= road.Power * 0.2)
                        {
                            Pictures.izgRoad = Roads.izg1;
                        }
                        else if (weight <= road.Power * 0.25)
                        {
                            Pictures.izgRoad = Roads.izg2;
                        }
                        else if (weight <= road.Power * 0.3)
                        {
                            Pictures.izgRoad = Roads.izg3;
                        }
                        else if (weight <= road.Power * 0.4)
                        {
                            Pictures.izgRoad = Roads.izg4;
                        }
                        else if (weight >= road.Power * 0.4)
                        {
                            Pictures.izgRoad = Roads.izg5;
                        }
                        break;

                    case Keys.H:
                        if (weight <= road.Power * 0.2)
                        {
                            Pictures.izgRoad = Roads.izg1H;
                        }
                        else if (weight <= road.Power * 0.25)
                        {
                            Pictures.izgRoad = Roads.izg2H;
                        }
                        else if (weight <= road.Power * 0.3)
                        {
                            Pictures.izgRoad = Roads.izg3H;
                        }
                        else if (weight <= road.Power * 0.4)
                        {
                            Pictures.izgRoad = Roads.izg4H;
                        }
                        else if (weight >= road.Power * 0.4)
                        {
                            Pictures.izgRoad = Roads.izg5H;
                        }
                        break;
                }
            }
            else if (Player.GetPlayer().isFishAttack && reverse)
            {
                switch (e.KeyCode)
                {
                    case Keys.H:
                        if (weight <= road.Power * 0.2)
                        {
                            Pictures.izgRoad = Roads.izg1;
                        }
                        else if (weight <= road.Power * 0.25)
                        {
                            Pictures.izgRoad = Roads.izg2;
                        }
                        else if (weight <= road.Power * 0.3)
                        {
                            Pictures.izgRoad = Roads.izg3;
                        }
                        else if (weight <= road.Power * 0.4)
                        {
                            Pictures.izgRoad = Roads.izg4;
                        }
                        else if (weight >= road.Power * 0.4)
                        {
                            Pictures.izgRoad = Roads.izg5;
                        }
                        break;

                    case Keys.G:
                        if (weight <= road.Power * 0.2)
                        {
                            Pictures.izgRoad = Roads.izg1;
                        }
                        else if (weight <= road.Power * 0.25)
                        {
                            Pictures.izgRoad = Roads.izg2;
                        }
                        else if (weight <= road.Power * 0.3)
                        {
                            Pictures.izgRoad = Roads.izg3;
                        }
                        else if (weight <= road.Power * 0.4)
                        {
                            Pictures.izgRoad = Roads.izg4;
                        }
                        else if (weight >= road.Power * 0.4)
                        {
                            Pictures.izgRoad = Roads.izg5;
                        }
                        break;
                }
            }
        }

        private void AutoDecBarValues()
        {
            if (gui.FLineBarValue > 0)
                gui.IncrementFLineBarValue(-3);
            if (gui.RoadBarValue > 0)
                gui.IncrementRoadBarValue(-3);
        }

        private void MakeCast(Point point)
        {
            try
            {
                if (player.IsPlayerAbleToFishing())
                {
                    for (int y = 0; y < CurLVL.Height; y++)
                    {
                        for (int x = 0; x < CurLVL.Widgth; x++)
                        {
                            Point between = new Point(point.X - CurLVL.Deeparr[x, y].Location.X,
                                                        point.Y - CurLVL.Deeparr[x, y].Location.Y);
                            float distance = (float)Math.Sqrt(between.X * between.X + between.Y * between.Y);
                            if (distance < 20)
                            {
                                gui.DeepValue = Convert.ToInt32(CurLVL.Deeparr[x, y].Tag);
                                Sounder.GetSounder().Column = y;
                                Sounder.GetSounder().Row = x;
                            }
                        }
                    }
                    player.IsBaitInWater = true;
                    player.CurrentDeep = gui.DeepValue;
                    player.IsBaitMoving = false;
                    Player.GetPlayer().IsJigging = false;
                    if (!player.isFishAttack && player.Assembly != null)
                    {
                        if (point.Y >= CurLVL.Deeparr[0, 0].Location.Y)
                        {
                            player.CurPoint.Y = point.Y;
                        }
                        else
                        {
                            player.CurPoint.Y = CurLVL.Deeparr[0, 0].Location.Y + 3;
                        }
                        if (point.X >= CurLVL.Deeparr[0, 0].Location.X)
                        {
                            player.CurPoint.X = point.X;
                        }
                        else
                        {
                            player.CurPoint.X = CurLVL.Deeparr[0, 0].Location.X + 5;
                        }

                        player.LastCastPoint = point;
                        sp.Stream = SoundsRes.zabr;
                        sp.Play();
                    }

                    if (!player.isFishAttack)
                    {
                        if (player.Assembly.Proad != null)
                        {
                            StartBaitTimer?.Invoke(this, EventArgs.Empty);
                            player.RoadY = 350;
                            gui.FLineBarValue = 0;
                            gui.RoadBarValue = 0;
                            player.WindingSpeed = 0;
                        }
                        if (!(player.Assembly.Lure is null))
                        {
                            StartBaitTimer?.Invoke(this, EventArgs.Empty);
                        }
                        try
                        {
                            if (player.Assembly.Lure is null && player.Assembly.Proad.Type == ROAD_TYPE.Spinning)
                            {
                                player.CurPoint.Y = 0;
                                MessageBox.Show(Messages.NO_LURE_EQUIPED);
                            }
                        }
                        catch (NullReferenceException)
                        {
                            player.CurPoint.Y = 0;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Игрок не готов к рыбалке");
                }
            }
            catch (NullReferenceException) { }
        }

        private void DoWiring()
        {
            if (Player.GetPlayer().isFishAttack)
            {
                Player.GetPlayer().WindingSpeed = Player.GetPlayer().Assembly.Reel.Power;
            }
            else
            {
                Player.GetPlayer().WindingSpeed = 1;
            }
            Player.GetPlayer().CurPoint.Y += Player.GetPlayer().WindingSpeed;
        }

        public override void Load()
        {
            throw new NotImplementedException();
        }

        public override void Close()
        {
            throw new NotImplementedException();
        }
    }
}