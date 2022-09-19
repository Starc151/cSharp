using static System.Console;
Clear();

/* Задача 2: Напишите программу, которая на вход 
принимает два числа и выдаёт, какое число большее, а 
какое меньшее. */
void zadacha2(){
    Write("Введите первое число: ");
    int number1 = Convert.ToInt32(ReadLine());
    Write("Введите второе число: ");
    int number2 = Convert.ToInt32(ReadLine());

    if (number1 > number2)
    {
        WriteLine($"Первое число {number1} больше, чем второе число {number2}");
    }
    else if (number1 < number2)
    {
        WriteLine($"Певрое число {number1} меньше, чем второе число {number2}");
    }
    else
    {
        WriteLine("Числа одинаковы"); 
    }
}

/* Задача 4: Напишите программу, которая принимает на 
вход три числа и выдаёт максимальное из этих чисел. */
void zadacha4(){
    Write("Введите первое число: ");
    int number1 = Convert.ToInt32(ReadLine());
    Write("Введите второе число: ");
    int number2 = Convert.ToInt32(ReadLine());
    Write("Введите третье число: ");
    int number3 = Convert.ToInt32(ReadLine());
    int max = number1;

    if (max < number2)
    {
        max = number2;
    }
    if (max < number3)
    {
        max = number3;
    }
    WriteLine($"Максимальное число из введённых: {max}");
}

// zadacha2();
zadacha4();
