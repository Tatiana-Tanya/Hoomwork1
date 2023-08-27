# username = input("Введите имя : !")
# if username =="жопа":
#     print("Ура, это моя жопа!")
# elif username == "наруто":
#     print("Я так не ждал Вас,наруто!")
# elif username =="сакура":
#     print("сакура,привет")
# else:
#     print("Привет",username)

# a = "не каких уроков смотри  "
# for i in a:
#     print(i)
# maxim = 0
# count = 0
# amaunt_day = int(input ("Введите колличество дней:"))
# for i in range(amaunt_day):
#     temp = int(input(f"Введите температуру в {i+1} день:"))
#     if temp > 0:
#         count += 1
#         if count > maxim:
#             maxim = count
#         else:
#             count = 0
#             print(f"Максимальное оттепель длилась{maxim}дней")
# #   
#    form = dict(Имя = input('Ваше имя: '), Возраст = input('Ваш возраст: '), Хобби = input('Ваше хобби: '), Любимое_животное = input('Ваше любимое животное: '))
#     print()
#     for key, value in form.items():
#         print("{0}: {1}".format(key,value))
# другая задача
# Task2()
# dictionary = {}
# dictionary['name'] = input("Введите свое имя: ")
# dictionary['age'] = input("Введите свой возраст: ")
# dictionary['hobby'] = input("Введите свое хобби: ")
# dictionary['favorite_animal'] = input("Введите свое любимое животное: ")

# for (k, v) in dictionary.items():
#     print(k+":", v)
# import random
# задача про осадки
# rainfall = [random.randint(0, 25) for index in range(30)]
# print(rainfall)
# sum1 = 0
# sum2 = 0
# for i in range(15):
#     sum1 += rainfall[i]

# for i in range(15, 30):
#     sum2 += rainfall[i]

# if sum1 > sum2:
#     print("В первой половине июня было больше осадков")
# elif sum1 < sum2:
#     print("Во второй половине июня было больше осадков")
# else:
#     print("В первой и во второй половине июня выпало одинаковое количество осадков")
# 2 задача варианты

# input("Введите свое имя: ")
# dict['age'] = input("Введите свой возраст: ")
# dict['hobby'] = input("Введите свое хобби: ")
# dict['favorite_animal'] = input("Введите свое любимое животное: ")

# for (k, v) in dict.items():
#     print(k+":", v)
#еще один вариант
# dictionary = dict()
# dictionary['name'] = input('Введите имя: ')
# dictionary['age'] = int(input('Введите возраст: '))
# dictionary['hobby'] = input('Введите свое хобби: ')
# dictionary['animal'] = input('Введите свое любимое животное: ')
# print(f'Словарь: {dictionary}')
# 3 Задача
# def Task3(length):
#     letters_and_digits = string.ascii_letters + string.digits
#     password = ''.join(random.sample(letters_and_digits, length))
#     print(password)
#4 Задача
# dict = {'Ручка':5, 'карандаш':3, 'ластик':4}
# sum = 0
# flag = True
# while flag:
#     code = input('Введите наименование: ')
#     if code in dict:
#         sum += dict[code]
#     elif code == 'стоп':
#         flag = False          
# print(sum)
# data = open('test.txt', encoding='utf-8')
# text = data.readlines()
# data.close()

# phrase = text[0].split(':')

# bot = {}
# bot[phrase[0]] = phrase[1]
# print(bot)
# Код для красоты
from os import system
from math import sin, sqrt

# разрешение поля терминала (стандартное)
# задаём значения типа float чтобы не проделывать лишние операции тайпкастинга
width = 120.0
height = 30.0
system(f"mode con cols={int(width)} lines={int(height)}")

# соотношение сторон терминала, и символов в этом терминале
# каждый символ в терминале занимает 11х24 пикселя
screen_aspect = width / height
symb_aspect = 11.0 / 24.0

# создаём градиент
# gradient_size нужен для получения последнего индекса символа из gradient
gradient = " .=+o0@"
gradient_size = len(gradient) - 1

# заполняем кортеж кадров чтобы пройтись по нему циклом for
# начинаем с 1.0 кадра, чтобы не было деления на 0
# можно закомментить чтобы вывести только один кадр
# но там ещё пару изменений тогда надо будет внести
frames = ()
frame = 1.0
while frame < 2000.0:
    frames += (frame,)
    frame += 1.0

# создаём строку-кадр (в дальнейшем будем его модифицировать и выводить)
screen = ""

for frame in frames:
    row = 0.0
    while row < height:
        col = 0.0
        while col < width:
            x = col / width * 2.0 - 1.0
            y = row / height * 2.0 - 1.0
            x *= screen_aspect * symb_aspect

            # тут можно писать различные функции для фигур
            x += sin(frame * 0.01)
            dist = sqrt(x * x + y * y)
            color = int(1.0 / dist)
            if color < 0:
                color = 0
            elif color > gradient_size:
                color = gradient_size
            screen += gradient[color]
            col += 1.0
        row += 1.0
    print(screen)
    # здесь кадр очищается (пустая строка)
    screen = ""

