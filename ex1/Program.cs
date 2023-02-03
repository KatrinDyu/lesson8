/*  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
 каждой строки двумерного массива. */
 Console.Clear();
 
Console.Write("Введите количество строк массива m: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива n: ");
int columns = int.Parse(Console.ReadLine());

int[,] arr = GetArray(rows, columns, 0, 10);
PrintArray(arr);
SortArr(arr);
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
void SortArr(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j =0; j<array.GetLength(1); j++)
        {
            for (int t = j+1; t<array.GetLength(1); t++)
            {
                if (array[i,t]>array[i,j])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,t];
                    array[i,t] = temp;
                }
                 //Console.Write($"{array[i, j]} ");

            }
Console.Write($"{array[i, j]} ");
           // Console.WriteLine();

        }
Console.WriteLine();
    }
}