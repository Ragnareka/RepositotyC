
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.



internal class Program
{  private static void Main(string[] args)
    {
        {
            Console.Clear();
            Console.WriteLine(" сколько чисел больше 0");
             Console.WriteLine("Введите массив. для разделения элементов массива используйте пробел, для обозначения дробных чисел  - запятую ");
            string [] InputMAss = Press("DoubleMinus").Split(' '); // не давать пользователям вводить глупости
            var DoubleArr = new List<double>(); // нет задачи делать это оптимально, верно? это же не ++. я могу перекладывать данные из контейнеров в контейнеры пока мне не станет скучно
            double result = 0; // переменная для counting  значений >0
            foreach ( string NUM in InputMAss)
           
            {  
                double i = Convert.ToDouble(NUM);
                DoubleArr.Add(i);
                if (i>0)
                {result ++;};
            }

            //
            Console.WriteLine($" результат : {result}");
        }


        string Press(string p) // функция чтобы не давать пользователям вводить глупости
        { //"DoubleMinus" для ввода массивов
            //"Integer" для ввода размерности массивов
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
   