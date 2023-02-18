//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.  
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
   
  //2/Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты
//1.Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
//3.Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.