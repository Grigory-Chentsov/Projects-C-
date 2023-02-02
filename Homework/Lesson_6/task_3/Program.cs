/* В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты */

void PrintTable(double[,] table)
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

void FillTable(double[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(1, 15);
        }
    }
}

double[,] ChangeTable(double[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        if (i % 2 == 0)
            for (int j = 0; j < table.GetLength(1); j++)
                if (j % 2 == 0)
                {
                    table[i, j] = Math.Pow(table[i, j], 2);
                }
    }
    return table;
}

double[,] table = new double[6, 6];
FillTable(table);
PrintTable(table);
Console.WriteLine();
ChangeTable(table);
PrintTable(table);

