
//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.



internal class Program
{
    private static void Main(string[] args)
    {
        
            Console.Clear();
            Console.WriteLine("находить строку с наименьшей суммой элементов");
            Random rnd = new Random();
 
             int n = rnd.Next(1, 10); // столбец
             int m = 0;
             do
             {
             m = rnd.Next(1, 10); //строка
             }
             while (m<n);
             
            Console.WriteLine($" Массив размерностью : {m} строк x {n} столбцов:");
           
            int [,] Arr = new int[m,n+1] ;
           int sum = 0;
            for (int i = 0; i<m; i++)
            { sum = 0;
                for (int j = 0; j<n; j++)
                {
                Arr[i,j] = rnd.Next(-999, 999);
                sum += Arr[i,j] ;
                if (j ==0) {Console.Write ($"\n {Arr[i,j]}    |");}
                else Console.Write ($" {Arr[i,j]}    |");
                 }
                 Arr[i,n] = sum; // пишем в лишний столбец суммы элементов

            }
             int min = int.MaxValue;
             int minplace = 0;
             for (int i = 0; i<m; i++)
                {
                    if (min > Arr[i,n]) 
                    {
                        min = Arr[i,n];
                        minplace = i;// вычисляем номер строки с мин.суммой
                    }
                }
            Console.WriteLine($" \n строка с наименьшей суммой элементов:");
             for (int j = 0; j<n; j++)
                {
                     Console.Write ($" {Arr[minplace,j]} "); // выводим
                }
Console.WriteLine($" \n номер строки с наименьшей суммой элементов: {minplace+1} строка с суммой {Arr[minplace,n]} ");



    }  
            
        
    }
