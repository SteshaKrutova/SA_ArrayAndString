//Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

// This function create matrix 
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

// This function makes of Matrix to String
string MatrixToString (char[,] Matrix){
    string result = string.Empty;
    for (int i=0; i<Matrix.GetLength(0);i++){
        for (int j=0; j<Matrix.GetLength(1);j++){
            result+=(Matrix[i, j]+" ");   
    }
    }
    return result;
}

// This functin print matrix 
void PrintMatrix(char[,] Matrix){
    for (int i=0; i<Matrix.GetLength(0);i++){
        for (int j=0; j<Matrix.GetLength(1);j++){
            Console.Write($"{Matrix[i, j]}\t");   
    }
    Console.WriteLine();
    }
}

// This function print string
void PrintString(string str){
    for (int i=0; i<str.Length;i++){
        Console.Write(str[i]+" ");   
    }
}

// This function lauches task number one
void Zadanie1(){
    Console.WriteLine("Please, write something number (for example '2' or '3')");
    int len = Convert.ToInt32(Console.ReadLine());
    char[,] Matrix = new char[len,len];
    Matrix = CreateMatrix(len);
    Console.WriteLine();
    Console.WriteLine("A matrix for yours tokens:");
    PrintMatrix(Matrix);
    Console.WriteLine();
    Console.WriteLine("A line for yours tokens:");
    PrintString(MatrixToString(Matrix));
    Console.WriteLine();
}

//Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой
//все заглавные буквы заменены на строчные.

//This function create string 
string CreateString(){
    Console.WriteLine("Please write something: ");
    string str = string.Empty;
    str = Console.ReadLine();
    str = str.ToString();
    return str;
}

// This function replaces all uppercase letters with lowercase
string UpperToLower(string str){
    string result = string.Empty;
    foreach (var c in str)
            {
                if (char.IsUpper(c))
                    result += char.ToLower(c);
                else
                    result += c;
            }
    return result;
}

// This function lauches task number two
void Zadanie2(){
    Console.WriteLine("Please write a few different characters");
    string str = CreateString();
    Console.WriteLine();
    Console.WriteLine("Your tokens after: ");
    Console.WriteLine(UpperToLower(str));
}

// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.


// This function defines a polynomial that or no
 void Polinom (string str){
 int len = str.Length;
 int j=len;
 bool result=true;
 for (int i=0; i<len;i++){
    if (str[i]!=str[j-1]){
        Console.WriteLine("Нет");
        result=false;
        break;
    }
    j=j-1;
 }
 if (result==true)
 Console.WriteLine("Да");
 }

//This function launches decision task number three
void Zadanie3(){
    Console.WriteLine("This function defines a polynomial that or no");
    Polinom(CreateString());
}

// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.

// This function forms a string in which all the words are arranged in reverse order
void SixtyNine(string str){
    int len = str.Length; 
    string result = "";
    string TempStr = string.Empty; 
    int hz = 2;
    for(int i=len-1;i>=0;i--){
        TempStr = TempStr + str[i];
        if (str[i].ToString()==" " || i==0){
            for (int j=TempStr.Length-hz; j>=0;j--){
                   hz=1;
                result = result + TempStr[j];
            }
            TempStr= string.Empty;
            result+=" ";
        }
    }
    Console.WriteLine(result);
}

// This function launch task number four
void Zadanie4(){
    Console.WriteLine("Please, write somethig with spaces!!!");
    SixtyNine(CreateString());
}


// This function calls all task

void MainFunction(){
    Zadanie1();
    Console.WriteLine();
    Zadanie2();
    Console.WriteLine();
    Zadanie3();
    Console.WriteLine();
    Zadanie4();
}

MainFunction();