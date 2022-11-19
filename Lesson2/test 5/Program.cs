Console.WriteLine("Ввести первое целочисленное число");
int firstValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввести второе целочисленное число");
int secondValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите операцию для этих чисел");
string operation = Console.ReadLine();
float total = 0.0f;
if (operation == "+")
{
    total = firstValue + secondValue;   
}

if (operation == "-")
{
    total = firstValue - secondValue;
}

if (operation == "*")
{
    total = firstValue * secondValue;
}

if (operation == "/")
{
    total = firstValue / secondValue;
}
Console.WriteLine($"результат: {firstValue} {operation} {secondValue} = {total}");
