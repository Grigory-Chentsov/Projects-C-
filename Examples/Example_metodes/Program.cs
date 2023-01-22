/* 1.Метод ничего не принимает и ничего не возвращает (void) */

// void Method1()
// {
//     Console.WriteLine("Hello, ...");
// }

// Method1();   // Вызов метода ()- обязательны

/* 2.Метод что-то принимает но ничего не возвращает */

// void Metod2(string msg)     // где void ключевое слово, название, в скобках указаны какие-то аргументы
// {
//     Console.WriteLine(msg);
// }
// Metod2("“Текст сообщения”");  // где Metod2 является названием, а в скобках текст, выводимый в консоли.

// void Method21(string msg, int count)    // именованные аргументы можно передавать в разном порядке
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }

// Method21(count: 4, msg: "Текст сообщения.");
/* Для выхода из зацикливания использовать ctrl + C */

/* 3.Метод что-то возвращает но ничего не принимает */

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();    // вызываем метод, создаём переменную и присваивания ей возвращенние функции

// Console.WriteLine(year);

/* 4.Методы, которые что-то принимают и что-то возвращают */

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;   // создаёт пустую строку
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(count: 10, text: " Пример");
// Console.WriteLine(res);


/* использование цикла for */

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine();
// }


/* ===== Работа с текстом
Дан текст. В тексте нужно все пробелы заменить чёрточками, маленькие буквы “к” заменить большими “К”,
а большие “С” маленькими “с”. =====*/

// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
//                 +"ежели бы вас послали вместо нашего милого Винценгероде,"
//                 +"вы бы взяли приступом согласие прусского короля."
//                 +"Вы так красноречивы. Вы дадите мне чаю?";

// string Replace(string text, string oldSymbol, string newSymbol)
// {
//     string newtext = String.Empty;
//     int len = text.Length;
//     for (int i = 0; i < len; i++)
//     {
//         if (text[i].ToString() == oldSymbol)
//         {
//             newtext = newtext + $"{newSymbol}";
//         }
//         else
//             newtext = newtext + $"{text[i]}";
//     }
//     return newtext;
// }

// string result = Replace(text, " ", "_");
// Console.WriteLine(result);
// Console.WriteLine();
// result = Replace(text, "к", "К");
// Console.WriteLine(result);


/* Упорядочить массив (sort) */

// int[] numbers = {1, 55, 3, 8, 2, 9, 0, 6, 4};

// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.WriteLine(array[i]);
//     }
//     Console.WriteLine();
// }

// void Sorted(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPos = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPos])
//             {
//                 minPos = j;
//             }
//         }
//         int temp = array[i];
//         array[i] = array[minPos];
//         array[minPos] = temp;
//     }
// }
// PrintArray(numbers);
// Sorted(numbers);
// PrintArray(numbers);


