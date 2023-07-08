/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6]-> 0 */

Console.Write("Введите количество элементов массива -> ");
int q = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[q];

void num(int q)
{
    for (int i = 0; i < q; i++)
    {
        randomArray[i] = new Random().Next(1, 99);
        Console.Write(randomArray[i] + " ");
    }

}

int kol(int[] randomArray)
{
    int sum = 0;
    int i = 0;
    while (i < randomArray.Length)
    {
        sum = sum + randomArray[i];
        i = i + 2;
    }
    return sum;
}
num(q);
Console.WriteLine( );
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях = {kol(randomArray)}");