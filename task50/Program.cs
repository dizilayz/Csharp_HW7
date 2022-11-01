// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет ([1,7] это позиция элемента)

void Main()
{
    int[,] array = GetArray(3, 4, 0, 10);
    PrintArray(array);
    Console.WriteLine("Введите номер строки: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца: ");
    int col = Convert.ToInt32(Console.ReadLine());
    
    FindNumber(array, row, col);
}
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
        Console.WriteLine();
    }
    return result;
}

void FindNumber(int[,] array, int row, int col)
{
    if (row < 0 || row >= array.GetLength(0) || col < 0 || col >= array.GetLength(1))
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
    else Console.WriteLine($"Ваше число: {array[row, col]}");
}
void PrintArray(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

Main();