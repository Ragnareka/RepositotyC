// See https://aka.ms/new-console-template for more information

//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine("принимает на вход три числа и выдаёт максимальное из этих чисел.");
int [] a = new int [3];
Console.WriteLine("Введите первое целое число.");
 a [0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число.");
 a [1]  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  третье целое число.");
 a [2]  = Convert.ToInt32(Console.ReadLine());
 int maxValue = a.Max();
 Console.WriteLine($"Наибольшее значение {maxValue}");

 


