
//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.



internal class Program
{
    private static void Main(string[] args)
    {
        
            Console.Clear();
            Console.WriteLine("принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет");
            Random rnd = new Random();
 
            int n = rnd.Next(1, 10); // столбец
            int m = rnd.Next(1, 10); //строка
            Console.WriteLine($" Массив размерностью : {m} строк x {n} столбцов:");
           
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
            do{
                Console.WriteLine("\n Введите номер строки: ");
                int a = int.Parse(Console.ReadLine()!);
                Console.WriteLine("\n Введите номер столбца: ");
                int b = int.Parse(Console.ReadLine()!);
                if ( a< m && b<n)
                {
                    Console.WriteLine($" {Math.Round(Arr[a-1,b-1],2)} ");// мы же думаем, что пользователь считает с 1-цы
                }
                else
                {
                    Console.WriteLine("такой позиции нет");
                }
                    Console.WriteLine("Продолжить? y/n");}
            while (Press("y/n") == "y");//проверяем. что пользователь все ввел что хотел
            
        
    }

         static string Press(string p) // функция чтобы не давать пользователям вводить глупости
        {   //"DoubleMinus" для ввода массивов
            //"Integer" для ввода размерности массивов
            // "y/n" для отчетов на вопрос

            string a = string.Empty;
            if (p == "y/n")
             { while (true)
                switch (Console.ReadKey(true).KeyChar)
                {
                    case 'y':
                        Console.Write("y");

                        a += "y";
                        break;
                    case 'n':
                        Console.Write("n");

                        a += "n";
                        break;
                    case (char)ConsoleKey.Enter:
                        goto Next1;
                }
            }

           
            Next1:
            Console.WriteLine("\n");
            return a;
        }
    

}


   