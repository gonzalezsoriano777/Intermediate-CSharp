using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_CSharp
{
   public class ListingShapes
    {
        public void DrawShapes(List<Shapes> shapes)
        {
            
            foreach(var shape in shapes)
            {
                // this will be used to be overridden in a derived class, each shape called that's overriden will be called in the console 
                shape.Draw();
            }
        }
    }
}
