/* В матрице чисел найти сумму элементов главной диагонали */

// void PrintTable(int[,] table)
// {
//     for (int str = 0; str < table.GetLength(0); str++)
//     {
//         for (int col = 0; col < table.GetLength(1); col++)
//         {
//             Console.Write($" {table[str, col]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillTable(int[,] table)
// {
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++)
//         {
//             table[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// int SumItem(int[,] table)
// {
//     int sum = 0;
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++)
//         {
//             if (j == i) sum += table[i, j];

//         }
//     }
//     return sum;
// }

// Console.WriteLine("введите размер матрицы: ");
// int matrixSize = int.Parse(Console.ReadLine()!);

// int[,] matrix = new int[matrixSize, matrixSize];

// FillTable(matrix);
// PrintTable(matrix);
// Console.WriteLine();
// int result = SumItem(matrix);
// Console.WriteLine($"Сумма элементов диагонали равна {result}");


/* Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.*/

void PrintTable(int[,] table)
{
    for (int str = 0; str < table.GetLength(0); str++)
    {
        for (int col = 0; col < table.GetLength(1); col++)
        {
            Console.Write($" {table[str, col]} ");
        }
        Console.WriteLine();
    }
}

void FillTable(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(1, 10);
        }
    }
}

double[] SumRow(int[,] table)
{
    double[] array = new double[table.GetLength(1)];
    
    for (int i = 0; i < table.GetLength(1); i++)
    {
        double sumrow = 0;
        for (int j = 0; j < table.GetLength(0); j++)
        {
            sumrow += table[j, i];

        }
        sumrow /= table.GetLength(0);
        array[i] = Math.Round(sumrow, 2);
    }
    return array;
}

Console.Write("Введите количество строк двумерного массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов двумерного массива: ");
int columns = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[rows, columns];

FillTable(matrix);
PrintTable(matrix);
Console.WriteLine();
double[] result = SumRow(matrix);
Console.WriteLine(string.Join(", ", result));




