using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_CSharp
{
    // Used for Obj. Initializer
    public class Person
    {
        public string FirstName;
        public string LastName;
    }


    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                FirstName = "Hector",
                LastName = "Gonzalez"
            };

            // gives the points for both X and Y
            var point = new Point(10, 30);
            point.Move(null);
            Console.WriteLine();


            Console.WriteLine();

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

    // Prac. Access Modifiers.. Creating and Grabbing data regarding birthdate
    public class Birth
    {
        private DateTime _birthdate;

        public void SetBirthDate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthDate()
        {
            return _birthdate;
        }

    }
}
