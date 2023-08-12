public class StringCollection
{
    private List<string> collection = new List<string>();

    public void Add(string value)
    {
        collection.Add(value);
    }

    public string this[int index]
    {
        get { return collection[index]; }
        set { collection[index] = value; }
    }

    public void Print()
    {
        foreach (string value in collection)
        {
            Console.WriteLine(value);
        }
    }
}