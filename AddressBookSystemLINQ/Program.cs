using System;

namespace AddressBookSystemLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address book problem using LINQ !!!!");

            AddressBookManagement addressBookManagement = new AddressBookManagement();
            //To get all records from the table
            addressBookManagement.GetAllContactsFromDataTable();
            //To edit a contact from the table
            addressBookManagement.EditContactFromDataTableUsingFirstName();
        }
    }
}
