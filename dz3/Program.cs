using static System.Console;
Clear();

/*Задача 19 Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.*/
void zadacha19(){
    Write("Введите 5тизначное число: ");
    int num = Convert.ToInt32(ReadLine());  // ??!!
    if(num<10000||num>99999){return;};
    if((num%10==num/10000)&&(num/10%10==num/1000%10)){
        Write("Да");
    }
    else{
      Write("Нет");  
    }
}
//zadacha19();