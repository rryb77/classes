using System;
using System.Collections.Generic;

namespace classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> EmployeesList { get; set; }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string name, DateTime dt, List<Employee> initialEmployees)
        {
            Name = name;
            CreatedOn = dt;
            EmployeesList = initialEmployees;
        }

        public void ListEmployees()
        {
            foreach (Employee employee in EmployeesList)
            {
                Console.WriteLine($"{employee}");
            }
        }
    }
}
