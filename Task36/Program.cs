int[] RandomArray(int elements)
{
    int[] array = new int[elements];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int SumOddElements(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum += array[i];
    }
    return sum;
}

Console.Write("Введите количество элементов массива: ");

int elem = Convert.ToInt32(Console.ReadLine());

int[] newarray = RandomArray(elem);

Console.Write("Сгенерированный массив: ");

ShowArray(newarray);

Console.WriteLine("Сумма элементов, стоящих на нечетных позициях массива: " + (SumOddElements(newarray)));

