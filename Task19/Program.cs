/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */

Console.Write("Введите целое число: ");
int number;
if (int.TryParse(Console.ReadLine(), out number))
    NumberComp(number, Mirroring(number));
else
    Console.WriteLine("Введено некорректное значение. Введите целое число");
    int Mirroring(int num)
{
    int mirrornum = 0;
    while (num > 0)
    {
        mirrornum = mirrornum * 10 + num % 10;
        num = num / 10;
    }
    return (mirrornum);
}

void NumberComp(int num, int mnum)
{
    if (mnum == num)
        Console.WriteLine($"Число {num} является палиндромом");
    else
        Console.WriteLine($"Число {num} не является палиндромом");
}