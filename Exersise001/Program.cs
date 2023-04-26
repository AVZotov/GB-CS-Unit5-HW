int[] GetArray()
{
    int minArrayLength = 5;
    int maxArrayLength = 9;
    int[] array = new int[new Random().Next(minArrayLength, maxArrayLength + 1)];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }

    return array;
}

int GetEvenSum(int[]array)
{
int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sum += array[i];
        }
    }

    return sum;
}

int[] array = GetArray();

Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Summ of even in array = {GetEvenSum(array)}");