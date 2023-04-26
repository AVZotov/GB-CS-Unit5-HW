int[] GetArray()
{
    int minArrayLength = 5;
    int maxArrayLength = 9;
    int[] array = new int[new Random().Next(minArrayLength, maxArrayLength + 1)];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }

    return array;
}

int GetSumOddIndex(int[] array)
{
    int sum = 0;

    for (int i = 1; i < array.Length;)
    {
        sum += array[i];
        i += 2;
    }

    return sum;
}

int[] array = GetArray();

Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Summ of values in array at odd indexes = {GetSumOddIndex(array)}");