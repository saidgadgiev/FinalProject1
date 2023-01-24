import random
#  Создание массива
def Add_Array():
    num = random.randint(3,10)
    array=[]
    print("*"*20)
    print(f"Будет создан массив из {num} элементов")
    print("*"*20)
    for i in range (num):
        text= input(f"Введите {i+1} -й элемент массива и нажмите Enter-> ")
        array.append(text)
    return array


list = Add_Array()
print("*"*20)
# Количество элементов для отбора
number_rand = random.randint(0,3) # Случайный выбор цифр от 0 до 3 
print(list," -> ", random.sample(list, number_rand)) # Вывод массива из случайных элементов другого массива