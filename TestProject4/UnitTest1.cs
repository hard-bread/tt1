using CommoditySupply2;
namespace TestProject4;
[TestFixture]
public class SupplyTests
{
    Supply supply;
    Commodity[] commodities;
    [SetUp]
    public void Setup()
    {
        var oranges = new Commodity("Апельсины");
        var bananas = new Commodity("Бананы");
        var lemons = new Commodity("Лимоны");
        var cucumbers = new Commodity("Огурцы");
        var apples = new Commodity("Яблоки");

        commodities = new Commodity[] { oranges, bananas, lemons, cucumbers, apples };
        supply = new Supply("Иванов Иван Сергеевич", 235109, "02.06.2025", commodities);
    }
    [Test]
    public void ConstructorTest()
    {
        Assert.That(supply.Supplier, Is.EqualTo("Иванов Иван Сергеевич"));
        Assert.That(supply.SupplyNumber, Is.EqualTo(235109));
        Assert.That(supply.SupplyDate, Is.EqualTo(new DateTime(2025, 6, 2)));

        foreach (var commodity in commodities)
            Assert.That(supply.Count(s => s.Equals(commodity)), Is.EqualTo(1));
    }
}