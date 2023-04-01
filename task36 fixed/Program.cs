
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


internal class Program
{
    private static void Main(string[] args)
    {
        {
            Console.Clear();
            Console.WriteLine("сумму элементов, стоящих на нечётных позициях в случайном массиве");
            
            Random rnd = new Random();
 
            int n = rnd.Next(1, 10);
            int chet = 0;
            int [] Arr = new int[n];

            
            for (int i = 0; i< n;  i++) // нечетные с точки зрения пользователей
            {
                Arr[i] = rnd.Next(-1000,1000);
                if (i%2 ==0)
                {chet += Arr[i];}
               
            }

            PrintM(Arr);
            Console.WriteLine( "\n результат");
            Console.WriteLine(chet);
        }
    
    }

    static void PrintM(int[] matrix)
    {
        Console.WriteLine( "Maccив:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        { if (i == 0) {Console.Write ($" {matrix[i]}");} 
            else Console.Write ($"; {matrix[i]}");
        
        }
    }

}