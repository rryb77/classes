using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company xyz = new Company("XYZ", new DateTime());

            // Create three employees
            Employee dave = new Employee("Dave", "Jones", "CEO", new DateTime());

            // Assign the employees to the company

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        }
    }
}
