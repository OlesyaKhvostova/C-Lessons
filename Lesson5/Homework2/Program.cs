int[] Generate()
{
    int count = new Random().Next(1,11);
    int[] array = new int[count];
    for(int i = 0 ; i < count; i++)
    {
        array[i] = new Random().Next(0,20);
    }

    return array;
}

int Calculate(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        result += array[i];
    }
    return result;
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