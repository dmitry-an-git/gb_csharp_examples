// See https://aka.ms/new-console-template for more information
Console.Clear();

// int[] my_array = {1,2,3,4,5,6,7,8,9};

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int max = Max(Max(my_array[0],my_array[1],my_array[2]),
//     Max(my_array[3],my_array[4],my_array[5]),
//     Max(my_array[6],my_array[7],my_array[8]));

// Console.WriteLine(max);

int[] array = {1,2,3,4,5,6,7,8,9};

int n = array.Length;

int find = 9;
int index = 0;

while (index<n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
