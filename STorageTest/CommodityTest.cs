using System.Diagnostics;
using System.Reflection.PortableExecutable;
using Storage;

namespace Storage
{
    [TestFixture]
    public class CommodityTests
    {
        [Test]
        public void ConstructorTest()
        {
            var first = CreateTestSclad();
            Assert.That(first.Article, Is.EqualTo(23423234));
            Assert.That(first.Name, Is.EqualTo("Сок"));
            Assert.That(first.Weight, Is.EqualTo(0.5));
            Assert.That(first.Dimensions, Is.EqualTo((23, 40, 50)));
            Assert.That(first.DateOfReceipt.ToShortDateString(), Is.EqualTo("15.03.2023"));
            Assert.That(first.Price, Is.EqualTo(150));
            Assert.That(first.Characteristic, Is.EqualTo(CommodityCharacteristic.Ordinary));
            Assert.That(first.StackingLimit, Is.EqualTo(10));
        }
        [Test]
        public void TestGetInfo()
        {
            var commodity = CreateTestSclad();
            var info = commodity.GetInfo();

            Assert.That(info.Length, Is.EqualTo(2));
            Assert.That(info[0], Is.EqualTo("Артикул:23423234 Название:Сок Цена:150"));
            Assert.That(info[1], Is.EqualTo("Вес: 0,5 кг, Габариты упаковки: 23x40x50 см, Дата поступления на склад: 15.03.2023, Характеристика товара: Обыкновенный, Особенность складирования: 10."));
        }
        private Commodity CreateTestSclad()
        {
            return new Commodity(23423234, "Сок", 0.5, (23, 40, 50))
            {
                DateOfReceipt = new DateTime(2023, 3, 15),
                Price = 150,
                Characteristic = CommodityCharacteristic.Ordinary,
                StackingLimit = 10
            };
        }
    }
}