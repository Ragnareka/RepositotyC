
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine(" найдёт сумму натуральных элементов в промежутке от M до N");// включительно, я так понимаю?
        Console.WriteLine(" введите N ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" введите M ");
        int m = Convert.ToInt32(Console.ReadLine());
        int res = 0;

        if (m == n) Console.WriteLine(m);// если они равны, то мы берем только края
        else
        {
            if (m > n)
            {
                res = n;
                res += recurs(m, n);
            }
            else
            {
                res = m;
                res += recurs(n, m);
            }
            Console.WriteLine(" результат ");
            Console.WriteLine(res);
        }
    }
    static int recurs(int n, int m)
    {   int res = n;
        n--;
        
        
        if (n > m)
        {
            res += recurs(n, m);
            
        }
        return res;
    }
}

