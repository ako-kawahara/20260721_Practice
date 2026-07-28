using System;
using System.Collections.Generic;
using System.Text;

namespace _20260721_Practice
{
  
		class Cat : Animal,IPlayable
		{
			public Cat(string name, int age)

				: base(name, age)
			{
				//	Species = "猫";
			}

			public void Sleep()
			{
				Console.WriteLine("スースー");
			}
			public override void Speak()
			{
				Console.WriteLine("ニャー");
			}
		
			public override string Species =>"Cat";

		public new void ShowKind()
		{
			Console.WriteLine("猫です");
		}

		protected override void MoveCore()
		{
			Console.WriteLine("かわいい");
		}
		
		
			public void Play()
			{
				Console.WriteLine("じゃれて遊ぶ");
			}
		
	}
	
}
