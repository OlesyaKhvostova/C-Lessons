int CalcPower(int value, int power)
{
    int result = value;
    for(int i = 1; i < power; i++)
    {
        result *= value;
    }
    return result;
}

Console.WriteLine("Введите число");
int value = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа");
int power = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Число {0} в степени {1} -> {2}", value, power, CalcPower(value, power));