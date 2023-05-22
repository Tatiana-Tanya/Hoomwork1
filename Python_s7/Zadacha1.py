# Задача 1. Создайте пользовательский аналог метода map().
# def my_map(func, iterable):
#     result = []
#     for i in iterable:
#         result.append(func(i))
#     return result
# def square(x):
#     return x ** 2

# numbers = [1, 2, 3, 4, 5]
# squares = my_map(square, numbers)
# print(squares) # [1, 4, 9, 16, 25]
# import telebot
# import random


# bot = telebot.TeleBot("6271813077:AAGgY5wqmI1Tqtd6WQgZ8aaxhsFxlaSU-4M")
# @bot.message_handler(commands=['start', 'help'])
# def send_welcome(message):
# 	bot.reply_to(message, "Добро пожаловать в игру 'Угадай число'! Я загадал число от 1 до 1000.Попробуйте угадать его с помощью команды /guess.")
# 	context.bot.send_message(chat_id=update.effective_chat.id, text=message)

# def guess(update, context):
#     user_input = update.message.text
#     user_guess = int(user_input.split()[1])
#     answer = random.randint(1, 1000)
#     attempts = 1

#     while user_guess != answer:
#         if user_guess < answer:
#             message = "Загаданное число больше. Попробуйте еще раз."
#         else:
#             message = "Загаданное число меньше. Попробуйте еще раз."
#         context.bot.send_message(chat_id=update.effective_chat.id, text=message)
#         user_input = update.message.text
#         user_guess = int(user_input.split()[1])
#         attempts += 1

#     message = f"Вы угадали число за {attempts} попыток!"
#     context.bot.send_message(chat_id=update.effective_chat.id, text=message)
