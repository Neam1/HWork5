//Task36
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// Например: [3, 7, 23, 12] -> 19
// Например: [-4, -6, 89, 6] -> 0

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 50);
}


int Summ(int[] array)
{
    int summa = 0;
    for (int i = 1; i < array.Length; i+=2)
        summa = summa + array[i];
    return summa;
}


Console.Clear();
Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
InputArray(array);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Сумма чисел нечётных элементов массива: {Summ(array)}");