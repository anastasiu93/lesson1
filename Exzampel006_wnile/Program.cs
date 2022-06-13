// Рисуем триугольник Console.SetCursorPosition(10, 4);


Console.Clear();

int xa = 7, ya = 1;
int xb = 1, yb = 7;
int xc =14, yc = 7;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;
int count = 0;
while (count < 10) ;
{
    int what = new Random().Next(0, 3); //от 0 до 3
    if (what == 0) ;
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1) ;
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2) ;
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1;
}