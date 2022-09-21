using static System.Console;
Clear();

/* Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.*/
void zadacha10(){
    Write("Введите 3х-значное число: ");
    int number = Convert.ToInt32(ReadLine());
    Write(number/10%10);
    
}

/*Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет.*/
void zadacha13(){
    Write("Введите число: ");
    int number = Convert.ToInt32(ReadLine());
    if (number<100){
        Write("третьей цифры нет");
        return;
    };
    while(number>1000){
        number/=10;
    }
    Write(number%10);
}

/*Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.*/
void zadacha15(){
    Write("Введите число: ");
    int number = Convert.ToInt32(ReadLine());
    if ((number<1)||(number>7)){return;};
    if ((number==6)||(number==7)){
        Write("ДА!");
    } else {
        Write("нет :(");
    }
}
// zadacha10();
// zadacha13();
zadacha15();

