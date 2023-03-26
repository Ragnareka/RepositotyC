
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.



Console.Clear();
Console.WriteLine("принимает на вход пятизначное число и проверяет, является ли оно палиндромом ");
Console.WriteLine("Введите целое число.");

int i = 0;
string a = string.Empty;



while(i<5)
    switch (Console.ReadKey(true).KeyChar)
    {
        case  '1':
            Console.Write("1");
            i++;
            a += "1";
            break;
        case  '2':    
            Console.Write("2");
            i++;
            a += "2";
            break;
        case  '3':    
            Console.Write("3");
            i++;
            a += "3";
            break;
        case  '4':    
            Console.Write("4");
            i++;
            a += "4";
            break;
        case  '5':    
            Console.Write("5");
            i++;
            a += "5";
            break;
        case  '6':    
            Console.Write("6");
            i++;
            a += "6";
            break;
        case  '7':    
            Console.Write("7");
            i++;
            a += "7";
            break;
        case  '8':    
            Console.Write("8");
            i++;
            a += "8";
            break;
        case  '9':    
            Console.Write("9");
            i++;
            a += "9";
            break;
       
      
    }
    Console.Write ("\n");
 // Console.WriteLine($"вы выбрали число {a}");
char[] sReverse = a.ToCharArray();
Array.Reverse(sReverse);
string s = new string(sReverse);


 if (a==s)
 Console.WriteLine($"{s}  это палиндром");
 else  Console.WriteLine($"{s} это не палиндром");


