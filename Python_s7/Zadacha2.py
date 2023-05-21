# Задача 2. Создайте декоратор, повторяющий функцию заданное количество раз.
def repeat(num_repeats):
    def decorator(func):
        def wrapper(*args, **kwargs):
            for i in range(num_repeats):
                func(*args, **kwargs)
        return wrapper
    return decorator
@repeat(3)
def say_hello(name):
    print("Hello, " + name + "!")

say_hello("Tanya")

