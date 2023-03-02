// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();
int[] GetArray(int size, int Min, int Max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++) result[i] = new Random().Next(Min, Max);
    return result;
}
int NeChetPosSum(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        result+=array[i];
    }
    return result;
}
Console.Write("Введите число элементов массива: ");
int a = int.Parse(Console.ReadLine()!);
int[] array = GetArray(a, -100, 100);
Console.Write("Массив: ");
Console.Write(String.Join(", ", array));
int result = NeChetPosSum(array);
Console.WriteLine("");
Console.Write("Сумма элементов на нечетных позициях: ");
Console.Write($"{result}");
