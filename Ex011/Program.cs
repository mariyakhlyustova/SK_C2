// заполнить массив случайными числами
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;

    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

// вывести массив
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;

    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

// Это функция поиска find 
int Index0f(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    // примем за -1, чтобы показать отсутствие
    // такого числа, а не нулевой индекс
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            // остановить после первого найденного
            break;
        }
        index++;
    }
    return position;
}

// вводим параметры массива
int[] array = new int[10];

// ВЫВОД в терминал:
// создание
FillArray(array);
// сюда можно в рандомный массив принудительно добавить 
// число и указать его индекс в массиве
//[индекс] = число
array[3] = 5;
// печать массива
PrintArray(array);
// отступили строку
Console.WriteLine();

int pos = Index0f(array, 8);
// печать индекса искомого
Console.WriteLine(pos);
