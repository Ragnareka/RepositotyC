
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("на вход трёхзначное число и на выходе показывает вторую цифру этого числа");
Console.WriteLine("Введите трёхзначное целое число.");
int a = Convert.ToInt32(Console.ReadLine());
while (a < 100 && a<0)
{Console.WriteLine("вы ошиблись\nВведите трёхзначное целое число.");
a = Convert.ToInt32(Console.ReadLine());};
int result = (a/10)%10;
Console.WriteLine(result);
