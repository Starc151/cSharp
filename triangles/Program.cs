using static System.Console;
Clear();

int xa = 40, ya = 1,  //первая точка
    xb = 1, yb = 30,  //вторая точка
    xc = 80, yc = 30; //третья точка

    int x = xa, y = xb; //??????
    
for (int count=0; count<10000; count++){
    int what = new Random().Next(1, 4); // Выбор случачйной вершины
    if (what==1){
        x=(x+xa)/2;
        y=(y+ya)/2;
    }
    if (what==2){
        x=(x+xb)/2;
        y=(y+yb)/2;
    }
    if (what==3){
        x=(x+xc)/2;
        y=(y+yc)/2;
    }
    
    SetCursorPosition(x, y);
    Write("+");
}