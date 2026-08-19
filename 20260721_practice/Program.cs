using System.ComponentModel.Design;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Net.Cache;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Timers;

namespace _20260721_Practice
{
	public class Program
	{
		//5.12.1
		//static string filePath = "address.csv";
		//static List<Person> people = new List<Person>();
		static void Main(string[] args)
		{
			//	//5.12.1
			//	try
			//	{
			//		LoadCsv();
			//		bool running = true;
			//		while (running)
			//		{
			//			Console.WriteLine();
			//			Console.WriteLine("=== アドレス帳 ===");
			//			Console.WriteLine("1. 一覧表示");
			//			Console.WriteLine("2. 追加");
			//			Console.WriteLine("3. 検索");
			//			Console.WriteLine("4. 削除");
			//			Console.WriteLine("5. 終了");
			//			Console.Write("番号を選択してください: ");

			//			string choice = Console.ReadLine();

			//			try
			//			{
			//				switch (choice)
			//				{
			//					case "1":
			//						ShowAll();
			//						break;
			//					case "2":
			//						AddPerson();
			//						break;
			//					case "3":
			//						SearchPerson();
			//						break;
			//					case "4":
			//						DeletePerson();
			//						break;
			//					case "5":
			//						SaveCsv();
			//						Console.WriteLine("終了します。");
			//						running = false;
			//						break;
			//					default:
			//						Console.WriteLine("1～5を入力してください。");
			//						break;

			//				}
			//			}
			//			catch (Exception ex)
			//			{
			//				Console.WriteLine("エラーが発生しました: " + ex.Message);
			//			}
			//		}
			//	}
			//	catch (Exception ex)
			//	{
			//		Console.WriteLine("起動時にエラーが発生しました" + ex.Message);
			//	}
			//}
			//	static void LoadCsv()
			//	{
			//		if (!File.Exists(filePath))
			//		{
			//			File.Create(filePath).Close();
			//			Console.WriteLine("address.csvを新規作成しました。");
			//			return;
			//		}

			//	using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
			//	{
			//		string line;
			//				while ((line = reader.ReadLine()) != null)
			//				{
			//					if (string.IsNullOrWhiteSpace(line))
			//					{
			//						continue;
			//					}
			//					string[] data = line.Split(',');
			//					if (data.Length != 3)
			//					{
			//						Console.WriteLine("不正なデータをスキップしました:" + line);
			//						continue;
			//					}
			//					if (string.IsNullOrWhiteSpace(data[0]) ||
			//						string.IsNullOrWhiteSpace(data[1]) ||
			//						string.IsNullOrWhiteSpace(data[2]))
			//					{
			//						Console.WriteLine(
			//							"空の項目があるためスキップしました: " + line);
			//						continue;
			//					}
			//					people.Add(new Person(
			//						data[0].Trim(),
			//						data[1].Trim(),
			//						data[2].Trim()
			//					));
			//				}
			//		}
			//	}
			//	static void SaveCsv()
			//	{
			//		using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
			//		{
			//			foreach (Person person in people)
			//			{
			//				writer.WriteLine(
			//					$"{person.Name},{person.Phone},{person.Email}"
			//				);
			//			}
			//		}
			//	}
			//	static void ShowAll()
			//	{
			//		if (people.Count == 0)
			//		{
			//			Console.WriteLine("登録されている人はいません。");
			//			return;
			//		}

			//		Console.WriteLine();
			//		Console.WriteLine("=== 一覧 ===");

			//		for (int i = 0; i < people.Count; i++)
			//		{
			//			Person person = people[i];
			//			Console.WriteLine(
			//						$"{i + 1}. 名前: {person.Name} / 電話: {person.Phone} / Email: {person.Email}"
			//					);
			//		}
			//	}
			//	static void AddPerson()
			//	{
			//		Console.WriteLine();
			//		Console.WriteLine("=== 追加 ===");

			//		string name = ReadValue("名前");
			//		string phone = ReadValue("電話番号");
			//		string email = ReadValue("Email");

			//		people.Add(new Person(name, phone, email));

			//		Console.WriteLine("登録しました。");
			//	}

			//	static void SearchPerson()
			//	{
			//		Console.WriteLine();
			//		Console.WriteLine("=== 検索 ===");

			//		string keyword = ReadValue("名前");

			//		bool found = false;

			//		foreach (Person person in people)
			//		{
			//			if (person.Name.Contains(keyword))
			//			{
			//				Console.WriteLine(
			//					$"名前: {person.Name} / 電話: {person.Phone} / Email: {person.Email}"
			//				);

			//				found = true;
			//			}
			//		}
			//		if (!found)
			//		{
			//			Console.WriteLine("該当する人が見つかりませんでした。");
			//		}
			//	}
			//	static void DeletePerson()
			//	{
			//		Console.WriteLine();
			//		Console.WriteLine("=== 削除 ===");

			//		string name = ReadValue("削除する名前");
			//		Person target = null;

			//		foreach (Person person in people)
			//		{
			//			if (person.Name == name)
			//			{
			//				target = person;
			//				break;
			//			}
			//		}

			//		if (target == null)
			//		{
			//			Console.WriteLine("該当する人が見つかりませんでした。");
			//			return;
			//		}
			//		people.Remove(target);

			//		Console.WriteLine("削除しました。");
			//	}
			//	static string ReadValue(string itemName)
			//	{
			//		while (true)
			//		{
			//			Console.Write(itemName + ": ");
			//			string value = Console.ReadLine();
			//			if (string.IsNullOrWhiteSpace(value))
			//			{
			//				Console.WriteLine(itemName + "を入力してください。");
			//				continue;
			//			}
			//			if (value.Contains(","))
			//			{
			//				Console.WriteLine("カンマ（,）は入力できません。");
			//				continue;
			//			}

			//			return value.Trim();
			//		}

			//6.1.1
			//6.1.2
			//List<int> num = new List<int>();
			//for (int i = 0; i < 5; i++)
			//{
			//	Console.Write((i + 1) + "つ目の整数を入力してください: ");
			//	int nums = int.Parse(Console.ReadLine());
			//	num.Add(nums);
			//}
			//foreach (int nums in num)
			//{
			//	Console.WriteLine(nums);
			//}

			//	int sum = 0;
			//for (int i = 0; i < num.Count; i++)
			//{
			//	sum += num[i];
			//}
			//Console.WriteLine(sum);

			//6.2.1
			//List<string> fr = new List<string>();
			//fr.Add("りんご");
			//fr.Add("ばなな");
			//fr.Add("みかん");
			//foreach (string frr in fr)
			//{ 
			//Console.WriteLine(frr);
			//}

			//Console.WriteLine("フルーツ名を入力してください");
			//string frs = Console.ReadLine();

			//if (fr.Contains(frs))
			//{
			//	Console.WriteLine("フルーツは含まれています");
			//}
			//else 
			//{
			//	Console.WriteLine("フルーツは含まれていません");
			//}

			//6.3.1
			//6.3.2
			//	Dictionary<string, int> dic = new Dictionary<string, int>();
			//Dictionary<string, int> di = new Dictionary<string, int>
			//{
			//	{ "Japan" , 125},
			//	{ "USA", 331},
			//	{ "France", 67}
			//};
			//foreach (KeyValuePair<string, int> country in di)
			//{
			//	Console.WriteLine($"{country.Key}:{country.Value}");
			//}
			//Console.WriteLine();
			//Console.Write("検索する国名を入力してください: ");

			//string c = Console.ReadLine();
			//if (di.ContainsKey(c))
			//{
			//	Console.WriteLine($"{c}の人口は{di[c]}百万人です。");
			//}
			//else
			//{
			//	Console.WriteLine("登録されていません");
			//}

			////6.4.1
			//List<Student> students = new List<Student>();

			//students.Add(new Student("山田太郎", 80));
			//students.Add(new Student("佐藤花子", 95));
			//students.Add(new Student("鈴木一郎", 70));

			//foreach (Student student in students)
			//{
			//	Console.WriteLine(
			//		$"名前：{student.Name} / 点数：{student.Score}点");
			//}

			//6.5.1
			//var list = new List<int>
			//{ 
			//	1, 2, 3, 4, 5, 6, 7, 8, 9
			//};
			//var evenNumber = list.Where(nameof => nameof % 2 == 0);
			//foreach (int num in evenNumber)
			//{
			//	Console.WriteLine(num);
			//}

			//6.5.2
			//List<string> fruits = new List<string>
			//	{
			//	"apple", "banana", "cherry", "date"
			//	};
			//var fr = fruits.OrderBy(f => f);
			//foreach (string fruit in fr)
			//{
			//	Console.WriteLine(fruit);
			//}

			//6.6.1
			//	List<int> numbers = new List<int>
			//{
			//	1, 2, 3, 4, 5
			//};

			//	List<int> doubleNumbers = numbers
			//		.Select(n => n * 2)
			//		.ToList();

			//	foreach (int number in doubleNumbers)
			//	{
			//		Console.WriteLine(number);
			//	}

			//6.7.1
			//List<int> numbers = new List<int>
			//{
			//	80, 92, 75, 60, 45
			//};
			//double average = numbers.Average();
			//Console.WriteLine("平均値：" + average);

			//6.7.2
			//List<int> numbers = new List<int>
			//{
			//80, 92, 75, 60, 45
			//};
			//int count = numbers.Count(score => score >= 70);

			//Console.WriteLine("70点以上の人数：" + count + "人");

			//6.8.1
			//List<Student> numbers = new List<Student>
			//{
			//new Student("Aoki", 80),
			//new Student("Alice", 90),
			//new Student("Baba", 85),
			//new Student("Abe", 60),
			//new Student("Sato", 75)
			//};
			//var result = numbers.Where
			//(
			//student => student.Score >= 70 && student.Name.StartsWith("A")
			//);
			//foreach (Student student in result)
			//{
			//	Console.WriteLine(
			//		$"名前：{student.Name} / 点数：{student.Score}点"
			//	);
			//}

			//6.9.1
			//List<Student> student = new List<Student>
			//	{
			//	new Student("Alice", 80),
			//	new Student("Bob", 75), 
			//	new Student("Charlie", 80), 
			//	new Student("Dave", 60)
			//	};
			//var groups = student.GroupBy(student => student.Score);
			//foreach (var group in groups)
			//{
			//	Console.WriteLine("点数：" + group.Key);
			//	foreach (Student students in group)
			//	{
			//		Console.WriteLine("  " + students.Name);
			//	}
			//}

			//6.10.1
			//List<Product> products = new List<Product>
			//{
			//	new Product ("ぶた小間", 500, "肉"),
			//	new Product ("タイ", 2000, "魚"),
			//	new Product ("キャベツ", 200, "野菜"),
			//	new Product ("牛バラ", 1000, "肉"),
			//	new Product ("サバ", 600, "魚")
			//};
			//var exProducts = products.Where(p => p.Price >= 1000);
			//Console.WriteLine("[1000円以上の商品]");
			//foreach (Product product in exProducts)
			//{
			//	Console.WriteLine($"{product.Name}:{product.Price}:円");
			//}
			//var groups = products.GroupBy(p => p.Category);
			//Console.WriteLine("[カテゴリごとの商品数]");
			//foreach (var group in groups)
			//{
			//	Console.WriteLine($"{group.Key}:{group.Count()}個");
			//}
			//var sorProducts = products.OrderByDescending(p => p.Price);
			//Console.WriteLine("[価格の降順]");
			//foreach (Product product in sorProducts)
			//{
			//	Console.WriteLine($"{product.Name}:{product.Price}円");
			//}

			//7.1.1
			//7.2.1
			//7.3.1
			//7.4.1
			List<IReportable> reports = new List<IReportable>
			{
				new FullTimeEmployee("田中", 300000),
				new PartTimeEmployee("佐藤", 0, 1200, 80)
			};

			foreach (IReportable report in reports)
			{
				Console.WriteLine(report.GenerateReport());
			}
			List<Employee> employees = new List<Employee>
			{
				new FullTimeEmployee("田中",300000),
				//new FullTimeEmployee("佐藤",280000),
				new PartTimeEmployee("佐藤",0,1200,80),
				//new PartTimeEmployee("山田",0,1500,60)
			};

			FullTimeEmployee tanaka = (FullTimeEmployee)employees[0];
			tanaka.AddOvertimeHours(10);
			foreach (Employee employee in employees)
			{
				employee.ShowProfile();
				Console.WriteLine($"月給：{employee.CalculateMonthlyPay()}円");
				//Console.WriteLine($"{employee.Name}:{employee.CalculateMonthlyPay()}円");
				//decimal monthlyPay = employee.CalculateMonthlyPay();
				//Console.WriteLine($"月給：{monthlyPay}円");
				//Console.WriteLine();
				if (employee is IOvertimeEligible overtime)
				{
					overtime.AddOvertimeHours(10);
					Console.WriteLine($"残業時間：{overtime.GetOvertimeHours()}時間");
				}

				if (employee is IReportable report)
				{
					Console.WriteLine(report.GenerateReport());
				}

				Console.WriteLine();
			}
		






			//    int x = 11;
			//     Console.WriteLine($"x= {x}");

			//       x = 13 + 17;
			//     Console.WriteLine("x=" + x);


			//       x = 13;
			//     int y = 17;
			//       Console.WriteLine("x=" + y);

			//        x = 13 * 17;
			// Console.WriteLine("x=" + x);

			//         m211();
			//m212();
			//m213();
			//m214();

			//m221();
			//m222();
			//         Console.WriteLine("m,nを入力してください");
			//         int m = int.Parse(Console.ReadLine());
			//int n = int.Parse(Console.ReadLine());
			//m223(m,n);
			//         Console.WriteLine("bを入力してください");
			//       //  int b = int.Parse(Console.ReadLine());
			////m224(b);
			//         Console.WriteLine("pを入力してください");
			//         int p = int.Parse(Console.ReadLine());
			//         power(p);

			//         int q = int.Parse(Console.ReadLine());
			//         aaa(q);

			//         Console.WriteLine("ｃを入力してください");
			//         int c = int.Parse(Console.ReadLine());
			//         Console.WriteLine(CircleArea(c));

			//         Console.WriteLine("tを入力してください");
			//         int t = int.Parse(Console.ReadLine());
			//         ggg(t);

			//         Console.WriteLine("a,bを入力してください");
			//         int a = int.Parse(Console.ReadLine());
			//   //      int b = int.Parse(Console.ReadLine());
			// //        Add(a,b);

			//         Console.WriteLine("numberを入力してください");
			//         int x = int.Parse(Console.ReadLine());
			//         bool b = IsEven(x);
			//         if (b) {
			//             Console.WriteLine("偶数");
			//         }else{
			//             Console.WriteLine("奇数");
			//         }

			//Console.WriteLine("priceを入力してください");
			//int price = int.Parse(Console.ReadLine());
			//Console.WriteLine(CalcTax(price));

			//Console.WriteLine("a,b,cを入力してください");
			//int a = int.Parse(Console.ReadLine());
			//int b = int.Parse(Console.ReadLine());
			//int c = int.Parse(Console.ReadLine());
			//Console.WriteLine(GetMax(a,b,c));

			//Console.WriteLine("x,yを入力してください");
			//int x = int.Parse(Console.ReadLine());
			//int y = int.Parse(Console.ReadLine());
			//compare(x,y);

			//Console.WriteLine("x,yを入力してください");
			//int x = int.Parse(Console.ReadLine());
			//int y = int.Parse(Console.ReadLine());
			//         number(x,y);

			//         Console.WriteLine("numを入力してください");
			//         int num = int.Parse(Console.ReadLine());
			//         even(num);

			//Console.WriteLine("点数を入力してください");
			//int score = int.Parse(Console.ReadLine());
			//judge(score);

			//Console.WriteLine("SPAM!!");
			//Spam();

			//Console.WriteLine("xを入力してください");
			//int x = int.Parse(Console.ReadLine());
			//kuku(x);


			//int sum = 0;
			////for (int i = 0; i < 10; i++)
			//{
			//    Console.WriteLine("整数を入力してください");
			//    int a = int.Parse(Console.ReadLine());
			//    sum += a;
			//}
			//int av = avg(sum);
			//Console.WriteLine("整数を入力してください");


			//Console.WriteLine(" 試合開始");
			//int g = 0;
			//int t = 0;
			//bb(g,t);




			//sb();

			//    Number();

			//num();

			// Kuku();

			// sm();

			//int t = int.Parse(Console.ReadLine());
			//Method(t);

			//	Console.WriteLine("数値を入力してください");
			//	int num = int.Parse(Console.ReadLine());
			//	int result = Method(num);

			//	Console.WriteLine(result);

			//Console.WriteLine("二つの整数を入力してください");
			//int t = int.Parse(Console.ReadLine());
			//int s = int.Parse(Console.ReadLine());

			//int result = avge(t, s);
			//Console.WriteLine(result);

			//Console.WriteLine("三つの整数を入力してください");
			//int x = int.Parse(Console.ReadLine());
			//         int y = int.Parse(Console.ReadLine());
			//int z = int.Parse(Console.ReadLine());
			//int re = com(x,y,z);
			//         Console.WriteLine(re);

			//Console.WriteLine("数値を入力してください");
			//int result = San();
			//Console.WriteLine("入力された最大値は" + result +"です");

			//Console.WriteLine("数値を入力してください");
			//int re = Min();
			//Console.WriteLine("入力された最小値は" + re + "です");


			//Console.WriteLine("数値を入力してください");
			//int re = av();
			//Console.WriteLine("入力された平均値は" + re + "です");


			//2.7.5.	問題7-5
			//2.7.6.	問題7-6

			//	CoinCase coinCase = new CoinCase();

			//	for (int i = 0; i < 10; i++)
			//	{
			//		Console.Write("硬貨の種類を入力してください（500,100,50,10,5,1）：");
			//		int type = int.Parse(Console.ReadLine());

			//		Console.Write("枚数を入力してください：");
			//		int count = int.Parse(Console.ReadLine());

			//		coinCase.AddCoins(type, count);
			//	}
			//	Console.WriteLine($"500円：{coinCase.GetCount(500)}枚");
			//	Console.WriteLine($"100円：{coinCase.GetCount(100)}枚");
			//	Console.WriteLine($"50円：{coinCase.GetCount(50)}枚");
			//	Console.WriteLine($"10円：{coinCase.GetCount(10)}枚");
			//	Console.WriteLine($"5円：{coinCase.GetCount(5)}枚");
			//	Console.WriteLine($"1円：{coinCase.GetCount(1)}枚");

			//	Console.WriteLine($"合計金額：{coinCase.GetAmount()}円");
			//	Console.WriteLine($"総額：{coinCase.GetAmount()}円");

			//2.7.7

			//Cat cat = new Cat();
			//cat.Name = "タマ";
			//cat.Age = 10;
			//cat.ShowProfile();
			//cat.Sleep();

			//2.7.8
			//Cat cat = new Cat("クロ", 2);
			//cat.ShowProfile();
			//cat.Sleep();

			//Cat cat = new Cat("クロ", 2);
			//Console.WriteLine(cat.Name);
			//cat.ShowProfile();
			//cat.Sleep();

			//2.7.9

			//Dog dog = new Dog("コロ", 7);
			//Console.WriteLine(dog.Name);
			//dog.ShowProfile();
			//dog.Run();

			//2.7.10
			//Dog dog = new Dog("ジョージ", 4);
			//dog.ShowProfile();
			//dog.Speak();

			//Cat cat = new Cat("マロ", 7);
			//cat.ShowProfile();
			//cat.Speak();


			//2.7.11
			//Animal[] animals = new Animal[4];
			//animals[0] = new Cat("ミケ", 2);
			//animals[1] = new Dog("ポチ", 5);
			//animals[2] = new Cat("タマ", 1);
			//animals[3] = new Dog("コロ", 4);


			//	foreach (Animal a in animals)
			//	{
			//		a.ShowProfile();
			//		a.Speak();
			//	}

			//2.8.2
			//Animal dog = new Dog("ポチ", 3); 
			//Animal cat = new Cat("タマ", 5); 
			//Console.WriteLine(dog);
			//Console.WriteLine(cat);

			////2.8.3
			//List<Animal> animal = new List<Animal>();
			//animal.Add(new Dog("ポチ",3));
			//animal.Add(new Cat("タマ",5));
			//animal.Add(new Dog("ジョン",7));
			//animal.Add(new Cat("ねこ", 5));

			//foreach (Animal a in animal)
			//{
			//	a.Speak();
			//	Console.WriteLine(a);
			//}

			//2.8.4
			//List<Animal> animal = new List<Animal>
			//{	
			//	new Dog("ポチ", 3),
			//	new Cat("タマ", 5),
			//	new Dog("ジョン", 7),
			//	new Cat("ねこ", 5),
			//	new Bird("ぴよ",8),
			//	new Bird ("ぽこ",11),
			//};

			//foreach (Animal a in animal)
			//{
			//	Console.WriteLine(a);
			//	a.Speak();
			//if (a is Bird b)
			//{
			//	b.Fly();
			//}
			//}

			//2.8.5
			//Animal dog = new Dog("ポン", 4);
			//dog.Walk();
			//dog.Walk(4);

			//2.8.6
			//List<Animal> animal = new List<Animal>
			//{
			//		new Dog("ポチ", 3),
			//		new Cat("タマ", 5),
			//		new Dog("ジョン", 7),
			//		new Cat("ねこ", 5),
			//		new Bird("ぴよ",8),
			//		new Bird ("ぽこ",11),
			//};
			//foreach (Animal a in animal)
			//{
			//	Console.WriteLine($"{a.Species}{a.Name}{a.Age}");
			//}




			//Animal animal = new Cat("ミー", 9);
			//animal.ShowKind();
			//Cat cat = new Cat("ポン",5);
			//cat.ShowKind();

			////2.8.8
			//Animal a = new Dog("ジョン",4);
			//   ((Dog)a).Run();
			////失敗すると例外が出る


			//Dog dog = a as Dog;
			//if (dog != null)
			//{
			//	dog.Run();
			//}
			////安全（null）の場合実行されない

			//if (a is Dog d) d.Run();
			////現代的で安全
			///

			//2.8.9

			//List<Animal> animal = new List<Animal>
			//{
			//		new Dog("ポチ", 3),
			//		new Cat("タマ", 5),
			//		new Dog("ジョン", 7),
			//		new Cat("ねこ", 5),
			//		new Bird("ぴよ",8),
			//		new Bird ("ぽこ",11),
			//};
			//foreach (Animal a in animal)
			//{
			//	a.DoDaily();
			//}

			//2.8.10


			//Dog.Play();

			//List<IPlayable> animal = new List<IPlayable>
			//{
			//		new Dog("ポチ", 3),
			//		new Cat("タマ", 5),
			//		new Dog("ジョン", 7),
			//		new Cat("ねこ", 5),
			//		new Bird("ぴよ", 8),
			//		new Bird("ぽこ", 11)
			//};
			//foreach (IPlayable a in animal)
			//{
			//	a.Play();
			//}

			//List<Animal> ani = new List<Animal>
			//{
			//		new Dog("ポチ", 3),
			//		new Cat("タマ", 5),
			//		new Dog("ジョン", 7),
			//		new Cat("ねこ", 5),
			//		new Bird("ぴよ",8),
			//		new Bird ("ぽこ",11),
			//};
			//foreach (Animal a in ani)
			//{
			//	a.Speak();
			//}

			//2.8.11

			//List<Animal> animal = new List<Animal>();

			//Console.WriteLine("何匹分入力しますか？");
			//int n = int.Parse(Console.ReadLine());

			//for (int i = 0; i < n; i++)
			//{ 
			//	Console.WriteLine("種類、名称、年齢を一行で入力してください");
			//	string[] data = Console.ReadLine().Split(' ');

			//	string s = data[0];
			//	string name = data[1];
			//	int age = int.Parse(data[2]);

			//	if (s == "Dog")
			//	{
			//		animal.Add(new Dog(name, age));
			//	}
			//	else if (s == "Cat")
			//	{
			//		animal.Add(new Cat(name, age));
			//	}
			//	else if (s == "Bird")
			//	{
			//		animal.Add(new Bird(name, age));
			//	}

			//}
			//	foreach (Animal a in animal)
			//	{
			//		a.Speak();
			//	}

			//	foreach (Animal a in animal)
			//	{
			//		a.ShowProfile();
			//	}

			//	foreach (Animal a in animal)
			//	{
			//	if (a is IPlayable p)
			//	{
			//		p.Play();
			//	}
			//	}

			//	Dictionary<string, int > count = new Dictionary<string, int>();

			//	foreach (Animal a in animal)
			//	{
			//		string type = a.GetType().Name;
			//		if(count.ContainsKey(type))
			//			count[type]++;
			//		else count[type] = 1;
			//	}
			//	foreach (var item in count)
			//	{
			//		Console.WriteLine($"{item.Key} : {item.Value}");
			//	}

			//3.1.1
			//Student s = new Student();
			//s.Name = "田中";
			//s.Age = 20;
			//s.ShowProfile();

			//3.2.1
			//Season season;
			//season = Season.Summer;
			//Console.WriteLine(season);
			//3.2.1
			//3.2.2
			//Console.WriteLine("0～3の数字を入力してください");
			//	int num = int.Parse(Console.ReadLine());
			//Season season = (Season)num;
			//Console.WriteLine(season);

			//3.3.1
			//Point p = new Point(5, 10);
			//p.ShowPoint();

			//3.4.1
			//Counter c1 = new Counter();
			//Counter c2 = new Counter();
			//Counter c3 = new Counter();

			//Console.WriteLine(Counter.GetCount());
			///3.5.1
			//List<int> numbers = new List<int>();

			//for (int i = 0; i < 5; i++)
			//{
			//	Console.Write("整数を入力してください：");
			//	int num = int.Parse(Console.ReadLine());

			//	numbers.Add(num);
			//}

			//foreach (int n in numbers)
			//{
			//	Console.WriteLine(n);
			//}
			//3.5.2
			//List<string> name = new List<string>();
			//for (int i = 0; i < 3; i++)
			//{
			//	Console.WriteLine("名前を入力してください");
			//	string n = Console.ReadLine();

			//	name.Add(n);
			//}
			//foreach (string n in name)
			//{
			//	Console.WriteLine(n);
			//}

			//3.6.1
			//Dictionary<string, int> p = new Dictionary<string, int>();
			//p.Add("wonbin",24);
			//p.Add("eun", 25);
			//p.Add("sun",24);
			//foreach (var key in p)
			//{
			//	Console.WriteLine($"{key.Key}:{key.Value}");
			//}

			//3.7.1
			//School.Teacher teacher = new School.Teacher();
			//School.Student student = new School.Student();

			//teacher.Name = "山田先生";
			//student.Name = "田中さん";

			//teacher.ShowProfile();
			//student.ShowProfile();

			//4.1.1
			//try
			//{
			//	Console.WriteLine("入力してください");
			//	int n = int.Parse(Console.ReadLine());
			//	Console.WriteLine($"入力された整数:{n}");
			//}
			//catch (FormatException)
			//{
			//	Console.WriteLine("整数を入力してください");
			//}

			//4.2.1
			//try
			//{
			//	StreamReader sr = new StreamReader("test.txt");

			//	Console.WriteLine("ファイルを開きました");

			//	sr.Close();
			//}
			//catch (FileNotFoundException)
			//{
			//	Console.WriteLine("ファイルが存在しません");
			//}
			//finally
			//{
			//	Console.WriteLine("処理を終了します");
			//}

			//4.3.1
			//try
			//{
			//	int a = 10;
			//	int b = 0;
			//	int c = a / b;
			//}
			//catch (DivideByZeroException)
			//{
			//	Console.WriteLine("0では割れません");
			//}
			//try
			//{
			//	int[] a = { 1, 2, 3 };
			//	Console.WriteLine(a[5]);
			//}
			//catch(IndexOutOfRangeException)
			//{
			//	Console.WriteLine("範囲外のアクセスです");
			//}

			//4.4.1
			//	try
			//	{
			//		Console.Write("年齢を入力してください：");
			//		int age = int.Parse(Console.ReadLine());

			//		CheckAge(age);
			//	}
			//	catch (ArgumentOutOfRangeException)
			//	{
			//		Console.WriteLine("入力が不正です");
			//	}

			//}

			//4.5.1



			//4.4.1
			//static void CheckAge(int age)
			//{
			//	if (age < 0 || age > 120)
			//	{
			//		throw new ArgumentOutOfRangeException();
			//	}

			//	Console.WriteLine($"年齢は{age}歳です");

			//4.5.1
			//try
			//{
			//	Console.WriteLine("分子を入力してください");
			//	int a = int.Parse(Console.ReadLine());
			//	Console.WriteLine("分母を入力してください");
			//	int b = int.Parse(Console.ReadLine());
			//	int c = a / b;
			//	Console.WriteLine(c);
			//}
			//catch (FormatException)
			//{
			//	Console.WriteLine("数字を入力してください");
			//}
			//catch (DivideByZeroException)
			//{
			//	Console.WriteLine("0では割れません");
			//}
			////4.6.1
			//			int total = 0;
			//		for (int i = 1; i <= 10; i++)
			//		{
			//			total += i;
			//		}
			//		Console.WriteLine("合計は " + total);

			//4.7.1

			//try
			//{
			//	Console.Write("数値1を入力してください：");
			//	int a = int.Parse(Console.ReadLine());

			//	Console.Write("数値2を入力してください：");
			//	int b = int.Parse(Console.ReadLine());

			//	Console.Write("演算子（+, -, *, /）を入力してください：");
			//	string op = Console.ReadLine();

			//	switch (op)
			//	{
			//		case "+":
			//			Console.WriteLine(a + b);
			//			break;
			//		case "-":
			//			Console.WriteLine(a - b);
			//			break;

			//		case "*":
			//			Console.WriteLine(a * b);
			//			break;

			//		case "/":
			//			Console.WriteLine(a / b);
			//			break;
			//		default:
			//			Console.WriteLine("演算子が正しくありません");
			//			break;
			//	}
			//}
			//catch (FormatException)
			//{
			//	Console.WriteLine("整数を入力してください");
			//}
			//catch (DivideByZeroException)
			//{
			//	Console.WriteLine("0では割れません");
			//}

			//using (StreamWriter sw = new StreamWriter("output.txt"))
			//{
			//	sw.WriteLine("名前：田中太郎");
			//	sw.WriteLine("年齢：20歳");
			//	sw.WriteLine("趣味：ゲーム");
			//}

			//Console.WriteLine("書き込みが完了しました");

			//5.2.1
			//string filePath = "output.txt";
			//if (File.Exists(filePath))
			//{
			//	using (StreamReader sr = new StreamReader("output.txt"))
			//	{
			//		int lineNumber = 1;

			//		string line;

			//		while ((line = sr.ReadLine()) != null)
			//		{
			//			Console.WriteLine($"{lineNumber}: {line}");
			//			lineNumber++;
			//		}
			//	}
			//}
			//catch (FileNotFoundException)
			//{
			//	Console.WriteLine("ファイルが見つかりません");
			//}

			//5.3.1
			//string path = "apend.txt";
			//string memo = "メモ内容";
			//using (StreamWriter sw = new StreamWriter(path, append:true))
			//{
			//	sw.WriteLine("DataTime.Today:2026-07-30");
			//}

			//string path = "append.txt";
			//using (StreamWriter sw = new StreamWriter(path, append:false))
			//{
			//	Console.WriteLine("初期化しました");
			//}
			//string text = File.ReadAllText(path);
			//Console.WriteLine("ファイルの内容");
			//Console.WriteLine(text);

			//5.4.1
			//Console.Write("読み込みたいファイル名を入力してください: ");
			//string fileName = Console.ReadLine();
			//if (!File.Exists(fileName))
			//{
			//	Console.WriteLine("存在しません");
			//	return;
			//}
			//try
			//{
			//	string[] line = File.ReadAllLines(fileName);
			//	Console.WriteLine("ファイルの内容");
			//	for (int i = 0; i < line.Length; i++)
			//	{
			//		Console.WriteLine($"{i+1}:{line[i]}");
			//	}
			//}
			//catch(Exception ex)
			//{
			//	Console.WriteLine("読み込み中にエラーが発生しました");
			//	Console.WriteLine(ex.Message);
			//}

			//5.5.1
			//string folder = "data/logs";
			//Directory.CreateDirectory(folder);
			//string path = Path.Combine(folder, "today.txt");
			//File.WriteAllText(path,"今日のメモ");
			//Console.WriteLine("ファイルを作成しました");

			//5.5.2
			//string folder = "data";
			//string[] files = Directory.GetFiles(folder, "*.txt");
			//foreach (string file in files)
			//{
			//	FileInfo info= new FileInfo(file);
			//	Console.WriteLine($"ファイル名：{info.Name}");
			//	Console.WriteLine($"サイズ：{info.Length}バイト");
			//	Console.WriteLine($"最終更新：{ info.LastWriteTime}");
			//	Console.WriteLine();
			//}

			//5.6.1
			//	string[] lines =
			//{
			//	"1行目",
			//	"2行目",
			//	"3行目"
			//};
			//	File.WriteAllLines("quick.txt", lines);
			//	string[] readLines = File.ReadAllLines("quick.txt");
			//	foreach (string line in readLines)
			//	{
			//		Console.WriteLine(line);
			//	}

			//5.7.1
			//string fileName = "user.csv";
			//string users = Console.ReadLine();
			//File.AppendAllText(fileName, users + Environment.NewLine, Encoding.GetEncoding("shift_jis"));
			//using (StreamReader sw = new StreamReader(fileName, Encoding.GetEncoding("shift_jis")))
			//{

			//	string[] lines = File.ReadAllLines("user.csv");
			//	foreach (string line in lines)
			//	{
			//		string[] data = line.Split(',');
			//		if (data.Length != 2)
			//		{
			//			Console.WriteLine("警告");
			//			continue;
			//		}
			//		Console.WriteLine($"Name={data[0]}, Age={data[1]}");
			//	}
			//}

			//5.7.2
			//Console.WriteLine("名前を入力してください");
			//string name = Console.ReadLine();

			//int age;

			//while (true)
			//{
			//	Console.WriteLine("年齢を入力してください");
			//	if (int.TryParse(Console.ReadLine(), out age))
			//	{
			//		break;
			//	}
			//	Console.WriteLine("年齢を整数で入力してください");
			//}
			//string line = $"{name},{age}";
			//File.AppendAllText("user.csv", line + Environment.NewLine);
			//Console.WriteLine("保存しました");

			//5.8.1
			//List<User> users = new List<User>();
			//string[] lines = File.ReadAllLines("user.csv");
			//foreach (string line in lines)
			//{
			//	string[] data = line.Split(',');
			//	if (data.Length != 2)
			//	{
			//		Console.WriteLine("データ形式が正しくありません");
			//		continue;
			//	}
			//	User user = new User
			//	{
			//		Name = data[0],
			//		Age = int.Parse(data[1])
			//	};
			//	users.Add(user);
			//}
			//Console.WriteLine("--　全ユーザー　--");
			//foreach (User user in users)
			//{
			//	Console.WriteLine(user);
			//}
			//users = users.OrderByDescending(u => u.Age).ToList();
			//Console.WriteLine();
			//Console.WriteLine("=== 年齢順（降順） ===");

			//foreach (User user in users)
			//{
			//	Console.WriteLine(user);
			//}

			//	List<User> users = new List<User>
			//{
			//	new User("Taro", 20),
			//	new User("Hanako", 25),
			//	new User("Jiro", 8)
			//};

			//	PrintUsersTable(users);

			//5.10.1
			//string path = "utf8.txt";
			//using (StreamWriter writer = new StreamWriter(path, append: false, Encoding.UTF8))
			//{
			//	writer.WriteLine("こんにちは、世界！");
			//	writer.WriteLine("これはUTF-8のテストです。");
			//}
			//using (StreamReader reader = new StreamReader(path, Encoding.UTF8))
			//{
			//	string line;
			//	while ((line = reader.ReadLine()) != null)
			//	{
			//		Console.WriteLine(line);
			//	}
			//}

			//5.11.1
			//try
			//{
			//	Log("起動しました");
			//	Console.WriteLine("アプリが動いています");
			//}
			//catch (Exception ex)
			//{
			//	Log("ERROR:" + ex.Message);
			//}
			//finally
			//{
			//	Log("終了します");
			//}

		}
		//5.11.1
		//static void Log(string message)
		//{
		//	string path = "logs/app.log";
		//	Directory.CreateDirectory("logs");
		//	using (StreamWriter writer = new StreamWriter(path, append: true))
		//	{
		//		writer.WriteLine($"{DateTime.Now:yyyy - MM - ddThh:mm: ss} {message}");
		//	}
		//}



	}

