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

string GenerateAndCalculate()
{
    int count = new Random().Next(1,11);
    int[] array = new int[count];
    int max = 0;
    int min = 10000;
    for(int i = 0 ; i < count; i++)
    {
        array[i] = new Random().Next(0,20);
        if (array[i] > max)
        {
            max = array[i];
        }

        if (array[i] < min)
        {
            min = array[i];
        }
    }

    var data = string.Format("{0} -> {1}", PrintArray(array), Convert.ToString(max - min));
    return data;
}

Console.WriteLine("{0}", GenerateAndCalculate());