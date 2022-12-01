Console.Clear();

int a1 = 1;
int a2 = 13;
int a3 = 13;
int a4 = 41;
int a5 = 12;
int a6 = 12;
int a7 = 14;
int a8 = 413;
int a9 = 31;

int max = a1;

// if (a2>max) max = a2;
// if (a3>max) max = a3;

// if (a4>max) max = a4;
// if (a5>max) max = a5;
// if (a6>max) max = a6;

// if (a7>max) max = a7;
// if (a8>max) max = a8;
// if (a9>max) max = a9;

// Console.WriteLine(max);

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int max1 = Max(a1,a2,a3);
int max2 = Max(a4,a5,a6);
int max3 = Max(a7,a8,a9);
int superMax = Max(max1,max2,max3);
Console.WriteLine(superMax);