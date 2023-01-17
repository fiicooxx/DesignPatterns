using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Square : Shape
    {
        public override void Render()
        {
            Console.WriteLine("Rendering a square...");
        }
    }
}
