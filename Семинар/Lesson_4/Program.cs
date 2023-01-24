// Задать массив из 8 элементов и вывести их на экран

// void NewArray(int[] array)   
// {
//     int len = array.Length;    
//     int index = 0;  
//     while (index < len)    
//     {
//         array[index] = new Random().Next(1, 8); 
//         index++;
//     }
// }

// int[] array = new int[8];
// NewArray(array);
// Console.WriteLine(string.Join(", ", array));


/* Задать массив из 12 элементов, заполненных числами из [-9, 9].
 Найти сумму положительных/отрицательных элементов массива */

// void NewArray(int[] array)
// {
//     int len = array.Length;
//     int index = 0;
//     while (index < len)
//     {
//         array[index] = new Random().Next(-9, 9);
//         index++;
//     }
// }

// int[] array = new int[12];
// NewArray(array);
// int sum_1 = 0;
// int sum_2 = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] < 0)
//     {
//         sum_1 = sum_1 + array[i];
//     }
//     else if (array[i] > 0)
//     {
//         sum_2 = sum_2 + array[i];
//     }
// }


// Console.WriteLine(string.Join(", ", array));
// Console.WriteLine($"{sum_1}, {sum_2}");


// Написать программу замену элементов массива на противоположные


void NewArray(int[] array)
{
    int len = array.Length;
    int index = 0;
    while (index < len)
    {
        array[index] = new Random().Next(-100, 100);
        index++;
    }
}

int[] array = new int[10];
NewArray(array);
Console.WriteLine(string.Join(", ", array));

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
}


Console.WriteLine(string.Join(", ", array));



