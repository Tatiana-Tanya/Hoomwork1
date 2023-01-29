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
//
int CutNumber(int number)    

{  
    int sot = number / 100;  
    int ed = number % 10;  
      
    int result  = sot * 10 + ed;  
    return resurt ;  
}  
int num = new Random().Next(100,1000);    
//  

