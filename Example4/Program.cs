Console.WriteLine("Введите имя");
string? username = Console.ReadLine();
if (username.ToLower() == "olesya")
{
    Console.WriteLine("Как здорово, это же Olesya");
}
else if (username.ToLower() == "lera")
{
    Console.WriteLine("Ура, и Lera c нами");
}
else
{
    Console.WriteLine($"Привет, {username}");
    
}
