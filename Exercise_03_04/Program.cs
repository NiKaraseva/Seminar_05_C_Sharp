/* Задача 3: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

*Пример для массива из 5, а не 123 элементов. 
В своём решении сделайте для 123*
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */


/* int[]array = GetArray(123, 0, 1000);
Console.WriteLine(String.Join(" ", array));

int sum = HowMany(array, 10, 99);
Console.WriteLine($"Количество элементов в отрезке [10, 99] ={sum}"); */

// Способ 1 (через цикл)
/* int sum = 0;
for(int i = 0; i < array.Length; i++)
{
    if ((array[i] > 9) && (array[i] < 99))
    {
        sum = sum + 1;
    }
}
Console.WriteLine($"Количество элементов в отрезке от 10 до 99 = {sum}"); */

// Способ 2 (через функцию)

/* int HowMany(int[] array, int min, int max)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if((array[i] >= min) && (array[i] <= max))
        {
            count++;
        }
    }
    return count;
} */ 


/* int[] GetArray(int size, int minValue, int maxValue) // создание массива 
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
} */ 




/* Задача 4: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */


int[] array = GetArray(9, -10, 8);
int[] res = Factorial(array);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine(String.Join(" ", res));


int[] GetArray(int size, int minValue, int maxValue) // создание массива 
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
} 

int[] Factorial(int[] array)
{
    int newsize = 0;
    if(array.Length % 2 == 0)
    {
        newsize = array.Length / 2;
    }
    else
    {
        newsize = array.Length / 2 + 1;
    }

    int[] newArr = new int[newsize];
    for (int i = 0, j = array.Length - 1; i < newsize; i++, j--)
    {
        if (i != j)
        {
            newArr[i] = array[i] * array[j];
        }
        else
        {
             newArr[i] = array[i];
        }
    }
    return newArr;
}

