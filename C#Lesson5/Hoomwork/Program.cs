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
  //Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)  
 // void ReverseArray(int[]array)  
  //{  
 //   for(int i = 0;i < array.Length/2;i++)    
 //{  
   // int temp = array[i];  
   //array[i]=array[array.Length -1 -i];  
   //array[array.Length -1-i]=temp;  
   //}  
   //}  
   //---6 строк скоп. и далее вывод  
   //ShowArray(myArray);  
   //ReverseArray(myArray);  
   //ShowArray(myArray);  
   //Еще один вариант этой задачи(более компакт.)  
   //void ReverseArray(int[]array)  
   //{  
    //for(int i = 0;j = array.Lengh -1;i < j;i++,j--)  
    //{    
   //int temp = array[i];  
   //array[i] = array[j];  
   //array[j] = temp;  
   //}  
   //}
 //Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.   

 //Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b  
 //Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.    
 /*
 int[,]pic = new int  
 void PrintImage(int[,]image)  
 {  
    for (int i = 0;i < image.Getlegth(0);i++)  
    {  
        for(int j = 0;j < image.Getlegth(1);j++)  
        {  
            if(image[i,j]==0)Console.Write($" ");  
            else Console.Write($"+");  
        }  
        Console.WriteLine();  
    }  
 }  
 PrintImage(Pic) 
 */   
 //Задача на рекурсию  
 /* 
 int Factorial(int n)  
 {  
    if(n==1)return 1;  
    else return n * Factorial(n-1);  
 }    

 Console.WriteLine(Factorial(3));  
 */   
 //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.   
 //Напишите программу, которая покажет количество чётных чисел в массиве.    
 /* void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}  
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");  
*/  
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.  
/*  
void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}  
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int sum = 0;

for (int z = 0; z < numbers.Length; z+=2)
    sum = sum + numbers[z];

    Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");  
*/  
    



 
