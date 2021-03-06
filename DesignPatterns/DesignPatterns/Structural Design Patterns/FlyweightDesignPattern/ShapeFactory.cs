using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Design_Patterns.FlyweightDesignPattern
{
    public class ShapeFactory
    {
        private static Dictionary<string, Shape> _shapes = new Dictionary<string, Shape>();

        public static Shape GetShape(string shapeType)
        {
            Shape shape = null;
            if(shapeType.Equals("circle", StringComparison.InvariantCultureIgnoreCase))
            {
                if (_shapes.TryGetValue("circle", out shape))
                {
                }
                else
                {
                    shape = new Circle();
                    _shapes.Add("circle", shape);
                    Console.WriteLine(" Creating circle object with out any color in shapefactory \n");
                }
            }
            return shape;
        }
    }
}
