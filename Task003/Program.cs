﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7:");
int num = Convert.ToInt32(Console.ReadLine());
if(num>5 && num<8){
    Console.WriteLine("Да");
}
else if (num > 0 && num<=5)
{
    Console.WriteLine("Нет");
}
else{
    Console.WriteLine("Введено не правильное число");
}
