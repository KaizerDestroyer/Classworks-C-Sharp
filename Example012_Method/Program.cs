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

void Method21(string message, int count)
{
    int i = 0;
    int num = 1;
    while (i < count)
    {
        Console.WriteLine(message + num);
        num++;
        i++;
    }
}

Method21("Кикашки", 100);