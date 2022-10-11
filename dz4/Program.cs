using static System.Console;
Clear();

/*Задача 25: Напишите метод, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B с использованием цикла.*/
int GetDegree(int num1, int num2){
    int result=1;
    for(int i=1; i<=num2; i++){
        result *= num1;
    }
    return result;         // В задаче не указано, что функция должна результат вернуть или вывести
}

/*Задача 27: Напишите метод, который принимает на вход число
и выдаёт сумму цифр в числе.*/
int GetSum(int num){
    int sum = 0;
    while(num>0){
        sum+=num%10;
        num=num/10;
    }
    return sum;
}

/*Задача 29: Напишите метод, который формирует массив из 8 случайных элементов
и выводит их на экран.*/
void GetArray(){
    int[] arr= new int[8];
    Write("[");
    for(int i=0;i<arr.Length-1;i++){
        arr[i] = new Random().Next(0, 101);
        Write($"{arr[i]}, ");
    }
    Write($"{arr[7]}]");
}

WriteLine(GetDegree(3, 5));
WriteLine(GetSum(452));
GetArray();
