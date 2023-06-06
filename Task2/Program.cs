/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.

M = 1; N = 15-> 120
M = 4; N = 8. -> 30*/

int numberM = Prompt("Введите число M: ");
int numberN = Prompt("Введите число N (N>M): ");

Console.WriteLine(FindSumInRange(numberM, numberN));

//Первый метод для ввода пользователем M и N:
int Prompt(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

//Второй метод для нахождения суммы всех чисел в диапазоне от M до N: 
int FindSumInRange(int numM, int numN)
{
    //Определяем условие для остановки рекурсии:
    if (numM>numN) return 0; 
    //В рекурсии увеличиваем число M, чтобы в диапазон попали все числа от M до N включительно.  
    return numM + FindSumInRange(numM+1, numN); 
}
