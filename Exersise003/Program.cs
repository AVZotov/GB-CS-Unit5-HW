double[] GetArray()
{
    int minArrayLength = 5;
    int maxArrayLength = 9;
    int minValue = -10;
    int maxValue = 10;

    double[] array = new double[new Random().Next(minArrayLength, maxArrayLength + 1)];

    for (int i = 0; i < array.Length; i++)
    {
        int divider = new Random().Next(1, 10);
        double value = (double) new Random().Next(minValue, maxValue) / (double) divider;
        array[i] = Math.Round(value, 1);
    }

    return array;
}

double GetMinValue(double[] array)
{
    double minValue = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minValue)
        {
            minValue = array[i];
        }
    }

    return minValue;
}

double GetMaxValue(double[] array)
{
    double maxValue = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxValue)
        {
            maxValue = array[i];
        }
    }

    return maxValue;
}

double[] array = GetArray();

Console.WriteLine(string.Join(", ", array));
double difference = GetMaxValue(array) - GetMinValue(array);
Console.WriteLine($"Difference between max value and min value in array = {difference}");