using static System.Console;
Clear();

int xa = 40, ya = 1,  //первая точка
    xb = 1, yb = 30,  //вторая точка
    xc = 80, yc = 30; //третья точка

SetCursorPosition(xa, xb);
Write("+");
SetCursorPosition(xb, yb);
Write("+");
SetCursorPosition(xc, yc);
Write("+");
