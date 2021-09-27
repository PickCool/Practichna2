using System;
using System.Collections.Generic;
using System.Text;

namespace Zadacha7
{
    public class Employee
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public string Appointment { get; set; }

        public int Experience { get; set; }

        public Employee(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        public void CalculateSalaryAndTax(out double salary, out double tax)
        {
            double baseSalary = 0d;

            switch (Appointment)
            {
                case "Chef":
                    baseSalary = 20000d;
                    break;

                case "Courier":
                    baseSalary = 14500d;
                    break;

                case "Waiter":
                    baseSalary = 15000d;
                    break;
            }

            salary = baseSalary * Experience / 2d;

            tax = salary * 0.08d;
        }
    }
}
