
int[] ParseDigits(string[] rawData)
{
    int[] digitsArray = new int[8];
    
    for (int i = 0; i < rawData.Length; i++)
    {
        if (i < digitsArray.Length)
        {
            digitsArray[i] = Convert.ToInt32(rawData[i]);
        }
    }
    return digitsArray;
}

void PrintDigits(string rawData, int count, int[] digits)
{
    string outputValue = "";
    for(int i = 0 ; i < digits.Length; i++)
    {
        if (i < count)
        {
            outputValue += Convert.ToString(digits[i]);
            if (i + 1 < (digits.Length < count ? digits.Length : count))
            {
                outputValue += ",";
            }
        }
    }
    Console.WriteLine("{0} -> [{1}]", rawData, outputValue);
}

Console.WriteLine("Введите не более 8 цифр через запятую");
var rawDigits = Console.ReadLine();
var digits = rawDigits.Split(',');
PrintDigits(rawDigits, digits.Length, ParseDigits(digits));