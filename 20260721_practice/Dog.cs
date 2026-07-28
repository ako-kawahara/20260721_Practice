using System;
using System.Collections.Generic;
using System.Text;


namespace _20260721_Practice
{

	//2.7.	問題7-1,2,3,4
	//      public string Name { get; set; }
	//public int Age { get; set; }

	//public string Seed { get; set; }
	//public void ShowProfile()
	//{
	//	Console.WriteLine($"名前：{Name}");
	//	Console.WriteLine($"年齢：{Age}");
	//	Console.WriteLine($"犬種：{Seed}");
	//}

	//2.7.9
	class Dog : Animal, IPlayable
		{
			public Dog(string name, int age)

						: base(name, age)
			{
				//	Species = "犬";
			}

			public override void Speak()
			{
				Console.WriteLine("ワンワン");
			}


		public void Run()
		{
			Console.WriteLine("トコトコ");
		}


		public override void Walk()
		{
			Console.WriteLine("しっぽを振りながら歩く");
		}
		public override string Species
		{
			get { return "Dog"; }
		}
		protected override void MoveCore()
		{
			Console.WriteLine("速い");
		}
		
			public void Play()
			{
			Console.WriteLine("ボールで遊ぶ");
			}
		

	}
}
