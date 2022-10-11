int[,] GenerateArray()
{
    int[,] array = new int[4,6];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,20);
        }
    }
    PrintArray(array);
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0 ; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,7}",array[i,j]);
        }
        Console.Write("\n");
    }
}

(int row, int sum) FindMinElementSum(int[,] array)
{
    int row = 0;
    int rowSumm = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int currSumm = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            currSumm += array[i,j];
        }

        if (i == 0)
        {
            rowSumm = currSumm;
        }
        else
        {
            if (currSumm < rowSumm)
            {
                rowSumm = currSumm;
                row = i;
            }
        }
    }
    return (row, rowSumm);
}
var array = GenerateArray();
var result = FindMinElementSum(array);
Console.WriteLine($"Номер строки = {result.row} Сумма = {result.sum}");