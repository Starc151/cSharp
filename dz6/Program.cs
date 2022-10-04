using static System.Console;
Clear();

//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Write("Введите ряд чисел:");
int[] arr=Array.ConvertAll(ReadLine().Split(new char[]{' ', ',', '.'}, StringSplitOptions.RemoveEmptyEntries), int.Parse);
int GetNumberPositive(int[] arr){
    int count=0;
    foreach(int i in arr){
        count++;
    }
    return count;
}
Write($"Чисел больше 0 среди введёных: {GetNumberPositive(arr)}");
