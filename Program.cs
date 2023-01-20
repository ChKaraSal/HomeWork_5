//Задача №34.
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Задача №34");
int[] Array = GetArray(4); 
int[] GetArray (int size) 
{ 
    int[] Array = new int[size]; 
    for (int i = 0; i < size; i++) 
    { 
      Array[i] = new Random().Next(100, 999);   
    } 
    return Array; 
} 
Console.WriteLine($"{String.Join(", ",Array)}"); 

int count = 0;
for (int i = 0; i < Array.Length; i++)
if (Array[i] % 2 == 0)
count++;
Console.WriteLine($"всего {Array.Length} чисел, {count} из них чётные");


//Задача №36. 
//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных индексах.
Console.WriteLine("Задача №36");
int[] numbers1 = new int[4];
FillArrayRandomNumbers(numbers1);
PrintArray(numbers1);
int result = 0;
for (int i1 = 0; i1 < numbers1.Length; i1++)
{
    if (i1 % 2 != 0)
    {
        result += numbers1[i1];
    }
}
Console.WriteLine($"Сумма элементов на нечетных индексах = {result}");

void FillArrayRandomNumbers(int [] array1)
{
    for (int i1 = 0; i1 < array1.Length; i1++)
    {
        array1[i1] = new Random().Next(10, 100);
    }
}

void PrintArray(int[] array1)
{
    for (int i1 = 0; i1 < array1.Length; i1++)
    {
        Console.Write(array1[i1] + " ");
    }
    Console.WriteLine();
}


//Задача №37.
//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
Console.WriteLine("Задача №37");
int[] startArray1 = GetArray1(6, 1 , 10);
Console.WriteLine(String.Join(" ", startArray1));
Console.WriteLine(String.Join(" ", ResultArray(startArray1)));

int[] GetArray1(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int index = 0; index < size; index++)
    {
        result[index] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
} 

int[] ResultArray(int[] array1)
{
    int size = array1.Length / 2;
    if (array1.Length % 2 == 1) size++;
    int[] result = new int[size];
    for (int index = 0; index < array1.Length / 2; index++)
    {
        result[index] = array1[index] * array1[array1.Length - 1 - index];
    }
    if (array1.Length % 2 == 1) result[size - 1] = array1[array1.Length / 2];
    return result;
}


