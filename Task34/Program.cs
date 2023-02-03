//Task34
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// Например: [345, 897, 568, 234] -> 2

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000);
}

int CountEvenInArray(int[] array)
{
    int count = 0;
    foreach(int element in array)
    {
        if (element % 2 == 0)
        count++;
    }
    return count;
}


Console.Clear();
Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
InputArray(array);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Количество чётных чисел в массиве: {CountEvenInArray(array)}");