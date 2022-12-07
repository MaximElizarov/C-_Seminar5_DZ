void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 999);
    
}
Console.Clear();
int n = 7;
int[] arr = new int[n];
int result = 0;
InputArray(arr);
for(int i = 0; i < n; i++)
{
    Console.WriteLine(arr[i]);
    if(arr[i] % 2 == 0)
    {
        result ++;
    }
}
Console.Write("Колличество четных элементов: " + result);




// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2