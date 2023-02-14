/* Составить частотный словарь элементов двумерного массива */

// 1) Есть набор данных { 1, 9, 9, 0, 2, 8, 0, 9 }
// int[] array = new int[] { 1, 9, 9, 0, 9, 2, 8, 0, 9 };

// var mass = array.GroupBy(x => x); 
// foreach (IGrouping<int, int> group in mass)
//     Console.WriteLine($"Число {group.Key} встречается {group.Count()} раз");

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int m = 6;
int n = 6;
int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine();


int[,] dictionary = new int[m * n, 2];
int count = 0;

bool exist = false;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        exist = false;
        for (int k = 0; k < count; k++)
        {
            if (dictionary[k, 0] == array[i, j])
            {
                dictionary[k, 1]++;
                exist = true;
                break;
            }
        }
        if (exist == false)
        {
            dictionary[count, 0] = array[i, j];
            dictionary[count, 1]++;
            count++;
        }
    }
}

for (int i = 0; i < count; i++)
{
    for (int j = 0; j < dictionary.GetLength(1); j++)
    {
        Console.Write($"{dictionary[i, j]} "); 
    }
    Console.WriteLine();
}

