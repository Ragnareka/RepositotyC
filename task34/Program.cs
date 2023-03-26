
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


internal class Program
{
    private static void Main(string[] args)
    {
        {
            Console.Clear();
            Console.WriteLine("покажет количество чётных чисел в рандомном массиве");
            Random rnd = new Random();
 
            int n = rnd.Next(1, 10);
            int chet = 0;
            int [] Arr = new int[n];
            for (int i = 0; i< n; i++)
            {
                Arr[i] = rnd.Next(100, 999);
                if (Arr[i]%2 ==0) chet++;
                if (i ==0) {Console.Write ($" {Arr[i]}");}
                else Console.Write ($"; {Arr[i]}");
            }

            Console.WriteLine($" результат : {chet}");
        }

    }

}