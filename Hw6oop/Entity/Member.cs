using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Hw6oop.Enums;

namespace Hw6oop.Entity
{
    public class Member
    {
        public Member(string userid, string username, string password, RuleEnum rule)
        {
            UserId = userid;
            UserName = username;
            Password = password;
            rule = (RuleEnum)rule;

        }

        public Member(string userName, string password)
        {
            Password = password;
            UserName = userName;
        }
        public Member(string userid )
        {
            this.UserId = userid;
        }

        public string UserId { get; set; } 
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Index { get; set; } = 0;
        

        public int index()
        {

            foreach (Member m in Storage.members)
            {
                if (m == null)
                    break;
                Index++;
            }
            return Index;
        }

        public void Add(Member m)
        {
            Storage.members[Index] = m;
        }
        public bool Check(string username, string password)
        {
            if (username == UserName && password == Password)
            {
                return false;
            }
            return true;
        }
    }
}
