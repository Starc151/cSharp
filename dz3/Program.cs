using static System.Console;
using static System.Math;
Clear();

/*Задача 19 Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.*/
void zadacha19(){
    Write("Введите 5тизначное число: ");
    int num = Convert.ToInt32(ReadLine());
    if(num<10000||num>99999){return;};
    if((num%10==num/10000)&&(num/10%10==num/1000%10)){
        Write("Да");
    }
    else{
      Write("Нет");  
    }
}

/*Задача 21 Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
Возможно перемудрил, но хотелось поэкспериментировать*/
// AB = √(b[0] - a[0])2 + (b[1] - a[1])2 + (b[2] - a[2])2
void zadacha21(){
  int[] DistanceAB(string text){
    int[] arr = new int[3];
    WriteLine($"Введите координаты {text} точки через enter: ");
    for (int i=0; i<3; i++){
      arr[i]=Convert.ToInt32(ReadLine());
    }
    return arr;
  } 
  int[] a=DistanceAB("первой");
  int[] b=DistanceAB("второй");
  Write(Round(Sqrt(Pow((b[0] - a[0]), 2)+Pow((b[1] - a[1]), 2)+Pow((b[2] - a[2]), 2)), 2));
}

/*Задача 23 Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N.*/
void zadacha23(){
  Write("Введите число: ");
  int num = Convert.ToInt32(ReadLine());
  for (int i=1; i<num; i++){
    Write($"{Pow(i, 3)}, ");
  }
  Write(Pow(num, 3)); //вывел за цикл, для удаления последней запятой при выводе. Вариантов было несколько, но понравился этот
}
//zadacha19();
// zadacha21();
zadacha23();
