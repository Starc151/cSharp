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
    // WriteLine(result);
}
GetDegree(3, 5);
