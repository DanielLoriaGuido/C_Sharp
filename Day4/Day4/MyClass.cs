using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNameSpace   //違う名前空間を書きます
{
    class MyClass
    {
        //2進数の文字列を整数に変換するメソッド
        public static int ToNumber (string binary)
        {
            int number = 0;　　//結果が入る変数

            foreach (var ch in binary)　　//文字列の先頭から1文字ずつ取り出してループする
            {
                number = number * 2;  //結果の値を2倍します

                if(ch == '1')  //シングルコテションを使用します  shift + 7
                    //取り出した文字が1なら
                {
                    number = number + 1;　//結果に1を加える
                }
            }

            return number; //戻り値の値を指定する
        }
    }
}
