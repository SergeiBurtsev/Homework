/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2 */

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
Array( array);
Console.WriteLine();
PrintArray( array);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i <  array.Length; i++)
{
    if ( array[i] > max)
        {
            max =  array[i];
        }
    if ( array[i] < min)
        {
            min =  array[i];
        }
}
void Array(double[]  array)
{
    for(int i = 0; i <  array.Length; i++)
        {
              array[i] =  Convert.ToDouble(new Random().Next(100,10000)) / 100;
             // есть ли более простой способ, чтобы в 38 сроке сократить код? а просто вывести  array[i]
        }
}
void PrintArray(double[]  array)
{
    Console.Write("|");
    for(int i = 0; i <  array.Length; i++)
        {
            Console.Write($"{Math.Round( array[i], 1, MidpointRounding.ToZero)}|");
        }
    
    Console.WriteLine();
}
 

Console.WriteLine($"Разница между максимальным и минимальным значением  массива = {Math.Round(max-min, 1, MidpointRounding.ToZero)}");