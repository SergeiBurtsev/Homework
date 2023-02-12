/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */
Console.WriteLine("Введите число M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Akkerman(number1,number2);

int Akkerman(int number1, int number2)
{
    if (number1 == 0)
        return number2 + 1;
    if (number1 > 0 && number2 == 0)
        return Akkerman(number1 - 1, 1);
    else
        return Akkerman(number1 - 1, Akkerman(number1, number2 - 1));
}

Console.WriteLine($"A({number1},{number2}) = {Akkerman(number1, number2)}");