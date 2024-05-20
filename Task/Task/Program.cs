void ShowSmallStrings(string[] str)
{
    if (CountNewArraySize(str) > 0)
    {
        string[] newStr = new string[CountNewArraySize(str)];
        int j = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i].Length <= 3)
            {
                newStr[j] = str[i];
                j++;
            }
        }
        PrintStringArray(newStr);
    }
    else
        Console.WriteLine("[]");
}

void PrintStringArray(string[] str)
{
    Console.Write("[");
    for (int i = 0; i < str.Length - 1; i++)
    {
        Console.Write(str[i] + ", ");
    }
    Console.Write(str[str.Length - 1] + "]");
}

int CountNewArraySize(string[] str)
{
    int c = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
        {
            c++;
        }
        else
            c += 0;
    }
    return c;
}

string[] str = { "He78", "2857", "eva", ":-)" };
PrintStringArray(str);
Console.Write(" -> ");
ShowSmallStrings(str);



