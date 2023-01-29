// Двумерные массивы

// string[,] table = new string[2, 3]; // тип данных (,) указывает что будет две размерности (строки и столбцы) 
// table[0,0] table[0,1] table[0,2] 
// table[0,1] table[1,1] table[1,2] 

// table[1, 2] = "Hello";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 3; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }


// int[,] matrix = new int[3, 4];

// for (int str = 0; str < matrix.GetLength(0); str++) // GetLength получает кол-во принятых при создании массива  
// {
//     for (int col = 0; col < matrix.GetLength(1); col++)
//     {
//         Console.Write($"{matrix[str, col]}");
//     }
// Console.WriteLine();
// }


/* Заполнение и печать двумерного массива */
// void PrintArray(int[,] matr)
// {
//     for (int str = 0; str < matr.GetLength(0); str++) // GetLength получает кол-во принятых при создании массива  
//     {
//         for (int col = 0; col < matr.GetLength(1); col++)
//         {
//             Console.Write($" {matr[str, col]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 15);
//         }
//     }
// }

// int[,] matrix = new int[4, 6];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);


/* Закрашивание ячеек двумерного массива */
// Рекурсия - функция вызывает сама себя.
// int[,] pic = new int[,]
// {
// {0, 0, 0, 0, 0, 0, 0, 0},
// {0, 1, 1, 1, 1, 1, 1, 0},
// {0, 1, 0, 0, 0, 0, 1, 0},
// {0, 1, 0, 0, 0, 0, 1, 0},
// {0, 1, 0, 0, 0, 0, 1, 0},
// {0, 1, 1, 1, 1, 1, 1, 0},
// {0, 0, 0, 0, 0, 0, 0, 0},
// };

// void PrintImage(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             if (image[i, j] == 0) Console.Write("  ");
//             else Console.Write(" +");
//         }
//         Console.WriteLine();
//     }
// }

// void FillImage(int row, int col)
// {
//     if (pic[row, col] == 0)
//     {
//         pic[row, col] = 1;
//         FillImage(row - 1, col);
//         FillImage(row, col - 1);
//         FillImage(row + 1, col);
//         FillImage(row, col + 1);
//     }

// }

// PrintImage(pic);
// FillImage(4, 4);
// Console.WriteLine();
// PrintImage(pic);


/* Поиск факториал  рекурсией */

// double Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);

// }
// {
//         for (int i = 1; i < 40; i++)
//         {
//            Console.WriteLine($"{i} = {Factorial(i)}"); 
//         }
        
// }


/* Вывод чисел Фиббоначи при помощи рекурсии */

// double Fibonacci(int n)
// {
//     if (n == 1 || n == 0) return n;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }
// for (int i = 1; i < 10; i++)
// {
//     Console.WriteLine(Fibonacci(i));
// }


/* Обход директории рекурсией */


