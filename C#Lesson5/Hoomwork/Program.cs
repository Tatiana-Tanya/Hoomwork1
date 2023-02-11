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
  //Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот  
  //преобразующий метод    
  /* 
  int[]RandomArray(int size,int minValue,int maxValue)  
  {  
    int[]array =new int [size];  
      
      for(int i = 0; i < size;i++)  
      {  
          array[i] = new Random().Next(minValue,maxValue +1);  
      }   
      return array;  
  }  
  void ShowArray(int[]array)   
  {  
    for(int i= 0; i < array.Length;i++)  
        Console.Write(array[i] + " ");  
          
     Console.WriteLine();  
  }  
  int[] InvertArray(int[]array)   
  {  
    for(int i = 0; i < array.Length; i++)  
       array[i]= -array[i];  
       return array;  
  }   
  */
  //2 задача Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.  
  //булевый метод.аналитический.  
   /*   
  bool IsNumberPresent(int[]array,int nunber)   
  {  
    for(int i = 0;i<array.Length;i++)  
    if(array[i] == number)  
    return true;  
    return false;  
  }
   */ 
  //3 задача.Задайте массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].  
  //шаблон на экране(кол-во эл,сколько их штук)   
  /* 
  int NumberOfElements(int[]array,int startNumber,int endNumber)  
  {  
     int result = 0;  
     for(int i = 0;i < array.Length;i++)  
      if(array[i] <= endNumber && array[i] >= startNumber)  
        result++;  
       return result;  
  }  
  -----  
  //первые 6строк вывода стандартные  
  Console.Write("Input a start number:");  
  int numStart =Convert.ToInt32(Console.ReadLine());  
  Console.Write("Input a end number:");  
  int numEnd = Convert.ToInt32(Console.ReadLine());  
  int[]myArray = RandomArray(Length, min, max);  
  ShowArray(myArray);  
  Console.WriteLine($"Number of elements in range[{numStart},{numEnd}]:{NumberOfElements(myArray,numStart,numEnd)}");  
  */  
  
