﻿//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.   
/* 
int[,]CreateRandom2dArray(int rows,int columns,int minValue,int maxValua)  
{  
    int[,]array = new int [rows,columns];  
   for(int i = 0; i < rows;i++)  
     
    for(int j = 0; j < columns;j++)  
    array[i,j] = new Random(). Next(minValue,maxValua + 1);
   return array;
}    
  
  void Show2dArray(int [,]array)  
  { 
  for(int i = 0; i < array.GetLength(0);i++)    
  {
  for(int j = 0; j < array.GetLength(1);j++)  
    Console.Write(array[i,j]+ " ");  
    Console.WriteLine();  
  }  
  Console.WriteLine();  
  }  
  Console.Write("Input a nmber of rows:");   
  int rows = Convert.ToInt32(Console.ReadLine()); 
  Console.Write("Input a nmber of columns:");  
  int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possble value:");  
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possble value:");  
int maxValua = Convert.ToInt32(Console.ReadLine());  
  
  int[,]newArray = CreateRandom2dArray( rows, columns, minValue, maxValua);  
  Show2dArray(newArray);  
  */ 
   
  //2/Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты  
  int[,]FillArray (int rows,int columns)  
{
    int[,]matrix = new int [rows,columns];  
    for(int i = 0; i < rows; i++)  
    {
      for(int j = 0; j < columns; j++) 
      { 
        matrix[i,j] = new Random().Next(1,20);
      }

    }
   return matrix;
}    
void PrintArray(int [,] matr)  
{  
   for(int i = 0;i < matr.GetLength(0); i++)  
   {
     for(int j = 0;j <matr.GetLength(1); j++)  
     {
      Console.Write($" {matr[i,j]}");

     }
     Console.WriteLine();
   }
}    
void MakeKvadratEvenNumbers(int[,]array)  
{
  for (int i = 0; i < array.GetLength(0);i++)  
    for(int j = 0; j < array.GetLength(1);j++)
    {
      if(i % 2 == 0 && j % 2 == 0)  
        array[i,j] = array[i,j]* array[i,j];
    }

}  
Console.WriteLine("Input rows =");  
int rows = Convert.ToInt32(Console.ReadLine());  
Console.WriteLine("Input columns =");  
int columns = Convert.ToInt32(Console.ReadLine());   
int[,] array = FillArray(rows,columns);
PrintArray(array);  
MakeKvadratEvenNumbers(array);  
PrintArray(array);
//1.Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экра       
//н.   
/*  
int[,]FillArray (int rows,int columns)  
{
    int[,]matrix = new int [rows,columns];  
    for(int i = 0; i < rows; i++)  
    {
      for(int j = 0; j < columns; j++) 
      { 
        matrix[i,j] = i+j;
      }

    }
   return matrix;
}  
void PrintArray(int [,] matr)  
{  
   for(int i = 0;i < matr.GetLength(0); i++)  
   {
     for(int j = 0;j <matr.GetLength(1); j++)  
     {
      Console.Write($" {matr[i,j]}");

     }
     Console.WriteLine();
   }
}  
Console.WriteLine("Input rows =");  
int rows = Convert.ToInt32(Console.ReadLine());  
Console.WriteLine("Input columns =");  
int columns = Convert.ToInt32(Console.ReadLine());   
int[,]matrix = FillArray(rows,columns);  

PrintArray(matrix);  
*/
//3.Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.  
//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

//Задача 1.Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.(столбцы =строкам),метод преобразующий. Только пошел по нужным.  
//Задача 2.Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наим
//еньший элемент.Найти мин элемент(индекс),сгенировать новый массив(проверка,как сделать)два метода  
//mathprofi(произведение матриц)