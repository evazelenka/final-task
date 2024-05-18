string[] ShowSmallStrings(string[] str)
{
    if (CountNewArraySize(str) > 0)
    {
        string[] str3 = new string[CountNewArraySize(str)];
        int j = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (CountElements(StringToChar(str[i])) <= 3)
            {
                str3[j] = str[i];
                j++;
            }
        }
        return str3;
    }
    else
        return str;
}

char[] StringToChar(string str)
{
    char[] chars = new char[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        chars[i] = str[i];
    }
    return chars;
}

int CountElements(char[] chars)
{
    return chars.Length;
}

void PrintStringArray(string[] str)
{
    Console.Write("[");
    for (int i = 0; i < str.Length - 1; i++)
    {
        Console.Write(str[i] + ", ");
    }
    Console.Write(str[str.Length - 1] + "]");
    Console.WriteLine();
}

int CountNewArraySize(string[] str)
{
    int c = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (CountElements(StringToChar(str[i])) <= 3)
        {
            c++;
        }
        else
            c += 0;
    }
    return c;
}

string[] str = { "Hello", "28", "eva", ":-)" };
PrintStringArray(str);
PrintStringArray(ShowSmallStrings(str));
