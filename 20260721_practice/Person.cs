using System;
using System.Collections.Generic;
using System.Text;

namespace _20260721_Practice
{
    internal class Person
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Person(string name, string phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }
    }
}