	//	//5.9.1
	//	static void PrintUsersTable(List<User> users)
	//	{
	//		Console.WriteLine("{0,-10} {1,5}", "Name", "Age");

	//		foreach (User user in users)
	//		{
	//			Console.WriteLine("{0,-10}{1,5}", user.Name, user.Age);
	//		}
	//	}
	


		//3.7.1
	//	namespace School
	//{
	//	class Teacher
	//	{
	//		public string Name { get; set; }
	//		public void ShowProfile()
	//		{
	//			Console.WriteLine($"先生：{Name}");
	//		}
	//	}
	//	class Student
	//	{ 
	//		public string Name { get; set; }
	//		public void ShowProfile()
	//		{ 
	//			Console.WriteLine($"生徒：{Name}");
	//		}
	//	}
	//}

	//3.2.1
		//enum Season { Spring, Summer, Autumn, Winter }

		//2.3.1
		//struct Point
		//{
		//	public int X;
		//	public int Y;

		//	public Point(int x, int y)
		//	{
		//		X = x;
		//		Y = y;
		//	}
		//	public void ShowPoint()
		//	{
		//		Console.WriteLine($"X:{X} Y:{Y}");
		//	}
		//}
		



			//関数
			//   string s = "11";
			//    int m = 11;
			//int>string
			//        s = x.ToString();

