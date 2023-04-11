
//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


internal class Program
{
    private static void Main(string[] args)
    {  Console.Clear();
        
 Console.WriteLine(" выведет все натуральные числа в промежутке от N до 1");
            Console.WriteLine(" введите N ");
            int n =   Convert.ToInt32(Console.ReadLine());
           
           string res = recurs(n);
            Console.WriteLine(" результат ");
            Console.WriteLine(res);
    }  
    static string recurs ( int n)
    {   string res = string.Empty;
        if (n > 0)         
        { 
            res +=Convert.ToString(n);
            res +=" ";
            res += recurs(n-1);
        }
        return res;
    }
}

     