 

   /* 
  int[] myArray = CreateRandomArray(length,min,max);  
  ShowArray(myArray); 
int[] CreateRandomArray(int size,int minValue,int maxValue) 

  {  
    int [] array = new int [size];  
    for( int i =0;i< size; i++)  
        array[i] = new Random().Next(minValue,maxValue +1);  
        return array;  
  }  
  void ShowArray(int[]array)  
  {  
    for(int i = 0; i < array.Length ; i ++)  
    Console.Write(array[i] + "");  
    Console.WriteLine();  
  }  
  Console.Write("Input a length of new array:");  
  int length = Convert.ToInt32(Console.ReadLine());  
  Console.Write("Input a min possible value:");  
  int min = Convert.ToInt32(Console.ReadLine());  
  Console.Write("Input a max possible value:");  
  int max = Convert.ToInt32(Console.ReadLine());  
    
  int[] myArray = CreateRandomArray(length,min,max);  
  ShowArray(myArray);   
  */
  //Задача 21.Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.  

  /*   
  int x1 = ReadInt("Введите координату X первой точки: ");
int y1 = ReadInt("Введите координату Y первой точки: ");
int z1 = ReadInt("Введите координату Z первой точки: ");
int x2 = ReadInt("Введите координату X второй точки: ");
int y2 = ReadInt("Введите координату Y второй точки: ");
int z2 = ReadInt("Введите координату Z второй точки: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {length}");
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}  

 
 
*/    
// Задача 23.Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.  
/*
int number = ReadInt("Введите число N: ");

for (int i = 1; i <= number; i++)
{ 
    Console.Write($"{i*i*i} ");
}  
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}  
*/  
// Задача 19.Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.  
/*  
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
 if (number[0] == number[4] && number[1] == number[3])
    {
 Console.WriteLine($"{number} - Палиндром");
    }
 else
    {
 Console.WriteLine($"{number} - НЕ палиндром");
    }
}
else
{
 Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
}  
*/    
// Задача 19.Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.  
/* 

void CheckPalindromicNumber(int number)
{
    if(number >= 10000)
    {
        int division1 = number / 10000;
        int remainder1 = number % 10;
 
            if(division1 == remainder1)
            {
                number = number / 10;
                int division2 = number / 100;
                int remainder2 = number % 10;
                if(division2 == remainder2)
                    Console.WriteLine("Да");
            }
            else 
            Console.WriteLine("Нет");
            
    }
    else
    Console.WriteLine("Некорректное число!");
}
 
Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine()!);
CheckPalindromicNumber(number);  
*/    
// Задача 19.Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.   
/*
 Console.Write("Enter a number to check if palindrome: ");
        bool palindrome = true;
        int x = int.Parse(Console.ReadLine());int c = x.ToString().Length - 1;
        string b = x.ToString();
        for (int i = 0; i < c; i++)
            if (b[i] != b[c - i])
                palindrome = false;
        if (palindrome == true)
            Console.Write("Yes");
        else Console.Write("No");
        Console.ReadKey();  
  */  
        


