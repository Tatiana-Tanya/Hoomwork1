//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива./   
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
