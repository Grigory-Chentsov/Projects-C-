/* Написать программу вычисления функции Аккермана */

int FuncAck(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return FuncAck(m - 1, 1);
    }
    else return FuncAck(m - 1, FuncAck(m, n - 1));
}

int m = 1;
int n = 1;

if(m > 3 || n > 4 || m < 0 || n < 0) Console.WriteLine("Stack overflow.");
else Console.WriteLine(FuncAck(m, n));

