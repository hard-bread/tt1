using System.Diagnostics;
using System.Reflection.PortableExecutable;
using static Storage.Commodity;

namespace Storage
{
    [TestFixture]
    public class FoodProductTest
    {
        [Test]
        public void ConstructorTest()
        {
            var foodcommodity = GetTestFoodCommodity();

            Assert.That(foodcommodity.ExpiryDate, Is.EqualTo(9));
            Assert.That(foodcommodity.Temperature, Is.EqualTo(10));
        }

        [Test]
        public void GetInfo_FullStudent()
        {
            var foodcommodity = GetTestFoodCommodity();
            var lines = new[]
            {
                "Артикул:23423234 Название:Сок Цена:150",
                "Вес: 0,5 кг, Габариты упаковки: 23x40x50 см, Дата поступления на склад: 15.03.2023, Характеристика товара: Обыкновенный, Особенность складирования: 10.",
                "Срок годности: 9 месяцев; Температура хранения: 10°"
            };

            var info = foodcommodity.GetInfo();

            Assert.That(info.Length, Is.EqualTo(3));

            for (var i = 0; i < info.Length; i++)
                Assert.That(info[i], Is.EqualTo(lines[i]));
        }

        private FoodProduct GetTestFoodCommodity()
        {
            var food = new FoodProduct(23423234, "Сок", 0.5, (23, 40, 50), new DateTime(2023, 3, 15), 150, CommodityCharacteristic.Ordinary, 10, 9, 10);
            food.DateOfReceipt = new DateTime(2023, 3, 15);
            food.Price = 150;
            food.StackingLimit = 10;
            return food;
        }
    }
}