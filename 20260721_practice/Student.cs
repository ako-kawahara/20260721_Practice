using System;
using System.Collections.Generic;
using System.Text;

namespace _20260721_Practice
{
    internal class Student
    {
        public string Name { get; set; }
    
       // public int Age { get; set; }

		public int Score { get; set; }

		public Student(string name, int score)
		{
			Name = name;
			Score = score;
		}
		//public void ShowProfile()
		//      {
		//          Console.WriteLine($"{Name},{Score}");
		//      }
	}
}
