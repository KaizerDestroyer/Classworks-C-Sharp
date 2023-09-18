int[] array = { 1, 245, 5435, 5435, 75, 432, 54, 21 };

int n = array.Length;
int find = 5435;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    index++;
}