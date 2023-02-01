/* Показать двумерный массив размером m×n заполненный вещественными числами */

Console.Write("Введите колличество строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите колличество столбцов: ");
int n = int.Parse(Console.ReadLine()!);

void PrintTable(double[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write($"{table[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[,] FillTable(double[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = Math.Round(new Random().NextDouble() * 20 - 10, 3);
        }
    }
    return table;
}

double[,] table = new double[m, n];
FillTable(table);
PrintTable(table);
