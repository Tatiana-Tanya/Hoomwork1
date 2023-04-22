#Задача 2. В первом списке находится информация об ассортименте мороженного, 
#во втором списке - информация о том, какое мороженное есть на складе.
 #Выведите названия того товара, который закончился.
assortment = ["шоколадное", "ванильное", "клубничное", "банановое", "карамельное"]

# список мороженного на складе
in_stock = ["шоколадное", "ванильное", "банановое", "карамельное"]

# находим мороженное, которое закончилось на складе
out_of_stock = set(assortment) - set(in_stock)

# выводим названия мороженного, которое закончилось на складе
print("Мороженное, которое закончилось на складе:")
for item in out_of_stock:
    print(item)