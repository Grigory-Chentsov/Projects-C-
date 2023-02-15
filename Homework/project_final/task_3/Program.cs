/* Найти сумму элементов от M до N, N и M заданы */

int SumNumbersLess(int m, int n)
{  
    if(m > n) return 0;    
    return m + SumNumbersLess(m + 1, n);      
}

int SumNumbersMore(int m, int n)
{  
    if(m < n) return 0;    
    return m + SumNumbersMore(m - 1, n);      
}

int m = 2;
int n = 5;

if(m > n) Console.WriteLine(SumNumbersMore(m, n));
else Console.WriteLine(SumNumbersLess(m, n));

