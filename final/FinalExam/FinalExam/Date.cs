using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    internal class Date
    {
        private string month;
        private string day;
        private string year;

        public Date()
        {
            month = "01";
            day = "01";
            year = "1999";
        }
        public Date(string m, string d, string y)
        {
            month=m;
            day=d;
            year=y;
        }
        public string Month
        {
            get { return month; }
            set { month = value; }
        }
        public string Day
        {
            get { return day; }
            set { day = value; }
        }
        public string Year
        {
            get { return year; }
            set { year = value; }
        }
        public string DisplayDate()
        {
            return month + "/" + day + "/" + year;
        }
    }
}
