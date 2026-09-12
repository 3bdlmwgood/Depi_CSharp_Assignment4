using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Employee
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public enSecurityLevel SecurityLevel {  get; set; }
        public decimal Salary { get; set; }
        public HireDate HireDate { get; set; }
        public enGender Gender { get; set; }

        public Employee()
        {
            this.ID = 0;
            this.Name = "Unknown";
            this.SecurityLevel = enSecurityLevel.Guest;
            this.Salary = 0;
            this.HireDate = new HireDate();
            this.Gender = enGender.Male;
        }

        public Employee(int Id,string Name, enSecurityLevel SecurityLevel,decimal Salary,HireDate HireDate,enGender Gender)
        {
            this.ID = Id;
            this.Name = Name;
            this.SecurityLevel = SecurityLevel;
            this.Salary = Salary;
            this.HireDate = HireDate;
            this.Gender = Gender;
        }

        public override string ToString()
        {
            return $"ID: {ID} - Name: {Name} - Gender: {Gender}" +
                $"\nSalary: {String.Format("{0:C}", Salary)} - Security Level: {SecurityLevel} - HireDate: {HireDate}";
        }

    }
}
