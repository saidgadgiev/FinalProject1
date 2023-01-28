/*
Задача: 
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
Примеры:
    ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
    ["1234", "1567", "-2", "computer science"] -> ["-2"]
    ["Russia", "Denmark", "Kazan"] -> []
*/
// Получить массив из случайных чисел

String[] InitArray(int num)
{
    string[] list = new string[num];
    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите {i+1}-й элемент массива -> ");
        list[i] = Console.ReadLine()??"";
    }
    return list;
}

// Печать массива

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("\""+array[i]+"\"" + (i < array.Length-1 ?", ":""));
    }
    Console.Write("]");
}    

//  Создание случайного  массива из сущ массива
void FinalArray(string[] array)
{
    Random rnd = new Random();
    int number = rnd.Next(0,4);
    Console.Write("[");
    for (int i = 0; i < number; i++)
    {
        int num = rnd.Next(0,array.Length);
        Console.Write("\""+array[num]+"\"" + (i < number-1 ?", ":""));
    }
    Console.Write("]");
}

Console.Write("Укажите длинну массива?? -> ");
int num  = int.Parse(Console.ReadLine()??""); //вводим размер массива
string[] array = InitArray(num);
PrintArray(array);
Console.Write(" -> ");
FinalArray(array);

