using static System.Console;
Clear();

void MaxDuplicate(int numElements, int numDesired){
    int count=0, result=0;
    int[] arr = new int[numElements];
    for (int i=0; i<numElements; i++){
        arr[i] = new Random().Next(0, 2);
        // Write($"{arr[i]}/, ");
        //
        if(arr[i]==numDesired){
            count++;
        } else {
            if(result<count){
                result=count;
            }
            count=0;
        }
        // выводит элемент массива/счетчик/результат для ручной проверки
        Write($"{arr[i]}/{count}/{result}, ");
    }
    if(result<count){
        result=count;
    }

    WriteLine();
    Write(result);    

}

MaxDuplicate(20, 0);
