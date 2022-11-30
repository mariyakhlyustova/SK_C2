int[] array = { 5, 7, 8, 12, 7, 9, 56, 24 };

int n = array.Length;
int find = 7;

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
