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
        public void sortedListData()
        {
            SortedList listsort = new SortedList();
            listsort.Add("23", 34);
            listsort.Add("34", "Mydata");
            string value = "";
            if (listsort.ContainsKey(23) == true)
            {
                value = listsort[23].ToString();
            }

        }
        public void StackOpeation()
        {
            //Last in ,first out
            Stack liststack = new Stack();
            liststack.Push("A");
            liststack.Push(23);
            liststack.Push("C");
            liststack.Push("D");
            var myclone = liststack.Clone();
            foreach (var mydata in liststack)
            {
                Console.WriteLine("The value" + mydata + " Type" + liststack.GetType().ToString());

            }
            liststack.Pop();
            liststack.Clear();
        }
           
        public void QueueList()
        {
            Queue listQueue = new Queue();
            listQueue.Enqueue(1);
            listQueue.Enqueue(2);
            listQueue.Enqueue(3);
            //Iteration list

            foreach(var mydata in listQueue)
            {
                Console.WriteLine("The Number:" + mydata);
            }
            //Removing the Queue from list (first in and first out)
            listQueue.Dequeue();
            listQueue.Dequeue();
            listQueue.Clear();
        }

        public void BitArray()
        {
            // Create BitArray from the array.
            BitArray bitArray = new BitArray(12);
            // Set three bits to 1.
            bitArray[3] = true;     // You can set the bits with the indexer.
            bitArray[5] = true;
            //bitArray[10] = true;
            bitArray.Set(10, true); // You can  the total of all bits (1s and 0s).
            Console.WriteLine("--- Total bits ---");
            Console.WriteLine(bitArray.Count);

            // You can loop to count set bits.
            Console.WriteLine("--- Total bits set to 1 ---");
            Console.WriteLine(CountBitArray(bitArray));
        }
        static int CountBitArray(BitArray bitArray)
        {
            int count = 0;
            foreach (bool bit in bitArray)
            {
                if (bit)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
