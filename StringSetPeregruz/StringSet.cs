public class StringSet
{
    private HashSet<string> set = new HashSet<string>();

    public void Add(string value)
    {
        set.Add(value);
    }

    public static StringSet operator +(StringSet set1, StringSet set2)
    {
        StringSet result = new StringSet();
        foreach (string value in set1.set)
        {
            result.Add(value);
        }
        foreach (string value in set2.set)
        {
            result.Add(value);
        }
        return result;
    }

    public static StringSet operator &(StringSet set1, StringSet set2)
    {
        StringSet result = new StringSet();
        foreach (string value in set1.set)
        {
            if (set2.set.Contains(value))
            {
                result.Add(value);
            }
        }
        return result;
    }

    public void Print()
    {
        foreach (string value in set)
        {
            Console.WriteLine(value);
        }
    }
}
