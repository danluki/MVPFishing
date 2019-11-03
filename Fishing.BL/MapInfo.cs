﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    [Serializable]
    public class MapInfo
    {
        public List<PicturesBoxInfo> Locs { get; set; }
        public Image BackImg { get; set; }
        public MapInfo(Image img, List<PicturesBoxInfo> l)
        {
            BackImg = img;
            Locs = l;
            MessageBox.Show(l.Count.ToString());
        }
    }
}