void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for (int position = 0; position < count; position++)
    {
        Console.Write(col[position] + " ");
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int position = -1;
    for ( int index = 0; index < count; index++)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444);

Console.WriteLine(pos);

