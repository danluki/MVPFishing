﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing.View.Menu
{
    interface IMenu
    {
        event EventHandler SettingsButtonClick;
        event EventHandler InventoryButtonClick;
        event EventHandler ShopButtonClick;
        event EventHandler ExitButtonClick;
        event EventHandler MapButtonClick;

        string NickNameL { get; set; }
    }
}