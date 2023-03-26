// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.Clear();
Console.WriteLine("вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
Console.WriteLine("Введите первое целое число.");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число.");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
    {Console.WriteLine($"max = {a}");}
else if (b>a)
    {Console.WriteLine($"max = {b}");}
    else {Console.WriteLine("они равны");};
