Console.Clear();

int xa = 40, ya = 0,
    xb = 0,  yb = 40,
    xc = 79, yc = 40;

Console.SetCursorPosition(xa,ya);
Console.Write('+');
Console.SetCursorPosition(xb,yb);
Console.Write('+');
Console.SetCursorPosition(xc,yc);
Console.Write('+');

int x = xa, y = ya;
int counter = 0;

while (counter <10000)

{
    int a = new Random().Next(0,3);

    if (a == 0)
        {x = (x+xa)/2;
        y = (y+ya)/2;}

    if (a == 1)
        {x = (x+xb)/2;
        y = (y+yb)/2;}

    if (a == 2)
        {x = (x+xc)/2;
        y = (y+yc)/2;}

    Console.SetCursorPosition(x,y);
    Console.Write('#');
    counter++;
}

Console.WriteLine('#');
