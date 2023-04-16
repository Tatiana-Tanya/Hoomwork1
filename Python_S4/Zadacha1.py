#Задача 1. Дано натуральное число N. Напишите метод, который вернёт список простых множителей числа N и количество этих множителей.
def prime_factors(n):
    factors = []
    count = 0
    for i in range(2, n+1):
                while n % i == 0:
                    factors.append(i)
                count += 1
             
    if n == 1:
     
      return factors, count


n = int(input("Введите натуральное число: "))
factors, count = prime_factors(n)
print("Список простых множителей числа {}: {}".format(n, factors))
print("Количество простых множителей числа {}: {}".format(n, count))