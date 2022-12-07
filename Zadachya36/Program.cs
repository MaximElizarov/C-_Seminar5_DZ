void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 100);
    
}
Console.Clear();
int n = 7;
int[] arr = new int[n];
int result = 0;
InputArray(arr);
for(int i = 0; i < n; i++)
{
    Console.WriteLine(arr[i]);
    if(i % 2 == 1)
    {
        result = result + arr[i];
    }
}
Console.Write("Сумма нечяетных элементов: " + result);













// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0