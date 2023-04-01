
//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// это задача на массивы? Зачем здесь массивы? Ладно


internal class Program
{  private static void Main(string[] args)
    {
        {
            Console.Clear();
            Console.WriteLine("точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;");
            double b1 ;
            double k1 ;
            double b2 ;
            double k2 ;
            do{
             Console.WriteLine("Введите значения b1, k1, b2 и k2 . для разделения элементов  используйте пробел, для обозначения дробных чисел  - запятую ");
            string [] InputMAss = Press("DoubleMinus").Split(' ',4); // не давать пользователям вводить глупости
            b1 = Convert.ToDouble(InputMAss[0]);
            k1 = Convert.ToDouble(InputMAss[1]);
            b2 = Convert.ToDouble(InputMAss[2]);
            k2 = Convert.ToDouble(InputMAss[3]);
                Console.WriteLine($" y = {b1} x + {k1}, y = {b2} x + {k2}; ");//
                Console.WriteLine("Все верно? y/n");}
                while (Press("y/n") == "n");//проверяем. что пользователь все ввел что хотел
            b1 = b1-b2;// вычитаем из первого уравнения второе
            k1 = k1-k2;
            
            double x = -k1/b1;// находим x
            double y = b2*x+k2;//// находим y
            Console.WriteLine($" пересечение будет в координатах: ({Math.Round(x,2)},{Math.Round(y,2)})");
        }


        string Press(string p) // функция чтобы не давать пользователям вводить глупости
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
   