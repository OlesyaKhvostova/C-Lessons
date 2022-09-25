int getDigitByIndex(int value, int index)
{
    int result = value % (int)Math.Pow(10, index);
    if (index > 1)
    {
        int childPow = (int)Math.Pow(10, index - 1);
        int temp = result % childPow;
        result = (result - temp)/childPow;
    }
    return result;
}

Console.WriteLine("Введите пятизначное число");
int value = Convert.ToInt32(Console.ReadLine());
bool isPalindrome = false;
getDigitByIndex(value, 5);
if (value > 9999 && value < 100000)
{
    if (getDigitByIndex(value, 1) == getDigitByIndex(value, 5) && 
        getDigitByIndex(value, 2) == getDigitByIndex(value, 4))
    {
        isPalindrome = true;
    }
}
Console.WriteLine("{0} -> {1}", value, isPalindrome ? "да" : "нет");