


# import random

# random_list = [random.randint(1, 10) for i in range(10)]
# print("Список случайных чисел:", random_list)
# unique_list = []
# for item in random_list:
#     if item not in random_list:
#         unique_list.append(item)

# if len(random_list) == len(unique_list):
#     print("Да, все элементы уникальны")
# else:
#     print("Нет, есть повторяющиеся элементы")
# Создаем список с заданными числами
# lst = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5]

# count_dict = {}

# for item in lst:
#     count_dict.setdefault(item, 0)
#     count_dict[item] += 1

# print("повторяющиеся элементы:",sum(count_dict.values()) - len(count_dict))

# lst = list(set(lst))

# print("уникальные элементы:",lst
# from datetime import datetime
# import random
# import time
# odds = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,
#         33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59}
# for i in range(5):
#     right_this_minute = datetime.today().minute
#     if right_this_minute in odds:
#         print("Минуты выведеные.")
#     else:
#         print("нет времени.")
#         wait_time = random.randint(1,60)
#         time.sleep(wait_time)
# a = int(input("Введите число")) 
# b = int(input("Введите число"))
# if a > b :
#  print( b)
# if a < b:
#  print (a )
# if a == b:
 
#  print (a,b)
# a = int(input("Введите число"))
# b = int(input("Введите число"))
# d = int(input("Введите число"))
# sum = a + b + d

# print(sum)
# a = int(input("Введите число"))
# b = int(input("Введите число"))
# d = int(input("Введите число"))
# e = int(input("Введите число"))
# n = int(input("Введите число"))
# m = int(input("Введите число"))
# sum = a + b + d + e + n + m
# if (a + b + d)==(e + n + m):
#   print ("Счастливое число")
# if  ( a + b + d) < (e + n + m):
#   print("не счастливое число")
# s = input('Введите 6-значный номер билета: ')
# if len(s) != 6:
#     print(f'Число {s} не 6-ти значное')
# else:
#     res1 = 0
#     res2 = 0
#     for i in range(len(s)//2):
#         res1 += int(s[i])
#         res2 += int(s[len(s)//2 + i])
#     if res1 == res2:
#         print(f'{s} счастливый номер')
#     else:
#         print(f'{s} не счастливый номер')

# import random

# # создаем массив размером 5x5
# arr = [[random.randint(0,1) for j in range(5)] for i in range(5)]

# # принудительно задаем точки [0,0] и [4,4] равными единице
# arr[0][0] = 1
# arr[4][4] = 1

# # функция для проверки существования пути
# def check_path_exists(arr):
#     visited = []
#     stack = [(0,0)]
#     while stack:
#         x, y = stack.pop()
#         if x == 4 and y == 4:
#             return True
#         if x < 0 or y < 0 or x > 4 or y > 4 or arr[x][y] == 0 or (x,y) in visited:
#             continue
#         visited.append((x,y))
#         stack.append((x+1,y))
#         stack.append((x-1,y))
#         stack.append((x,y+1))
#         stack.append((x,y-1))
#     return False

# # проверяем существование пути
# if check_path_exists(arr):
#     print("Путь существует")
# else:
#     print("Путь не существует")  
# 
# import random
# import queue

# arr = [[random.randint(0,1) for j in range(5)] for i in range(5)]

# arr[0][0] = 1
# arr[4][4] = 1

# q = queue.Queue()

# q.put((0,0))

# dist = [[-1 for j in range(5)] for i in range(5)]

# dist[0][0] = 0

# while not q.empty():
#     x, y = q.get()
#     if x == 4 and y == 4:
#         break
#     if x > 0 and arr[x-1][y] == 1 and dist[x-1][y] == -1:
#         dist[x-1][y] = dist[x][y] + 1
#         q.put((x-1,y))
#     if x < 4 and arr[x+1][y] == 1 and dist[x+1][y] == -1:
#         dist[x+1][y] = dist[x][y] + 1
#         q.put((x+1,y))
#     if y > 0 and arr[x][y-1] == 1 and dist[x][y-1] == -1:
#         dist[x][y-1] = dist[x][y] + 1
#         q.put((x,y-1))
#     if y < 4 and arr[x][y+1] == 1 and dist[x][y+1] == -1:
#         dist[x][y+1] = dist[x][y] + 1
#         q.put((x,y+1))

