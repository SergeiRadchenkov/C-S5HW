/* Задача 36: Задайте одномерный массив, 
заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int InputNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void FillArray(int[] newArr)
{
    for (int i = 0; i < newArr.Length; i++)
        newArr[i] = new Random().Next(-99, 100);
}

int FindSumOddNum(int[] newArr)
{
    int sum = 0;
    for (int i = 1; i < newArr.Length; i = i + 2)
        sum += newArr[i];
    return sum;
}

void PrintArray(int[] newArr)
{
    Console.Write("[ ");
    for (int i = 0; i < newArr.Length -1; i++)
        Console.Write(newArr[i] + ", ");
    Console.Write(newArr[newArr.Length -1] + " ]");
    Console.WriteLine();
}

int size = InputNum("Введите размер массива: ");
int[] newArray = new int [size];
FillArray(newArray);
int res = FindSumOddNum(newArray);
PrintArray(newArray);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {res}.");