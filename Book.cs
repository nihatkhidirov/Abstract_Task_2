using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Task_2
{
    internal class Book : Product
    {
        public string Genre;
        

        public Book(int Id, string name, int price, int count, string genre) : base(Id,name, price, count)
        {
        }
       
    }
}
