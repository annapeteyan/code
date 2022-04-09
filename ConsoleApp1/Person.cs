using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        private string _name;
        string _surname;
        DateTime _birthdayDate;
        public void Show()
        {
            Console.WriteLine("hello!" + _name);
        }

        public Person(string name, string surname, DateTime bdate)
        {
            _name = name;
            _surname = surname;
            _birthdayDate = bdate;
        }

    }
}
