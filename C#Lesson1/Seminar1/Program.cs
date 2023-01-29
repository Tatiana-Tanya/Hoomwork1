/*   
int number = 5;
double number2 = 5.47;  
string word = "Hello";  
bool check = true;   
 
Console.WriteLine ();
*/  
// Задача 2. Напишите программу, которая на вход принемает два числа и выдает,какое число большее,а какое меньшее  
//а=5;b=7 -> max =7  
//a=2 b=10 -> max =10  
//a=-9 b=-3 -> max =-3  
Console.Write("Input a first number:");  
int a = Convert.ToInt32(Console.ReadLine());  
Console.Write("Input a second number:");  
int b = Convert.ToInt32(Console.ReadLine());  
//  
// Задача 1 Напишите программу,которая принемает во вход трехзначное читсло и удаляет вторую цифру этого числа  
//    

  
 
//Задача 4. Напишите программу,которая принимает на вход три числа и выдает максимальное из этих чисел.  
  

int Max (int arg1,int arg2,int arg3)  
{  
    int result = arg1;  
    if(arg2 > result)result = arg2; 
    if(arg3 > result)result = arg3;  
    return result;    
}

int a1 = 2 ;  
int b1 = 7 ; 
int c1 = 3 ; 
int a2 = 7 ;
int b2 = 44 ;
int c2 = 5 ;
int a3 = 9 ;
int b3 = 3 ;
int c3 = 22 ;
int max1 = Max (a1,b1,c1);   
int max2 = Max (a2,b2,c2);  
int max3 = Max (a3,b3,c3);  
int max = Max(max1,max2,max3);  
Console.WriteLine(max);