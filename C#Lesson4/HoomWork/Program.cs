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

  //Напишите программу, которая принемает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.  
  