using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstraction_Interface.Service.Interfaces
{
    internal interface IAccountService
    {
        void Login(string username, string password);
    }
}
