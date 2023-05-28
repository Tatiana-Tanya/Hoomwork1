# Задача 1. Дан список элементов. Используя библиотеку NumPy, подсчитайте количество уникальных элементов в нём.
import numpy as np

list1 = [1, 2, 2, 3, 3, 3, 4, 4, 4, 4]
array1 = np.array(list1)
unique_elements, counts = np.unique(array1, return_counts=True)

for element, count in zip(unique_elements, counts):
    print(f"{element}: {count}")