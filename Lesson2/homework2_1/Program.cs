int Calculate(int value)
{
    int result = 0;
    int remainValue = value % 100;
    int firstNumber = (value - remainValue)/100;
    result = firstNumber * 10;
    int thirdNumber = value % 10;
    result += thirdNumber;
    return result;
}


int value = new Random().Next(100, 1000);
Console.WriteLine("{0} -> {1}",value, Calculate(value));

