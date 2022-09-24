Console.WriteLine("Введите число");
int value = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введенное число {0}", value);
int randomValue = new Random().Next(1,100);
while((randomValue % value) != 0)
{
    Console.WriteLine("{0} -> не кратно", randomValue);
    randomValue = new Random().Next(1,100);
}

Console.WriteLine("{0} -> кратно", randomValue);