			//string>int
			//      x = int.Parse(s);




			//            int x = Calc(2, 3);
			//       Console.WriteLine(x);

			//    static int Calc(int x, int y)
			//   {
			//        return x + y;
			// }

			//static void m211()
			//{
			//    int x = 11;
			//    Console.WriteLine($"x= {x}");
			//}
			//static void m212()
			//{
			//    int x = 13 + 17;
			//    Console.WriteLine("x=" + x);
			//}
			//static void m213()
			//{
			//    int x = 13;
			//    int y = 17;
			//    Console.WriteLine("x=" + y);
			//}
			//static void m214()
			//{
			//    int x = 13;
			//    int y = 17;
			//    Console.WriteLine("x=" + x * y);
			//}






			//static void m221()
			//{
			//    string s = Console.ReadLine();
			//    Console.WriteLine(s);
			//}

			//static void m222()
			//{
			//    int x = int.Parse(Console.ReadLine());
			//    Console.WriteLine(x);
			//}

			//static void m223(int m, int n)
			//{
			//    Console.WriteLine((m + n) / 2);
			//}

			//static void m224(int b)
			//{
			//    Console.WriteLine(b * 365);
			//}

			//static int power(int p)
			//{
			//    return (p * p);
			//}



			//static void aaa(int q)
			//{
			//    if (q >= 10)
			//    {
			//        return;
			//    }
			//    Console.WriteLine("値が10以下です");

