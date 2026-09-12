using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class HireDate
    {
        public int Day {  get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HireDate()
        {
            this.Day = 1;
            this.Month = 1;
            this.Year = 1900;
        }

        public HireDate(int day,int month,int year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }
    }
}
