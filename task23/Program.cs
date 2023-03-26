
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


internal class Program
{
    private static void Main(string[] args)
    {
        {
            Console.Clear();
            Console.WriteLine("принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N");
            Console.WriteLine("Введите  число. (для дробных чисел используйте запятую)");

            double a = Convert.ToDouble(Press());
            while (a < 0)
            {   Console.WriteLine("невозможно для отрицательных чисел");
                a = Convert.ToDouble(Press());
            };

            for (int i = 1; i<a; i++)
            { 
                Console.Write($", {Math.Pow(i,3)}");
            }
        }


        string Press()
        {
            string a = string.Empty;

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
                    case '-':
                        Console.Write("-");

                        a += "-";
                        break;

                    case ',':
                        Console.Write(",");

                        a += ",";
                        break;

                    case (char)ConsoleKey.Enter:
                        goto Next1;

                }
            Next1:
            Console.WriteLine("\n");
            return a;
        }
    }
}