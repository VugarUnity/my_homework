//Задайте значения M и N. Напишите программу, которая выведет все натуральные 
//числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.


Console.Write("Ввести число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввести число n: ");
int n = Convert.ToInt32(Console.ReadLine());

 void PrintNumbersRecursive(int m, int n)
{
    if (m <= n)
    {
        Console.WriteLine(m);
        PrintNumbersRecursive(m+1, n);
    }
}

Console.Write($"Натуральные числа от " + m + " до " + n + ": ");
Console.WriteLine();
PrintNumbersRecursive(m, n);