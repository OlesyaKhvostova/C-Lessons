Console.WriteLine("Ввести число");
int value = Convert.ToInt32(Console.ReadLine());
if (value % 2 == 0)
{
    Console.WriteLine($"{value} это четное число");
}
else
{
    Console.WriteLine($"{value} это нечетное число");
}
