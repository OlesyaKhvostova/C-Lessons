try
{
    Console.WriteLine("Введите первое число");
    int value1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int value2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третье число");
    int value3 = Convert.ToInt32(Console.ReadLine());
    if (value1 > value2) 
    {
        Console.WriteLine("max = {0}", value1 > value3 ? value1 : value3);
    }
    else
    {
        Console.WriteLine("max = {0}", value2 > value3 ? value2 : value3);
    }
}
catch (FormatException)
{
    Console.WriteLine("Ввод некорректных данных");
}





