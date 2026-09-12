using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Employee
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public string SequrityLevel {  get; set; }
        public decimal Salary { get; set; }
        public HireDate HireDate { get; set; }
        public char Gender { get; set; }

        public Employee()
        {
            this.ID = 0;
            this.Name = "Unknown";
            this.SequrityLevel = "Unknown";
            this.Salary = 0;
            this.Gender = 'M';
        }

        public Employee(int Id,string Name,string SequrityLevel,decimal Salary,HireDate HireDate,char Gender)
        {
            this.ID = Id;
            this.Name = Name;
            this.SequrityLevel = SequrityLevel;
            this.Salary = Salary;
            this.HireDate = HireDate;
            this.Gender = Gender;
        }
    }
}
