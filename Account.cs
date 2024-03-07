using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Task_2
{
    internal class Account
    {
        public void Login(string username, string password)
        {
            if(username== "Admin "||password== "AdminEA18yr@")
            {
                Console.WriteLine("Giris Ugurludur");
            }
            else
            {
                Console.WriteLine("Username ve ya Password yanlisdir");
            }
        }
    }
}
