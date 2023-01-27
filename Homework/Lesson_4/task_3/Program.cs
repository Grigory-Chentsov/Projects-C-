/* Задать массив, заполнить случайными положительными трёхзначными числами.
   Показать количество нечетных\четных чисел */

Console.WriteLine("Сколько элементов должно быть в массиве?");
int amount = int.Parse(Console.ReadLine()!);

void FillArray(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
        array[i] = new Random().Next(100, 1000);
}

void PrintNumber(int[] array)
{
    int length = array.Length;
    int even = 0;
    int odd = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] % 2 == 0)
            even += 1;
        else
            odd += 1;
    }
    Console.WriteLine($"В массиве {even} чётных и {odd} нечётных чисел.");
}

int[] array = new int[amount];
FillArray(array);
PrintNumber(array);

Console.WriteLine(string.Join(", ", array));
