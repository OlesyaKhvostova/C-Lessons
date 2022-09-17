try
{
    Console.WriteLine("Введите первое число:");
    int firstValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    int secondValue = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("max = {0}", firstValue > secondValue ? firstValue : secondValue);
}
catch(FormatException)
{
    Console.WriteLine("Вы ввели неккоретное число");
}