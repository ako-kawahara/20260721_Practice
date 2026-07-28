using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace _20260721_Practice
{

	abstract class Animal
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
		public int Age { get; private set; }    // 年齢

		public virtual string Species 
		{
			get { return "Animal"; }
		}

		public Animal(string name, int age)
		{
			Name = name;
			Age = age;
		}

		public void ShowProfile()
		{
			Console.WriteLine(Name + "," + Age + "歳");
		}

		//public string Species;

		public override string ToString()
		{
			return $"{GetType().Name}名前: {Name}, 年齢: {Age}"; ;
		}

		public abstract void Speak();

		public virtual void Walk()
		{
			Console.WriteLine("トコトコ歩く");
		}
		public void Walk(int steps)
		{
			Console.WriteLine($"{steps}歩歩いた");
		}

		public void ShowKind()
		{
			Console.WriteLine("動物です");
		}
		public void DoDaily()
		{
			ShowProfile();
			Speak();
			MoveCore();
		}

		
		protected abstract void MoveCore();

	}
}



