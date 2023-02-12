/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Введите число M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M: ");
int number2 = Convert.ToInt32(Console.ReadLine());

SumNumbers(number1,number2);

int SumNumbers(int number1, int number2)
{
    if(number1 == number2) return number2;
    return number2 + SumNumbers(number1,number2 -1);
}

Console.WriteLine($"Сумма элементов от {number1} до {number2} = {SumNumbers(number1, number2)}");