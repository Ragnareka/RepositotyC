
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


internal class Program
{
    private static void Main(string[] args)
    {
        {
            Console.Clear();
            Console.WriteLine("сумму элементов, стоящих на нечётных позициях в случайном массиве");
            
            Random rnd = new Random();
 
            int n = rnd.Next(1, 10);
            int chet = 0;
            int [] Arr = new int[n];
            for (int i = 0; i< n; i++)
            {
                Arr[i] = rnd.Next();
                if (i%2 ==0) chet += Arr[i];
                if (i == 0) {Console.Write ($" {Arr[i]}");} // я так понимаю на нечетных с точки зрения пользователя.
                // а не с точки зрения машины. как если бы массив начинался с 1-ы ( нечетной) а не с 0-я ( четного)
                else Console.Write ($"; {Arr[i]}");
            }

            Console.WriteLine($" результат : {chet}");
        }

    }

}