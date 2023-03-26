
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//Формула вычисления расстояния между двумя точками A(xa, ya) и B(xb, yb) на плоскости:
//AB = √(xb - xa)2 + (yb - ya)2

 
Console.Clear();
Console.WriteLine("принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве ");
Console.WriteLine("Введите координаты первой точки через запятую");

int [,] x = new int[2,2];
string[] s = Press().Split(',');
x[0,0] = Convert.ToInt32(s[0]);
x[0,1] = Convert.ToInt32(s[1]);
Console.WriteLine("Введите координаты второй точки через запятую");
s = Press().Split(',');
x[1,0] = Convert.ToInt32(s[0]);
x[1,1] = Convert.ToInt32(s[1]);
double r = Math. Sqrt(Math. Pow(x[0,0] - x[1,0],2)+Math. Pow(x[0,1] - x[1,1],2));
Console.WriteLine($"расстояние между ними = {r}");



string Press ()
{
string a = string.Empty;

while(true)
    switch (Console.ReadKey(true).KeyChar)
    {
        case  '1':
            Console.Write("1");
           
            a += "1";
            break;
        case  '2':    
            Console.Write("2");
           
            a += "2";
            break;
        case  '3':    
            Console.Write("3");
           
            a += "3";
            break;
        case  '4':    
            Console.Write("4");
           
            a += "4";
            break;
        case  '5':    
            Console.Write("5");
            
            a += "5";
            break;
        case  '6':    
            Console.Write("6");
           
            a += "6";
            break;
        case  '7':    
            Console.Write("7");
            
            a += "7";
            break;
        case  '8':    
            Console.Write("8");
            
            a += "8";
            break;
        case  '9':    
            Console.Write("9");
           
            a += "9";
            break;
         case  '-':    
            Console.Write("-");
           
            a += "-";
            break;
            
         case  ',':    
            Console.Write(",");
           
            a += ",";
            break;
       
        case  (char)ConsoleKey.Enter:    
            goto Next1;
      
    }
   Next1: 
   Console.WriteLine("\n");
   return a;
}