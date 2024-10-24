using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hw6oop.Entity;
using Hw6oop.Enums;

namespace Hw6oop
{
    public static class Storage
    {
        public static Member[] members { get; set; } = new Member[100];

        public static Book[] books { get; set; } = new Book[100];

        public static Member currentUser { get; set; } 


        static Storage()
        {
            members[0] = new Member("1234", "ali.k5", "ali", RuleEnum.member);
            members[1] = new Member("1212" , "hassan" , "hassan" , RuleEnum.member);
            members[2] = new Member("1519" , "reza" , "reza" , RuleEnum.member);


            books[0] = new Book("1" , "me");
            books[1] = new Book("2", "you");
            books[2] = new Book("3" , "sea");
        }
    }
}
