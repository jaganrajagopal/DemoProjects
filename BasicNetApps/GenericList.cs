using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BasicNetApps
{
    class GenericList
    {
        public void GenericMyOwnList()
        {
            List<int> mylist = new List<int>();
            mylist.Add(1);
            mylist.Add(2);
            mylist.Add(3);

            List<double> mylistdouble = new List<double>();
            mylistdouble.Add(234.45);
            mylistdouble.Add(56.78);
        }

        public void DictionaryList()
        {
            Dictionary<int, string> dictKeys = new Dictionary<int, string>();
            dictKeys.Add(1, "one");
            dictKeys.Add(2, "two");
            dictKeys.Add(3, null);
            foreach(var myvalue in dictKeys)
            {
                Console.WriteLine("Data for Key :" + myvalue.Key + "  Data for value: " + myvalue.Value);
                //if(dictKeys.contain)
            }

            //Dictionary<double, string> dictString = new Dictionary<double, string>();
            //dictString.Add(23.45, "one");
            

            //Hashtable myhash = new Hashtable();
            //myhash.Add()

        }

        public void CustomList()
        {
            List<Customer> listCustomers = new List<Customer>();
            Customer objCustomer = new Customer()
            {
                customerId = 1, customerName = "Jagan"
            };
            Customer objCustomer1 = new Customer()
            {
                customerId = 2,
                customerName = "Naveen"
            };
            Customer objCustomer2 = new Customer()
            {
                customerId = 3,
                customerName = "Ram"
            };
            //listCustomers.Add()
            listCustomers.Add(objCustomer);
            listCustomers.Add(objCustomer1);
            listCustomers.Add(objCustomer2);

            foreach( var displayCustomer in listCustomers)
            {
                Console.WriteLine("Customer Id:" + displayCustomer.customerId + "   Customer Name" + displayCustomer.customerName);
            }


        }
    }
}
