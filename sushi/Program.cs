namespace sushi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("お好きな寿司を選んでください");
            Console.WriteLine("1:まぐろ 2:えび 3:こはだ 4:あなご 5:いくら");

            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
            Console.WriteLine("1:まぐろ→ 今日のあなたはリーダー運が好調です。積極的に行動しましょう！");
            break;

        case 2:
            Console.WriteLine("2:えび→ 周囲との協力が運気アップの鍵です。困ったときは相談してみましょう！");
            break;
 
        case 3:
            Console.WriteLine("3:こはだ→ 新しい知識を身につけるのに最適な一日です。");
            break;

        case 4:
            Console.WriteLine("4:あなご→ 焦らずゆっくり進めることで良い結果につながります。");
            break;

        case 5:
            Console.WriteLine("5:いくら→ 思わぬ幸運が舞い込むかもしれません。チャンスを逃さないようにしましょう！");
            break;


        }
    }
    }
}
