using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ShapeFactory
    {
        public Shape CreateShape(ShapeType shapeType)
        {
            switch (shapeType)
            {
                case ShapeType.Circle:
                    return new Circle();
                case ShapeType.Square:
                    return new Square();
                case ShapeType.Triangle:
                    return new Triangle();
                default:
                    throw new Exception($"Shape type {shapeType} is not handled!");
            }
            
        }
    }
}
