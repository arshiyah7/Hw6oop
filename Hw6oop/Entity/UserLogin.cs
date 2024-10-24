using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hw6oop.interfaces;

namespace Hw6oop.Entity
{
    public class UserLogin : IAuthentication
    {





        public bool Login(string username, string password)
        {
            Member member1 = new Member(username, password);
            foreach (Member member in Storage.members)
            {
                if (member is not null)
                {
                    if (username == member.UserName)
                    {
                        if (password == member.Password)
                        {

                            return true;
                        }

                    }
                }

            }
            return false;
        }

        public bool Regester( string password, string username)
        {
            foreach (Member member in Storage.members)
            {
                if (member is not null)
                {
                    if (member.Check(username, password))
                    {

                        password = member.Password;
                        username = member.UserName;
                        member.Add(member);
                        return true;
                    }
                }

            }
            return false;
        }


    }
}

