using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Timers;

namespace _20260721_Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
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

			

         
            sb();






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

		}
            static void m211()
            {
                int x = 11;
                Console.WriteLine($"x= {x}");
            }
            static void m212()
            {
                int x = 13 + 17;
                Console.WriteLine("x=" + x);
            }
            static void m213()
            {
                int x = 13;
                int y = 17;
                Console.WriteLine("x=" + y);
            }
            static void m214()
            {
                int x = 13;
                int y = 17;
                Console.WriteLine("x=" + x * y);
            }






            static void m221()
            {
                string s = Console.ReadLine();
                Console.WriteLine(s);
            }

            static void m222()
            {
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine(x);
            }

            static void m223(int m, int n)
            {
                Console.WriteLine((m + n) / 2);
            }

            static void m224(int b)
            {
                Console.WriteLine(b * 365);
            }

            static int power(int p)
            {
                return (p * p);
            }



            static void aaa(int q)
            {
                if (q >= 10)
                {
                    return;
                }
                Console.WriteLine("値が10以下です");

            }


            static double CircleArea(double c)
            {
                return (c * c * 3.14);
            }


            static void ggg(int t)
            {
                // int h = t / 3600;
                // int m = (t - h*3600) / 60;
                // int s = t - (h*3600 + m*60);

                int h = t / 3600;
                int m = (t % 3600) / 60;
                int s = t % 60;

                //   Console.WriteLine(h + "時間" + m + "分" + s + "秒");
                Console.WriteLine($"{h} 時間{m}分{s} 秒");
            }

            static int Add(int a, int b)
            {
                return (a + b);
            }

            static bool IsEven(int number)
            {
                if (number % 2 == 0)
                {
                    return true;
                }
                return false;
            }


            static int CalcTax(int price)
            {
                return (int)Math.Floor(price * 1.1);
            }

            static int GetMax(int a, int b, int c)
            {
                int l = 0;
                if (a > b)
                {
                    l = a;
                }
                else
                {
                    l = b;
                }
                if (c > l)
                {
                    l = c;
                }
                return l;
            }

            // 2026.7.22↓
            // 2.3.1.問題3-1

            static void compare(int x, int y)
            {
                if (x > y)
                {
                    Console.WriteLine("xはyより大きい");
                }
            }

            // 2.3.2.	問題3-2
            static void number(int x, int y)
            {
                if (x > y)
                {
                    Console.WriteLine("xはyより大きい");
                }
                else if (x < y)
                {
                    Console.WriteLine("xはyより小さい");
                }
                else
                {
                    Console.WriteLine("xとyは等しい");

                }
            }

            //2.3.3.	問題3-3
            static void even(int num)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("偶数");
                }
                else
                {
                    Console.WriteLine("奇数");
                }
            }

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
			static int Spam()
            {
                  for (int i = 0; i < 10; i++)
                 {
                    Console.WriteLine("SPAM");
                  }
                    return 10;
            }

			//2.4.2.	問題4-2
            static void kuku(int x)
            {
                if (x % 3 == 0)
                {
                    Console.WriteLine(x);
                }
                else
                {
                    Console.WriteLine("---");
                }
            }

			//2.4.3.問題4 - 3
            static int avg(int a)
            {
                
                    return a / 10;
                
            }


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
			static void sb()
            {
			    int sta = 0;
			    int bla = 0;

                while (sta == 3 || bla == 4)
                {
                    Console.WriteLine("ストライクは1，ボールは2を入力してください");
                    int s = int.Parse(Console.ReadLine());
                if (s == 1)
                {
                    sta++;
                }
                else if (s == 2)
                {
                    bla++;
                }
                else 
                {
                    Console.WriteLine("mm");
                    bla++;

				}
                    Console.WriteLine($"{bla}ボール{sta}ストライク");
            
			    }

		    }

	}
}


