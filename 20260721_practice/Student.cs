using System;
using System.Collections.Generic;
using System.Text;

namespace _20260721_Practice
{
    internal class Student
    {
        public string Name { get; set; }
    
        public int Age { get; set; }

        //public Student(string name, int age)
        //{
        //    Name = name;
        //    Age = age;
        //}
    public void ShowProfile()
        {
            Console.WriteLine($"{Name},{Age}");
        }
    }
}
