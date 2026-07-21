using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace _20260721_Practice
{
    internal class Program
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

            int price = int.Parse(Console.ReadLine());
            Console.WriteLine(CalcTax(price));

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(a,b,c));

            int attack = int.Parse(Console.ReadLine());
            int defense = int.Parse(Console.ReadLine());
            Console.WriteLine(CalcDamage(attack,defense));





			//関数
			string s = "11";
        //    int m = 11;
            //int>string
            //        s = x.ToString();

            //string>int
            //      x = int.Parse(s);




//            int x = Calc(2, 3);
     //       Console.WriteLine(x);
        }
    //    static int Calc(int x, int y)
     //   {
    //        return x + y;
       // }


        static void m211()
        {
            int x = 11;
            Console.WriteLine($"x= {x}");
        } static void m212()
        {
            int x = 13 + 17;
            Console.WriteLine("x=" + x);
        } static void m213()
        {
            int x = 13;
            int y = 17;
            Console.WriteLine("x=" + y);
        }static void m214()
        {
            int x = 13;
			int y = 17;
			Console.WriteLine("x=" + x*y);
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

        static void m223(int m,int n)
        {
            Console.WriteLine((m + n) / 2);
		}

        static void m224(int b)
        {
            Console.WriteLine(b * 365);
		}

        static int power(int p)
        {
           return ( p*p);
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

            int h = t/3600;
            int m = (t % 3600)/60;
            int s = t % 60;

            //   Console.WriteLine(h + "時間" + m + "分" + s + "秒");
            Console.WriteLine($"{h} 時間{ m}分{ s} 秒");
        }

        static int Add(int a ,int b) {
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
            return(int) Math.Floor(price * 1.1);
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

        static int CalcDamage(int attack, int defense)
        {

        }
            


	}

}
