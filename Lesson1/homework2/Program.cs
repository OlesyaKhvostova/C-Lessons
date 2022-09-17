try
{
    Console.WriteLine("Введите первое число:");
    int firstValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    int secondValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третье число:");
    int thirdValue = Convert.ToInt32(Console.ReadLine());

    int max = firstValue > secondValue ? firstValue : secondValue;
    if (max > thirdValue)
    {
        Console.WriteLine("max = {0}", max);
    }
    else
    {
        Console.WriteLine("max = {0}", thirdValue);
    }

}
catch(FormatException)
{
    Console.WriteLine("Вы ввели неккоретное число");
}