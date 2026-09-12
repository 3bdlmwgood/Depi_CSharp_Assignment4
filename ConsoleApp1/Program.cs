namespace ConsoleApp1
{
    public enum enGender { Male , Female}

    public enum enSecurityLevel { Guest,Developer,Secrtary,DBA,SecurityOfficer }

    internal class Program
    {
        
        static void PrintEmployees(Employee[] employees)
        {
            Console.WriteLine($"====================== All Employees ({employees.Length}) ======================\n");
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i]);
                Console.WriteLine("---------------------------------------------------------------");
            }
        }

        static void Main(string[] args)
        {
            Employee[] EmpArr = new Employee[3];

            EmpArr[0] = new Employee
            {
                ID = 1,
                Name = "Abdallah",
                SecurityLevel = enSecurityLevel.DBA,
                Salary = 15_000,
                HireDate = new HireDate(20, 12, 2026),
                Gender = enGender.Male
            };

            EmpArr[1] = new Employee
            {
                ID = 2,
                Name = "Mona",
                SecurityLevel = enSecurityLevel.Guest,
                Salary = 10_000,
                HireDate = new HireDate(13, 9, 2024),
                Gender = enGender.Female
            };

            EmpArr[2] = new Employee
            {
                ID = 3,
                Name = "Ahmed",
                SecurityLevel = enSecurityLevel.SecurityOfficer,
                Salary = 25_000,
                HireDate = new HireDate(1, 8, 2022),
                Gender = enGender.Male
            };

            PrintEmployees(EmpArr);

        }
    }
}
