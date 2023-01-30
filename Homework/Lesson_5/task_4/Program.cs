// Написать программу копирования массива

int[] array = { 81, 42, 83, 465, 52, 56, 7, 78, 390, 336, 335, 244, 6573, 4332, 61 };

int[] CopyArray(int[] array)
{
    int[] copy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copy[i] = array[i];
    }
    return copy;
    // Console.WriteLine(string.Join(", ", copy));
}
int[] copy = CopyArray(array);

Console.WriteLine(string.Join(", ", copy));

