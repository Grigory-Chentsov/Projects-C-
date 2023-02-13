/* Найти произведение двух матриц */

void FillArray(int[,] tableA, int[,] tableB, int[,] multitable)
{
    for (int i = 0; i < tableA.GetLength(0); i++)
    {
        for (int j = 0; j < tableA.GetLength(1); j++)
        {
            tableA[i, j] = new Random().Next(1, 10);
        }
    }

    for (int i = 0; i < tableB.GetLength(0); i++)
    {
        for (int j = 0; j < tableB.GetLength(1); j++)
        {
            tableB[i, j] = new Random().Next(1, 10);
        }
    }

    for (int i = 0; i < multitable.GetLength(0); i++)
    {
        for (int j = 0; j < multitable.GetLength(1); j++)
        {
            for (int k = 0; k < tableB.GetLength(0); k++)

                multitable[i, j] += tableA[i, k] * tableB[k, j];
        }
    }
}

void PrintArray(int[,] tableA, int[,] tableB, int[,] multitable)
{
    for (int i = 0; i < tableA.GetLength(0); i++)
    {
        for (int j = 0; j < tableA.GetLength(1); j++)
        {
            Console.Write($"{tableA[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    for (int i = 0; i < tableB.GetLength(0); i++)
    {
        for (int j = 0; j < tableB.GetLength(1); j++)
        {
            Console.Write($"{tableB[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    if (tableA.GetLength(0) != tableB.GetLength(1))
    {
        Console.WriteLine("Матрицы нельзя перемножать.");

    }
    else
        for (int i = 0; i < multitable.GetLength(0); i++)
        {
            for (int j = 0; j < multitable.GetLength(1); j++)
            {
                Console.Write($"{multitable[i, j]} ");
            }
            Console.WriteLine();
        }
}

int[,] tableA = new int[3, 3];
int[,] tableB = new int[3, 3];
int[,] multitable = new int[tableA.GetLength(0), tableB.GetLength(1)];

FillArray(tableA, tableB, multitable);
PrintArray(tableA, tableB, multitable);

