using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AddressBookSystemLINQ
{
    public class AddressBookManagement
    {
        //creating a datatable
        DataTable addressBookTable = new DataTable();
        
        public AddressBookManagement()
        {
            //Adding columns into data table
            addressBookTable.Columns.Add("FirstName", typeof(string));
            addressBookTable.Columns.Add("LastName", typeof(string));
            addressBookTable.Columns.Add("Address", typeof(string));
            addressBookTable.Columns.Add("City", typeof(string));
            addressBookTable.Columns.Add("State", typeof(string));
            addressBookTable.Columns.Add("Zip", typeof(int));
            addressBookTable.Columns.Add("MobileNumber", typeof(string));
            addressBookTable.Columns.Add("EmailId", typeof(string));

        }
    }
}
