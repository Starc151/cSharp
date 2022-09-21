using static System.Console;
Clear();

/* Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа. */
void zadacha10(){
    Write("Введите 3х-значное число: ");
    int number = Convert.ToInt32(ReadLine());
    Write(number/10%10);
    
}


zadacha10();