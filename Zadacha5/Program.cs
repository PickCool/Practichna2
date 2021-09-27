using System;

namespace Zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.Write("Login: ");
            string login = Console.ReadLine();

            Console.Write("Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            string secondName = Console.ReadLine();

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            var user = new User(login, firstName, secondName, age);
            Console.WriteLine();

            Console.WriteLine("Filling out a questionnaire:");
            Console.WriteLine(user);

            Console.ReadLine();
        }
    }
}
