/* Задача 2: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 26
[-4, -6, 4, 67]-> 0 */


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

int oddPosition(int[] array) // находит нечетные позиции и складывает их
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 > 0)
            {
                sum += array [i];
            }
    }
    return sum;
}



void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.WriteLine ();
}



//------
int[] array = fillMassive(4, 9, 100);
PrintArray (array);

Console.WriteLine ($"Сумма чисел на нечетных позициях: {oddPosition(array)}");
