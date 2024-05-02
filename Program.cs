Console.WriteLine("Hello, World!");

//Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
char[,] CreateMatrix(int len){
    char[,] Matrix = new char[len,len];
    string token = string.Empty;
    Console.WriteLine("Please, write " +len*len+ " token: ");
    for (int i=0; i<len;i++){
        for (int j=0; j<len;j++){
            string str = Console.ReadLine();
            char character = char.Parse(str);
            Matrix[i,j]=character;
    }
    }
    return Matrix;
}

void Zadanie1(){
    Console.WriteLine("Pleaze, write someone nember (for example '2' or '3')");
    int len = Convert.ToInt32(Console.ReadLine());
    char[,] Matrix = new char[len,len];
    Matrix = CreateMatrix(len);
    Console.WriteLine();
    Console.WriteLine("A matrix for yours tokens:");
    PrintMatrix(Matrix);
    Console.WriteLine();
    Console.WriteLine("A line for yours tokens:");
    PrintString(MatrixToString(Matrix));
}

string MatrixToString (char[,] Matrix){
    string result = string.Empty;
    for (int i=0; i<Matrix.GetLength(0);i++){
        for (int j=0; j<Matrix.GetLength(1);j++){
            result+=(Matrix[i, j]+" ");   
    }
    }
    return result;
}


void PrintMatrix(char[,] Matrix){
    for (int i=0; i<Matrix.GetLength(0);i++){
        for (int j=0; j<Matrix.GetLength(1);j++){
            Console.Write($"{Matrix[i, j]}\t");   
    }
    Console.WriteLine();
    }
}

void PrintString(string str){
    for (int i=0; i<str.Length;i++){
        Console.Write(str[i]+" ");   
    }
    
}

Zadanie1();