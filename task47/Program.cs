
//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.





internal class Program
{
    private static void Main(string[] args)
    {
        {
            Console.Clear();
            Console.WriteLine("двумерный массив размером m×n, заполненный случайными вещественными числами");
            Random rnd = new Random();
 
            int n = rnd.Next(1, 10);
            int m = rnd.Next(1, 10);
            Console.WriteLine($" Массив размерностью : {m} x {n}:");
           
            Double [,] Arr = new double[m,n];
            for (int i = 0; i<m; i++)
            {
                for (int j = 0; j<n; j++)
                {
                Arr[i,j] = rnd.Next(-999, 999)*rnd.NextDouble();
                
                if (j ==0) {Console.Write ($"\n {Math.Round(Arr[i,j],2)}    |");}
                else Console.Write ($" {Math.Round(Arr[i,j],2)}    |");
                 }
            }

            
        }

    }

}
   