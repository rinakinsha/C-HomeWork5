int[] RandomArray(int elements)
{
    int[] array = new int[elements];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
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

int EvenNumber(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

Console.Write("Введите количество элементов массива: ");

int elem = Convert.ToInt32(Console.ReadLine());

int[] newarray = RandomArray(elem);

Console.Write("Сгенерированный массив: ");

ShowArray(newarray);

Console.WriteLine("Количество четных чисел в массиве: " + (EvenNumber(newarray)));