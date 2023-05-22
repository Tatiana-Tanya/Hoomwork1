# Задача 2. Напишите программу, которая позволяет считывать из файла вопрос, отвечать на него и отправлять ответ обратно пользователю.
def readfile(filename):
    date = [i.split()for i in open(filename,'r',encoding = 'utf-8')]
    return date
def printinfo(date):
    for i in date:
        print(i)
def export() :       
    pass
def main():
    my_choice = -1
    date = readfile('tel.txt')
    while my_choice != 0:
        print('Выбирите одно из действий :')
        print('1 - вывести инфо на экран')
        print('2 - произвести экспорт данных')
        print('0 - выход из программы')
        my_choice = int(input())
        operations ={1:printinfo,2: export}
        operations[my_choice](date)
    print ('До свидания') 
if __name__ == '__main__':
    main()    