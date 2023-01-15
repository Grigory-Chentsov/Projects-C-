Console.Clear();    // оператор очистки консоли
// Console.SetCursorPosition(10, 4);   // указывает отступ от краёв консоли
// Console.WriteLine("+");

int xa = 40;
int ya = 1;
int xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = ya;

int count = 0;

while(count < 10000)
{
    int what = new Random().Next(0, 3); // генерируем случайное число для выбора точки
    if(what == 0)   // определяем середину отрезка
    {
        x = (x+xa)/2;
        y = (y+ya)/2;
    }

    if(what == 1)   // определяем середину отрезка
    {
        x = (x+xb)/2;
        y = (y+yb)/2;
    }

    if(what == 2)   // определяем середину отрезка
    {
        x = (x+xc)/2;
        y = (y+yc)/2;
    }

    Console.SetCursorPosition(x , y);
    Console.WriteLine("+");
    count++ ;   // увеличение счетчика на единицу
}
