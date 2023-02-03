//  Задайте массив дробных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//  Например: [3.57, 7.96, 22.47, 2.12, 78.73] -> 76.61

void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = Math.Round(new Random().NextDouble() * (10 - 1) + 1, 2);
}

double DifMaxAndMin(double[] array)
{
    double minArray = array[0], maxArray = array[0];
    foreach (double element in array)
    {
        if (element > maxArray)
            maxArray = element;
        if (element < minArray)
            minArray = element;
    }
    return maxArray - minArray;
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
double[] array = new double[a];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join("| ", array)}]");
Console.WriteLine($"Разница Max и Min значения: {DifMaxAndMin(array)}");