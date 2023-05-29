string FillUpArray(int[] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($"{array[i]} ");
    }
    return result;
}

int NumberOfEvenDigits(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
        else continue;
    }
    Console.WriteLine();
    return count;
}




try
{
    Console.Write("Insert the size of an array = ");
    int num = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[num];
    Console.Write("The generated array: ");
    FillUpArray(array);
    Console.Write($"The number of even digits in the generated array is {(NumberOfEvenDigits(array))} ");
}
catch
{
    Console.WriteLine("~ You may insert only numbers ~");
}