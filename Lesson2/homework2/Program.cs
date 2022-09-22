int RemoveMiddleDigit(int value)
{    
    int leftDigit = (value - value % 100)/10;
    int rightDigit = value % 10;
    int result = leftDigit + rightDigit;
    return result;
}

int value = new Random().Next(100, 1000);
int result = RemoveMiddleDigit(value);
Console.WriteLine($"{value} -> {result}");