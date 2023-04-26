// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M: ");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int numberN = int.Parse(Console.ReadLine());

Console.WriteLine(sumNumbers(numberM, numberN));

int sumNumbers(int a, int b)
{
    if (a>b) return a + sumNumbers(a-1,b);
    else if (a<b) return a + sumNumbers(a+1,b);
    else return a;
}