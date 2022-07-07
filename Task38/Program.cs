double[] RandomArray(int elements)
{
    double[] array = new double[elements];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (new Random().Next(1, 31)) + new Random().NextDouble();
        array[i] = Math.Round(array[i], 2);
    }
    return array;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

double Subtraction(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }
    
    Console.WriteLine("Максимальное значение массива: " + max);
    Console.WriteLine("Минимальное значение массива: " + min);
   
    double subtr = max - min;
    subtr = Math.Round(subtr, 2);
    return subtr;

}

Console.Write("Введите количество элементов массива: ");

int elem = Convert.ToInt32(Console.ReadLine());

double[] newarray = RandomArray(elem);

Console.Write("Сгенерированный массив: ");

ShowArray(newarray);

Console.WriteLine("Разница между max и min значениями элементов массива: " + (Subtraction(newarray)));