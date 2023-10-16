// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

char numbers(string chislo, int num)
{
    if (chislo.Length >= num)
    {
        return chislo[num - 1];
    }
    else
    {
        Console.Write($"{num}-й элемент отсутствует");
    }
return '!';
}
Console.WriteLine("Введите число трехзначное");
Console.WriteLine(numbers(Console.ReadLine(),3));
