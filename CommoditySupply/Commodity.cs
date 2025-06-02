using System;

public class Commodity : IComparable<Commodity>
{
    public string Name { get; }

    public Commodity(string name)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }

    public int CompareTo(Commodity other)
    {
        if (other == null) return 1;
        return string.Compare(Name, other.Name, StringComparison.Ordinal);
    }
}
