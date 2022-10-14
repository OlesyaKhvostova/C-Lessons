int GetSumm(int numberM, int numberN)
{
    if ( numberM == numberN)return numberM;
    return numberM + GetSumm(numberM + 1, numberN);
}

Console.WriteLine("Введите 1 число больше 0");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2 число больше 0");
int numberN = Convert.ToInt32(Console.ReadLine());

int summ = GetSumm(numberM, numberN);
Console.WriteLine($"{summ}");