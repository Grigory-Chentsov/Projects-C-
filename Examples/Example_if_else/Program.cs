Console.Write("Введите ваше имя: ");

string? username = Console.ReadLine();

if (username!.ToLower() == "вика")   // преобразует слово в нижний регистр
{
    Console.Write("Привет Викуся!");
}
else
{
    Console.Write("Привет ");
    Console.WriteLine(username);
}