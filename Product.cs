using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Task_2
{
    internal class Product
    {
        public int Id;
        public string Name;
        public int Price;
        public int count;

        public Product(int Id, string name, int price, int count)
        {
            this.Id= Id;
            Name = name;
            Price = price;
            this.count = count;
        }
        public Product()
        {

        }

        public void Detail(string Name, int Price, int count)
        {
            Console.WriteLine($"Mehsulun Adi: {Name}\nMehsulun Qiymeti:{Price}\nMehsulun Sayi: {count}");
        }
        public void Discount(int Price, double DiscountPercentage)
        {
            double NewPrice = (Price * (DiscountPercentage / 100));
            Console.WriteLine($"Yeni Endirimli Qiymet:{Price-NewPrice}");
        }

    }
   
}
