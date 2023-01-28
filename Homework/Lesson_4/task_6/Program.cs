/* Найти произведение пар чисел в одномерном массиве.
   Парой считаем первый и последний элемент, второй и предпоследний и т.д. */

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
int[]? sum_arr = {};

for (int i = 0; i < array.Length / 2; i++)
{
    int sum = array[i] * array[array.Length - 1 - i];
    sum_arr = sum_arr.Append(sum).ToArray();
}

Console.WriteLine(string.Join(",", sum_arr));
