
// Задайте массив дробных чисел. Найдите разницу между максимальным и минимальным элементов массива.


internal class Program
{
   /* private static void Main(string[] args)
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

    }*/


// семинар 49

/*    static void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
              {  matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
             
              }

        }
    }

static void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

private static void Main(string[] args)
{
Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("Новый: ");
UpdateMatrix(matrix);
PrintMatrix(matrix);
}


static void UpdateMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
           {
            if ( i%2 ==1 && j%2==1)
            {matrix[i, j] = matrix[i, j]* matrix[i, j];}

           }
        
    }
}

} */

// семинар 51
/*
  static void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
              {  matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
             
              }

        }
    }

static void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

private static void Main(string[] args)
{
Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);

SumMatrix(matrix);
Console.WriteLine($"результат: {SumMatrix(matrix)}");
//PrintMatrix(matrix);
}


static int SumMatrix(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
           {
            if ( i== j)
            {sum += matrix[i, j];}

           }
        
    }
    return sum;
}

} 
*/
