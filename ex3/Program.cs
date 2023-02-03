/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. */
Console.Clear();
 
Console.Write("Введите количество строк массива A: ");
int rowsA = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива A: ");
int columnsA = int.Parse(Console.ReadLine());

int[,] arrA = GetArray(rowsA, columnsA, 0, 10);
PrintArray(arrA);
Console.Write("Введите количество строк массива B: ");
int rowsB = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива B: ");
int columnsB = int.Parse(Console.ReadLine());

int[,] arrB = GetArray(rowsB, columnsB, 0, 10);
PrintArray(arrB);
if (columnsA != rowsB)
 {
    Console.WriteLine("umnojit nevosmojno");
}
PrintArray(Multiplication(arrA,arrB));
Console.WriteLine();

int [,] Multiplication(int [,] arrayA, int [,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int row = 0; row < arrayA.GetLength(0); row++)
    {
        for (int columns = 0; columns < arrayB.GetLength(1); columns++)
        {
            for (int k = 0; k< arrayA.GetLength(1); k++)
            {
                arrayC[row,columns] += arrayA[row, k] * arrayB[k, columns];
            }
        }
    }
    return arrayC;
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