			//}


			//static double CircleArea(double c)
			//{
			//    return (c * c * 3.14);
			//}


			//static void ggg(int t)
			//{
			// int h = t / 3600;
			// int m = (t - h*3600) / 60;
			// int s = t - (h*3600 + m*60);

			//    int h = t / 3600;
			//    int m = (t % 3600) / 60;
			//    int s = t % 60;

			//    //   Console.WriteLine(h + "時間" + m + "分" + s + "秒");
			//    Console.WriteLine($"{h} 時間{m}分{s} 秒");
			//}

			//static int Add(int a, int b)
			//{
			//    return (a + b);
			//}

			//static bool IsEven(int number)
			//{
			//    if (number % 2 == 0)
			//    {
			//        return true;
			//    }
			//    return false;
			//}


			//static int CalcTax(int price)
			//{
			//    return (int)Math.Floor(price * 1.1);
			//}

			//static int GetMax(int a, int b, int c)
			//{
			//    int l = 0;
			//    if (a > b)
			//    {
			//        l = a;
			//    }
			//    else
			//    {
			//        l = b;
			//    }
			//    if (c > l)
			//    {
			//        l = c;
			//    }
			//    return l;
			//}

			//// 2026.7.22↓
			//// 2.3.1.問題3-1

			//static void compare(int x, int y)
			//{
			//    if (x > y)
			//    {
			//        Console.WriteLine("xはyより大きい");
			//    }
			//}

