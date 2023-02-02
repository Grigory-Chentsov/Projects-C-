/* Задать двумерный массив следующим правилом: Aₘₙ = m+n */

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);

void PrintArray(int[,] table)
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

int[,] FillArray(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = i + j;
        }
    }
    return table;
}

int[,] table = new int[m, n];
FillArray(table);
PrintArray(table);


