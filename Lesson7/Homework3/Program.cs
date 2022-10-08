int[,] arrayValue = new int[3,4];

void FillArray(int[,] array)
{
    for (int i = 0 ; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0, 10);
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

void CalcAvrColValue(int[,] array, double[] arrayAvrValue)
{
    for(int i = 0; i < array.GetLength(1); i++)
    {
        arrayAvrValue[i] = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            arrayAvrValue[i] += array[j,i];
        }
        Console.WriteLine(arrayAvrValue[i]);
        arrayAvrValue[i] /= array.GetLength(0);
    }
}
void PrintAvrValue(double[] arrayAvrValue)
{
    for(int i = 0 ; i < arrayAvrValue.Length; i++)
    {
        Console.WriteLine("Среднее арифметическое столбца {0} = {1:N2}", i, arrayAvrValue[i]);
    }
}

FillArray(arrayValue);
PrintArray(arrayValue);
double[] arrayAvrValue = new double[4];
CalcAvrColValue(arrayValue, arrayAvrValue);
PrintAvrValue(arrayAvrValue);