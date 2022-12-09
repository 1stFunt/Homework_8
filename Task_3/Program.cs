// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int rows = ReadInt("Введите число строк 1ой матрицы: ");
int rowsColumns = ReadInt("Введите число столбцов 1ой матрицы и строк 2ой матрицы: ");
int columns = ReadInt("Введите число столбцов 2ой матрицы: ");
int[,] firstMatrix = new int[rows, rowsColumns];
FillArray(firstMatrix);
Console.WriteLine($"Первая матрица:");
PrintArray(firstMatrix);
int[,] secondMatrix = new int[rowsColumns, columns];
FillArray(secondMatrix);
Console.WriteLine($"Вторая матрица:");
PrintArray(secondMatrix);
int[,] resultMatrix = new int[rows, columns];
MultiMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine($"Результирующая матрица:");
PrintArray(resultMatrix);
void MultiMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int b = 0; b < firstMatrix.GetLength(1); b++)
            {
                sum += firstMatrix[i, b] * secondMatrix[b, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

void PrintArray(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            Console.Write($"{image[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}