# if dist[4][4] != -1:
#     print("Путь существует")
# else:
#     print("Путь не существует")

# Задача 1. Дано натуральное число N. Видимое значение выражения: N + NN + NNN
# N может быть любая найдена.
# N = 132: 132 + 132132 + 132132132 = 132264396
# 
# определить  задачу1 ( N : целое ):    
#     return  N  +  int ( str ( N ) +  str ( N )) +  int ( str ( N ) +  str ( N ) +  str ( N ))

# N  =  int ( ввод ( 'Введите число: ' ))
# N = абс ( N )
# print ( f'Результат для N= { N } : { task1 ( N ) } ' )

# Задача 2. Задан массив из случайных цифр на 15 элементов.
# На входе можно получить трехзначное натуральное число.
# Напишите программу, которая определяется, есть ли в массиве
# последовательность из трёх элементов, совпадающая с введённым числом.
# [0, 5, 6, 2, 7, 7, 8, 1, 1, 9] - 277 -> да
# [4, 4, 3, 6, 7, 0, 8, 5, 1, 2] - 812 -> нет

# список из случайных цифр на 15 элементов:
# def  generateDigits ( N  =  15 ):
#     возврат [ случайный . randint ( 0 , 9 ) для  _  в  диапазоне ( N )]    

# def  задача2 ( цифры : список , N : целое ):
#     строкаЦифры  =  '' . присоединиться ( str ( i ) для  i  в  цифрах )
#     индекс  =   строка цифр . найти ( ул ( N ))
#     если  индекс  >=  0 :
#         print ( f'Для числа { N } имеется вхождение, индекс: { index } ' )
#     еще :
#         print ( f'Для числа { N } вхождений в списке НЕ имеется' )        

# цифры  =  генерироватьцифры ()
# print ( f'список из случайных цифр: { digits } ' )

# N  =  int ( input ( 'Введите трехзначное число: ' ))
# если  N < 100  или  N > 999 :
#     print ( f'Число { N } - не трехзначное!' )
# еще :    
#     задача2 ( цифры , N )

# Задача 3. Найдите все простые несократимые дроби, 
# лежащие между 0 и 1, знаменатель которых не превышает 11.

# алгоритм поиска наибольшего общего делителя двух целых m, n
#def greaterCommonDivisor(m: int, n: int):
    # 1. Базовый алгоритм
    # if m == n:
    #     return m
    # result = 1
    # for i in range(2, min(m, n)+1):
    #     if m % i == 0 and n % i == 0:
    #         result = i
    # return result                
    
    # 2. Продвинутый алгоритм
#     while m > 0:
#         tmp = n % m
#         n = m
#         m = tmp
#     return n      

# def task3():
#     result = []    
#     # Перебираем знаменатели:
#     for i in range(2,12):
#         # Перебираем числители от 1 до i, т.к. дроби менее 1
#         for j in range(1, i):
#             # признак несократимой дроби: НОД = 1
#             if greaterCommonDivisor(i, j) == 1:   
#                 result.append(str(j) + '/' + str(i))
#     return result       
# 
# number = int(input("Введите число"))
# for i in range(1,number + 1):
#     print(i)   
# number = int(input("Введите число:"))
# for i in range(1,number + 1):
#     if number % i == 0:
#         if i % 2 == 0:
#             print(f"{i}четное")
#         else:
#             print(f"{i}нечетное

# import random

# # Создаем матрицу смежности для лабиринта 5x5
# maze = [[random.randint(0, 1) for i in range(5)] for j in range(5)]

# # Принудительно задаю точки [0,0] и [4,4] равными единице
# maze[0][0] = 1
# maze[4][4] = 1

