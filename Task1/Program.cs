/*  Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */


int[] fillMassive(int size, int min, int max) // заполняет массив
{
    Random random = new Random();
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

int EvenNumber(int[] array) // проверка на четность числа
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            result++;
    }
    return result;
}

void PrintArray(int[] array) // выводит массив на экран
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.WriteLine();
}


//------
int[] array = fillMassive(4, 100, 999);
PrintArray(array);

Console.WriteLine($"Сумма четных чисел: {EvenNumber(array)}");
