import random
#  Создание массива
def Add_Array(num):
    array=[]
    print(f"Будет создан массив из {num} элементов")
    print("*"*20)
    for i in range (num):
        text= input(f"Введите {i+1} -й элемент массива и нажмите Enter-> ")
        array.append(text)
    return array
num_rand = random.randint(3,10)

list = Add_Array(num_rand)
print("*"*20)
number_rand = random.randint(0,3)
print(list," -> ", random.sample(list, number_rand))