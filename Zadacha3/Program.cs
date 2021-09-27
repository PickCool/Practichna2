using System;
using System.Text;
using Author1;
using Containing1;
using Book1;
using Title1;

namespace Zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding =
            Console.OutputEncoding =
            Encoding.Unicode;

            var book = new Book();

            while (true)
            {
                Console.WriteLine("Main menu:");

                Console.WriteLine("1 - Add new title");

                Console.WriteLine("2 - Add Author");

                Console.WriteLine("3 - Add some containing");

                Console.WriteLine("4 - Show the book");

                Console.WriteLine("5 - Exit");

                Console.WriteLine();

                Console.Write("Your choice is ");
                int choice;
                bool choiceParsed = int.TryParse(Console.ReadLine(), out choice);
                if (!choiceParsed)
                {
                    Console.WriteLine("Unknown");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Title: ");
                        book.AddTitle(Console.ReadLine());
                        break;

                    case 2:
                        Console.Write("Author: ");
                        book.AddAuthor(Console.ReadLine());
                        break;

                    case 3:
                        Console.Write("Containing: ");
                        book.AddContent(Console.ReadLine());
                        break;

                    case 4:
                        book.Show();
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Error404");

                        continue;
                }
            }
        }
    }
}
