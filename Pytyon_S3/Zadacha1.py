# Задача 1.Создайте список. Запишите в него N первых элементов последовательности Фибоначчи.
N = int(input("Введите количество элементов последовательности Фибоначчи: "))
fibonacci = [0, 1]
for i in range(2, N):
    next_fibonacci = fibonacci[i-1] + fibonacci[i-2]
    fibonacci.append(next_fibonacci)
    print(fibonacci)