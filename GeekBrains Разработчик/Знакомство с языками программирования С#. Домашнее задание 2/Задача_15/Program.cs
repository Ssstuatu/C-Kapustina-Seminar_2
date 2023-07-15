// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите чисо от 1 до 7: ");
int day = int.Parse(Console.ReadLine());
if (day >= 6 && day < 8) Console.WriteLine("Это выходной день");
if (day >= 1 && day < 7) Console.WriteLine("Это будний день");
else Console.WriteLine("Внимательно читай условие!");
Console.WriteLine(day);