// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

void NumArray(int[] array)
{
    int len = array.Length;
    int count = 0;
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(0, 124);
        {
            if (array[i] >= 10 && array[i] <= 99)
                count += 1;
        }
    }
    Console.WriteLine($"{count}");
}


int[] array = new int[123];
NumArray(array);
Console.WriteLine(string.Join(", ", array));
