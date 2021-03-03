using System;
using System.Collections.Generic;

namespace classes
{
    public class Employee
    {

        // Some readonly properties (let's talk about gets, baby)
        public string FirstName { get; }
        public string LastName { get; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public string Title { get; }
        public DateTime StartDate { get; }


        public Employee(string firstName, string lastName, string title, DateTime dt)
        {
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            StartDate = dt;
        }

        public void AddEmployees(List<string> employee)
        {
            Console.WriteLine($"{employee}");
        }

    }
}
