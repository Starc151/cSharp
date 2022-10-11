using static System.Console;
Clear();

//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int GetNumberPositive(int[] arr){
    int count=0;
    foreach(int i in arr){
        if(i>0){count++;}
    }
    return count;
}
/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.*/
double[] Crossroad(double b1, double k1, double b2, double k2){
    double[] crossroad=new double[2];
    crossroad[0]=Math.Round((b2-b1)/(k1-k2), 2);
    crossroad[1]=Math.Round(k1*crossroad[0]+b1, 2);
    return crossroad;
}

Write("Введите несколько чисел: ");
int[] arr=Array.ConvertAll(ReadLine().Split(new char[]{' ', ',', '.'}, StringSplitOptions.RemoveEmptyEntries), int.Parse);
WriteLine($"Чисел больше 0 среди введёных: {GetNumberPositive(arr)}");

Write("Введите значение b1: ");
double b1=Convert.ToDouble(ReadLine());
Write("Введите значение k1: ");
double k1=Convert.ToDouble(ReadLine());
Write("Введите значение b2: ");
double b2=Convert.ToDouble(ReadLine());
Write("Введите значение k2: ");
double k2=Convert.ToDouble(ReadLine());
double[] crossroad=Crossroad(b1, k1, b2, k2);
WriteLine($"Координаты пересечения отрезков X={crossroad[0]}, Y={crossroad[1]}");
