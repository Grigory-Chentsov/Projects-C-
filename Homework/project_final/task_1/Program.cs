/* Показать натуральные числа от N до 1, N задано */

int N = 8;

void PrintNumber(int N)
{
    if(N < 1) return;
    Console.Write(N + " ");
    PrintNumber(N - 1);    
}

PrintNumber(N);
