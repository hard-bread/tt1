using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommoditySupply
{
    public class Supply : IEnumerable<Commodity>
    {
        public string Supplier { get; set; }
        public int SupplyNumber { get; set; }
        public DateTime SupplyDate;

        List<Commodity> products;

        public Supply(string supplier, int supplyNumber, string supplydate, IEnumerable<Commodity> commodities)
        {
            Supplier = supplier;
            SupplyNumber = supplyNumber;
            SupplyDate = DateTime.Parse(supplydate);
            products = new List<Commodity>();
            foreach (var commodity in commodities)
                if (!products.Contains(commodity))
                    products.Add(commodity);
        }
        public IEnumerator<Commodity> GetEnumerator() => products.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
