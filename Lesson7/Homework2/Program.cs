int[,] arrayValue = new int[3,4];

void FillArray(int[,] array)
{
    for (int i = 0 ; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0, 100);
        }
    }
}

void PrintArray(int[,] array)
{
    Console.Write("\n");
    for (int i = 0 ; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,5} ",array[i,j]);
        }
        Console.Write("\n");
    }
}

void PrintArrayElement(int[,] array, int col, int row)
{
    if (row < array.GetLength(0) && col < array.GetLength(1))
    {
        PrintArray(array);
        Console.WriteLine("Элемент [{0}, {1}] = {2}", row, col, array[row,col]);
    }
    else
    {
        Console.WriteLine("Такого элемента не существует");
    }
}
Console.WriteLine("Введите индекс строки");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбцы");
int col = Convert.ToInt32(Console.ReadLine());

FillArray(arrayValue);
PrintArrayElement(arrayValue, col, row);