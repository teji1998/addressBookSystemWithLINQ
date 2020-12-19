using System;

namespace AddressBookSystemLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address book problem using LINQ !!!!");

            AddressBookManagement addressBookManagement = new AddressBookManagement();

            /*//To get all records from the table
            addressBookManagement.GetAllContactsFromDataTable();
            //To edit a contact from the table
            addressBookManagement.EditContactFromDataTableUsingFirstName();
            //To delete a contact from the table
            addressBookManagement.DeleteContactFromDataTableUsingFirstName();
            //To obtain contacts based on city or state
            addressBookManagement.DisplayContactsBasedOnCityOrState();
            //To obtain count of persons for a given city and state
            addressBookManagement.CountByCityAndState(); 
            //to sort the records alphabetically by first name for given city
            addressBookManagement.SortTheRecordsByFirstNameForACity();*/
            addressBookManagement.CountByPersonType();

        }
    }
}
