using System;
using System.Collections.Generic;
using System.Text;


//2.7.	問題7-1,2,3,4
namespace _20260721_Practice
{
    internal class Dogclass
    {

        public string Name { get; set; }
		public int Age { get; set; }

		public string Seed { get; set; }
		public void ShowProfile()
		{
			Console.WriteLine($"名前：{Name}");
			Console.WriteLine($"年齢：{Age}");
			Console.WriteLine($"犬種：{Seed}");
		}


	}
}
