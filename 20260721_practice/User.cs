using System;
using System.Collections.Generic;
using System.Text;

namespace _20260721_Practice
{
    internal class User
    {
		public string Name { get; set; }
		public int Age { get; set; }

		public User(string name, int age)
		{
			Name = name;
			Age = age;
		}

		public override string ToString()
		{
			return $"Name={Name}, Age={Age}";
		}
	}
}
