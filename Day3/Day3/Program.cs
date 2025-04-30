
const int COUNT = 10;  //合計する数値の個数

int[]numbers = new int[COUNT]; 

for (int index = 0; 　　//初期化式(最初に1回だけ実行)
    index < COUNT; 　　//条件式　（条件が成り立てば、ループを一回実行）
    index++)　　//更新式（ループの処理の後に実行）
{
    //数値を入力する
    //プロント文字列を表示する
    Console.WriteLine("整数入力してください : ");
    //数字列（文字列）を入力する　（console.ReadLine)
    //数値に変換する (int.Parse)
    numbers[index]= int.Parse(Console.ReadLine());
}

//合計を計算する
int sum = 0;
foreach (var item in numbers)
{
    sum += item;    //  +=  は、sum = sum + item;の省略形
    //省略　　-=, *=, /=, %=, &=, |=, ^=

    //item = 10; 値のセットはできない
}

for (int index =0; index <COUNT; index++)
{
    if (index == 0)  //条件式　(indexが０と等しい場合、成り立つ）
    {
        //条件が成り立った場合　(indexが0の場合)
        Console.WriteLine($"{numbers[0]}");
}
    else
    {
        Console.WriteLine($" + {numbers[index]}");
        //条件が成り立てなかった場合　(indexが0以外の場合)
    }

}

