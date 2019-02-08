using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BasicNetApps
{
    class CollectionList
    {
        //Use for Arraylist
        public void ArrayListMethod()
        {
            //int[] myarray = new int[5];// fixed length 
            //myarray[0] = 1;
            // myarray[1] = "asdfs";

            ArrayList MyStringList = new ArrayList();
            MyStringList.Add(1);
            MyStringList.Add("Jagan");
            MyStringList.Add("Besant");
            MyStringList.Add(123.45);
            //var collection= MyStringList.AsQueryable()
            int count = MyStringList.Capacity;
            int recount = MyStringList.Count;
            //MyStringList.Add(null);

            MyStringList.Add("Naveen");
            MyStringList.Add("Ram");
            MyStringList.Remove(1);
            count = MyStringList.Capacity;

            //var data =MyStringList.OfType<SampleDelegate>();

            foreach (var mydata in MyStringList)
            {
                Console.WriteLine("N" + mydata.ToString());
            }

        }

        public void HastTableMethod()
        {
            Hashtable myHastData = new Hashtable();
            myHastData.Add(1, "Besant"); //1: Unique Key , 2: Values
            myHastData.Add(12.34, "Ram");
            myHastData.Add("45", "sales");
            string myvalue = "";
            if (myHastData.ContainsKey(12.34) == true)
            {
                myvalue = myHastData[12.34].ToString();
            }
            if (myHastData.ContainsValue("sales")==true)
            {
                //
            }
            ICollection key = myHastData.Keys;
            ICollection myvalues = myHastData.Values;
            foreach(var data in key)
            {
                myvalue=myHastData[data].ToString();
            }
        }
    }
}
