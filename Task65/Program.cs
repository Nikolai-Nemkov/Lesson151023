// See https://aka.ms/new-console-template for more information
Console.WriteLine();
Console.WriteLine("Задача 65");
Console.WriteLine();

// Задача 65: Задайте значения M и N. Напишите программу, которая
//  выведет все натуральные числа в промежутке от M до N.
//  M = 1; N = 5 -> "1, 2, 3, 4, 5"
//  M = 4; N = 8 -> "4, 5, 6, 7, 8"

void RangeNatureNumbers(int numA, int numB)
{
    if (numA == numB) // если А и В равны
    {
        Console.Write($"{numA}"); // то выводим число либо А либо В
    }
    else if (numA > numB) //  А если  А > В
    {
        Console.Write($"{numA} "); // то А выводим
        RangeNatureNumbers(numA - 1, numB); // рекурсия от А до В
    }
    else
    {
        Console.Write($"{numA} "); //  А если A < В
        RangeNatureNumbers(numA + 1, numB); // рекурсия в обратном порядке.
    }
}

Console.WriteLine("Введите первое натуральное число");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write($"{numberM}, {numberN} -> ");
RangeNatureNumbers(numberN, numberM);

 