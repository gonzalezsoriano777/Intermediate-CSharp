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
            #region Created 2 classes that are flexible and able to recieve different messages from the same method in the same class

            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var install = new Installer(logger);

            dbMigrator.Migrator();

            install.Install();

            Console.WriteLine();

            #endregion

            #region Object Initializer
            var human = new Human
            {
                FirstName = "Hector",
                LastName = "Gonzalez"
            };
            #endregion

            #region working with getter and setter to find the initial age
            // set birthdate and print in console
            var birth = new Birth();
            birth.SetBirthDate(new DateTime(2006, 3, 1));
            Console.WriteLine(birth.GetBirthDate());

            // using properties that include getter and setter
            var person = new Person(new DateTime(1998, 1, 3));
            Console.WriteLine(person.Age);
            #endregion

            
            #region Working with indexes and prac. with key prop. and values
            var cookie = new Indexers();

            // this grabs the key string and what that strings value will be
            cookie["name"] = "Erickson";
            Console.WriteLine(cookie["name"]);

            #endregion

            #region Defensive Programming

            // used the try method to run lines.. of code

            try
            {
                // gives the points for both X and Y
                var point = new Point(10, 30);

                //test ran to see if were able to detect no value once arg. null is implemented
                point.Move(null);
                Console.WriteLine("The Point of both (X:{0} & Y:{1})", point.X, point.Y);

                point.Move(new Point(100, 200));
                Console.WriteLine("The new points of both (X:{0} & Y:{1})", point.X, point.Y);

            }

            // if detected an issue with no value, print to console data to let it know

            catch (Exception)
            {
                Console.WriteLine("Unexpected error has been detected, no value has been shown..");
            }

            #endregion


            // instantiating object that needs a registration# to be called in console
            var car = new Cars("XX235YSS");

            #region Working with Interfaces Testability,
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            orderProcessor.
            #endregion

            #region Working with overriding different classes that have different shapes

            var shapes = new List<Shapes>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());
            shapes.Add(new Triangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
            #endregion

            #region Working with Interfaces Extensibility, changing it's behaviors 

            // log messages through the console
            var dbMigratorv2 = new DbMigratorv2(new ConsoleLogger());

            
            // logs messages through a file
            // var dbMigratorv2 = new DbMigratorv2(new FileLogger("C:\\Go\\log.txt"));


            dbMigratorv2.Migrate();
            #endregion

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

    
    public class DbMigrator
    {
        private readonly Logger _logger;

        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrator()
        {
            _logger.Log("Writing a message for the first time in the world");
        }
    }

    public class Installer
    {
        private readonly Logger _logger;

        public Installer(Logger logger)
        {
            _logger = logger;
        }

        public void Install()
        {
            _logger.Log("Another message added where this one has another class using it");
        }
    }

    // this will consist of the car and it's registration number being initialized from the Vehicle itself
    public class Cars : Vehicle
    {

        // the keyword "base" is used for grabbing the field "registrationNumber" from the vehicle and implementing the field to this class
        

        public Cars(string registrationNumber)
            // overall initializing the field use in one class to another, in this case if the field is private
            : base (registrationNumber)
        {
            Console.WriteLine("The Car is being initialized. Complete the registration # is {0}", registrationNumber);
        }
    }
}