# # Функция, которая проверяет, существует ли путь от точки (x1, y1) до (x2, y2) в лабиринте
# def is_path(maze, x1, y1, x2, y2):
#     stack = [(x1, y1)]
#     visited = set()
#     while stack:
#         x, y = stack.pop()
#         if x == x2 and y == y2:
#             return True
#         if (x, y) in visited:
#             continue
#         visited.add((x, y))
#         if x > 0 and maze[x-1][y] == 1:
#             stack.append((x-1, y))
#         if x < len(maze)-1 and maze[x+1][y] == 1:
#             stack.append((x+1, y))
#         if y > 0 and maze[x][y-1] == 1:
#             stack.append((x, y-1))
#         if y < len(maze[x])-1 and maze[x][y+1] == 1:
#             stack.append((x, y+1))
#     return False

# # Проверяем, существует ли путь от точки [0,0] до [4,4]
# if is_path(maze, 0, 0, 4, 4):
#     print("Путь существует")
# else:
#     print("Путь не существует")

# # Создаем альтернативный выход
# for i in range(1, 4):
#     if maze[0][i] == 0:
#         maze[0][i] = 1
#         break

# # Выводим лабиринт
# for i in range(5):
#     for j in range(5):
#         print(maze[i][j], end=" ")
#     print()
# substring =input("Введите строку:")
# phrase = input('Введите фразу:')
# length_substr = len(substring)
# length = len(phrase)
# for i in range(length_substr):
#     print(phrase[i:i+length_substr])
# a = [1,2,3,4,5]
# k = 3
# b = a[-k:]
# c = a[:-k]
# print(b + c)
# length = 7
# numbers = [0]*length
# for index in range(length):
#     numbers[index]=5
# print(numbers)
# import random
# random.randint
# numbers = [1,2,3,4,5]


# for el in range(10):
#     length = random
# sum = 0
# for index in range(6):
#  total = 0
#  for num in numbers:
#       total += num
#       if sum // 3 == 0:
#         print(f"Сумма четная:",sum + num)

#  if sum % 2 == 0:
#         print("Сумма четная")
# else:
#         print(f"Сумма нечетная:{sum}")
# print(f"Сумма чисел в списке:{total}")
# import random
# len = 30
# a = 0
# b = 0
# temper = [random.randint(0,25)for index in range(len)]
# for index in range(0,15):
#     a = a + temper[index]
#     print(a)
# for index in range (15,30):
#         b = b + temper[index]
#         print(b)
#         if a > b:
#          print("Осадки в первой половине июня:")
#         else:
#          print("Во второй половине июня:")
# form = dict(Имя = input("Ваше имя:"),
#             Возраст = input("Ваш возраст:"),
#             Хобби = input("Ваше хобби:"),
#             Любимое_животное = input("Любимое животное:"))
# print()
# for key,value in form.items():
#     print ("{0}:{1}".format(key,value))
# phrase = input('Введите фразу:')
# fruttis =["абрикос,""авокадо","апельсин,""айва,"]
# message = "Слова из списка"
# if set(fruttis) & set(message.split()):
#     print('В строке есть слова из списка')
#     if set(fruttis)and phrase(fruttis):
#         print("Да")
# fruits = ['абрикос', 'айва', 'ананас', 'апельсин']
# a_fruits = [fruit for fruit in fruits if fruit.startswith('а')]
# print(a_fruits)
# animals = ['слон','собака','соболь','свинья']
# с_animals = [animal for animal in animals if animal.startswith('с')]
# print(с_animals)
# st = 'a a a b c a a d c' 
# my_dict = {} 
# for i in st.split():
#     if i in my_dict:
#         print(f'{i}_{my_dict[i]}', end =' ')
#         my_dict[i] += 1 
#     else:
#         print(i,end =' ')
#         my_dict[i] = 1 
# spisok1 = [1,2,4,2,4,5,2,5]
# the_unique_spisok = set(spisok1) 
# print(the_unique_spisok)
# from random import randint
# n_set = set(randint(1, 20) for i in range(int(input('Введите кол-во элементов первого множества: '))))
# print(n_set)
# m_set = set(randint(1, 20) for i in range(int(input('Введите кол-во элементов второго множества: '))))
# print(m_set)
# s_set = sorted(n_set.intersection(m_set))
# print(*s_set)                
# def our_filter(func, numbers):
#     return (el for el in numbers if func(el))

