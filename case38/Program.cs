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
    for (int i = 0; i < newArr.Length; i++)
    {
        int min = 1;
        int max = 100;
        newArr[i] = Math.Round(rnd.NextDouble() + rnd.Next(min, max), 2);
    }
}

double FindDifMaxMin(double[] newArr)
{
    double difMaxMin = 0;
    int max = 0;
    int min = 0;
    for (int i = 1; i < newArr.Length; i++)
    {
        if (newArr[i] > newArr[max])
        max = i;
        else if (newArr[i] < newArr[min])
        min = i;
    }
    return difMaxMin = Math.Round(newArr[max] - newArr[min], 2);
}

void PrintArray(double[] newArr)
{
    Console.Write("[ ");
    for (int i = 0; i < newArr.Length -1; i++)
        Console.Write(newArr[i] + "; ");
    Console.Write(newArr[newArr.Length -1] + " ]");
    Console.WriteLine();
}

int size = InputNum("Введите размер массива: ");
double[] doubles = new double[size];
FillArray(doubles);
double res = FindDifMaxMin(doubles);
PrintArray(doubles);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {res}.");