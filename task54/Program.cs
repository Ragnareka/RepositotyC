
//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.



internal class Program
{
    private static void Main(string[] args)
    {
        
            Console.Clear();
            Console.WriteLine("упорядочит по убыванию элементы каждой строки двумерного массива");
            Random rnd = new Random();
 
             int n = rnd.Next(1, 10); // столбец
            int m = rnd.Next(1, 10); //строка
            Console.WriteLine($" Массив размерностью : {m} строк x {n} столбцов:");
           
            int [][] Arr = new int[m][] ;
            for (int i = 0 ; i < m; i++)
            {
                Arr[i] = new int [n];
            }
            for (int i = 0; i<m; i++)
            {
                for (int j = 0; j<n; j++)
                {
                Arr[i][j] = rnd.Next(-999, 999);
                
                if (j ==0) {Console.Write ($"\n {Arr[i][j]}    |");}
                else Console.Write ($" {Arr[i][j]}    |");
                 }
            }
            Console.WriteLine($" \n Упорядоченный Массив размерностью : {m} строк x {n} столбцов:");

            foreach (int [] item in Arr) 
            {
                foreach (int element in item)
                    Array.Sort(item);
                    Array.Reverse(item);
            }

            for (int i = 0; i<m; i++)
            {
                for (int j = 0; j<n; j++)
                {
                               
                if (j ==0) {Console.Write ($"\n {Arr[i][j]}    |");}
                else Console.Write ($" {Arr[i][j]}    |");
                 }
            }

    }  
            
        
    }
