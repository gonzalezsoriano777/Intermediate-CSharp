using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_CSharp
{
    // Used for Obj. Initializer
    public class Human
    {
        public string FirstName;
        public string LastName;
    }


    class Program
    {
        static void Main(string[] args)
        {
            var human = new Human
            {
                FirstName = "Hector",
                LastName = "Gonzalez"
            };

            // set birthdate and print in console
            var birth = new Birth();
            birth.SetBirthDate(new DateTime(2006, 3, 1));
            Console.WriteLine(birth.GetBirthDate());

            // using properties that include getter and setter
            var person = new Person();
            person.BirthDate = (new DateTime(1981, 1, 3));
            Console.WriteLine(person.Age);

            // gives the points for both X and Y
            var point = new Point(10, 30);

            //test ran to see if were able to detect no value once arg. null is implemented
            point.Move(null);
            Console.WriteLine("The Point of both (X:{0} & Y:{1})", point.X, point.Y);

            point.Move(new Point(100, 200));
            Console.WriteLine("The new points of both (X:{0} & Y:{1})", point.X, point.Y);
            

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
