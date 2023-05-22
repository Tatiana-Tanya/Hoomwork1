# Задача 2. Создайте декоратор, повторяющий функцию заданное количество раз.
# def repeat(num_repeats):
#     def decorator(func):
#         def wrapper(*args, **kwargs):
#             for i in range(num_repeats):
#                 func(*args, **kwargs)
#         return wrapper
#     return decorator
# @repeat(3)
# def say_hello(name):
#     print("Hello, " + name + "!")

# say_hello("Tanya")
# import telebot
# bot = telebot.Bot('6271813077:AAGgY5wqmI1Tqtd6WQgZ8aaxhsFxlaSU-4M')
# @bot.message_handler(commands=['start', 'help'])
# def send_welcome(message):
# 	bot.reply_to(message, "Howdy, how are you doing?")


