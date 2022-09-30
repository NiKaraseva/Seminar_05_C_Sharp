/* Задача 1: Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, 
и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

int[] array = GetArray(10, -10, 10);
Console.WriteLine(String.Join(" ", array));

for(int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * (-1);
}
Console.WriteLine(String.Join(" ", array));



int[] GetArray(int size, int minValue, int maxValue) // создание массива 
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
} 




/* Задача 2: Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; маcсив [6, 7, 19, 345, 3] -> да */ 

/* Console.WriteLine("Загадываем число от 0 до 9");
int number = new Random().Next(0, 9);
Console.WriteLine($"Загаданное число = {number}");

int[] array = GetArray(5, -10, 10);
Console.WriteLine(String.Join(" ", array));
int count = 0;

for(int i = 0; i < array.Length; i++)
{
    if (array[i] == number)
    {
        Console.WriteLine($"Число {number} присутствует в массиве");
        count++;
        break;
    }
}
if (count == 0)
{
    Console.WriteLine("Искомого числа в массиве нет!");
}



int[] GetArray(int size, int minValue, int maxValue) // создание массива
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
} */ 