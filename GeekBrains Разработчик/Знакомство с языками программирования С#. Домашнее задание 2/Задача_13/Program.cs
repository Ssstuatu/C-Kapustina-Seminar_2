// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int result = number;
if (result / 100 < 1) Console.WriteLine($"В числе {result} нет третьей цифры");
else 
{
    while(result > 1000)
    {
        result = result / 10;
    }
    if (result >= 100 && result <= 999)
    {
        result = result % 10;
        Console.WriteLine($"{number} - {result}");
    }
}