//------------------------------------------------------------------------------
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);
        return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int Numbers(int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
    if (array[i] % 2 == 0)
    count++;
return count;
}

Console.Write("input a lenght of new array: ");
int Length = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(Length);
ShowArray(myArray);
Console.WriteLine("even numbers: "+ Numbers(myArray));
*/
//-----------------------------------------------------------------------------
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
        return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int Numbers(int[] array)
{
int sum = 0;
    for (int i = 1; i < array.Length; i++)
        if (i % 2 == 1)
            sum ++;
return sum;
}
Console.Write("input a lenght of new array: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(Length, min, max);
ShowArray(myArray);
Console.WriteLine("sum odd elements: "+ Numbers(myArray));
*/
//--------------------------------------------------------------------------
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for(int i = 0; i<size; i++)
        array[i] = new Random().NextDouble() + new Random().Next(minValue, maxValue);
    return array; 
}
void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(Math.Round(array[i], 2) + "  ");
    Console.WriteLine();
}
double DifNum(double[] array)
{
    double max = array[0];
    double min = array[0];
    for(int i = 1; i<array.Length; i++)
    {
        if(array[i]>max) max = array[i];
        if(array[i]<min) min = array[i];
    }
     double difnum = max - min;
    return difnum;
}
Console.WriteLine("input a lenght of new array:  ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input a min possible value:  ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
double[] array = CreateRandomArray(size, min, max);
ShowArray(array);
double difnum = Math.Round(DifNum(array),2);
Console.WriteLine(difnum);