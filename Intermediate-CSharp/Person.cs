using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_CSharp
{
    // simplfied of getter and setter.. getter gets the variable and setter gets the value of the setter

    public class Person
    {
        // just practices of using getter & setter
        public string Name { get; set; }
        public string Username { get; set; }

        public DateTime BirthDate { get; private set; }

        public Person(DateTime birthdate)
        {
            BirthDate = birthdate;
        }

        public int Age
        {
            get
            { 
                // getting the initial age of a person based of the date today and the birthdate
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
    }
}
