// See https://aka.ms/new-console-template for more information
Console.WriteLine();
Console.WriteLine("Задача 67");
Console.WriteLine();

// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int Factorial(int n) // 453, 45, 4, 0
{
    if (n == 0)
        return 0; // напр: если return поставить не 0 а напр 100, то ответ к 112 т.е 100 + 12.
    return n % 10 + Factorial(n / 10); // 453, 45, 4
    // 4 % 10 + 45 % 10 + 453 % 10 + 0 = 12
}

Console.WriteLine(Factorial(453)); //  12
Console.WriteLine();
