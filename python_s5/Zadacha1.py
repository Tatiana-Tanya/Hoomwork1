#Задача 1. Задайте список случайных чисел от 1 до 10, выведите все элементы больше 5. Используйте для решения лямбда-функцию.
import random

lst = [random.randint(1, 10) for i in range(10)]

filtered_lst = list(filter(lambda x: x > 5, lst))

print("Исходный список:", lst)
print("Элементы больше 5:", filtered_lst)