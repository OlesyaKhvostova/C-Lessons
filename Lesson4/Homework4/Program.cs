int[] GenerateArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

int GetSecondMax(int[] array)
{
    int maxIndex = 0;
    int index = -1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > array[maxIndex])
        {
            index = maxIndex;
            maxIndex = i;
        }
        else if (array[i] != array[maxIndex])
        {
            if (index == -1 || array[index] < array[i])
            {
                index = i;
            }
        }
    }

    return index;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write("{0} ", array[i]);
    }
    Console.Write("->");
    int index = GetSecondMax(array);
    Console.Write(" {0}", index == -1 ? "не найден" : array[index]);
}

PrintArray(GenerateArray());