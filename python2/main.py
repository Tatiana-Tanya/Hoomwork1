'''
number = float(input('Введите любое дробное число: '))
number2 = int((number % 1 - number % 0.1) * 10)
print(number2)
'''
# Задача 2 Найдите сумму цифр трехзначного числа.
'''
num = input('Введите 3-х значное число: ')
res = 0
if len(num) == 3:
    for i in num:
        res += int(i)
    print(res)
else:
    print('Вы ввели не 3-х значное число')
'''
# Задача 4 Петя, Катя и Сережа делают из бумаги журавликов. Вместе они сделали S журавликов.
# Сколько журавликов сделал каждый ребенок, если известно, что Петя и Сережа сделали одинаковое количество журавликов,
#а Катя сделала в два раза больше журавликов, чем Петя и Сережа вместе?
'''
s = 60
print('Петя и Сережа сделали по', s/6, 'шт')
print('Маша сделала ', s/6*4, 'шт')    
'''
# Задача 6 Вы пользуетесь общественным транспортом? Вероятно, вы расплачивались за проезд и получали билет с номером.
#Счастливым билетом называют такой билет с шестизначным номером, где сумма первых трех цифр равна сумме последних трех.
#Т.е. билет с номером 385916 – счастливый, т.к. 3+8+5=9+1+6.
#Вам требуется написать программу, которая проверяет счастливость билета.
'''
s = input('Введите 6-значный номер билета: ')
if len(s) != 6:
    print(f'Число {s} не 6-ти значное')
else:
    res1 = 0
    res2 = 0
    for i in range(len(s)//2):
        res1 += int(s[i])
        res2 += int(s[len(s)//2 + i])
    if res1 == res2:
        print(f'{s} счастливый номер')
    else:
        print(f'{s} не счастливый номер')
'''
# Задача 8. Требуется определить, можно ли от шоколадки размером n × m долек отломить k долек,
#если разрешается сделать один разлом по прямой между дольками (то есть разломить шоколадку на два прямоугольника).
'''
n,m,k = int(input('В-те 1-ю сторону: ')),int(input('В-те 2-ю сторону: ')),int(input('В-те кол-во долек: '))
if k%n == 0 or k%m == 0:
    print('Yes')
else: print('No') 
'''       