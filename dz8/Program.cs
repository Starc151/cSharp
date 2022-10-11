using static System.Console;
Clear();

int[,] GetMatrix(){
    int[,] inArr=new int [4, 4];
    Random rnd=new Random();
    for(int i=0; i<4; i++){
        for(int j=0; j<4; j++){
            inArr[i, j]=rnd.Next(0, 11);
        }
    }
    return inArr;
}
 void PrintMatrix(int[,] inArr){
    for(int i=0; i<inArr.GetLength(0); i++){
        for(int j=0; j<inArr.GetLength(1); j++){
            Write($"{inArr[i, j]} ");
        }
        WriteLine();
    }
 }
 int[,] arrForDz8=GetMatrix();
  PrintMatrix(arrForDz8);
