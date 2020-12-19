using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        /// <summary>
        /// To get all the records from the data table
        /// </summary>
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

        /// <summary>
        /// To edit a contact from data table using first name
        /// </summary>
        public void EditContactFromDataTableUsingFirstName()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Please give the first name of the contact to be updated : ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please give the name of column in which you want to edit : ");
            string columnFieldName = Console.ReadLine();
            Console.WriteLine("Please give the value to be updated in the table : ");
            string value = Console.ReadLine();
            //FirstOrDefault gives first value or default value if no element matches
            DataRow updatedContact = addressBookTable.Select("FirstName = '" + firstName + "'").FirstOrDefault(); 
            updatedContact[columnFieldName] = value;
            Console.WriteLine("The contact has been updated successfully !!!!");
            GetAllContactsFromDataTable();
        }

        /// <summary>
        /// To delete a contact using first name
        /// </summary>
        public void DeleteContactFromDataTableUsingFirstName()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Please enter the first name of the contact you want to delete : ");
            string name = Console.ReadLine();
            var records = addressBookTable.AsEnumerable().Where(data => data.Field<string>("FirstName") == name);
            foreach ( var dataRows in records.ToList())
            {
                dataRows.Delete();
            }
            GetAllContactsFromDataTable();
        }

        /// <summary>
        /// to display contacts based on city or state
        /// </summary>
        public void DisplayContactsBasedOnCityOrState()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Enter City : ");
            string city = Console.ReadLine();
            Console.WriteLine("Enter State : ");
            string state = Console.ReadLine();
            var data = from record in addressBookTable.AsEnumerable()
                         where record.Field<string>("City").Equals(city) || record.Field<string>("State").Equals(state)  
                         select record;

            foreach (var record in data)
            {
                Console.WriteLine("FirstName :" + record.Field<string>("Firstname") +  "\tCity :" + record.Field<string>("City") +
                    "\tState : " + record.Field<string>("State"));
            }
        }

        /// <summary>
        /// Count of persons in a city and state
        /// </summary>
        public void CountByCityAndState()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Enter City : ");
            string city = Console.ReadLine();
            Console.WriteLine("Enter State : ");
            string state = Console.ReadLine();
            var data = from record in addressBookTable.AsEnumerable()
                         where record.Field<string>("City").Equals(city) && record.Field<string>("State").Equals(state)
                         select record;
            Console.WriteLine("Number of persons in a given city and state : " + data.Count());


        }
    }
}
