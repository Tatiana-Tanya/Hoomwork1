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