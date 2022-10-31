int Calculate(int value)
{
    int result = -1; 
    if (value >= 100)
    {
        int temp = value % 1000;
        result = (temp - temp % 100) / 100;
    }
    return result;
}
Console.WriteLine("Введите число");
int value = Convert.ToInt32(Console.ReadLine());
int result = Calculate(value);
Console.WriteLine("{0} -> {1}", value, result == -1 ? "Третьего числа не существует" : result);  
