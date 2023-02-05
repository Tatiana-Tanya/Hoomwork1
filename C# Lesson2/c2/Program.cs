/*
int CutNumber(int number)  

{
            int result = -1;
            if (number >= 100)
    {
                while (number > 999)
                {
                    number = number / 10;
                }
                result = number % 10;
            }
            return result; 
        }  
*/  
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа.   
/* 
int MakeArray(int a, int b)
{
int result = 0;
 if (b < 3)
    {
 Console.Write("Третьей цифры нет,только ");
    }
 else
    {
 int c = 1;
 for (int i = b; i > 3; i--)
        {
 c = c * 10;
        }

 result = (a / c) % 10;
    }
return result;
}
int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));
int ReadInt(string message)
{
 Console.Write(message);
 return Convert.ToInt32(Console.ReadLine());
}  
*/    
//Задача 15: 
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.  
/*
string WorkHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("Под цифрой " + a + " - Выходной");
        }
        else
        {
            Console.Write("Под цифрой " + a + " - Рабочий");
        }
    }
    else
    {
        Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
    }
    return " день.";
}  
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}  
int dayNumber = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(WorkHoliday(dayNumber));  
/*  
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.  

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int InCenter(int a)
{
    
    int result = ((a / 10) % 10);
    return result;
}    
int number = ReadInt("Введите трехзначное число: ");
int amount = number.ToString().Length;

if (amount < 3 || amount > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(InCenter(number));
}  
    

  //Console.Write("Input an integer number.");  
  //int num = Convert.ToInt32(Console.ReadLine());     
  ---------------------- 
  //Задача 1.Напишите программу,которая на вход принемает два числа и проверяет,является ли первое число квадратом второго.

    //Console.Write("input a first number:");  
 int num1 = Convert.ToInt32(Console.ReadLine());  
  Console.Write("Input a second number:");  
  int num2 = Convert.ToInt32(Console.ReadLine());  
  int quad2 = num2 * num2;  
  if (num1 == quad2)  
  {  
      Console.WriteLine("Yes");  
  }   
  else  
  {  
      Console.WriteLine("No");  
  }    
  */ 
 //Задача 2. Напишите программу,которая на вход принемает одно число(N),а на выходе показывает все целые числа в промежутке от -N до N.   
 /*  

   Console.Write("Input a number:");  
   int n = Convert.ToInt32(Console.ReadLine());  
   int current = -n;  
   while(current <= n)   
   {  
      Console.Write(current + "");  
      current ++;  
   }    
   */   
   /* 
   int CutNumber(int number)  
   {  
    int sot = number / 100;  
    int ed = number % 10;  
      
    int result = sot * 10 + ed;  
    return result;  
   }    
   Console.Write("Input a number:");  
   int num = Convert.ToInt32(Console.ReadLine());  
   int newNum = CutNumber(num);  
   Console.WriteLine($"new version of{num} is {newNum}");  
   */  
  // Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и  
  // выдаёт номер четверти плоскости, в которой находится эта точка.  
  /*int[] CreateRandomArray(int size,int minValue,int maxValue)  
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


   
   
   
   

    
  


