# Задача 3. Добавьте в telegram-бота игру «Угадай числа». Бот загадывает число от 1 до 1000.
# Когда игрок угадывает его, бот выводит количество сделанных ходов.
import telebot
from random import randint

def run_tg_bot():
    commands_dict = {"/start": "starts bot",
                     "/help": "show help and available commands",
                     "/guess_number": "start a game \"guess number\""}

    help_message = "Available commands:\n"
    for key in commands_dict:
        help_message += f"{key}: {commands_dict[key]}\n"

    trys_counts = {}

    with open("token.txt") as file:
        token = file.read()
    bot = telebot.TeleBot(token)

    @bot.message_handler(commands=["start"])
    def start(message):
        chat_id = message.chat.id
        bot.send_message(chat_id, f"Hello {message.from_user.first_name}")
        bot.send_message(chat_id, "for help type command \"/help\"")

    @bot.message_handler(commands=["help"])
    def show_help(message):
        chat_id = message.chat.id
        bot.send_message(chat_id, help_message)

    @bot.message_handler(commands=["guess_number"])
    def guess_number(message):

        def get_user_number(message):
            if message.text.isdigit():
                user_number = int(message.text)
                if user_number > bots_number:
                    message = bot.send_message(chat_id, "Я загадал меньшее число")
                    trys_counts[chat_id] += 1
                    bot.register_next_step_handler(message, get_user_number)

                elif user_number < bots_number:
                    message = bot.send_message(chat_id, "Я загадал большее число")
                    trys_counts[chat_id] += 1
                    bot.register_next_step_handler(message, get_user_number)

                else:
                    bot.send_message(chat_id, f"Угадал c {trys_counts[chat_id]} попытки")
            else:
                message = bot.send_message(chat_id, "Вы ввели не число")
                bot.register_next_step_handler(message, get_user_number)

        chat_id = message.chat.id
        trys_counts[chat_id] = 1
        bots_number = randint(1, 1000)
        message = bot.send_message(chat_id, "Ок, я загадал число [1, 1000], попробуй его отгадать")
        bot.register_next_step_handler(message, get_user_number)

    @bot.message_handler(func=lambda message: True)
    def echo(message):
        print(message)
        chat_id = message.chat.id
        bot.send_message(chat_id, message.text)

    bot.polling()


run_tg_bot()



	




