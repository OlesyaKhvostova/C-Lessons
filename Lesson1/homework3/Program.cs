try
{
    Console.WriteLine("Введите число:");
    int value = Convert.ToInt32(Console.ReadLine());
    int remainder = value % 2;
    if (remainder == 0)
        Console.WriteLine("Число четное");
    else
        Console.WriteLine("Число нечетное");
}
catch(FormatException)
{
    Console.WriteLine("Вы ввели неккоретное число");
}