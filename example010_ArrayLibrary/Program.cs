Console.Clear();

int[] array = new int[10];

void fill_array(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index<length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
} 

void print_array(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position<count)
    {
        Console.Write($"{col[position]}, ");
        position++;
    }
    Console.WriteLine();
}

int find_position(int find, int[] collection)
{
    int length = collection.Length;
    int index = 0;
    int position = -1;
    while (index<length)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

fill_array(array);
print_array(array);
Console.WriteLine(find_position(4,array));
