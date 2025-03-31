using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public class Commodity
    {
        public readonly int Article;
        public string Name { get; set; }
        public double Weight { get; set; }
        public (double Length, double Width, double Height) Dimensions { get; set; }
        public DateTime DateOfReceipt { get; set; }
        public int Price { get; set; }
        public CommodityCharacteristic Characteristic { get; set; }
        public int StackingLimit { get; set; }

        public Commodity(int article, string name, double weight, (double, double, double) dimensions)
        {
            Article = article;
            Name = name;
            Weight = weight;
            Dimensions = dimensions;
        }

        public virtual string[] GetInfo()
        {
            var info = new string[2];
            info[0] = $"Артикул:{Article} Название:{Name} Цена:{Price}";

            string characteristic;
            if (Characteristic == CommodityCharacteristic.Ordinary)
                characteristic = "Обыкновенный";
            else if (Characteristic == CommodityCharacteristic.Fragile)
                characteristic = "Хрупкий";
            else
                characteristic = "Боится сырости";

            info[1] = $"Вес: {Weight} кг, Габариты упаковки: {Dimensions.Length}x{Dimensions.Width}x{Dimensions.Height} см, Дата поступления на склад: {DateOfReceipt:d}, Характеристика товара: {characteristic}, Особенность складирования: {StackingLimit}.";

            return info;
        }
        public class FoodProduct : Commodity
        {
            public int ExpiryDate { get; set; }
            public int Temperature { get; set; }
            public bool StorageCapability { get; set; }

            public FoodProduct(int article, string name, double weight, (double, double, double) dimensions, DateTime dateOfReceipt, int price, CommodityCharacteristic characteristic, int stackingLimit, int expiryDate, int temperature) : base(article, name, weight, dimensions)
            {
                ExpiryDate = expiryDate;
                Temperature = temperature;
            }

            public override string[] GetInfo()
            {
                var info = new string[3];
                var studentInfo = base.GetInfo();

                info[0] = studentInfo[0];
                info[1] = studentInfo[1];
                info[2] = $"Срок годности: {ExpiryDate} месяцев; Температура хранения: {Temperature}°";
                return info;
            }
        }

        public class BuildMaterial : Commodity
        {
            public string StorageCapability { get; set; }
            public BuildMaterial(int article, string name, double weight, (double, double, double) dimensions, DateTime dateOfReceipt, int price, CommodityCharacteristic characteristic, string storageCapability) : base(article, name, weight, dimensions)
            {
                StorageCapability = storageCapability;
            }

            public override string[] GetInfo()
            {
                var info = new string[3];
                var studentInfo = base.GetInfo();

                info[0] = studentInfo[0];
                info[1] = studentInfo[1];
                info[2] = $"Возможность хранения на открытом воздухе: {StorageCapability}";
                return info;
            }
        }
    }
}
