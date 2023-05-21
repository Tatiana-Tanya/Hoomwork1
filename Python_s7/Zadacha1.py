# Задача 1. Создайте пользовательский аналог метода map().
def my_map(func, iterable):
    result = []
    for i in iterable:
        result.append(func(i))
    return result
def square(x):
    return x ** 2

numbers = [1, 2, 3, 4, 5]
squares = my_map(square, numbers)
print(squares) # [1, 4, 9, 16, 25]
