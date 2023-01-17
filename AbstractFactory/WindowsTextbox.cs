﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class WindowsTextbox : ITextbox
    {
        public void HandleInput()
        {
            Console.WriteLine("Render windows textbox");        
        }

        public void Render()
        {
            Console.WriteLine("Render windows text input");
        }
    }
}
