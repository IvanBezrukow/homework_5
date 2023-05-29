string FillUpArray(double[] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * 1000;
        Console.Write($"{Math.Round(array[i], 2)}; ");
    }
    return result;
}

double Min(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        double temp = array[i];
        if (min > array[i])
        {
            min = array[i];
            array[i] = temp;
        }
        else continue;
    }
    return Math.Round(min, 2);
}

double Max(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        double temp = array[i];
        if (max < array[i])
        {
            max = array[i];
            array[i] = temp;
        }
    }
    return Math.Round(max, 2);
}

double Subtraction(double arg1, double arg2)
{
    double result = arg1 - arg2;
    return Math.Round(result, 2);
}




try
{
    Console.Write("Insert the size of an array = ");
    int num = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[num];
    if (num > 1)
    {
        Console.Write("The generated array: ");
        Console.WriteLine(FillUpArray(array));
        Console.WriteLine($"The min number of the array = {Min(array)}");
        Console.WriteLine($"The max number of the array = {Max(array)}");
        Console.WriteLine($"The result of the min number being subtracted from the max number = {Subtraction(Max(array), Min(array))}");
    }
    else Console.WriteLine("The size of an array should be equel or more than two");
}
catch
{
    Console.WriteLine("You may insert only numbers");
}