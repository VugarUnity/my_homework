//Задайте произвольный массив. Выведете его элементы, 
//начиная с конца. Использовать рекурсию, не использовать циклы.

//Console.Write("Введите размерность массива: ");
//int n = Convert.ToInt32(Console.ReadLine());


int[] array = { 1, 2, 5, 0, 10, 34 };
PrintArrayReverse(array, array.Length - 1);
void PrintArrayReverse(int[] array, int i)
{
    {
        if (i < 0)
            return;

        Console.WriteLine(array[i]);
        PrintArrayReverse(array, i - 1);
    }
}

