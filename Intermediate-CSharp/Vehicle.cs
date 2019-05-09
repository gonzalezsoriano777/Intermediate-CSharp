using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_CSharp
{
    // focusing on using constructor that use private modifiers and how to include inheritance using a property that is private
    public class Vehicle
    {
        private readonly string _registrationNumber;

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;

            Console.WriteLine();

            Console.WriteLine("The Vehicle is being initialized. Finalized the # is {0}", registrationNumber);
        }
    }
}
