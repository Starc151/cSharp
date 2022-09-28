using static System.Console;
Clear();

int[] MaxDuplicate(int numElements, int numSought){
    int count=0;
    int[] result= {0, numElements, numSought};
    int[] arr = new int[numElements];
    for (int i=0; i<numElements; i++){
        arr[i] = new Random().Next(0, 2);
        if(arr[i]==numSought){count++;}
        else {
            if(result[0]<count){result[0]=count;}
            count=0;
        }
    }
    //Красивый вывод масива (взято из инета)
    WriteLine("[{0}]", string.Join(", ", arr));
    
    // конечная проверка на максимальный результат
    if(result[0]<count){result[0]=count;}
    WriteLine();
    return result;    // Возвращает массив, где result[0] ответ, result[1], длина массива, result[2] искомый элемент
}
WriteLine("Введите длину массива");
int length = Convert.ToInt32(ReadLine());
WriteLine("Введите элемент для поиска");
int sought = Convert.ToInt32(ReadLine());
int[] maxDuplicate = MaxDuplicate(length, sought);
WriteLine($"В массиве длинной {maxDuplicate[1]}, элемент {maxDuplicate[2]} встречается максимум {maxDuplicate[0]} раз подряд");
