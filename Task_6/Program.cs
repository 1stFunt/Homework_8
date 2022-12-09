// Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

int row = ReadInt("Введите количество строк: ");
int[,] pascal = new int[row, row];
const int cellWidth = 3;
FillPascal();
Isosceles();
void FillPascal()
{
    for (int i = 0; i < row; i++)
    {
        pascal[i, 0] = 1;
        pascal[i, i] = 1;
    }
    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            pascal[i, j] = pascal[i - 1, j - 1] + pascal[i - 1, j];
        }
    }
}
void Isosceles()
{
    int col = cellWidth * row;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            if (pascal[i, j] != 0) Console.Write($"{pascal[i, j],cellWidth} ");
            col += cellWidth * 2;
        }
        col = cellWidth * row - cellWidth * (i + 1);
        Console.WriteLine();
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}