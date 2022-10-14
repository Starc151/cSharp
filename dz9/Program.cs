using static System.Console;
Clear();
//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
string GetNtoOne(int n){
    return (n==1)?n.ToString():n+" "+GetNtoOne(n-1);
}
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
int GetMtoN(int n, int m, int summ){
    return (n==m)?summ+m:GetMtoN(n+1, m, summ+=n);
}
//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int Akkerman(int n, int m){
    if (n==0){return m+1;}
    else if ((n!=0) && (m==0)){return Akkerman(n-1, 1);}
    else {return Akkerman(n - 1, Akkerman(n, m - 1));}
}


Write("Введите число n: ");
int n=Convert.ToInt32(ReadLine()!);
Write("Введите число m: ");
int m=Convert.ToInt32(ReadLine()!);

WriteLine($"От n до 1: {GetNtoOne(n)}");
WriteLine($"От n до m: {GetMtoN(n, m, 0)}");
WriteLine($"Функция Аккермана(n, m): {Akkerman(n, m)}");
