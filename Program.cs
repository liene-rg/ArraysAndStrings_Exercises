

// Check if string has only unique values
bool IsCharUnique(String str)
{
    if (str.Length > 128) // assuming 128 ASCII 
    {
        return false;
    }
    bool[] charSet = new bool[128];
    for (int i = 0; i < str.Length; i++)
    {
        int val = str.ElementAt(i);
        if (charSet[val])
        {
            return false;
        }
        charSet[val] = true;
    }
    return true;
}

Console.WriteLine(IsCharUnique("122bcd"));


// check if string is a permutation of the other

String SortString(String str)
{
    char[] content = str.ToCharArray();
    Array.Sort(content);
    return new String(content);
}

bool Permutation(String str1, String str2)
{
    if (str1.Length != str2.Length)
    {
        return false;
    }
    return SortString(str1).Equals(SortString(str2));
}

Console.WriteLine(Permutation("abcv", "cbas"));