using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw11_student_class
{
    class UnderGraduate:Student
    {
        private string year;
        private double gpa;
        private string major;

        public UnderGraduate():base()
        {
            year = "XXXX";
            gpa = 1.23;
            major = "Education";
        }
        public UnderGraduate(string fn, string ln, string edu, string yr, double gPA, string maj):base(fn, ln, edu)
        {
            year = yr;
            gpa = gPA;
            major = maj;
        }

        public string Year
        {
            get { return year; }
            set { year = value; }
        }
        public double GPA
        {
            get { return gpa; }
            set { gpa = value; }
        }
        public string Major
        {
            get { return major; }
            set { major = value; }
        }

        public override string ToString()
        {
            string outStr = FirstName+" "+LastName+" is a " + year + " Undergraduate majoring in " + major + " at " + School + " with a " + gpa + " GPA.\n";
            return outStr;
        }
        ~UnderGraduate() { }
    }
}
