try
{
    Console.WriteLine("Введите число:");
    int value = Convert.ToInt32(Console.ReadLine());

    Console.Write($"{value} ->");
    for(int i = 1; i <= value; i++)
    {
        int remainder = i % 2;
        if (remainder == 0)
            Console.Write($" {i}");
    }
}
catch(FormatException)
{
    Console.WriteLine("Вы ввели неккоретное число");
}