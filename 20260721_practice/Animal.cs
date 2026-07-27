using System;
using System.Collections.Generic;
using System.Text;

namespace _20260721_Practice
{

	class Animal
	{
		//public string Name { get; set; } // 名前
		//public int Age { get; set; } // 年齢

		//public Animal(string name, int age)
		//{
		//	Name = name;
		//	Age = age;
		//}

		//public void ShowProfile()
		//{
		//	Console.WriteLine(Name + "," + Age + "歳");
		//}

		//2.7.8
			public string Name { get; private set; }    // 名前
			public int Age { get; private set; }        // 年齢

			public Animal(string name, int age)
			{
				Name = name;
				Age = age;
			}

			public void ShowProfile()
			{
				Console.WriteLine(Name + "," + Age + "歳");
			}

		public virtual void Speak()
		{
			Console.WriteLine("......");
		}

	}


	class Cat : Animal
	{
		public Cat(string name, int age)

			: base(name, age)
		{
		}

		public void Sleep()
		{
			Console.WriteLine("スースー");
		}
		public override void Speak()
		{
			Console.WriteLine("ニャー");
		}
	}


	//2.7.9
	class Dog : Animal
	{
		public Dog(string name, int age)

					: base(name, age)
		{
		}
		public void Run()
		{
			Console.WriteLine("トコトコ");
		}

		




	}



}



