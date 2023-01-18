﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class SmallPizza : IPizza
    {
        public double CalculatePrice()
        {
            return 15.0;
        }
    }
}
