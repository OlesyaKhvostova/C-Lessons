int[,] GenerateArray()
{
    int[,] array = new int[3,5];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,100);
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

void SortRow(int[,] array, int row)
{
    bool unsort = false;
    while (!unsort)
    {   
        unsort = true;
        for (int i = 0; i < array.GetLength(1) - 1; i++)
        {
            if (array[row, i + 1] > array[row, i])
            {
                var temp = array[row, i];
                array[row, i] = array[row, i + 1];
                array[row, i + 1] = temp;
                unsort = false;
            }
        }
    }
}

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        SortRow(array, i);
    }
}
var array = GenerateArray();
SortArray(array);
Console.WriteLine("====== SORT ======");
PrintArray(array);