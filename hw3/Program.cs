/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

Console.Write("Введите количество элементов массива -> ");
int q = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[q];

void num(int q)
{
    for (int i = 0; i < q; i++)
    {
        randomArray[i] = new Random().Next(1, 99);
        Console.Write(randomArray[i] + " ");
    }

}

double raz(double[] randomArray)
{
    double min = randomArray[0];
    double max = randomArray[0];
    int i = 1;
    while (i < randomArray.Length)
    {
        if (max < randomArray[i])
            max = randomArray[i];
        if (min > randomArray[i])
            min = randomArray[i];
        i = i + 1;
    }
    return max - min;
}

num(q);
Console.WriteLine( );
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {raz(randomArray):F2}");