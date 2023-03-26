
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. 
Console.Clear();
Console.WriteLine("на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
Console.WriteLine("Введите целое число.");
int N = Convert.ToInt32(Console.ReadLine());
if ( N >1)
    {for (int i = 2;i<N+1;i+=2)
        {Console.Write($" {i}");}
    }
else Console.WriteLine("Невозможно обработать ");
