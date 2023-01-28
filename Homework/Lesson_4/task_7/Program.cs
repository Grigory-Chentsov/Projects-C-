// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] array = { 15, 56.22, 0.0, 12423, -232336.11, 0, 1, -1, 2.245, 845 };

double min = 0;
double max = 0;

void Find_Min_Max(double[] aray)
{
    int len = array.Length;

    for (int i = 0; i < len; i++)
    {
        if (array[i] < min) min = array[i];
        else if (array[i] > max) max = array[i];
    }
}

Find_Min_Max(array);
double diff = max - min;

Console.WriteLine($"Разница между максимальным {max} и минимальным {min} элементами \nравна {diff}");
