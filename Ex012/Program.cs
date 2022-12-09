// МЕТОДЫ

// 1 ВИД
// ничего не принимает и не возвращает, просто печатает строку

void Method1()
{
    Console.WriteLine("Автор ...");
}
 Method1();

// 2 ВИД
// получает строку и просто выводит ее

void Method2(string msg)
{
    Console.WriteLine(msg);
}
 Method2(msg: "текст");

// дополнен количеством раз вывода строки
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "текст", count: 4);

// 3 ВИД
// ничего не принимает, возвращает, например, дату/год

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);



// 4 ВИД
// принимает аргуметны и возвращает результат

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);





