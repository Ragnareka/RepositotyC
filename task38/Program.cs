
// Задайте массив дробных чисел. Найдите разницу между максимальным и минимальным элементов массива.


internal class Program
{
    private static void Main(string[] args)
    {
        {
            Console.Clear();
            Console.WriteLine("покажет разницу между максимальным и минимальным элементов случайного массива");
            
            Random rnd = new Random();
 
            int n = rnd.Next(1, 10);
            double s;
            double max = double.MinValue;
            double min = double.MaxValue;
            double [] Arr = new double[n];
            for (int i = 0; i< n; i++)
            {
                s = rnd.NextDouble() ;
                Arr[i] = 100*s ;
                if (max < Arr[i] ) max = Arr[i] ;
                if (min > Arr[i] ) min = Arr[i] ;
                if (i ==0) {Console.Write ($" {Math.Round(Arr[i],2)}");}
                else Console.Write ($"; {Math.Round(Arr[i],2)}");
            }
            Console.Write ("\n");
            Console.WriteLine($" результат : {Math.Round(max-min,2)}");
        }

    }

}