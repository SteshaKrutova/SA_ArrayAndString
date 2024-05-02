Console.WriteLine("Hello, World!");

//Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
char[,] CreateMatrix(int len){
    char[,] Matrix = new char[len,len];
    string token = string.Empty;
    for (int i=0; i<len;i++){
        for (int j=0; j<len;j++){
            string str = "A";
            char character = char.Parse(str);
            Matrix[i,j]=character;
    }
    }
    return Matrix;
}
PrintMatrix(CreateMatrix(3));



void PrintMatrix(char[,] Matrix){
    for (int i=0; i<Matrix.GetLength(0);i++){
        for (int j=0; j<Matrix.GetLength(1);j++){
            Console.Write($"{Matrix[i, j]}\t");   
    }
    Console.WriteLine();
    }
}

