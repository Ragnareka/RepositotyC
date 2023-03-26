


//// Н Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("выводит третью цифру заданного числа или сообщает, что третьей цифры нет");
Console.WriteLine("Введите  целое число.");


string a = (Console.ReadLine());
int b = Convert.ToInt32(a);

while ( b <0)
{   Console.WriteLine("вы ошиблись\nВведите неотрицательное целое число.");
    a = Console.ReadLine();
    b = Convert.ToInt32(a);
};

if (a.Length>2)
    Console.WriteLine(a[2]);
else Console.WriteLine("такой цифры нет");

return 0;


