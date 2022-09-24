var weekDays = new string[]{"Рабочий", "Рабочий", "Рабочий", "Рабочий", "Рабочий", "Выходной", "Выходной"};
Console.WriteLine("Введите день недели");
int day = Convert.ToInt32(Console.ReadLine());
string answer = "Нет такого дня";
if ( day > 0 && day <= 7)
{
    answer = weekDays[day - 1];
}
Console.WriteLine("{0} -> {1}", day, answer);