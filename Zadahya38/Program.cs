void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().NextDouble() * 100;
    
}
Console.Clear();
int n = 6;
double[] arr = new double[6];
InputArray(arr);
double min = arr[0];
double max = arr[0];
for(int i = 0; i < n; i++)
{
    Console.WriteLine(arr[i]);
    if(min > arr[i])
    {
        min = arr[i];
    }
    if(max < arr[i])
    {
        max = arr[i];
    }
}
Console.WriteLine("Вывод макс " + max);
Console.WriteLine("Вывод мин " + min);
double result = max - min;
Console.WriteLine("Разница: " + result);









// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

