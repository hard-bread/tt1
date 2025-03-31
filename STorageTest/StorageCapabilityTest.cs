using System.Diagnostics;
using System.Reflection.PortableExecutable;
using static Storage.Commodity;
namespace Storage
{

    public class StorageCapabilityTest
    {
        [Test]
        public void ConstructorTest()
        {
            var material = GetTestStorageCapability();

            Assert.That(material.StorageCapability, Is.EqualTo("Да"));
        }

        [Test]
        public void GetInfo_StorageCapability()
        {
            var material = GetTestStorageCapability();
            var lines = new[]
            {
                "Артикул:23423234 Название:Сок Цена:150",
                "Вес: 0,5 кг, Габариты упаковки: 23x40x50 см, Дата поступления на склад: 15.03.2023, Характеристика товара: Обыкновенный, Особенность складирования: 10.",
                "Возможность хранения на открытом воздухе: Да"
            };

            var info = material.GetInfo();

            Assert.That(info.Length, Is.EqualTo(3));

            for (var i = 0; i < info.Length; i++)
                Assert.That(info[i], Is.EqualTo(lines[i]));
        }

        private BuildMaterial GetTestStorageCapability()
        {
            var food = new BuildMaterial(23423234, "Сок", 0.5, (23, 40, 50), new DateTime(2023, 3, 15), 150, CommodityCharacteristic.Ordinary, "Да");
            food.DateOfReceipt = new DateTime(2023, 3, 15);
            food.Price = 150;
            food.StackingLimit = 10;
            return food;
        }
    }
}