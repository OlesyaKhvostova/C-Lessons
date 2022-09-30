int Summ(int value)
{
    int result = 0;
    
    for (int i = 10; i >= 0 ; i--)
    {
        int powerValue = (int)Math.Pow(10, i);
        if (value >= powerValue)
        {
            int part = value % powerValue;
            result += (value - part)/powerValue;
            value = part;
        } 
    }

    return result;
}

Console.WriteLine("Введите число");
int value = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("{0} -> {1}", value, Summ(value));