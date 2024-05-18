string[] ShowSmallStrings(string[] str)
{
    if (CountNewArraySize(str) > 0)
    {
        string[] str3 = new string[CountNewArraySize(str)];
        int j = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (CountElements(str[i]) == true)
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

bool CountElements(string str)
{
    if (str.Length <= 3)
    {
        return true;
    }else
    return false;
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
        if (CountElements(str[i]) == true)
        {
            c++;
        }
        else
            c += 0;
    }
    return c;
}

string[] str = { "He", "28", "eva", ":-)" };
PrintStringArray(str);
PrintStringArray(ShowSmallStrings(str));
