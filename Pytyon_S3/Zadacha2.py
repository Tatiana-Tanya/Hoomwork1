# Задача 2. В списке находятся названия фруктов. Выведите все фрукты, названия которых начинаются на заданную букву.
letter = input("Введите букву, с которой должны начинаться названия фруктов: ")
fruits = ["apple", "apricot", "avocado",]
for fruit in fruits:
    if fruit.startswith(letter):
        print(fruit)