// See https://aka.ms/new-console-template for more information
Console.WriteLine();
Console.WriteLine("Задача 66");
Console.WriteLine();

// Задача 66. Задайте значение M и N. Напишите программу, которая найдет сумму натуральных элементов
// в промежутке от М до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30



int m = InputInt("Введите M:");
int n = InputInt("Введите N:");
Console.WriteLine($"Сумма элементов от {m} до {n} = {NaturalElementSum(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
int NaturalElementSum(int m, int n)
{
    if (m == n) return n;
    return n + NaturalElementSum(m, n - 1);

}
Console.WriteLine();

 