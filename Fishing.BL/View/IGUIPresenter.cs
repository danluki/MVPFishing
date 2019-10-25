﻿using Fishing.BL.Model.UserEvent;
using System.Drawing;

namespace Fishing.View.GUI
{
    public interface IGUIPresenter
    {
        Bitmap BaitPicture { get; set; }
        Image RoadPicture { get; set; }
        Image ReelPicture { get; set; }
        Image FLinePicture { get; set; }
        int DeepValue { get; set; }
        int RoadBarValue { get; set; }
        int FLineBarValue { get; set; }
        int MoneyLValue { get; set; }
        int EventBoxItemsCount { get; set; }
        int LureDeepValue { get; set; }
        string WiringType { get; set; }
        int EatingBarValue { get; set; }

        void AddEventToBox(BaseEvent ev);

        void ClearEvents();

        void IncrementRoadBarValue(int value);

        void IncrementFLineBarValue(int value);

        void CheckNeedsAndClearEventBox();
    }
}