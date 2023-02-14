/* Показать натуральные числа от M до N, N и M заданы */

int M = 18;
int N = 12;

void MmoreNPrint(int M, int N)
{
    if (M >= N)
    {
        Console.Write(M + " ");
        MmoreNPrint(M - 1, N);
    }
}

void MlessNPrint(int M, int N)
{
    if (M <= N)
    {
        MlessNPrint(M, N - 1);
        Console.Write(N + " ");
    }

}

if(M > N) MmoreNPrint(M, N);
else MlessNPrint(M, N);
