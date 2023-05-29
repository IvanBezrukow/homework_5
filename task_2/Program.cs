string FillUpArray(int[] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
        Console.Write($"{array[i]} ");
    }
    return result;
}

int Sum(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) result = result + array[i];
        else continue;
    }
    return result;
}




try
{
    Console.Write("Insert the size of an array = ");
    int num = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[num];
    FillUpArray(array);
    Console.Write($"The sum of numbers with uneven indexes {Sum(array)} ");
}
catch
{
    Console.WriteLine("You may insert only numbers");
}