﻿Console.WriteLine("Введите целочисленное число");
int value = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вещественное число");
double valueDbl = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите строку");
string valueStr = Console.ReadLine();
Console.WriteLine("Введите логическое значение true false");
bool valueBl = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine($"целочисленное число = {value} вещественное значение = {valueDbl}");
Console.WriteLine("строка = {0} логическое значение = {1}", valueStr, valueBl);
