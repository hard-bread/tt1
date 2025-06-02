using System;
using System.Collections;
using System.Collections.Generic;

namespace CommoditySupply
{
    public class Supply : IEnumerable<Commodity>
    {
        public string Supplier { get; }
        public int SupplyNumber { get; }
        public DateTime SupplyDate { get; }
        private readonly List<Commodity> commodities;

        public Supply(string supplier, int supplyNumber, DateTime supplyDate, List<Commodity> commodities)
        {
            Supplier = supplier ?? throw new ArgumentNullException(nameof(supplier));
            SupplyNumber = supplyNumber;
            SupplyDate = supplyDate;
            this.commodities = commodities ?? throw new ArgumentNullException(nameof(commodities));
        }

        // Исправлено: Явно указываем, что Supply реализует IEnumerable<Commodity>
        public IEnumerator<Commodity> GetEnumerator()
        {
            return commodities.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IReadOnlyList<Commodity> Commodities => commodities;

        public int Count => commodities.Count;
    }
}
