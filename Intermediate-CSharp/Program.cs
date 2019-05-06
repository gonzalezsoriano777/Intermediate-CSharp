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

            Console.WriteLine("{0} {1}", person.FirstName, person.LastName);
        }
    }
}
