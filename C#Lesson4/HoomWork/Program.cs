//Напишите программу,которая по заданному номеру четверти,показывает диапозон возможных координат точек в этой четверти(х и у).  
/*  
void ShowCoordinate(int quadNum)    

{  
    if (quadNum <= 0 || quadNum > 4) Console.WriteLine("uncorrect");  
    else if (quadNum == 1) Console.WriteLine("x > 0, y > 0");  
    else if (quadNum == 2) Console.WriteLine("x < 0 , y > 0");  
    else if (quadNum == 3) Console.WriteLine("x < 0, y < 0");  
    else if (quadNum == 4) Console.WriteLine("x > 0, y < 0 ");  
}   
  
  Console.Write("Input a quad nunber:");  
  int num = Convert.ToInt32(Console.ReadLine());  
  ShowCoordinate(num);  
  */  
  // Напишите программу, которая принемает на вход число (N) и выдает квадраты чисел от 1 до N.   
  /*

  void Shown(int num)  
  {  
     int current = 1;  
     if (num <= 0) Console.WriteLine("Error num");  
     else  
     {  
        while (current <= num)  
        {  
            Console.Write(Math.Pow(current,2) + "");  
            current++;  
        }  
     }  
  }  
  Console.Write("Input a number:");  
  int num = Convert.ToInt32(Console.ReadLine());  
  Shown(num);    
  */    
  //Задача 25.Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.  
  /*
  void ToDegree(int a, int b)
{
 int result = 1;
 for (int i = 1; i <= b; i++)
    {
 result = result * a;
    }
 Console.WriteLine(result);
}  
int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите число B: ");
ToDegree(numberA, numberB);  
int ReadInt(string message)
{
 Console.WriteLine(message);
 return Convert.ToInt32(Console.ReadLine());
}

  //Напишите программу, которая принемает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.  
  /*   

    double LenthPoint(double xA, double yA, double xB, double yB)  
    {  
        double kat1 = xB - xA;  
        double kat2 = yB - yA;  
        double gip = Math.Sqrt(Math.Pow(kat1,2) + Math.Pow(kat2,2));  
        return gip;  
    }  
    Console.Write("Input xA");  
    double xA = Convert.ToDouble(Console.ReadLine());  
    Console.Write("Input yA");  
    double yA = Convert.ToDouble(Console.ReadLine());  
    Console.Write("Input xB:");  
    double xB = Convert.ToDouble(Console.ReadLine());  
    Console.Write("Input yB: ");  
    double yB = Convert.ToDouble(Console.ReadLine());  
    double result = LenthPoint(xA,yA,xB,yA);  
    Console.WriteLine(Math.Round(result,2));  
    */   
   //Задача 25.Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.  
  /*
  void ToDegree(int a, int b)
{
 int result = 1;
 for (int i = 1; i <= b; i++)
    {
 result = result * a;
    }
 Console.WriteLine(result);
}  
int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите число B: ");
ToDegree(numberA, numberB);  
int ReadInt(string message)
{
 Console.WriteLine(message);
 return Convert.ToInt32(Console.ReadLine());
}  
*/   
// Задача 27.Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
  void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}  
int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}  
int number = ReadInt("Введите число: ");
int len = NumberLen(number);
SumNumbers(number, len);  
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
    
