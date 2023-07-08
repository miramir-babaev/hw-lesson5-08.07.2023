/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

Console.Write("Введите количество элементов массива -> " );
int q = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[q];

void num(int q)
{
    for (int i = 0; i < q; i++)
    {
        randomArray[i] = new Random().Next(99, 999);
        Console.Write(randomArray[i] + " ");
    }

}

int EvenNum(int[] randomArray)
{
    int EvenNum = 0;
    for (int i = 0; i < randomArray.Length; i++)
    {
        if (randomArray[i] % 2 == 0)
            EvenNum = EvenNum + 1;
    }
    return EvenNum;
}

num(q);
Console.WriteLine( );
Console.WriteLine($"Количество чётных чисел в массиве -> {EvenNum(randomArray)}");