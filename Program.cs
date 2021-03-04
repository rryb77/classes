using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company xyz = new Company("XYZ", new DateTime(), new List<Employee>());

            // Create three employees
            Employee dave = new Employee("Dave", "Jones", "CEO", new DateTime());
            Employee carl = new Employee("Carl", "Sage", "VP", new DateTime());
            Employee eli = new Employee("Eli", "Quest", "CIO", new DateTime());

            // Assign the employees to the company
            xyz.EmployeesList.Add(dave);
            xyz.EmployeesList.Add(carl);
            xyz.EmployeesList.Add(eli);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            foreach (Employee employee in xyz.EmployeesList)
            {
                Console.WriteLine($"{employee.FullName} works for {xyz.Name} as {employee.Title} since {employee.StartDate}");
            }
        }
    }
}
