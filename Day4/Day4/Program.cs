
using MyNameSpace;

namespace Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //二進数の文字列を入力して、整数に変換し、表示します
            //1) 二進数の文字列を入力します
            Console.WriteLine("2進数の文字列を入力してください:  ");
            string binary = Console.ReadLine();


            //2）二進数の文字列を整数に変換します　（メソッドを作ります）
            int number = MyClass.ToNumber(binary);


            //3）二進数の文字列と整数を表示します
            Console.WriteLine($"2進数：{binary}, 10進数: {number}");

        }
    }
}
