#Задача 3. Даны две строки. Посчитайте сколько раз каждый символ первой строки встречается во второй.
def count_chars(str1, str2):
    result = {}
    for char in str1:
        count = str2.count(char)
        result[char] = count
    return result

str1 = input("Введите первую строку: ")
str2 = input("Введите вторую строку: ")

result = count_chars(str1, str2)
print(result)