Console.WriteLine("Введите число");
int value = Convert.ToInt32(Console.ReadLine());

Console.Write($"{value} ->");
for (int i = 1; i <= value; i++)
{
    Console.Write("{0}{1}", Math.Pow(i,3), i < value ? ", " : "");
}