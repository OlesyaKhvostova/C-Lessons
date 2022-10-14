void PrintDigit(int number)
{
    if( number > 0)
    {
        Console.Write($"{number} ");
        PrintDigit(number - 1);
    }
}

Console.WriteLine("Введите число больше 0");
int number = Convert.ToInt32(Console.ReadLine());
PrintDigit(number);