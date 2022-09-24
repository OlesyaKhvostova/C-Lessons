int ConvertValue(int value)
{
    int maxOrder = 1;

    while ((value / Convert.ToInt32(Math.Pow(10, maxOrder))) > 0)
    {
        maxOrder++;
    }

    int[] digits = new int[maxOrder];

    for (int i = maxOrder - 1, index = 0; i >= 0; i--, index++)
    {
        int divider = Convert.ToInt32(Math.Pow(10, i));
        int temp = value % divider;
        int digit = (value - temp)/divider;
        digits[index] = digit;
        
        value = temp;
    }

    return digits.Length >= 3 ? digits[2] : -1;
}

Console.WriteLine("Введите число");
int value = Convert.ToInt32(Console.ReadLine());
int result = ConvertValue(value);
Console.WriteLine("{0}", result == -1 ? "третьего числа нет" : result);