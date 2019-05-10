using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_CSharp
{

    public class Circle : Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("This shape is a circle");
        }
    }

    public class Rectangle : Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("This shape is a rectangle");
        }
    }

    public class Triangle : Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("This shape is a Triangle");
        }
    }

    public class Shapes
    {
        // created fields that will be used for the sized of the shapes
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        public virtual void Draw()
        {

        }

    }
}
