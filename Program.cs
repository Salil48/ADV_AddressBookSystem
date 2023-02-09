using AdvAddressBookSystem;

namespace AddressBook_ADO.NET
{

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the AddressBook DataBase problem");

            AddressBook addressbook1 = new AddressBook();
            addressbook1.AddToDataTable();
        }
    }
}