// Показать натуральные числа от 1 до N, N задано
// int n = 6;

// void PrintArray(int n)
// {
//     if (n > 1)           
//     PrintArray(n-1);   
//     Console.Write(n + " ");
// }

// PrintArray(n);


// Найти сумму цифр числа

// int SumItem(int n)
// {
//     if(n < 10) return n;
//     return n % 10 + SumItem(n / 10);   
// }
// Console.WriteLine("Введите N:");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(SumItem(n));

// Написать программу возведения числа А в целую стень B

int Function(int a, int b)
{
    if(b==0) return 1;
    return a * Function(a, b - 1);   
}

int a = 2;
int b = 0;
Console.WriteLine(Function(a, b));


