// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int rows = 4;
int columns = 4;
int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
int sumRow = 0;
int rowIndex = 0;
for (int j = 0; j < array.GetLength(1); j++)
{
    sumRow += array[0, j];
}
for (int i = 0; i < array.GetLength(0); i++)
{
    int tempSum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        tempSum += array[i, j];
    }
    if (tempSum < sumRow)
    {
        sumRow = tempSum;
        rowIndex = i;
    }
}
Console.WriteLine($"Cтрокa с наименьшей суммой элементов: {rowIndex + 1}");

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