			//// 2.3.2.	問題3-2
			//static void number(int x, int y)
			//{
			//    if (x > y)
			//    {
			//        Console.WriteLine("xはyより大きい");
			//    }
			//    else if (x < y)
			//    {
			//        Console.WriteLine("xはyより小さい");
			//    }
			//    else
			//    {
			//        Console.WriteLine("xとyは等しい");

			//    }
			//}

			////2.3.3.	問題3-3
			//static void even(int num)
			//{
			//    if (num % 2 == 0)
			//    {
			//        Console.WriteLine("偶数");
			//    }
			//    else
			//    {
			//        Console.WriteLine("奇数");
			//    }
			//}

			//2.3.4.	問題3-4
			//static void judge(int score)
			//{
			//    if (score >= 60 && score < 70)
			//    {
			//        Console.WriteLine("合格");
			//        Console.WriteLine("可");
			//    }
			//    else if (score >= 60 && score < 80)
			//    {
			//        Console.WriteLine("合格");
			//        Console.WriteLine("よくできました");
			//    }
			//    else if (score >= 70 && score < 80)
			//    {
			//        Console.WriteLine("合格");
			//        Console.WriteLine("良");
			//    }
			//    else if (score >= 80 && score <= 100)
			//    {
			//        Console.WriteLine("合格");
			//        Console.WriteLine("優");
			//    }
			//    else if (score < 60)
			//    {
			//        Console.WriteLine("不合格");
			//        Console.WriteLine("不可");
			//        Console.WriteLine("ざんねんでした");
			//    }
			//    else
			//    {
			//        Console.WriteLine("---");
			//    }
			//}

