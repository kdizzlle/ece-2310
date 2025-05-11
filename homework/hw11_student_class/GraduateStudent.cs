using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw11_student_class
{
    class GraduateStudent:Student
    {
        private string bachelors;
        private int gradYear;
        private string masters;

        public GraduateStudent() : base()
        {
            bachelors = "Education";
            gradYear = 2001;
            masters = "Psychology";
        }
        public GraduateStudent(string fn, string ln, string edu, string bs, int yr, string ms) : base(fn, ln, edu)
        {
            bachelors = bs;
            gradYear = yr;
            masters = ms;
        }

        public string Bachelors
        {
            get { return bachelors; }
            set { bachelors = value; }
        }
        public int GradYear
        {
            get { return gradYear; }
            set { gradYear = value; }
        }
        public string Masters
        {
            get { return masters; }
            set { masters = value; }
        }

        public override string ToString()
        {
            string outStr = FirstName + " " + LastName + " graduated with a Bachelors in " + bachelors + " from " + School + " in " + gradYear + ".";
            outStr += "\nThey are now a Graduate student pursuing a Masters in " + masters + ".\n";
            return outStr;
        }
        ~GraduateStudent() { }
    }
}
