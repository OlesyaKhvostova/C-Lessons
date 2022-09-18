Console.WriteLine("Ввести число");
int value = Convert.ToInt32(Console.ReadLine());
Console.Write($"{value} ->");
for(int i = 1; i <= value; i++)
{
   
    if (i % 2 == 0)
    {
        Console.Write($" {i}");

    }

}
Console.Write($"\n{value} ->");
int count = 1;
while (count <= value)
{
    if (count % 2 == 0)
    {
        Console.Write($" {count}");
    }
    count++;

}