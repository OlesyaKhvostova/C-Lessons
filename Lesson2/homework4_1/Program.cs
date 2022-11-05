Console.WriteLine("Ввести день недели");
int value = Convert.ToInt32(Console.ReadLine());
if (value >= 1 && value <= 7)
{
    if (value >= 6)
    {
        Console.WriteLine($"{value} выходной день");
    }
    else if (value >= 1 && value <= 5)
    {
        Console.WriteLine($"{value} будний день");
    }
}
else
{
    Console.WriteLine($"Значение {value} ошибка. Правильный диапазон от 1 до 7");
}