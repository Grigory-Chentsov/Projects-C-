// Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("Поиск кубов последовательных чисел, с окончанием на чётную цифру.");
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
var numbers = new List<int>();

for (int i = 0; i <= N; i++)
{
    int cube = i * i * i;
    int last_num = cube % 10;
    if (last_num % 2 == 0)
    {
        numbers.Add(cube);
    }
    Console.WriteLine(cube);
    
}
Console.WriteLine(string.Join(", ", numbers));



