// Method 1
// void Method1()
// {
//     Console.WriteLine("Лублу какат");
// }

// Method1();

// Method 2
// void Method2(string message)
// {
//     Console.WriteLine(message);
// }

// Method2("Кикашки");

// void Method21(string message, int count)
// {
//     int i = 0;
//     int num = 1;
//     while (i < count)
//     {
//         Console.WriteLine(message + num);
//         num++;
//         i++;
//     }
// }

// Method21("Кикашки", 100);


// Method 3
// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

// Method 4

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(10, "la");
// Console.WriteLine(res);

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

int[] arr = { 1, 5, 6, 3, 2, 9, 4, 7, 8, 1, 3 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j <= array.Length - 1; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}


PrintArray(arr);
SelectionSort(arr);


PrintArray(arr);