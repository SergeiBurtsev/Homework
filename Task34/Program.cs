/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */





Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[size];
Array(arr);
Console.WriteLine("Массив: ");
PrintArray(arr);
int count = 0;

for (int i = 0; i < arr.Length; i++)
if (arr[i] % 2 == 0)
count++;

Console.WriteLine($"Четных чисел в массиве {count}");

void Array(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(101,999);
    }
}
void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for(int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
    Console.WriteLine();
}