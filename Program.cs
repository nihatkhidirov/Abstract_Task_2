using System.Xml.Linq;

namespace Abstract_Class_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ForMethods_Login
            //Account account = new Account();
            //Console.WriteLine("Username Daxil Edin: ");
            //string username = Console.ReadLine();
            //Console.WriteLine("Password Daxil Edin:");
            //string password = Console.ReadLine();
            //account.Login(username, password);
            #endregion
            #region ForMethods_Details
            //Product product = new Product("Iphone 15", 2500, 5);
            //Console.WriteLine("Mehsulun Adini Daxil Edin:");
            //string Name= product.Name;
            //Name = Console.ReadLine();
            //Console.WriteLine("Mehsulun Qiymetini Daxil Edin:");
            //int Price = product.Price;
            //Price =Convert.ToInt32( Console.ReadLine());
            //Console.WriteLine("Mehsulun Sayini Daxil Edin:");
            //int Count = product.count;
            //Count =Convert.ToInt32(Console.ReadLine());
            //product.Detail(Name, Price, Count);
            //Console.WriteLine("Ne Qeder Endirim Tetbiq Etmek Isteyirsiniz:");
            //int DiscountValue = Convert.ToInt32(Console.ReadLine());
            //product.Discount(Price,DiscountValue);
            #endregion
            Book book = new Book(1,"",1,1,"");
            Console.WriteLine("Array-in Uzunlugunu Daxil Edin: ");
            int ArrayLength = Convert.ToInt32(Console.ReadLine());
            Book[]BookArray= new Book[ArrayLength];
            for (int i = 0; i < ArrayLength; i++)
            {
                Console.WriteLine($"{i + 1}.Kitabin Adini Daxil Edin:");
                string Name = Console.ReadLine();
                Console.WriteLine($"{i + 1}.Kitabin Qiymetini Daxil Edin:");
                int Price1=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{i + 1}.Kitabin Sayini Daxil Edin: ");
                int count1=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{i + 1}.Kitabin Janrini Daxil Edin:");
                string genre=Console.ReadLine();
                BookArray[i] = new Book(i, Name, Price1, count1, genre);
            }
            Console.WriteLine("\nList of Books:");
            for (int i = 0; i < ArrayLength; i++)
            {
                Console.WriteLine($"Book {i+1 } - ID: {BookArray[i].Id+1}, Name: {BookArray[i].Name}, Price: {BookArray[i].Price}, Count: {BookArray[i].count}, Genre: {BookArray[i].Genre}");
            }

        }

    }
}