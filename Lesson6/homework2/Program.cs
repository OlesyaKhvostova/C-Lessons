// y = k1 * x + b1, y = k2 * x + b2;
// K1*x + b1 = K2*x + b2
//k1x - k2x = b2 - b1
const int K1 = 0;
const int B1 = 1;
const int K2 = 2;
const int B2 = 3;
const int Size = 4;

double[] array = new double[Size];
double CalceulateX(double[] array)
{
    return (array[B2] - array[B1])/(array[K1] -array[K2]); 
}

double CalceulateY(double[] array, double x)
{
    return array[K1] * x + array[B1];    
}

void PrintResult(double[] array, double x, double y)
{
    Console.WriteLine("K1={0}, B1={1}, K2={2}, B2={3} -> x={4}, y={5}", 
    array[K1], array[B1], array[K2], array[B2], x, y);
}

double GetParamFromConsole(string name)
{
    Console.WriteLine($"Введите name {name}");

    return Convert.ToDouble(Console.ReadLine());
}

array[K1] = GetParamFromConsole("K1");
array[B1] = GetParamFromConsole("B1");
array[K2] = GetParamFromConsole("K2");
array[B2] = GetParamFromConsole("B2");
double x = CalceulateX(array);
double y = CalceulateY(array, x);

PrintResult(array, x, y);

