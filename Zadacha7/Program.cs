using System;

namespace Zadacha7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Console.OutputEncoding = System.Text.Encoding.Unicode;

            var employee = new Employee("Isaak", "Izrael")
            {
                Appointment = "Courier",
                Experience = 2
            };

            employee.CalculateSalaryAndTax(out double salary, out double tax);

            Console.WriteLine($"Name: {employee.Name} {employee.LastName}");

            Console.WriteLine($"Appointment: {employee.Appointment}");

            Console.WriteLine($"Salary: {salary}");

            Console.WriteLine($"Tax: {tax}");

            Console.ReadLine();
        }
    }
}