			//2.4.1.	問題4-1
			//static int Spam()
			//{
			//    for (int i = 0; i < 10; i++)
			//    {
			//        Console.WriteLine("SPAM");
			//    }
			//    return 10;
			//}

			////2.4.2.	問題4-2
			//static void kuku(int x)
			//{
			//    if (x % 3 == 0)
			//    {
			//        Console.WriteLine(x);
			//    }
			//    else
			//    {
			//        Console.WriteLine("---");
			//    }
			//}

			////2.4.3.問題4 - 3
			//static int avg(int a)
			//{

			//    return a / 10;

			//}


			//         //2.4.4.問題4 - 4
			//         static void bb(int g, int t)
			//         {
			//	for (int i = 1; i <= 9; i++)
			//	{
			//	Console.Write(i + "回表、巨人の得点は？");
			//	g += int.Parse(Console.ReadLine());
			//             Console.WriteLine($"巨人：{g}点");


			//	Console.Write(i + "回裏、阪神の得点は？");

			//                 t += int.Parse(Console.ReadLine());
			//             Console.WriteLine($"阪神：{t}点");

			//	}

			//             Console.WriteLine($"巨人:{g}阪神:{t}");

			//	if (g > t)
			//	{
			//	Console.WriteLine("巨人の勝ち");
			//	}
			//	else if (g < t)
			//	{
			//	Console.WriteLine("阪神の勝ち");
			//	}
			//	else
			//	{
			//	Console.WriteLine("引き分け");
			//	}
			//}

