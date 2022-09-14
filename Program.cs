

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


