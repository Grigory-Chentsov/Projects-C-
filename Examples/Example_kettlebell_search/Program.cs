int a = 1;
int b = 4;
int c = 3;
int d = 7;
int e = 2;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = a;

Console.WriteLine(max);
