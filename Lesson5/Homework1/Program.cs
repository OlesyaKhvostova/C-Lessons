int Calculate(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if ((array[i] % 2) == 0)
        {
            count++;
        }
    }
    return count;
}

int[] Generate()
{
    int count = new Random().Next(1,11);
    int[] array = new int[count];
    for(int i = 0 ; i < count; i++)
    {
        array[i] = new Random().Next(100,1000);
    }

    return array;
}

string PrintArray(int[] array)
{
    string outputValue = "[";
    for(int i = 0; i < array.Length; i++)
    {
        outputValue += Convert.ToString(array[i]);
        outputValue +=  ( i + 1 < array.Length ) ? "," : "]";
    }
    return outputValue;
}

var array = Generate();
Console.WriteLine("{0} -> {1}", PrintArray(array), Calculate(array));
