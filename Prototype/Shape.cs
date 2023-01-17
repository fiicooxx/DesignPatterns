﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }
        public Border Border { get; set; }
        public abstract void Render();
        public abstract Shape Clone();
    }
}

