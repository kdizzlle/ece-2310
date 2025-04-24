using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_inheritance
{
    class Name
    {
        string firstName = "Unknown";
        string lastName = " ";

        public Name()
        {
            firstName = "Unknown";
            lastName = " ";
        }
        
        public Name(string fn, string ln)
        {
            firstName = fn;
            lastName = ln;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public override string ToString()
        {
            return firstName + " " + lastName;
        }

        ~Name() { }
    }
}
