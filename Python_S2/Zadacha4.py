#Задача 4. Задайте список из N элементов, заполненных числами из промежутка [-N, N]. Сдвиньте все элементы списка на 2 позиции вправо.
N = 5
lst = list(range(-N, N+1))
print("Исходный список:", lst)

shift = 2
lst = lst[-shift:] + lst[:-shift]
print("Список со сдвигом на", shift, "позиции вправо:", lst)