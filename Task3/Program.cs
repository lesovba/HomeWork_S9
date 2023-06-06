/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3->A(m, n) = 9
m = 3, n = 2->A(m, n) = 29*/

int numberN = Prompt("Введите число N: ");
int numberM = Prompt("Введите число M: ");

Console.WriteLine(AckermannFunction(numberM, numberN));

//Первый метод для ввода пользователем M и N:
int Prompt(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

//Насколько я понял, выражаясь простыми словами, функция Аккерманна - это рекурсия в рекурсии. 
//Результат выполнения функции от двух значений (в нашем случае m и n) вычисляется "вложенной" рекурсией.  
//Следующий метод вычисляет результат выполнения функции при максимальных значениях m=3, n=11. 
//Если увеличивать значения m или n больше указаных, получаем Stack Overflow Exception, 
//поскольку рекурсия слишком глубокая и стек переполнится из-за большого количества результатов 
//промежуточных вычислений. 
//Реализация следующая: 
int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return AckermannFunction(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
    else
        return n + 1;
}