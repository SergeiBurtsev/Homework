/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */
Console.Write("Введите число A: ");

double numbers;

if (double.TryParse(Console.ReadLine(), out numbers))
{
    Console.Write("Введите натуральное число B: ");
    
    int number1;
    
    if (int.TryParse(Console.ReadLine(), out number1) && number1 > 0) 
    {
         double answer = Math.Round(Number1(numbers, number1), 3, MidpointRounding.AwayFromZero);

        Console.WriteLine($"Число {numbers} в степени {number1} -> {answer}");

    }

    else Console.WriteLine("Введено некорректное значение числа B. Введите натуральное число.");

}

else Console.WriteLine("Введено некорректное значение числа A. Введите число.");

double Number1(double num1, int num2)
{
    double result = Math.Pow(num1, num2);
    return result;
}