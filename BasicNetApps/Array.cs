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

            //string[] employeelist = new string[4]
            //{
            //  "ram","kiran","raj","john","scott"
            //};
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


        public void MultipleArryMethod()
        {
            int[,] arrayNo = new int[4,2] ///4 -rows and 2 columns
            {{0,0}, {1,2} , {2,4}, {3,6} };

           
            //foreach (var j  in arrayNo)
            //{
            //    Console.WriteLine("number" + j);

            //}
             for (int i= 0; i < arrayNo.GetLength(0); i++ )
            {

                for (int j= 0; j < arrayNo.GetLength(1); j++)
                {

                    Console.WriteLine("a[{0},{1}] = 2", i, j, arrayNo[i, j]);
                }
            }


        }
    }
}
