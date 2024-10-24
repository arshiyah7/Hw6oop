using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw6oop.interfaces
{
    public interface IAuthentication
    {

        public bool Login(string username, string password);

        public bool Regester( string password, string username);

    }
}
