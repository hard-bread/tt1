using System;
using System.Collections.Generic;
using NUnit.Framework;
using CommoditySupply;

namespace CommoditySupply
{
    [TestFixture]
    public class SupplyTests
    {
        private Supply supply;

        [SetUp]
        public void Setup()
        {
            var commodities = new List<Commodity>
            {
                new Commodity("јпельсины"),
                new Commodity("Ѕананы"),
                new Commodity("яблоки")
            };

            supply = new Supply("FreshFruits", 101, DateTime.Today, commodities);
        }

        [Test]
        public void SupplierNameTest()
        {
            Assert.That(supply.Supplier, Is.EqualTo("FreshFruits"));
        }

        [Test]
        public void SupplyNumberTest()
        {
            Assert.That(supply.SupplyNumber, Is.EqualTo(101));
        }

        [Test]
        public void SupplyDateTest()
        {
            Assert.That(supply.SupplyDate.Date, Is.EqualTo(DateTime.Today));
        }

        [Test]
        public void CommodityCollectionTest()
        {
            var expectedNames = new List<string> { "јпельсины", "Ѕананы", "яблоки" };
            var actualNames = new List<string>();

            foreach (var commodity in supply.Commodities)
            {
                actualNames.Add(commodity.Name);
            }

            CollectionAssert.AreEqual(expectedNames, actualNames);
        }

        [Test]
        public void CommodityCountTest()
        {
            Assert.That(supply.Count, Is.EqualTo(3));
        }
    }
}
