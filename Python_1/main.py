# Задача 1.Напишите программу, которая принимает на вход цифру, обозначающую день недели, и выводит название этого дня недели.
'''
n = int(input('Введите число недели:'))
if (n < 1 or n > 7):
    print('Такого дня не существует')
if (n == 1):
    print('Понедельник')
if (n == 2):
    print('Вторник')
if (n == 3):
    print('Среда')  
if (n == 4):
    print('Четверг')
if (n == 5):
    print('Пятница') 
if (n == 6):
    print('Суббота') 
if (n == 7):
    print('Воскресенье')    
'''
# Задача 2.Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
'''
ax = float(input('Введите координаты точки a по оси x:'))
ay = float(input('Введите координаты точки a по оси y:'))
bx = float(input('Введите координаты точки b по оси x:'))
by = float(input('Введите координаты точки b по оси y:'))

import math
distans = math.sqrt((ax-bx)**2+(ay-by)**2)
print(f'Растояние между точкой A до точки B = {distans}' )  
'''
# Задача 3.Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)
'''
a = int(input('Введите номер четверти в которой бы хотели узнать диапозон возможных координат: '))

if a == 1:
    print('В первой четверти - x > 0 y > 0')
elif a == 2:
    print('Во второй четверти - x < 0 y > 0')
elif a == 3:
    print('В третьей четверти - x < 0 y < 0')
elif a == 4:
    print('В четвертой четверти - x > 0 y < 0')
else:
    print('Такой четверти нет :(')
'''
# Задача 4.Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
'''
def even_numbers(n):
    for i in range(2, n+1, 2):
        print(i)

n = int(input("Введите число: "))
even_numbers(n)   
'''
