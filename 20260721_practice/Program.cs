using System.ComponentModel.Design;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq.Expressions;
using System.Net.Cache;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Timers;
using System.Linq;
using System.ComponentModel;

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
			//7.5.1
			//Employee emp = new FullTimeEmployee("田中", 30000);
			//emp.MonthlyRoutine();
			//List<IReportable> reports = new List<IReportable>
			//{
			//	new FullTimeEmployee("田中", 300000),
			//	new PartTimeEmployee("佐藤", 0, 1200, 80)
			//};

			//foreach (IReportable report in reports)
			//{
			//	Console.WriteLine(report.GenerateReport());
			//}
			//List<Employee> employees = new List<Employee>
			//{
			//	new FullTimeEmployee("田中",300000),
			//	//new FullTimeEmployee("佐藤",280000),
			//	new PartTimeEmployee("佐藤",0,1200,80),
			//	//new PartTimeEmployee("山田",0,1500,60)
			//};

			//FullTimeEmployee tanaka = (FullTimeEmployee)employees[0];
			//tanaka.AddOvertimeHours(10);
			//foreach (Employee employee in employees)
			//{
			//	employee.ShowProfile();
			//	Console.WriteLine($"月給：{employee.CalculateMonthlyPay()}円");
			//	//Console.WriteLine($"{employee.Name}:{employee.CalculateMonthlyPay()}円");
			//	//decimal monthlyPay = employee.CalculateMonthlyPay();
			//	//Console.WriteLine($"月給：{monthlyPay}円");
			//	//Console.WriteLine();
			//	if (employee is IOvertimeEligible overtime)
			//	{
			//		overtime.AddOvertimeHours(10);
			//		Console.WriteLine($"残業時間：{overtime.GetOvertimeHours()}時間");
			//	}

			//	if (employee is IReportable report)
			//	{
			//		Console.WriteLine(report.GenerateReport());
			//	}

			//	Console.WriteLine();
			//}

			////7.8.1
			//FullTimeEmployee tanakat = new FullTimeEmployee("田中", 300000);

			//tanaka.TaxStrategy = new FlatTaxStrategy();
			//Console.WriteLine($"一律10%の場合：{tanakat.CalculateMonthlyPay()}円");

			//tanaka.TaxStrategy = new ProgressiveTaxStrategy();
			//Console.WriteLine($"段階税率の場合：{tanakat.CalculateMonthlyPay()}円");

			////7.9.1
			//List<IPayable> payables= new List<IPayable>()
			//{
			//	new FullTimeEmployee("田中",300000),
			//	new PartTimeEmployee("佐藤",0,1200,80)
			//};
			//foreach (IPayable payable in payables)
			//{
			//	payable.Pay();
			//}

			//7.10.1
			//		List<Employee> employee = new List<Employee>();
			//while (true)
			//{
			//	try
			//	{
			//		Console.WriteLine("---簡易給与計算アプリ---");
			//		Console.WriteLine("1.社員追加");
			//		Console.WriteLine("2.残業登録");
			//		Console.WriteLine("3.税方式切替");
			//		Console.WriteLine("4.月次処理");
			//		Console.WriteLine("5.明細表示");
			//		Console.WriteLine("6.終了");

			//		Console.WriteLine("選択してください");
			//		string e = Console.ReadLine();
			//		switch (e)
			//		{
			//			case "1":
			//				Console.WriteLine("社員の種類を選択してください");
			//				Console.WriteLine("1.正社員");
			//				Console.WriteLine("2.アルバイト");
			//				string emp = Console.ReadLine();
			//				Console.WriteLine("名前を入力してください");
			//				string name = Console.ReadLine();
			//				if (emp == "1")
			//				{
			//					Console.WriteLine("基本給を入力してください");
			//					decimal basesalary = decimal.Parse(Console.ReadLine());
			//					FullTimeEmployee empl = new FullTimeEmployee(name, basesalary);
			//					employee.Add(empl);
			//					Console.WriteLine("正社員を追加しました");
			//				}
			//				else if (emp == "2")
			//				{
			//					Console.WriteLine("時給を入力してください");
			//					decimal hourlyWage = decimal.Parse(Console.ReadLine());
			//					Console.WriteLine("勤務時間を入力してください");
			//					int workhours = int.Parse(Console.ReadLine());
			//					PartTimeEmployee pt = new PartTimeEmployee(name, 0, hourlyWage, workhours);
			//					employee.Add(pt);
			//					Console.WriteLine("アルバイトを追加しました");
			//				}
			//				else
			//				{
			//					Console.WriteLine("正しい番号を入力してください");
			//				}
			//				break;

			//			case "2":
			//				Console.WriteLine("残業登録する社員名");
			//				string empName = Console.ReadLine();
			//				Employee empfind = employee.Find(e => e.Name == empName);
			//				if (empfind == null)
			//				{
			//					Console.WriteLine("その社員は見つかりません");
			//				}
			//				if (employee is IOvertimeEligible overtime)
			//				{
			//					Console.WriteLine("残業時間を入力してください");
			//					int hours = int.Parse(Console.ReadLine());
			//					overtime.AddOvertimeHours(hours);
			//					Console.WriteLine("残業時間を登録しました");
			//				}
			//				else
			//				{
			//					Console.WriteLine("この社員は登録できません");
			//				}
			//				break;

			//			case "3":
			//				Console.WriteLine("税方式を変更します");
			//				Console.WriteLine("1. 全員");
			//				Console.WriteLine("2. 個別");

			//				string target = Console.ReadLine();

			//				Console.WriteLine("税方式を選択してください");
			//				Console.WriteLine("1. 一律10%");
			//				Console.WriteLine("2. 段階税率");

			//				string taxChoice = Console.ReadLine();

			//				ITaxStrategy taxStrategy;

			//				if (taxChoice == "1")
			//				{
			//					taxStrategy = new FlatTaxStrategy();
			//				}
			//				else if (taxChoice == "2")
			//				{
			//					taxStrategy = new ProgressiveTaxStrategy();
			//				}
			//				else
			//				{
			//					Console.WriteLine("正しい番号を入力してください");
			//					break;
			//				}

			//				if (target == "1")
			//				{
			//					foreach (Employee empm in employee)
			//					{
			//						empm.TaxStrategy = taxStrategy;
			//					}

			//					Console.WriteLine("全員の税方式を変更しました");
			//				}
			//				else if (target == "2")
			//				{
			//					Console.WriteLine("税方式を変更する社員名");
			//					string strName = Console.ReadLine();

			//					Employee strfind = employee.Find(x => x.Name == strName);

			//					if (strfind == null)
			//					{
			//						Console.WriteLine("この社員は見つかりません");
			//						break;
			//					}

			//					strfind.TaxStrategy = taxStrategy;

			//					Console.WriteLine("税方式を変更しました");
			//				}
			//				else
			//				{
			//					Console.WriteLine("正しい番号を入力してください");
			//				}

			//				break;
			//			case "4":
			//				foreach (Employee empm in employee)
			//				{
			//					empm.MonthlyRoutine();
			//					if (empm is IPayable payable)
			//					{
			//						payable.Pay();
			//					}
			//				}
			//				break;

			//			case "5":
			//				Console.WriteLine("明細を表示します");
			//				foreach (Employee empg in employee)
			//				{
			//					if (empg is IReportable reportable)
			//					{
			//						Console.WriteLine(reportable.GenerateReport());
			//					}
			//				}
			//				break;

			//			case "6":
			//				Console.WriteLine("終了します");
			//				return;
			//		}
			//	}
			//		catch (Exception ex)
			//	{
			//		Console.WriteLine("入力に誤りがあります");
			//	}


			//}

			//8.1
			//try
			//{
			//	Console.WriteLine("数値1を入力してください");
			//	int num1 = int.Parse(Console.ReadLine());
			//	Console.WriteLine("演算子を入力してください");
			//	string en = Console.ReadLine();
			//	Console.WriteLine("数値２を入力してください");
			//	int num2 = int.Parse(Console.ReadLine());

			//	switch (en)
			//	{
			//		case "+":
			//			Console.WriteLine(num1 + num2);
			//			break;

			//		case "-":
			//			Console.WriteLine(num1 - num2);
			//			break;

			//		case "*":
			//			Console.WriteLine(num1 * num2);
			//			break;

			//		case "/":
			//			Console.WriteLine(num1 / num2);
			//			break;

			//		default:
			//			Console.WriteLine("正しい演算子を入力してください");
			//			break;

			//	}
			//} catch (FormatException)
			//{
			//	Console.WriteLine("数値を入力してください");
			//}
			//catch (DivideByZeroException)
			//{
			//	Console.WriteLine("0で割ることはできません");
			//}

			//8.2
			//while (true)
			//{
			//	Console.WriteLine("1.登録");
			//	Console.WriteLine("2.一覧表示");
			//	Console.WriteLine("3.検索");
			//	Console.WriteLine("4.終了");
			//	string choice = Console.ReadLine();
			//	switch (choice)
			//	{
			//		case "1":
			//			Console.WriteLine("単語を入力してください");
			//			string word = Console.ReadLine();
			//			Console.WriteLine("意味を入力してください");
			//			string mean = Console.ReadLine();
			//			File.AppendAllText("words.csv", word + "," + mean + Environment.NewLine);
			//			Console.WriteLine("登録しました");
			//			break;

			//		case "2":
			//			string[] lines = File.ReadAllLines("words.csv");
			//			foreach (string line in lines)
			//			{
			//				Console.WriteLine(line);
			//			}
			//			break;

			//		case "3":
			//			Console.WriteLine("検索したい単語を入力してください");
			//			string search = Console.ReadLine();
			//			string[] l = File.ReadAllLines("words.csv");
			//			foreach (string line in l)
			//			{
			//				if (line.StartsWith(search + ","))
			//				{
			//					Console.WriteLine(line);
			//				}
			//			}
			//			break;

			//		case "4.":
			//			Console.WriteLine("終了します");
			//			return;

			//	}
			//}

			//8.3

			//	List<Product> products = new List<Product>();
			//while (true)
			//{
			//	Console.WriteLine("---商品管理---");
			//	Console.WriteLine("1.商品登録");
			//	Console.WriteLine("2.一覧表示");
			//	Console.WriteLine("3.価格の高い順");
			//	Console.WriteLine("4.カテゴリごとに表示");
			//	Console.WriteLine("5.終了");
			//	Console.WriteLine("選択してください");

			//	string choice = Console.ReadLine();
			//	switch (choice)
			//	{
			//		case "1":
			//			Console.WriteLine("商品名を登録してください");
			//			string name = Console.ReadLine();
			//			Console.WriteLine("価格を登録してください");
			//			int price = int.Parse(Console.ReadLine());
			//			Console.WriteLine("カテゴリを登録してください");
			//			string category = Console.ReadLine();
			//			Product product = new Product(name, price, category);
			//			products.Add(product);
			//			Console.WriteLine("商品を登録しました");
			//			break;

			//		case "2":
			//			foreach (Product pro in products)
			//			{
			//				Console.WriteLine($"商品名：{pro.Name}価格：{pro.Price}カテゴリ：{pro.Category}");
			//			}
			//			break;

			//		case "3":
			//			var result = products.OrderByDescending(p => p.Price);
			//			foreach (Product prod in result)
			//			{
			//				Console.WriteLine($"{prod.Name}:{prod.Price}円");
			//			}
			//			break;

			//		case "4":
			//			var groups = products.GroupBy(p => p.Category);

			//			foreach (var group in groups)
			//			{
			//				Console.WriteLine($"【{group.Key}】");

			//				foreach (Product prod in group)
			//				{
			//					Console.WriteLine($"{prod.Name}:{prod.Price}円");
			//				}
			//			}
			//			break;
			//		case "5":
			//			Console.WriteLine("終了します");
			//			return;

			//		default:
			//			Console.WriteLine("正しい番号を入力してください");
			//			break;
			//	}

			//	}

			//8.4
			//List<Book> book = new List<Book>();
			//while(true)
			//{
			//Console.WriteLine("【図書館貸出アプリ】");
			//Console.WriteLine("1.本の登録");
			//Console.WriteLine("2.貸出/返却 の変更");
			//Console.WriteLine("3.一覧表示");
			//Console.WriteLine("4.終了");
			//string choice = Console.ReadLine();

			//	switch (choice)
			//	{
			//		case "1":
			//			Console.WriteLine("タイトルを入力してください");
			//			string title = Console.ReadLine();

			//			Console.WriteLine("著者を入力してください");
			//			string author = Console.ReadLine();

			//			Book newBook = new Book(title,author);
			//			book.Add(newBook);


			//			Console.WriteLine("本を登録しました");
			//			break;

			//		case "2":
			//			Console.WriteLine("変更する本のタイトルを入力してください");
			//			string tit = Console.ReadLine();
			//			Book target = book.Find(b => b.Title == tit);
			//			if (target == null)
			//			{
			//				Console.WriteLine("その本は見つかりません");
			//				break;
			//			}
			//			if (target.IsBorrowed == false)
			//			{
			//				target.IsBorrowed = true;
			//				Console.WriteLine("貸し出しました");
			//			}
			//			else 
			//			{
			//				target.IsBorrowed = false;
			//				Console.WriteLine("返却しました");
			//			}
			//			break;

			//		case "3":
			//			foreach (Book b in book)
			//			{
			//				string status;

			//				if (b.IsBorrowed)
			//				{
			//					status = "貸出中";
			//				}
			//				else
			//				{
			//					status = "利用可能";
			//				}

			//				Console.WriteLine($"タイトル：{b.Title} 著者：{b.Author} 状態：{status}");
			//			}
			//			break;

			//			case"4":
			//				Console.WriteLine("終了します");
			//			return;

			//	}
			//}

			//8.5

			List<Drink> drinks = new List<Drink>();
			drinks.Add(new Drink(1, "コーラ", 170, 30));
			drinks.Add(new Drink(2, "ポカリ", 180, 8));
			drinks.Add(new Drink(3, "麦茶", 120, 15));
			int tenStock = 10;
			int fiftyStock = 10;
			int hundredStock = 10;
			int fiveHundredStock = 5;
			int sales = 0;
			int sum = 0;
			while (true)
			{
			Console.WriteLine("[ 商品一覧 ]");
			foreach (Drink drink in drinks)
			Console.WriteLine($"番号：{drink.Number} 名前：{drink.Name} 価格：{drink.Price} 在庫：{drink.Stock}");
			Console.WriteLine("操作を選んでください");
			Console.WriteLine("1.お金を入れる（10/50/100/500/1000 円のみ受付）");
			Console.WriteLine("2.購入する（商品番号を指定）");
			Console.WriteLine("3.返金する");
			Console.WriteLine("4.返金（投入金を払い戻す）");
			string choice = Console.ReadLine();
				
					switch (choice)
				{
					case "1":

						Console.WriteLine("何円を入れますか？");
							Console.WriteLine("10 / 50 / 100 / 500 / 1000");
							string moneyInput = Console.ReadLine();

							if (!int.TryParse(moneyInput, out int money))
							{
								Console.WriteLine("数字を入力してください。");
								break;
							}

							if (money != 10 &&
								money != 50 &&
								money != 100 &&
								money != 500 &&
								money != 1000)
							{
								Console.WriteLine("その金種は使用できません。");
								break;
							}

							sum += money;

							if (money == 10)
							{
								tenStock++;
							}
							else if (money == 50)
							{
								fiftyStock++;
							}
							else if (money == 100)
							{
								hundredStock++;
							}
							else if (money == 500)
							{
								fiveHundredStock++;
							}

							Console.WriteLine($"{money}円を受け付けました。");
							Console.WriteLine($"現在の投入金額：{sum}円");
							break;

					case "2":
							Console.WriteLine("何番の商品を購入しますか？");

							if (!int.TryParse(Console.ReadLine(), out int num))
							{
								Console.WriteLine("数字を入力してください。");
								break;
							}

							Drink selectDrink = null;

							foreach (Drink drink in drinks)
							{
								if (drink.Number == num)
								{
									selectDrink = drink;
									break;
								}
							}
							if (selectDrink == null)
							{
								Console.WriteLine("その商品番号はありません。");
								break;
							}

							if (selectDrink.Stock <= 0)
							{
								Console.WriteLine("在庫がありません。");
								break;
							}
							if (sum < selectDrink.Price)
							{
								Console.WriteLine("お金が足りません。");
								break;
							}

							int change = sum - selectDrink.Price;

							int remainingChange = change;

							int use500 = Math.Min(
								remainingChange / 500,
								fiveHundredStock);

							remainingChange -= use500 * 500;
							int use100 = Math.Min(
						   remainingChange / 100,
						   hundredStock);

							remainingChange -= use100 * 100;

							int use50 = Math.Min(
								remainingChange / 50,
								fiftyStock);

							remainingChange -= use50 * 50;

							int use10 = Math.Min(
								remainingChange / 10,
								tenStock);

							remainingChange -= use10 * 10;

							if (remainingChange != 0)
							{
								Console.WriteLine("釣銭が不足しているため、購入できません。");
								break;
							}


							selectDrink.Stock--;

							sales += selectDrink.Price;
							fiveHundredStock -= use500;
							hundredStock -= use100;
							fiftyStock -= use50;
							tenStock -= use10;

							Console.WriteLine();
							Console.WriteLine($"{selectDrink.Name}を購入しました。");
							Console.WriteLine($"価格：{selectDrink.Price}円");
							Console.WriteLine($"おつり：{change}円");

							if (use500 > 0)
							{
								Console.WriteLine($"500円玉：{use500}枚");
							}

							if (use100 > 0)
							{
								Console.WriteLine($"100円玉：{use100}枚");
							}

							if (use50 > 0)
							{
								Console.WriteLine($"50円玉：{use50}枚");
							}

							if (use10 > 0)
							{
								Console.WriteLine($"10円玉：{use10}枚");
							}
							sum = 0;

							break;

							

					case "3":
						if (sum == 0)
						{
							Console.WriteLine("返金するお金がありません。");
							break;
						}

						Console.WriteLine($"{sum}円を返金します。");

						sum = 0;

						break;


					case "4":
						Console.WriteLine("アプリを終了します。");
						Console.WriteLine($"本日の売上：{sales}円");

						return;


					default:

						Console.WriteLine("1～4を入力してください。");

						return;

				}
				//2.1.1
				//Console.WriteLine("Hello, World!");

				//2.1.2
				//int x = 11;
				//Console.WriteLine("x = " + x);

				//2.1.3
				//int x = 13 + 17;
				//Console.WriteLine(x);

				//2.1.4
				//int x = 13 * 17;
				//Console.WriteLine(x);

				//2.2.1
				//Console.WriteLine(s);

				//2.2.2
				//int x = 7;
				//Console.WriteLine(x);

				//2.2.4
				//Console.WriteLine("年齢はいくつですか？");
				//int year = int.Parse(Console.ReadLine());
				//Console.WriteLine(year * 365 +　"日");

				//2.3.1
				//Console.WriteLine("xを入力してください");
				//int x = int.Parse(Console.ReadLine());
				//Console.WriteLine("yを入力してください");
				//int y = int.Parse(Console.ReadLine());
				//if (x > y)
				//{
				//	Console.WriteLine("xはyより大きい");
				//}
				////2.3.2
				//else if (y > x)
				//{
				//	Console.WriteLine("xはyより小さい");
				//}
				//else
				//{
				//	Console.WriteLine("xとyは等しい");
				//}

				////2.3.3
				//Console.WriteLine("数値を入力してください");
				//int x = int.Parse(Console.ReadLine());
				//if (x % 2 == 0)
				//{
				//	Console.WriteLine("偶数");
				//}
				//else
				//{
				//	Console.WriteLine("奇数");
				//}

				//2.3.4
				//Console.WriteLine("点数を入力してください");
				//int x = int.Parse(Console.ReadLine());
				//if (60 <= x)
				//{
				//	Console.WriteLine("合格");
				//}
				//else 
				//{
				//	Console.WriteLine("不合格");
				//}

				//Console.WriteLine("点数を入力してください");
				//int y = int.Parse(Console.ReadLine());
				//if (80 <= y)
				//{
				//	Console.WriteLine("たいへんよくできました");
				//}
				//else if (60 <= y)
				//{
				//	Console.WriteLine("よくできました");
				//}
				//else
				//{ 
				//Console.WriteLine("ざんねんでした");
				//}

				//Console.WriteLine("点数を入力してください");
				//int z = int.Parse(Console.ReadLine());
				//if (80 <= z)
				//{
				//	Console.WriteLine("優");
				//}
				//else if (70 <= z)
				//{
				//	Console.WriteLine("良");
				//}
				//else if (60 <= z)
				//{
				//	Console.WriteLine("可");
				//}
				//else
				//{ 
				//Console.WriteLine("不可");
				//}

				//2.3.5
				//Console.WriteLine("整数xを入力してください");
				//int x = int.Parse(Console.ReadLine());
				//Console.WriteLine("整数yを入力してください");
				//int y = int.Parse(Console.ReadLine());
				//if ( x < y && x % 2 ==0 && y % 2 == 0)
				//{
				//	Console.WriteLine("xはyより小さく、かつ、xとyは共に偶数である。");
				//}
				//if ( x == y && x < 0 && y < 0)
				//{
				//	Console.WriteLine("xとyは等しく、かつ、負の数である。");
				//}
				//if ( x < y || x % 2 == 0)
				//{
				//	Console.WriteLine("xはyより小さい、または、xは偶数である。");
				//}
				//if (( x <= 10 || x >= 100) && (y >= 10 && y <= 100))
				//{
				//	Console.WriteLine("xは10以下または100以上で、かつ、yは10以上かつ100以下である。");
				//}
				//if (!( x < 0 && y < 0))
				//{
				//	Console.WriteLine("xもyも負の数である、ではない。");
				//}

				//2.3.6
				//Console.WriteLine("お好きな寿司を選んでください");
				//Console.WriteLine("1:まぐろ 2:えび 3:こはだ 4:あなご 5:いくら");
				//string num = Console.ReadLine();
				//switch (num)
				//{
				//	case "1":
				//		Console.WriteLine("今日のあなたはリーダー運が好調です。積極的に行動しましょう！");
				//		break;

				//	case "2":
				//		Console.WriteLine("周囲との協力が運気アップの鍵です。困ったときは相談してみましょう！\r\n");
				//		break;

				//	case "3":
				//		Console.WriteLine("新しい知識を身につけるのに最適な一日です。");
				//		break;

				//	case "4":
				//		Console.WriteLine("焦らずゆっくり進めることで良い結果につながります。");
				//		break;

				//	case "5":
				//		Console.WriteLine("思わぬ幸運が舞い込むかもしれません。チャンスを逃さないようにしましょう！");
				//		break;

				//}


				//2.4.1
				//for (int i = 0; i < 10; i++)
				//{
				//	Console.WriteLine("SPAM");
				//}

				//2.4.2
				//for (int i = 1; i < 10; i++)
				//{ 
				//	Console.WriteLine(i * 3);
				//}

				//2.4.3
				int sum = 0;
				for (int i = 0; i < 10; i++)
				{
					Console.WriteLine("整数を入力してください");
					int n = int.Parse(Console.ReadLine());
					sum += n;
				}
				Console.WriteLine(sum / 10);

				//2.4.4
				//Console.WriteLine("【試合開始！】");
				//int sumK = 0;
				//int sumH = 0;
				//for (int i = 1; i < 10; i++)
				//{
				//	Console.WriteLine($"{i}回表、巨人の得点は？");
				//	int kyojinn = int.Parse(Console.ReadLine());
				//	sumK += kyojinn;
				//	Console.WriteLine($"{i}回裏、阪神の得点は？");
				//	int hannsinn = int.Parse(Console.ReadLine());
				//	sumH += hannsinn;
				//}
				//Console.WriteLine($"巨人：{sumK}点,阪神{sumH}点");
				//if (sumK < sumH)
				//{
				//	Console.WriteLine("阪神の勝ち");
				//}
				//else
				//{
				//	Console.WriteLine("巨人の勝ち");
				//}

				//2.4.5
				//2.4.6
				//int s = 0;
				//int b = 0;
				//while (s < 3 && b < 4)
				//{
				//	Console.WriteLine("ストライク=1 or ボール=2 or ファウル=3？");
				//	int sb = int.Parse(Console.ReadLine());
				//	if (sb == 1)
				//	{
				//		s++;
				//	}

				//	else if (sb == 2)
				//	{
				//		b++;
				//	}
				//	else if (sb == 3)
				//	{
				//		if (s < 2)
				//		{
				//			s++;
				//		}
				//	}
				//}
				//Console.WriteLine($"{b}ボール、{s}ストライク");

				//2.5.1
				//int [] nums = new int [10];
				//Console.WriteLine("10個の整数を入力してください");
				//for (int i = 0; i < 10; i++)
				//{
				//	nums[i] = int.Parse(Console.ReadLine());
				//}
				//for (int i = 0; i < 10; i++)
				//{
				//	Console.WriteLine(nums[i] * 2);
				//}

				//2.5.2
				//int[] nums = new int[10];
				//Console.WriteLine("10個の整数を入力してください");
				//for (int i = 0; i < 10; i++)
				//{
				//	nums[i] = int.Parse(Console.ReadLine());
				//}
				//int[] numg = new int[10];
				//int[] numk = new int[10];
				//int g = 0;
				//int k = 0; 
				//for (int i = 0; i < 10; i++)
				//{
				//	if (nums[i] % 2 == 0)
				//	{
				//		numg[g] = nums[i];
				//		g++;
				//	}
				//	else
				//		{
				//		numk[k] = nums[i];
				//		k++;
				//		}
				//}
				//Console.WriteLine("偶数");
				//for (int i = 0; i < g; i++)
				//{
				//	Console.WriteLine(numg[i]);
				//}
				//Console.WriteLine("奇数");
				//for(int i = 0; i < k; i++){ 
				//Console.WriteLine(numk[i]);
				//}

				//2.5.3
				//int[,] kuku = new int[9, 9];

				//for (int i = 0; i < 9; i++)
				//{
				//	for (int j = 0; j < 9; j++)
				//	{
				//		kuku[i, j] = (i + 1) * (j + 1);
				//	}
				//}

				//for (int i = 0; i < 9; i++)
				//{
				//	for (int j = 0; j < 9; j++)
				//		Console.Write(" {0,2}", kuku[i, j]);

				//	Console.WriteLine();
				//}

				//2.5.4
				//Console.WriteLine("整数を10回入力してください");
				//int[] nums = new int[10];
				//for (int i = 0; i < 10; i++)
				//{
				//	nums[i] = int.Parse(Console.ReadLine());
				//}
				//for (int i = 0; i < 9; i++)
				//{
				//	for (int j = i + 1; j < 10; j++)
				//	{
				//		if (nums[i] > nums[j])
				//		{
				//			int temp = nums[1];
				//			nums[i] = nums[j];
				//			nums[j] = temp;
				//		}
				//	}
				//}
				//for (int i = 0; i < 10; i++)
				//{ 
				//Console.WriteLine(nums[i]);
				//}

				//2.6.1
				//int t = int.Parse(Console.ReadLine());
				//int result = m261(t);			
				//Console.WriteLine(result);

				//2.6.2
				//int n = int.Parse(Console.ReadLine());
				//int m = int.Parse(Console.ReadLine());
				//int result = m262(n, m);
				//Console.WriteLine(result);

				//2.6.3
				//int x = int.Parse(Console.ReadLine());
				//int y = int.Parse(Console.ReadLine());
				//int result = m263(x, y);
				//Console.WriteLine(result);

				//2.6.4
				//int[] nums = new int[5];
				//for (int i = 0; i < 5; i++)
				//{
				//	Console.WriteLine("数値を入力してください");
				//	nums[i] = int.Parse(Console.ReadLine());
				//}
				//Console.WriteLine("最大値：" + m264(nums));
				//Console.WriteLine("最小値：" + m264(nums));
				//Console.WriteLine("平均値：" + GetAverage(nums));


				//2.7
				//Dog dog = new Dog();
				//dog.Name = "ポチ";
				//dog.ShowProfile();

				//2.7.2
				//Dog dog = new Dog();
				//dog.Name = "タロウ";
				//dog.Age = 4;
				//dog.ShowProfile();

				//2.7.3
				//Dog dog1 = new Dog();
				//dog1.Name = "ぽこ";
				//dog1.Age = 4;
				//Dog dog2 = new Dog();
				//dog2.Name = "jhon";
				//dog2.Age = 2;
				//dog1.ShowProfile();
				//dog2.ShowProfile();

				//2.7.4
				//Dog dog1 = new Dog("shiba");
				//Dog dog2 = new Dog("pu-doru");
				//Dog dog3 = new Dog("pagu");
				//dog1.Name = "pino";
				//dog1.Age = 8;

				//dog2.Name = "sun";
				//dog2.Age = 5;

				//dog3.Name = "lon";
				//dog3.Age = 4;

				//dog1.ShowProfile();
				//dog2.ShowProfile();
				//dog3.ShowProfile();

				//2.7.5



			}

			//2.6.1
			//static int m261(int t)
			//{
			//return t * t;
			//}

			//2.6.2
			//static int m262(int n, int m)
			//	{
			//	return (n + m) / 2;
			//	}

			//2.6.3
			//static int m263(int x, int y)
			//{
			//	if (x > y)
			//	{
			//		return x;
			//	}
			//	else
			//	{ 
			//		return y;
			//	}
			//}

			//2.6.4
			//static int m264(int[] nums)
			//{
			//	int max = nums[0];
			//	for (int i = 1; i < nums.Length; i++)
			//	{
			//		if (nums[i] > max)
			//		{ 
			//		max = nums[i];
			//		}
			//	}
			//	return max;
			//}
			//static int GetMin(int[] nums)
			//{
			//	int min = nums[0];

			//	for (int i = 1; i < nums.Length; i++)
			//	{
			//		if (nums[i] < min)
			//		{
			//			min = nums[i];
			//		}
			//	}

			//	return min;
			//}
			//static double GetAverage(int[] nums)
			//{
			//	int sum = 0;

			//	for (int i = 0; i < nums.Length; i++)
			//	{
			//		sum += nums[i];
			//	}

			//	return (double)sum / nums.Length;
			//}



		}




		//7.6.1
		//Employee empl = new FullTimeEmployee("田中",1000);
		//empl.CalculateMonthlyPay();
		//FullTimeEmployee fte1 = (FullTimeEmployee)emp;
		//fte1.AddOvertimeHours(10);
		//FullTimeEmployee? fte2 = emp as FullTimeEmployee;
		//if (fte2 != null)
		//{ 
		//fte2.AddOvertimeHours(10);
		//}
		////失敗時（FullTimeEmployee出ない場合）、asはnullを返す
		//if (emp is FullTimeEmployee fte3)
		//{
		//	fte3.AddOvertimeHours(10);
		//}
		////失敗時（FullTimeEmployeeでない場合）ifの中は実行されない


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




	




