// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
Console.Write("Введите 5-значное число: ");
int a = int.Parse(Console.ReadLine()!);
while (a<10000||a>99999) 
{
    Console.WriteLine("Несоответствие числа условию!");
    Console.Write("Введите 5-значное число: ");
    a = int.Parse(Console.ReadLine()!);
}
int first_dig=a/10000;
int last_dig=a%10;
// Console.WriteLine($"Первая цифра: {first_dig}  Последняя цифра: {last_dig} "!);
int second_dig=a/1000%10;
int four_dig=a/10%10;
// Console.WriteLine($"Вторая цифра: {second_dig}  Четвертая цифра: {four_dig} "!);
if (first_dig==last_dig && second_dig==four_dig) Console.WriteLine("Число является палиндромом");
else Console.WriteLine("Число НЕ является палиндромом");