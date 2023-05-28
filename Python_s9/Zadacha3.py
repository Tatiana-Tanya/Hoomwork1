# Задача 3. Создайте двумерный массив случайного размера. Найдите индексы максимального и минимального элементов в нём.
# Выведите элементы главной диагонали матрицы в виде одномерного массива.
import numpy as np

n = np.random.randint(2, 10)
m = np.random.randint(2, 10)
arr = np.random.randint(0, 10, size=(n, m))

min_index = np.unravel_index(np.argmin(arr), arr.shape)
max_index = np.unravel_index(np.argmax(arr), arr.shape)

print(f"Минимальный элемент: {arr[min_index]}, его индекс: {min_index}")
print(f"Максимальный элемент: {arr[max_index]}, его индекс: {max_index}")

diag = np.diag(arr)
print(f"Элементы главной диагонали: {diag}")