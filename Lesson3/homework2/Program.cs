int GetUserData(string coord, string point)
{
    Console.WriteLine("Введите координату {0} точки {1}", coord, point);
    int result = 0;
    try
    {
        result = Convert.ToInt32(Console.ReadLine());
    }
    catch(FormatException)
    {
        Console.WriteLine("Вы ввели некорректное число, расчет будет неверным");
    }
    return result;
}
var pointA = new int[3];
var pointB = new int[3];

pointA[0] = GetUserData("X", "A");
pointA[1] = GetUserData("Y", "A");
pointA[2] = GetUserData("Z", "A");

pointB[0] = GetUserData("X", "B");
pointB[1] = GetUserData("Y", "B");
pointB[2] = GetUserData("Z", "B");


double distance = Math.Sqrt(Math.Pow(pointB[0] - pointA[0], 2) + Math.Pow(pointB[1] - pointA[1], 2) + Math.Pow(pointB[2]- pointA[2], 2));
Console.WriteLine("A({0},{1},{2});B({3},{4},{5}); -> {6:N2}", pointA[0], pointA[1], pointA[2], 
pointB[0], pointB[1], pointB[2], distance);
