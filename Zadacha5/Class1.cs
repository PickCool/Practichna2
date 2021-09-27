using System;
using System.Collections.Generic;
using System.Text;

namespace Zadacha5
{
    public class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public DateTime DateOfQ { get; }

        public User(string login, string name, string lastName, int age)
        {
            Login = login;
            Name = name;
            LastName = lastName;
            Age = age;
            DateOfQ = DateTime.Now;
        }

        public override string ToString()
        {

            return
                $"Login: {Login}\n" +
                $"Name: {Name}\n" +
                $"Last Name: {LastName}\n" +
                $"Age: {Age}\n" +
                $"Date of filling out the questionaire: {DateOfQ}";
        }
    }
}
