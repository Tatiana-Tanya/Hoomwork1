# Задача 3. Задайте список случайных чисел от 1 до 10.
# Посчитайте, сколько всего совпадающих элементов есть в списке. Удалите все повторяющиеся элементы.
import random

random_list = [random.randint(1, 10) for i in range(10)]
print("Список случайных чисел:", random_list)


num_duplicates = len(random_list) - len(set(random_list))
print("Количество совпадающих элементов:", num_duplicates)

unique_list = list(set(random_list))
print("Список уникальных элементов:", unique_list)