			//2.4.5.問題4 - 5
			//static void sb()
			//{
			//    int sta = 0;
			//    int bla = 0;

			//    while (sta < 3 && bla < 4)
			//    {
			//        Console.WriteLine("ストライクは1，ボールは2を入力してください");
			//        int s = int.Parse(Console.ReadLine());
			//        if (s == 1)
			//        {
			//            sta++;
			//        }
			//        else if (s == 2)
			//        {
			//            bla++;
			//        }
			//        else if (s == 3)
			//        {
			//            if (sta < 2)
			//            {
			//                sta++;
			//            }
			//        }
			//        Console.WriteLine($"{bla}ボール{sta}ストライク");

			//    }

			//}

			//      }



			// 2.5.1.	問題5-1
			//      static void Number()
			//      {

			//          Console.WriteLine("数値を入力してください");
			//	int[] num = new int[10];

			//          for (int i = 0; i < 10; i++)
			//          {
			//              num[i] = int.Parse(Console.ReadLine());
			//          }
			//	for (int i = 0; i < 10; i++)
			//	{
			//		Console.WriteLine(num[i] * 2);
			//	}
			//}


			//     static void num()
			//     {
			//         Console.WriteLine("数値を入力してください");
			//int[] nums = new int[10];
			//         for (int i = 0; i < 10; i++)
			//         {
			//             1nums[i] = int.Parse(Console.ReadLine());
			//         }
			//Console.WriteLine("偶数：" );
			//         for (int i = 0; i < 10; i++)
			//         {
			//             if (nums[i] % 2 == 0)
			//             {
			//                 Console.WriteLine(nums[i]);
			//             }
			//         }

