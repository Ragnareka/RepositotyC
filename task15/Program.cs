
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным 



Console.Clear();
Console.WriteLine("принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным ");
Console.WriteLine("Введите целое число.");



/*

int N = Convert.ToInt32(Console.ReadLine());
while  ( N >7 | N<1 )
    {Console.WriteLine("Невозможно обработать \n введите корректное значение");
     N = Convert.ToInt32(Console.ReadLine());
    }

if (N>5)
Console.WriteLine("это выходной");
else Console.WriteLine("это будний день");
*/



while(true)
    switch (Console.ReadKey(true).KeyChar)
    {
        case  '1':
            Console.WriteLine(" 1 - будний день");
            break;
        case  '2':    
            Console.WriteLine("2 - будний день");
            break;
        case  '3':    
            Console.WriteLine("3 - будний день");
            break;
        case  '4':    
            Console.WriteLine("4 - будний день");
            break;
        case  '5':    
            Console.WriteLine("5 - будний день");
            break;
        case  '6':    
            Console.WriteLine("6 - Выходной");
            break;
        case  '7':    
            Console.WriteLine("7 - Выходной");
            break;
        case  (char)ConsoleKey.Enter:    
            goto Next1;
      
    }
   Next1: Console.WriteLine("END");

