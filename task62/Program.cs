
//  Напишите программу, которая заполнит спирально массив 4 на 4.


internal class Program
{
    private static void Main(string[] args)
    {
        
            Console.Clear();
            Console.WriteLine(" заполнит спирально массив 4 на 4");
            
            int[,] Arr = new int[4 ,4];

InitM(Arr, 4);
PrintM(Arr, 4);

    }  

    static void PrintM (int[,] Arr, int n)
    { 
        for (int i = 0; i<n; i++)
            { 
                for (int j = 0; j<n; j++)
                {
               
                
                if (j ==0) {Console.Write ($"\n {Arr[i,j]}    |");}
                else Console.Write ($" {Arr[i,j]}    |");
                 }
                

            }
    }      
     static void InitM (int[,] Arr, int num)
    {
        int a = 0;
        int n = num-1;
        int chis = 1;
        do
        { int i = a;
        int j = a ;
            while (j <n)
            {
                Arr[i,j] = chis;
                chis ++;
                j++;
            }
             while (i <n)
            {
                Arr[i,j] = chis;
                chis ++;
                i++;
            }
             while (j >a)
            {
                Arr[i,j] = chis;
                chis ++;
                j--;
            }
             while (i >a)
            {
                Arr[i,j] = chis;
                chis ++;
                i--;
            }
a++;
n--;
        }
        while (a<n);
        
    }
 

}
