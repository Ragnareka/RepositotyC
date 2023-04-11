
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine(" вычисления функции Аккермана(m,n)");
            Console.WriteLine(" введите M ");
        int m = Convert.ToInt32(Press("Integer"));
        Console.WriteLine(" введите N ");
        int n = Convert.ToInt32(Press("Integer"));
    
        int res =  accer( m,  n);
    Console.WriteLine($"результат {res} ");
    }

static int accer(int m, int n)
{
    int res = 0;
    if (m == 0)
    {
        res = n + 1;
}
    else if (n == 0)
    {
        res = accer(m - 1, 1);
    }
    else
    {
        res = accer(m - 1, accer(m, n - 1));
    }
return res;

}

static string Press(string p) // функция чтобы не давать пользователям вводить глупости
{ //"DoubleMinus" для ввода массивов
  //"Integer" для ввода размерности массивов
    string a = string.Empty;

    if (p == "Integer")
    {
        while (true)
            switch (Console.ReadKey(true).KeyChar)
            {
                case '1':
                    Console.Write("1");

                    a += "1";
                    break;
                case '2':
                    Console.Write("2");

                    a += "2";
                    break;
                case '3':
                    Console.Write("3");

                    a += "3";
                    break;
                case '4':
                    Console.Write("4");

                    a += "4";
                    break;
                case '5':
                    Console.Write("5");

                    a += "5";
                    break;
                case '6':
                    Console.Write("6");

                    a += "6";
                    break;
                case '7':
                    Console.Write("7");

                    a += "7";
                    break;
                case '8':
                    Console.Write("8");

                    a += "8";
                    break;
                case '9':
                    Console.Write("9");

                    a += "9";
                    break;
                case '0':
                    Console.Write("0");

                    a += "0";
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

   


