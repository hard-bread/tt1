using NUnit.Framework;

[TestFixture]
public class SupplyTests
{
    [Test]
    public void SupplierNameTest()
    {
        var supply = new Supply("FreshFruits", 101, DateTime.Today, new List<Commodity>());
        Assert.That(supply.Supplier, Is.EqualTo("FreshFruits"));
    }
}
