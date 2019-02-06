using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicNetApps
{
    class Array
    {
        public void ArrayMethod()
        {
            int[] arryNumber = new int[4];
            arryNumber[0] = 12;
            arryNumber[1] = 23;
            arryNumber[2] = 45;
            arryNumber[3] = 67;
            //print 
            foreach (var mynumber in arryNumber)
            {
                Console.Write("Number" + mynumber);
            }
            //another approach
            int[] arryRand = new int[4] { 2, 3, 4, 5 };
            foreach (var mydata in arryRand)
            {
                Console.Write("Number" + mydata);
            }

        }
    }
}
