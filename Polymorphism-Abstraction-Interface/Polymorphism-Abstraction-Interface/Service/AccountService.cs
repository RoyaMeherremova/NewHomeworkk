using Polymorphism_Abstraction_Interface.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstraction_Interface.Service
{
    internal class AccountService : IAccountService
    {
        public void Login(string username, string password)
        {
            if(username=="Roya123" && password=="roya123")
            {
                Console.WriteLine("Giris ugurludur");
            }
            else
            {
                Console.WriteLine("Email ve ya Password sehvdir");
            }
        }
    }
}
