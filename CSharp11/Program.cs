Console.WriteLine(AddAll(1,2,3,5,7,11,13,17));

static int AddAll(params int[] values)
{
    if (values == null) throw new ArgumentNullException(nameof(values));

    int result = 0;
    foreach (var value in values)
    {
        result += value;
    }
    return result;
}