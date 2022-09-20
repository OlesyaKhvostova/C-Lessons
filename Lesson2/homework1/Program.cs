int Calculate(int value)
{
    int remainValue = value % 100;
    int smallValue = remainValue % 10;
    int result = (remainValue - smallValue)/10;
    return result;
} 

Console.WriteLine("Введите трехзначное число");
int value = Convert.ToInt32(Console.ReadLine());
if (value > 99 && value < 1000)
{
    int result = Calculate(value);
    Console.WriteLine($"{value} -> {result}");
} 
else
{
    Console.WriteLine("Число неккоректное");
}



