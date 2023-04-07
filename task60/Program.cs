
//  Сформируйте трёхмерный массив из неповторяющихся двузначных чисел


internal class Program
{
    private static void Main(string[] args)
    {
        
            Console.Clear();
            Console.WriteLine(" трёхмерный массив из неповторяющихся двузначных чисел");
            Random rnd = new Random();
 
             int a = rnd.Next(1, 5); // размерность 
             int b = rnd.Next(1, 5); // размерность 
             int c = rnd.Next(1, 5); // размерность 
                                      


        //Произведение двух матриц  имеет смысл только в том случае, когда число столбцов матрицы А совпадает с числом строк матрицы В .
        int[,,] Arr= new int[a,b,c];
       
        InitM(Arr, a,b,c);
        
       
        Console.WriteLine($" \n Матрица размерностью : {a} строк x {b} столбцов x {c} глубины");
        PrintM(Arr, a,b,c );
      


    }  

    static void PrintM (int[,,] Arr, int a, int b, int c)
    {
         for (int i = 0; i<a; i++)
            { 
                for (int j = 0; j<b; j++)
                {
                    for (int k = 0; k<c; k++)
                    {
                
                    if (j ==0) {Console.Write ($"\n {Arr[i,j,k]} ({i},{j},{k}) ;  ");}
                    else Console.Write ($" {Arr[i,j,k]} ({i},{j},{k}) ;");
                    }
                }

            }
    }      
     static void InitM (int[,,] Arr, int a, int b, int c)
    {
        Random rnd = new Random();

        List<int> distinctArr = new List<int>();
        List<int> dist;
        do
        {
            distinctArr.Add(rnd.Next(10, 100));
            dist = distinctArr.Distinct().ToList();
        }
        while (dist.Count < a * b * c);


        int ch = 0;
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                for (int k = 0; k < c; k++)
                {
                    Arr[i, j, k] = dist[ch];
                    ch ++;
                    }
            }

        }
    }

}
