int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}


int a1 = 0;
int b1 = 8;
int c1 = 45;
int d1 = 45;
int e1 = 6;
int b3 = 19;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b1, c1);
// int max3 = Max(a1, b1, c1);
// int max = Max(max1, max2, max3);

int max = Max(max1, max2, max3)

Console.WriteLine(max);