			//         Console.WriteLine("奇数：" );
			//             for (int i = 0; i < 10; i++)
			//             {
			//		if (nums[i] % 2 != 0)
			//		{
			//			Console.WriteLine(nums[i]);
			//		}
			//	}
			//}


			//static void Kuku()
			//{
			//    for (int i = 1; i <= 9; i++)
			//    {
			//        for (int j = 1; j <= 9; j++)
			//        {
			//            Console.Write((i * j) + "\t");
			//        }
			//        Console.WriteLine();
			//    }
			//}


			//  2.5.4.	問題5-4
			//      static void sm()
			//       {
			//          Console.WriteLine("数字を10個入力してください");
			//          int[] nums = new int[10];
			//          for (int i = 0; i< 10; i++)
			//          {
			//              nums[i] = int.Parse(Console.ReadLine());
			//          }
			//          for (int i = 0; i < 10; i++)
			//          {
			//              for (int j = i + 1; j < 10; j++)
			//              {
			//                  if (nums[i] > nums[j])
			//                  {
			//				int temp = nums[i];
			//				nums[i] = nums[j];
			//				nums[j] = temp;
			//			}
			//              }
			//          }
			//	Console.WriteLine("小さい順");
			//	for (int i = 0; i < 10; i++)
			//	{
			//		Console.WriteLine(nums[i]);
			//	}
			//}


			//2.6.1.	問題6-1
			//static int Method(int t)
			//{
			//	return t * t;
			//}







			// 2.6.2.	問題6-2
			//      static int avge(int t,int s)
			//      {

			//          return (t + s )/ 2;
			//}


			//2.6.3.	問題6-3
			//      static int com(int x, int y, int z)
			//      {
			//          int l = 0;
			//          if (x > y)
			//          {
			//              l = x;
			//          }
			//          else if (y > z)
			//          {
			//              l = y;
			//          }
			//          else
			//          {
			//              l = z;
			//          }
			//          return l;
			//}

			//2.6.4.	問題6-4
			//     static int San()
			//     {
			//         int max = 0;
			//for (int i = 1; i < 6; i++)
			//         {
			//	Console.Write(i  + "回目:"  );
			//             int u = int.Parse(Console.ReadLine());
			//             if (u > max)
			//             {
			//                 max = u;
			//             }
			//         }
			//         return max;
			//     }

			//      static int Min()
			//      {
			//	Console.Write("1回目:");
			//	int min = int.Parse(Console.ReadLine());

			//          for (int i = 2; i <= 5 ; i++)
			//          {
			//		Console.Write(i + "回目:");
			//		int u = int.Parse(Console.ReadLine());
			//		if (u < min)
			//		{
			//			min = u;
			//		}
			//	}
			//	return min;
			//}


			//    static int av()
			//{
			//    int sum = 0;
			//    for (int i = 1; i < 6; i++)
			//    {
			//        Console.Write(i + "回目:");
			//        int u = int.Parse(Console.ReadLine());
			//        sum += u;
			//    }
			//    return sum / 5;
			//}


			//2.7.	問題7-1,2,3,4
			//static void Main()
			//{
			//	Dogclass dog1 = new Dogclass();

			//	dog1.Name = "タロウ";
			//	dog1.Age = 5;
			//	dog1.Seed = "柴犬";

			//	Dogclass dog2 = new Dogclass();

			//	dog2.Name = "ポチ";
			//	dog2.Age = 9;
			//	dog2.Seed = "ボルゾイ";

			//	dog1.ShowProfile();
			//	dog2.ShowProfile();



		
		

}




	




