/* Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива. */

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

void Streamline(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            for (int k = 0; k < table.GetLength(1) - 1; k++)
            {
                if (table[i, k] < table[i, k + 1])
                {
                    int temp = table[i, k + 1];
                    table[i, k + 1] = table[i, k];
                    table[i, k] = temp;
                }
            }
        }
    }
}

int[,] table = new int[3, 6];
FillTable(table);
PrintTable(table);
Console.WriteLine();
Streamline(table);
PrintTable(table);


