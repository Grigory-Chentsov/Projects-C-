// По заданному номеру дня недели вывести его название

string[] days = {"Понедельник", "Вторник", "Среда",
               "Четверг", "Пятница", "Суббота", "Воскресенье"};

Console.WriteLine("Введите число от 1 до 7.");
int number_user = Convert.ToInt32(Console.ReadLine()) - 1;

Console.WriteLine(days[number_user]);
