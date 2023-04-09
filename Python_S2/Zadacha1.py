#Задача 1. Напишите программу, которая принимает на вход число N и выдает список факториалов для чисел от 1 до N.

def factorial(n):
    if n == 0:
        return 1
    else:
        return n * factorial(n-1)

def factorial_list(n):
    result = []
    for i in range(1, n+1):
        result.append(factorial(i))
    return result

n = int(input("Введите число: "))
result = factorial_list(n)
print(result)