
//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


internal class Program
{
    private static void Main(string[] args)
    {
        
            Console.Clear();
            Console.WriteLine("произведение двух матриц");
            Random rnd = new Random();
 
             int n1 = rnd.Next(1, 5); // размерность матрицы столбцы
             int m1 = rnd.Next(1, 5); // размерность матрицы строки
             int m2 = rnd.Next(1, 5); // размерность матрицы строки и столбцы
                                      


        //Произведение двух матриц  имеет смысл только в том случае, когда число столбцов матрицы А совпадает с числом строк матрицы В .
        int[,] ArrB = new int[m2, n1];
        int[,] ArrA = new int[m1, m2];
        InitM(ArrA, m1, m2);
        InitM(ArrB, m2, n1);
       
        Console.WriteLine($" \n Матрица размерностью : {m1} строк x {m2} столбцов:");
        PrintM(ArrA, m1, m2);
         Console.WriteLine($" Матрица размерностью : {m2} строк x {n1} столбцов:");
        PrintM(ArrB, m2, n1);
        int [,] ArrC = new int[m1,n1] ;
        for (int i = 0;i<m1;i++)
        {
            for (int j = 0; j<n1;j++)
            {
                for (int k = 0; k<m2;k++)
            {           ArrC [i,j] +=  ArrA [i,k]*ArrB [k,j];
            }
            }
        }

         Console.WriteLine($" \n результат:");
            PrintM (ArrC,m1,n1);

    }  

    static void PrintM (int[,] Arr, int a, int b)
    {
         for (int i = 0; i<a; i++)
            { 
                for (int j = 0; j<b; j++)
                {
               
                
                if (j ==0) {Console.Write ($"\n {Arr[i,j]}    |");}
                else Console.Write ($" {Arr[i,j]}    |");
                 }
                

            }
    }      
     static void InitM (int[,] Arr, int a, int b)
    {
          Random rnd = new Random();
         for (int i = 0; i<a; i++)
            { 
                for (int j = 0; j<b; j++)
                {
               Arr[i,j] = rnd.Next(-99, 99);
                 }
                

            }
    }               
        
    }
