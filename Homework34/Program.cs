// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();
int[] GetArray(int size, int Min, int Max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++) result[i] = new Random().Next(Min, Max);
    return result;
}
int ChetNmb(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) result++;
    }
    return result;
}

Console.Write("Введите число элементов массива: ");
int a = int.Parse(Console.ReadLine()!);
int[] array = GetArray(a, 100, 1000);
Console.Write("Массив: ");
Console.Write(String.Join(", ", array));
int result = ChetNmb(array);
Console.WriteLine("");
Console.Write("Количество четных чисел в массиве: ");
Console.Write($"{result}");
