void PrintArray(int[,] array)
{
    for (int i = 0 ; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,3}",array[i,j]);
        }
        Console.Write("\n");
    }
}

bool CheckCell(ref int dir, int[,] array, ref int i, ref int j)
{
    if (dir == 0) // right
    {
        if ( (j + 1 == array.GetLength(0)) ||
            (array[i,j + 1] != 0) )
        {
            dir = 1;
            return false;
        }
        j++;
    }
    else if (dir == 1) // down
    {
        if ( (i + 1 == array.GetLength(0)) ||
            (array[i + 1,j] != 0) )
        {
            dir = 2;
            return false;
        }
        i++;
    }
    else if (dir == 2) // left
    {
        if ( (j == 0) ||
            (array[i,j - 1] != 0) )
        {
            dir = 3;
            return false;
        }
        j--;
    }
    else if (dir == 3) // up
    {
        if ( (i == 0 ) ||
            (array[i - 1,j] != 0) )
        {
            dir = 0;
            return false;
        }
        i--;
    }
    return true;
}

int[,]GenerateArray(int size)
{
    int i = 0;
    int j = 0;
    int value = 1;
    int max = size*size;
    int[,] array = new int[size,size];
    int dir = 0;

    while(value <= max)
    {
        array[i,j] = value;
        
        if (value == max)break;
        if (CheckCell(ref dir, array, ref i, ref j))
        {
            value++;
        }
    }
    return array;
}

var array = GenerateArray(7);
PrintArray(array);