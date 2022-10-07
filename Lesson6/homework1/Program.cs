int CalculateNegativeDigitCount(string digits)
{
    string[] array = digits.Split(',');
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (Convert.ToInt32(array[i]) > 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine("введите набор положительных и отрицательных чисел через запятую");
string digits = Console.ReadLine();

Console.WriteLine("Пользователь ввел {0} чисел больше 0", CalculateNegativeDigitCount(digits));