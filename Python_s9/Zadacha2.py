# Задача 2. Создайте двумерный массив, размером 5х5. Определите, есть ли в нём одинаковые строки.
import numpy as np
arr = np.random.randint(0, 10, size=(5, 5))
if len(arr) != len(set(map(tuple, arr))):
    print("Есть одинаковые строки в массиве")
else:
    print("Нет одинаковых строк в массиве")