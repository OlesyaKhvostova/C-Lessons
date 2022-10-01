int[] Generate(int arrayLength, int arrayFillType)
{
    int[] array = new int[arrayLength];
    for(int i = 0, value = 1 ; i < arrayLength/2; i++ )
    {
        if (arrayFillType == 1)
        {
            array[i] = array[arrayLength - 1 - i] = value++;
        }
        else
        {
            array[i * 2] = array[i * 2 + 1] = value++;
        }
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

Console.WriteLine("Введите четную длину массива");
int arrayLength = Convert.ToInt32(Console.ReadLine());
if ( ( arrayLength % 2 == 0 ) && ( arrayLength > 0 ) )
{
    Console.WriteLine("Введите тип заполнения массива:1 - зеркальный, 2 - дублирование");
    int arrayFillType = Convert.ToInt32(Console.ReadLine());
    if (arrayFillType == 1 || arrayFillType == 2)
    {
        var array = Generate(arrayLength, arrayFillType);
        Console.WriteLine("{0}", PrintArray(array));
    }
}
else
{
    Console.WriteLine("Длина массива не валидная");
}

