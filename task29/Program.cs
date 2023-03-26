
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


internal class Program
{
    private static void Main(string[] args)
    {
        {
            Console.Clear();
            Console.WriteLine("задаёт массив и выводит их на экран");
            Console.WriteLine("Введите массив не более 8 символов. для разделения элементов массива используйте пробел, для обозначения дробных чисел запятую  ");
            int n = 8;
            string [] s = Press("DoubleMinus").Split(' ',n); // ограничиваем число элементов в массиве до 8
            double [] Arr = new double[n];

            Arr[0] = Convert.ToDouble(s[0]);
            Console.Write ($"{Arr[0]}");
            for (int i = 1; i< n-1; i++)
            {
                Arr[i] = Convert.ToDouble(s[i]);
               Console.Write ($"; {Arr[i]}");
            }

            //Console.WriteLine($" результат : {res}");
        }


        string Press(string p)
        {
            string a = string.Empty;
            if (p == "DoubleMinus")
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
                    case '-':
                        Console.Write("-");

                        a += "-";
                        break;

                    case ',':
                        Console.Write(",");

                        a += ",";
                        break;
                    case ' ':
                        Console.Write(" ");

                        a += " ";
                        break;

                    case (char)ConsoleKey.Enter:
                        goto Next1;

                }
            }
            else if (p == "Integer")
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
}