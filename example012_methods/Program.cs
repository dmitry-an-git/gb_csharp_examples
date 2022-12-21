// string method4(int Count, string text)
// 	{
// 		int i = 0;
// 		string result = String.Empty;
// 		while (i<Count)
// 			{result += text;
// 			i++;}
// 		return result;
// 	}

// string res = method4(10, "qwerty");
// Console.WriteLine(res);

// sorting
int n=10;
int[] my_array = new int[n];
Random r = new Random();
for (int i=0;i<10;i++)
    {
        my_array[i]=r.Next(0,1000);
    }

void PrintArray(int[] array)
{
    for (int i=0;i<array.Length; i++)
        {Console.Write($"{array[i]} ");}
    Console.WriteLine();
}

void SelectionSortMin(int[] array)
{
    for (int i=0;i<array.Length;i++)
    {
        int min = array[i];
        int min_ind = i;
        for (int j=i+1;j<array.Length;j++)
            if(min>array[j])
                {
                    min = array[j];
                    min_ind = j;
                }
        array[min_ind] = array[i];
        array[i] = min;
    }
}

void SelectionSortMax(int[] array)
{
    for (int i=0;i<array.Length;i++)
    {
        int max = array[i];
        int max_ind = i;
        for (int j=i+1;j<array.Length;j++)
            if(max<array[j])
                {
                    max = array[j];
                    max_ind = j;
                }
        array[max_ind] = array[i];
        array[i] = max;
    }
}

PrintArray(my_array);

SelectionSortMin(my_array);

PrintArray(my_array);

SelectionSortMax(my_array);

PrintArray(my_array);