# def compare_numbers(num):
#     return num > 5

# numbers = [1, 14, 6, 10, 3, 2, 5]

# print( list(filter(compare_numbers, numbers)))
# print( list(our_filter(compare_numbers, numbers)))
# import telebot
# import requests
# import time

# bot = telebot.TeleBot("6119292896:AAEZvqy8hW6fx42SKaWBr5_9qyI7NopYdaE") 

# @bot.message_handler(commands=['start', 'help'])
# def send_welcome(message):
# 	bot.reply_to(message, "Howdy, how are you doing?")
	

# @bot.message_handler(content_types=['text'])
# def text_message(message):
# 	#print(message)
# 	data = open('log.txt', mode='a', encoding='utf-8')
# 	text = f'{message.from_user.first_name} {message.from_user.last_name}: {message.text}\n'
# 	data.write(text)
# 	data.close()
	

# bot.polling()
#----
# if message.text == 'регистрация':
# 		data = open('registred_users.txt', mode='r', encoding='utf-8')
# 		id_list = data.readlines()
# 		data.close()
# 		print(id_list)
# 		id_list = list(el[:-1] for el in id_list)
# 		print(id_list)
# 		if str(message.from_user.id) not in id_list:
# 			data = open('registred_users.txt', mode='a', encoding='utf-8')
# 			data.write(f'{message.from_user.id}\n')
# 			data.close()
# 			bot.reply_to(message, 'Регистрация прошла успешно!')
# 		else:
# 			bot.reply_to(message, 'Вы уже зарегистрированы!')
#####3#
# elif message.text == 'оповещение':
# 		data = open('registred_users.txt', mode='r', encoding='utf-8')
# 		id_list = data.read().split('\n')
# 		data.close()
# 		id_list = id_list[:-1]
# 		for id in id_list:
# 			bot.send_message(id, 'совещание через 5 минут')
# полностью файл
# 
# Здесь уже бот с кнопками
import telebot
from telebot import types
import requests
import time

bot = telebot.TeleBot("6119292896:AAEZvqy8hW6fx42SKaWBr5_9qyI7NopYdaE") 

markup = types.ReplyKeyboardMarkup(row_width=1)
btn_reg = types.KeyboardButton('регистрация')
btn_alarm = types.KeyboardButton('оповещение')
markup.add(btn_reg, btn_alarm)

@bot.message_handler(commands=['start', 'help'])
def send_welcome(message):
	bot.send_message(message.from_user.id, "Привет, я бот Питоша.", reply_markup=markup)
	

@bot.message_handler(content_types=['text'])
def text_message(message):
	#print(message)
	data = open('log.txt', mode='a', encoding='utf-8')
	text = f'{message.from_user.first_name} {message.from_user.last_name}: {message.text}\n'
	data.write(text)
	data.close()
	if message.text == 'регистрация':
		data = open('registred_users.txt', mode='r', encoding='utf-8')
		id_list = data.readlines()
		data.close()
		id_list = list(el[:-1] for el in id_list)
		if str(message.from_user.id) not in id_list:
			data = open('registred_users.txt', mode='a', encoding='utf-8')
			data.write(f'{message.from_user.id}\n')
			data.close()
			bot.reply_to(message, 'Регистрация прошла успешно!')
		else:
			bot.reply_to(message, 'Вы уже зарегистрированы!')
	elif message.text == 'оповещение':
		data = open('registred_users.txt', mode='r', encoding='utf-8')
		id_list = data.read().split('\n')
		data.close()
		id_list = id_list[:-1]
		for id in id_list:
			bot.send_message(id, 'совещание через 5 минут')
		
	
bot.polling()







