/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int InputNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void FillArray(int[] newArr)
{
    for (int i = 0; i < newArr.Length; i++)
        newArr[i] = new Random().Next(100, 1000);
}

int FindPosNum(int[] newArr)
{
    int count = 0;
    for (int i = 0; i < newArr.Length; i++)
    {
        if(newArr[i] % 2 ==0)
            count ++;        
    }
    return count;
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
int res = FindPosNum(newArray);
PrintArray(newArray);
Console.WriteLine($"В массиве {res} чётных чисел.");