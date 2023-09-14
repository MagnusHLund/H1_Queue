using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Queue.Model
{
    internal class Person
    {
        internal readonly string[] firstNames = { "John", "Paul", "Ringo", "George", "Stephen", "Larry", "Scott", "Alexander", "Dennis", "Tyler" };

        internal readonly string[] lastNames = { "Lennon", "McCartney", "Starr", "Harrison", "Anderson", "Moore", "Lee", "Thompson", "Clark", "Hill" };

        internal string firstName;
        internal string lastName;

        internal string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        internal string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
    }
}
