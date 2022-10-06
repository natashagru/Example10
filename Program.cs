// программа которая на вход принимает трехзначное число и на выходе показывает вторую цифру этого числа

Console.Clear();
Console.WriteLine("введите трехзначное число n");
int n = int.Parse(Console.ReadLine()!);
int result = (n%100)/10;
Console.WriteLine($"{result}");
