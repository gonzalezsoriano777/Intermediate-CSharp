using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_CSharp
{
    public class Person
    {
        public DateTime BirthDate { get; set; }

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
