/* Сформировать трехмерный массив не повторяющимися двузначными числами 
показать его построчно на экран выводя индексы соответствующего элемента*/

HashSet<int> numbers = new HashSet<int>();
int GenerateUniqueNumber()
{
    while (true)
    {
        Random r = new Random();
        var n = r.Next(10, 99);
        if (!numbers.Contains(n))
        {
            numbers.Add(n);
            return n;

        }
        if (numbers.Count >= 89)
            return n;
    }
}

int[,,] arr = new int[3, 3, 3];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        for (int k = 0; k < 3; k++)
        {
            arr[i, j, k] = GenerateUniqueNumber();
            Console.WriteLine($"{arr[i, j, k]} индекс {i} {j} {k}");
        }
    }
}

