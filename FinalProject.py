import random
#  Создание массива
def Add_Array(num):
    array=[]
    print(f"Будет создан массив из {num} элементов")
    print("*"*20)
    for i in range (num):
        # print(i)
        text= input(f"Введите {i+1} -й элемент массива и нажмите Enter-> ")
        array.append(text)
    print("*"*20)
    print(f"Создан массив из {num+1} элементов")
    print("*"*10)
    return array
    
num_rand = random.randint(3,10)