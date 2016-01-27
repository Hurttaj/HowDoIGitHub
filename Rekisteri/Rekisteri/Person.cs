using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekisteri
{
    /// <summary>
    /// This class contains Person properties
    /// </summary>
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }

        public override string ToString()
        {
            return "First name: " + FirstName + " Last name: " + LastName + " Social Security Number: " + SSN;
        }
    }
}
