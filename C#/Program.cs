
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

Random rnd = new Random();
int num = rnd.Next(3,10); // Случайное число для размера массива
Console.WriteLine($"Длинна массива будет равна {num} эле. ");
string[] array = InitArray(num);
PrintArray(array);
Console.Write(" -> ");
FinalArray(array);

