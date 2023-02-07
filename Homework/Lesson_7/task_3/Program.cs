/* В прямоугольной матрице найти строку с наименьшей суммой элементов. */

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

void FindMinSumRow(int[,] table)
{
    int[] arraySum = new int[table.GetLength(0)];
    for (int i = 0; i < table.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < table.GetLength(1); j++)
        {
            sum = sum + table[i, j];
        }
        arraySum[i] = sum;
    }

    int min = arraySum[0];
    int indexmin = 0;
    for (int i = 0; i < arraySum.Length; i++)
    {
        if (arraySum[i] < min)
        {
            min = arraySum[i];
            indexmin = i;
        }
    }

    for (int i = 0; i < table.GetLength(0); i++)
    {
        if (i == indexmin)
        {
            for (int col = 0; col < table.GetLength(1); col++)
            {
                Console.Write($" {table[i, col]} ");
            }
        }
        else continue;
    }
    Console.WriteLine($" - cтрока {indexmin + 1} с наименьшей суммой элементов.");
}

int[,] table = new int[4, 6];
FillTable(table);
PrintTable(table);
Console.WriteLine();
FindMinSumRow(table);

