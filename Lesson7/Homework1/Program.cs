double[,] arrayValue = new double[3,4];

void FillArray(double[,] array)
{
    for (int i = 0 ; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            double value = new Random().Next(-100, 100);
            double valuePart = new Random().Next(0, 10);

            array[i,j] = value + valuePart/10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0 ; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,7:N1} ",array[i,j]);
        }
        Console.Write("\n");
    }
}

FillArray(arrayValue);
PrintArray(arrayValue);