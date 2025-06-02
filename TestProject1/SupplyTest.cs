using CommoditySupply;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[TestFixture]
public class SupplyTests
{
    ÑommoditySupplyy supply;
    Commodity[] commodities;
    [SetUp]
    public void Setup()
    {
        var oranges = new Commodity("Àïåëüñèíû");
        var bananas = new Commodity("Áàíàíû");
        var lemons = new Commodity("Ëèìîíû");
        var cucumbers = new Commodity("Îãóðöû");
        var apples = new Commodity("ßáëîêè");

        commodities = new Commodity[] { oranges, bananas, lemons, cucumbers, apples };
        supply = new ÑommoditySupplyy("Èâàíîâ Èâàí Ñåðãååâè÷", 235109, "02.06.2025", commodities);
    }
    [Test]
    public void ConstructorTest()
    {
        Assert.That(supply.Supplier, Is.EqualTo("Èâàíîâ Èâàí Ñåðãååâè÷"));
        Assert.That(supply.SupplyNumber, Is.EqualTo(235109));
        Assert.That(supply.SupplyDate, Is.EqualTo(new DateTime(2025, 6, 2)));

        foreach (var commodity in commodities)
            Assert.That(supply.Count(s => s.Equals(commodity)), Is.EqualTo(1));
    }
}
