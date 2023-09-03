/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

int InputNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void FillArray(double[] newArr)
{
    Random rnd = new Random();
    for (int i = 0; i < doubles.Length; i++)
    {
        int min = -99;
        int max = 100;
        doubles[i] = Math.Round(rnd.NextDouble() + rnd.Next(min, max), 2);
    }
}

double FindDifMaxMin(double[] newArr)
{
    double difMaxMin = 0;
    
}

int size = InputNum("Введите размер массива: ");
double[] doubles = new double[size];
FillArray(doubles);

Console.WriteLine(String.Join(" ", doubles));
