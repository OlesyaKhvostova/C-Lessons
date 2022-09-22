try
{
    Console.WriteLine("Введите первое число");
    int valyeA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int valyeB = Convert.ToInt32(Console.ReadLine());
    if (valyeA > valyeB)
    {
        Console.WriteLine($"max = {valyeA}");
    }
    else 
    {
        Console.WriteLine($"max = {valyeB}");
    }
}
catch (FormatException) 
{
    Console.WriteLine("Ввод некорректных данных");
}