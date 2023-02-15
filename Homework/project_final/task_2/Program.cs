/* Показать натуральные числа от M до N, N и M заданы */

int M = 18;
int N = 12;

void MmoreNprint(int M, int N)
{
    if (M >= N)
    {
        Console.Write(M + " ");
        MmoreNprint(M - 1, N);
    }
}

void MlessNprint(int M, int N)
{
    if (M <= N)
    {
        MlessNprint(M, N - 1);
        Console.Write(N + " ");
    }

}

if(M > N) MmoreNprint(M, N);
else MlessNprint(M, N);
