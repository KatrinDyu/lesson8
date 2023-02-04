/* адайте прямоугольный двумерный массив. Напишите программу, которая 
будет находить строку с наименьшей суммой элементов. */
 Console.Clear();
 
Console.Write("Введите количество строк массива m: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива n: ");
int columns = int.Parse(Console.ReadLine());

int[,] arr = GetArray(rows, columns, 0, 10);
PrintArray(arr);
Console.WriteLine($"stroka s naimenshei summoi = {GetRow(arr)}");
int GetRow(int[,] array)
{
    int row =0;
    int minsum =0;
    for (int i = 0; i< array.GetLength(1); i++)
    {
        minsum=minsum + array[0,i];
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        if (minsum > sum)
        {
            minsum = sum;
            row = i;
        }
    }
    return row
}





int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}