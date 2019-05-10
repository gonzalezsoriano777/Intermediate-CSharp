using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_CSharp
{
    // this is polymorphism.
    public class Circle : Shapes
    {
        public override void Draw()
        {
            Console.WriteLine();
            Console.WriteLine("This shape is a circle");
        }
    }

    // we are able to create new classes that have no effect or impact
    public class Rectangle : Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("This shape is a rectangle");
        }
    }

    // meaning that each class that revolves around different shapes won't derive from other shapes
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

        public virtual void Draw()
        {

        }

    }
}
