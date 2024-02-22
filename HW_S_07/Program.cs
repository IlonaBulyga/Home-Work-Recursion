// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"
string printNumber(int m, int n)
{
    if (n == m)
        return $"{m} ";
    return printNumber(m,n - 1) + $"{n} ";
}
Console.Clear();
Console.Write("Enter the first number M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Enter the last number N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(printNumber(m,n));
Console.Write("Next? ");
string str = Console.ReadLine()!;
// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
//           | n + 1,                 m = 0;
// A(m, n) = | A(m-1, 1),             m > 0, n = 0;
//           | A(m - 1, A(m, n - 1)), m > 0, n > 0.
// m = 2, n = 3 -> A(m,n) = 29
int akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
        if (n == 0)
            return akkerman(m - 1, 1);
        else return akkerman(m - 1, akkerman(m, n - 1));
}
Console.Clear();
Console.Write("Enter the number M: ");
int am = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number N: ");
int an = int.Parse(Console.ReadLine()!);
Console.WriteLine(akkerman(am,an));
Console.Write("Next? ");
str = Console.ReadLine()!;
// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 
void inputArray(int[] array, int i)
{
array[i] = new Random().Next(1, 100); 
if (i < array.Length - 1)
    inputArray(array, i + 1);
}
void reversArray(int[] array, int i)
{
Console.Write(array[i] + " ");
if (i > 0)
    reversArray(array, i - 1);
}
Console.Clear();
Console.Write("Enter the number of array elements: ");
int k = int.Parse(Console.ReadLine()!);
int[] array = new int[k];
inputArray(array,0);
Console.WriteLine($"The initial array: [{string.Join(", ", array)}]");
Console.Write("The revers: ");
reversArray(array, array.Length - 1);
