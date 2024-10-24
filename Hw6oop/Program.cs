using Hw6oop.Entity;
using Hw6oop.Enums;

Console.WriteLine("chooose N OPTION  \n 1- Login \n 2- Register :");

string userName = "";
string password = "";
string userID = "1";

UserLogin u = new UserLogin();
bool vic = u.Login(userName, password);

bool regestr = u.Regester(password, userName);

Member m = new Member(userName, password);
Member m2 = new Member(userID, userName, password, Hw6oop.Enums.RuleEnum.member);

LibraryServices libraryServices = new LibraryServices();



RuleEnum rule = new RuleEnum();

int option = Convert.ToInt32(Console.ReadLine());
switch (option)
{
    case 1:

        Console.WriteLine("Enter your user name :");
        userName = Console.ReadLine();
        Console.WriteLine("Enter your password");

        password = Console.ReadLine();

        u.Login(userName, password);
        if (vic = true)
        {
            Console.WriteLine("wlecom");

        }
        break;
    case 2:
        Console.WriteLine("CW Enter an ID");
        userID = Console.ReadLine();
        if (Convert.ToInt32(userID) != 1)
        {
            Console.WriteLine("Enter a userName : ");

        }
        userName = Console.ReadLine();
        Console.WriteLine("enter a password :");
        password = Console.ReadLine();
        u.Regester(password, userName);
        if (regestr == true)
        {
            Console.WriteLine("successful!");
        }
        break;

}

Console.WriteLine("please enter right number");
Console.WriteLine("1)borrow book");
Console.WriteLine("2)return book");
Console.WriteLine("3)list of borrowed book");
Console.WriteLine("4)list of available book");
int menu = Convert.ToInt32(Console.ReadLine());


switch (menu)
{
    case 1:

        string name = Console.ReadLine();
        libraryServices.BorrowBook(name);
        break;
    case 2:
        string bookname = Console.ReadLine();
        libraryServices.ReturnBook(bookname);
        break;
    case 3:

        libraryServices.GetListOfUserBooks();
        break;
    case 4:

        libraryServices.GetListOfLibraryBooks();
        break;


}



