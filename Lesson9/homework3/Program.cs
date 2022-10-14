uint FunctionA(uint numberN, uint numberM)
{
    if (numberN == 0)
    {
        return numberM + 1;
    }
    else
    {
        if ((numberN != 0) && (numberM == 0))
        {
            return FunctionA(numberN - 1, 1);
        }
        else
        {
            return FunctionA(numberN - 1, FunctionA(numberN, numberM - 1));    
        }
    }
}


Console.WriteLine("Введите 1 число больше 0");
uint numberN = Convert.ToUInt32(Console.ReadLine());

Console.WriteLine("Введите 2 число больше 0");
uint numberM = Convert.ToUInt32(Console.ReadLine());

uint summ = FunctionA(numberN, numberM);
Console.WriteLine($"{summ}");