Console.WriteLine("整数を入力してください: ");

var input = Console.ReadLine();　

var number = int.Parse(input);

long answer = number * number;  //int*int = int
//long: ±21億×40億

Console.WriteLine($"{number:n0}*{number:n0} = {answer:n0}");




