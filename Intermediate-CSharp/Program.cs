using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_CSharp
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        static void Main(string[] args)
        {
            var person = new Person
            {
                FirstName = "Hector",
                LastName = "Gonzalez"
            };

            // Console.WriteLine("{0} {1}", person.FirstName, person.LastName);
        }
    }

    #region Defensive Programming, points (X & Y) if the value is null we test it with a Argu.NullException that will show us that the variable has no value 

    public class Point
        {

            public int X;
            public int Y;

            public Point(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public void Move(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
            
            // problem is tested defensively by throwing an arg. in if location has no value (heads up)
            public void Move(Point newLocation)
            {
                if(newLocation == null)
                    throw new ArgumentNullException("newLocation");
                
                 Move(newLocation.X, newLocation.Y);
            }
        }

    #endregion
}
