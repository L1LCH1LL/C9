/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


Console.WriteLine("Введите начальное число M:");
int numM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите начальное число M:");
int numN = int.Parse(Console.ReadLine());

void PrSum (int numM, int numN, int sum)
{
    if (numM > numN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numM++);
    PrSum(numM, numN, sum);
}

PrSum(numM, numN, 0);
