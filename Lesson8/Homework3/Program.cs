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

int[,] GenerateArray(int row, int col)
{
    int[,] array = new int[row,col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
        }
    }
    PrintArray(array);
    return array;
}

int[,] MultiplyMatrix(int[,] first, int[,] second)
{
    if (first.GetLength(1) != second.GetLength(0)) 
    {
        throw new InvalidDataException();
    }
    int[,] matrix = new int[first.GetLength(0), second.GetLength(1)];
    Console.WriteLine($"Итоговая матрица{matrix.GetLength(0)} X {matrix.GetLength(1)}");
    for (int i = 0 ; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int element = 0;
            for (int index = 0; index < first.GetLength(1); index++)
            {   
                Console.Write($"({first[i,index]} * {second[index,j]}) ");             
                element += first[i,index] * second[index,j];                
            }
            Console.WriteLine($"= {element}");
            matrix[i,j] = element;
        }
    }
    return matrix;
}
var firstMatrix = GenerateArray(2,3);

Console.WriteLine("  \\  /  ");
Console.WriteLine("   \\/   ");
Console.WriteLine("   /\\   ");
Console.WriteLine("  /  \\  ");

var secondMatrix = GenerateArray(3,1);
Console.WriteLine("==========");
try
{
    var resultMatrix = MultiplyMatrix(firstMatrix, secondMatrix);
    PrintArray(resultMatrix);
}
catch(InvalidDataException)
{
    Console.WriteLine("Неверные размерности матрицы");
}