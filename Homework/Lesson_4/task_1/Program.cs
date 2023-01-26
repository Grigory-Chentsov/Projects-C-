// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

void ZerOne(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(0, 2);

    }
}

void print_ZerOne(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        Console.WriteLine(array[i]);

    }
}


int[] array = new int[8];

ZerOne(array);
print_ZerOne(array);
// Console.WriteLine(string.Join(", ", array));
