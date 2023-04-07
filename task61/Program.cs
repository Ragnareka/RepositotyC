
//  Вывести первые N строк треугольника Паскаля


internal class Program
{
    private static void Main(string[] args)
    {
        
            Console.Clear();
            Console.WriteLine(" Вывести первые N строк треугольника Паскаля");
            Console.WriteLine(" введите N ");
            int n =   Convert.ToInt32(Console.ReadLine());
            int[,] pascalTriangle = new int[n ,n];

InitM(pascalTriangle, n);
PrintM(pascalTriangle, n);

    }  

    static void PrintM (int[,] Arr, int n)
    { 
        int ch = n;
         for (int i = 0; i<n; i++)
            { 
                for (int j = 0; j<n; j++)
                {
                    if (j == 0)  {Console.Write ("\n");

                    for (int k = 0;k<ch;k++)
                    {
                        Console.Write (" ");
                    }
                    ch--;
                   
                    }
                    
                    if (Arr[i,j] ==0) 
                    {
                        Console.Write ("   ");
                    }
                    else 
                    {
                    Console.Write ($"{Arr[i,j]} ");
                    }
                    
                }

            }
    }      
     static void InitM (int[,] Arr, int n)
    {Arr[0,0] = 1;
            for (int i = 1;i<n;i++)
            {
                for (int k = 0;k< n;k++)
                {
                    if (k ==0) Arr[i,k] = 1;
                    else  Arr[i,k] = Factarial(i) / (Factarial(k) * Factarial(i - k));
                }
            }
        
    }
   static int Factarial(int n)
{
    
    int x = 1;
    for (int i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}

}
