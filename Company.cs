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
        public List<string> Employees { get; set; }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string name, DateTime dt)
        {
            Name = name;
            CreatedOn = dt;
        }

        public void ListEmployees()
        {
            foreach (string employee in Employees)
            {
                Console.WriteLine($"{employee}");
            }
        }

        public void AddEmployees(string employee)
        {
            Employees.Add(employee);
        }
    }
}
