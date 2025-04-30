using MyNameSpace;

namespace Report4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 無限ループ：ユーザーが終了するまで繰り返します
            while (true)
            {
                // ユーザーに10進数の入力を求めます
                Console.Write("10進数を入力してください：  ");
                string input = Console.ReadLine();

                int number;

                // 入力が整数かどうかを確認します
                if (!int.TryParse(input, out number))
                {
                    // 数字以外が入力されたときのエラーメッセージ
                    Console.WriteLine("無効な入力です。整数を入力してください。");　　//Esto tambien tiene implicaciones a la hora de no asignar valores

                    // ユーザーに再試行するか終了するかを聞きます
                    Console.Write("もう一度試しますか？ (Y/N)：");
                    string retry = Console.ReadLine();
                    if (retry.ToUpper() != "Y") break;  //En caso de ingresar n (o cualquier otro valor distinto a "y") realiza break
                    else continue;
                }

                // 入力された整数を2進数に変換します（メソッド呼び出し）
                string binary = MyClass.ToBinary(number);

                // 結果を表示します
                Console.WriteLine($"10進数：{number}, 2進数：{binary}");

                // ユーザーにもう一度変換するかどうかを確認します
                Console.Write("もう一度変換しますか？ (Y/N)：");  //Mantiene el programa abierto en caso de que se desee preguntar de nuevo
                string again = Console.ReadLine();
                if (again.ToUpper() != "Y") break;
            }
        }
    }
}

