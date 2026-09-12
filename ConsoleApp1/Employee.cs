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
        public DateOnly HireDate { get; set; }
        public bool Gender { get; set; }

        public Employee(int Id,string Name,string SequrityLevel,decimal Salary,DateOnly HireDate,bool Gender)
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
