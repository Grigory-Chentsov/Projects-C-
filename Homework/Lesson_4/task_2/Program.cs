// Определить, присутствует ли в заданном массиве, некоторое число

int FindNum(int[] numbers, int num)
{
    int len = numbers.Length;
    int index = 0;
    for (int i = 0; i < len; i++)
    {
        if (numbers[i] == num)
            index = i;
        // Console.WriteLine($"Да число {num} есть в массиве под индексом {i}.");
    }
    return index;
}

int[] numbers = { 1, 46, 7865, 4445, 35, 7, 89, 4, 5, 0, 32, 5, 34, 98 };

Console.WriteLine("Введите искомое число: ");
int num = int.Parse(Console.ReadLine()!);

int find = FindNum(numbers, num);
if (find == 0)
    Console.WriteLine($"Число {num} не найдено в массиве.");
else
    Console.WriteLine($"Число {num} есть в массиве под индексом {find}.");
