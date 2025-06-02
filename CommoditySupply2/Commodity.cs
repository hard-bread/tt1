using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommoditySupply2
{
    public class Commodity : IComparable<Commodity>
    {
        public string Name { get; }

        public Commodity(string name)
        {
            Name = name;
        }

        public int CompareTo(Commodity other)
        {
            if (other == null) return 1;
            return string.Compare(Name, other.Name, StringComparison.Ordinal);
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
