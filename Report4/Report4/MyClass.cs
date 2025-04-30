using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNameSpace   
{
    class MyClass
    {
        //整数を2進数の叔父列に変換します

        public static string ToBinary(int number)
        {

            if (number <= 0) return "0";    // 0以下は0を返す


            string binary = "";    　 // string binary = string.Empty;  と同じです
                                     // 結果を入れる変数

            while (number > 0)   　 //While文条件が成り立てば、ループの中身を1回実行します
            {
                if (number % 2 == 0)
                    binary = "0" + binary; // 0を先頭に追加
                else
                    binary = "1" + binary; // 1を先頭に追加

                number = number / 2;
            }
            return binary;

        }
    }

}
