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

            //Inserting values into data table
            addressBookTable.Rows.Add("Tejaswini", "Kulkarni", "Chembur", "Mumbai", "Maharashtra", 400071, "9920275347", "teju@gmail.com");
            addressBookTable.Rows.Add("Sravani", "Sabbisetti", "Gandhinagar", "Hyderabad", "Telangana", 458000, "9927893400", "sravani_123@abc.com");
            addressBookTable.Rows.Add("Bhagyalakshmi", "Reddy", "JPnagar", "Hyderabad", "Telangana", 580000, "8097456100", "bhagya123@yahoo.com");
            addressBookTable.Rows.Add("Lee", "Minho", "Gangwon", "Seoul", "South Korea", 689768, "9765123000", "leemin123@kbs.com");
            addressBookTable.Rows.Add("Abhimanyu", "Jagirdar", "Juhu", "Pune", "Maharashtra", 400098, "8904543432", "abhiJagi987@cms.com");
            addressBookTable.Rows.Add("Jaydeep", "Patil", "Malleshwaram", "Pune", "Karnataka", 560789, "8097395111", "jay_patil@sm.com");

        }

        public void GetAllContactsFromDataTable()
        {
            foreach (DataRow rowData in addressBookTable.AsEnumerable())
            {
                Console.WriteLine("\n");
                Console.WriteLine("FirstName : " + rowData.Field<string>("FirstName"));
                Console.WriteLine("LastName : " + rowData.Field<string>("LastName"));
                Console.WriteLine("Address : " + rowData.Field<string>("Address"));
                Console.WriteLine("City : " + rowData.Field<string>("City"));
                Console.WriteLine("State : " + rowData.Field<string>("State"));
                Console.WriteLine("Zip : " + rowData.Field<int>("Zip"));
                Console.WriteLine("MobileNumber : " + rowData.Field<string>("MobileNumber"));
                Console.WriteLine("EmailId : " + rowData.Field<string>("EmailId"));
            }
        }
    }
}
