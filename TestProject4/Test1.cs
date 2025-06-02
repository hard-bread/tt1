using CommoditySupply2;

namespace TestProject4;

[TestFixture]
public class Test1
{
    [Test]
    public void CompareTo()
    {
        var oranges = new Commodity("Апельсины");
        var bananas = new Commodity("Бананы");
        var lemons = new Commodity("Лимоны");
        var cucumbers = new Commodity("Огурцы");
        var apples = new Commodity("Яблоки");


        Assert.That(oranges.CompareTo(apples), Is.LessThan(0));
        Assert.That(cucumbers.CompareTo(bananas), Is.GreaterThan(0));
        Assert.That(lemons.CompareTo(oranges), Is.GreaterThan(0));
        Assert.That(oranges.CompareTo(oranges), Is.EqualTo(0));
    }
}
