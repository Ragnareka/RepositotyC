
//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.



internal class Program
{
    private static void Main(string[] args)
    {
        
            Console.Clear();
            Console.WriteLine("среднее арифметическое элементов в каждом столбце");
            Random rnd = new Random();
 
            int n = rnd.Next(1, 10); // столбец
            int m = rnd.Next(1, 10); //строка
            Console.WriteLine($" Массив размерностью : {m} строк x {n} столбцов:");
           int avgN = 0;
            int [,] Arr = new int[m+1,n]; 
            for (int i = 0; i<n; i++) // переворачиваем массив
            {avgN = 0;
                for (int j = 0; j<m; j++)
                {
                Arr[j,i] = rnd.Next(-999, 999);
                     avgN += Arr[j,i];         
                 }
                 Arr[m,i] = Convert.ToInt32(avgN/m); // в лишней строке храним среднее по столбцу

            }
            
             for (int i = 0; i<m+1; i++) // переворачиваем массив обратно
            {
                for (int j = 0; j<n; j++)
                {
                
                 if (j ==0) {
                    if (i ==m) {Console.WriteLine ($" \n среднее по столбцу ");}
                    Console.Write ($"\n {(Arr[i,j])}    |");
                    
                    }
                else Console.Write ($" {(Arr[i,j])}    |");
                
               
                              
                 }
                 
            }

    }  
            
        
    }
