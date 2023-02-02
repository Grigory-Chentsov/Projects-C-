/* Написать программу, которая обменивает элементы первой строки и последней строки */

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

void ChangeRow(int[,] table)
{
    int len = table.GetLength(1) - 1;
    for (int i = 0; i < table.GetLength(0); i++)
    {
        if (i == 0)
            for (int j = 0; j < table.GetLength(1); j++)
            {
                int temp = table[i, j];
                table[i, j] = table[len, j];
                table[len, j] = temp;
            }
    }
}

int[,] table = new int[10, 10];
FillTable(table);
PrintTable(table);
Console.WriteLine();
ChangeRow(table);
PrintTable(table);

