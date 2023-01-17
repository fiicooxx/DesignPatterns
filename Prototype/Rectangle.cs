using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Rectangle : Shape
    {
        //shallow clone
        //public override Shape Clone()
        //{
        //    return (Rectangle)this.MemberwiseClone();
        //}
        public override Shape Clone()
        {
            Rectangle cloneBase = (Rectangle)this.MemberwiseClone();

            cloneBase.Border = new Border()
            {
                Size = Border.Size,
                Color = Border.Color
            };

            return cloneBase;
        }

        public override void Render()
        {
            Console.WriteLine("Render rectangle...");
        }
    }
}