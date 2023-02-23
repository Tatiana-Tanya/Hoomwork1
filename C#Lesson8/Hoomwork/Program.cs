// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.  
/* 
void FillArrayRandom(int[,] array)
{
    for    (int i=0;  i<array.GetLength(0); i++)
    {
        for    (int j=0; j<array.GetLength(1); j++)
        {
            array [i, j] = new Random().Next (1, 10);
        }
    }
}  
void SortToLower(int[,] array)
{
    for    (int i=0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}  
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}  
int[,] table = new int[3, 4];
FillArrayRandom(table);
PrintArray(table);
SortToLower(table);
Console.WriteLine();
PrintArray(table);
*/ 
//  Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.  
/* 
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}  
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}  
 Console.Write("Input a nmber of rows:");   
  int rows = Convert.ToInt32(Console.ReadLine()); 
  Console.Write("Input a nmber of columns:");  
  int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
int[,] secondArray = new int[rows, columns];
int[,] resultArray = new int[rows, columns];

FillArrayRandom(array);
PrintArray2D(array);

Console.WriteLine();

FillArrayRandom(secondArray);
PrintArray2D(secondArray);

Console.WriteLine();

if (array.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}

PrintArray2D(resultArray);  
*/  
/// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента. 
  /* 


 int[,,] array3D = new int[2, 2, 2]; 
void PrintIndex(int[,,] arr)
{
    for    (int i=0; i < arr.GetLength(0);i++)
    {
        for    (int j=0; j < arr.GetLength(1);j++) 
        {
            Console.WriteLine();
            for    (int k=0; k < arr.GetLength(2); k++) 
            {
                Console.Write($"{array3D[i,j,k]}({i},{j},{k}) ");
            }
        }
    }
}  
void FillArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 3;
            }
        }
    }
}

FillArray(array3D);
PrintIndex(array3D);
 */  
 //*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.  
 /*  
 Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

 int[,] nums = new int[size, size];

int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
 nums[i, j] = num;
 if (i <= j + 1 && i + j < size - 1)
 ++j;
 else if (i < j && i + j >= size - 1)
 ++i;
 else if (i >= j && i + j > size - 1)
 --j;
 else
 --i;
 ++num;
}

PrintArray(nums);

void PrintArray(int[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
    {
 Console.Write("[ ");
 for (int j = 0; j < array.GetLength(1); j++)
        {
 Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}  
*/  
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.   
/*
Console.Clear();
 
int height = EnterInt("Введите количество строк: ");
int width = EnterInt("Введите количество столбцов: ");
 
int[,] numbers = new int[height, width];

 
int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}
 
void Fill2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(-20, 21);
        }
    }
}
 
void Print2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)      
    {
        for (int j = 0; j < numbers.GetLength(1); j++)   
        {
            Console.Write($"{numbers[i, j],3} ");
        }
        Console.WriteLine();
    }    
}
 
void SumInLines(int[,] numbers)
        {
            int[] sumInLines = new int[numbers.GetLength(0)];
            Console.Write("Суммы элементов в каждой строке: ");
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    sumInLines[i] += numbers[i, j];
                }
                Console.Write($"{sumInLines[i]} ");
            }
            int minI = 0;
            for (int i = 0; i < sumInLines.Length; i++)
            {
                if (sumInLines[minI] > sumInLines[i]) minI = i;
            }
            Console.Write($"Наименьшая сумма элементов: {sumInLines[minI]}");  
            
Console.Write($"Наименьшая сумма элементов: {sumInLines[minI]}, номер строки с ней: {minI + 1}");

        }   
 Fill2DArray(numbers);
Print2DArray(numbers);
SumInLines(numbers);  
*/  
using System;
class InputCosoleDemo{
    static void Main(){
        string name;
        Console.Title=("Давайте познакомимся");
        Console.Write("Как вас зовут?");
        name=Console.ReadLine();
        string txt="Очень приятно,"+name+"!";
        Console.Title = "Знакомство состоялось";
        Console.WriteLine(txt);
    }
}

