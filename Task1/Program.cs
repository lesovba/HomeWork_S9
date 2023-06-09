﻿/*Задача 64: Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
//Дополнение: выводим только четные числа, включая 0.  

int value = Prompt("Введите число N: ");

//Первый метод для ввода пользователем N:
int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

//Второй метод для вывода четных чисел в диапазоне от N до 0 включительно:
void PrintEvenNumbers(int value)
{
    //Определим условие для остановки рекурсии (включаем 0, т.к. он является четным числом):
    if (value < 0) return;
    //Условие для записи в консоль только четных чисел:
    if (value % 2 == 0)
    {
        Console.Write($"{value} ");
    }
    //В рекусии уменьшаем аргумент, чтобы запись чисел в консоль производилась в обратном порядке:  
    PrintEvenNumbers(value - 1);
}


PrintEvenNumbers(value);
Console.WriteLine();