/*  Задача 3: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3, 7, 22, 2, 78] -> 76 */

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


int FindMax(int[] array) // находим минимальное и максимальное число
{
    int max = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= max)
            max = array[i];
    }
    return max;
}

int FindMin(int[] array)
{
    int min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;
}

int SubstrationNumbers(int max, int min) // вычитание максимального и минимального числа
{
    int result = max - min;
    return result;
}
//------


int[] array = fillMassive(6, 9, 200);

Console.WriteLine(SubstrationNumbers(FindMax(array), FindMin(array)));




