/* Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить 
   что это невозможно (в случае, если матрица не квадратная). */

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

void ChangeMatrix(int[,] table)
{
    if (table.GetLength(0) == table.GetLength(1))
    {
        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = i + 1; j < table.GetLength(1); j++)
            {
                int temp = table[i, j];
                table[i, j] = table[j, i];
                table[j, i] = temp;
            }
        }
        PrintTable(table);
    }
    else Console.WriteLine("Матрица не квадратная.");
}


int[,] table = new int[4, 4];
FillTable(table);
PrintTable(table);
Console.WriteLine();
ChangeMatrix(table);



