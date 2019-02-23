using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PerformanceConsoleApps
{
    class Program
    {
       
            private static string _dummy;
            private static string[] _array = new string[] {"a","b","c","d","e"
                                                      ,"f","g","h","i","j"
                                                      ,"k","l","m","n","o"
                                                      ,"p","q","r","s","t"};


            static void Main(string[] args)
            {
            //LoopMatch();
            //SwitchMatch();
            //IfMatch();
            //LoopNoMatch();
            //SwitchNoMatch();
            //IfNoMatch();
            //Check performance for FOR Vs Foreach
            // ForVsForeach();
            MemoryLeakage_Task1();
                Console.ReadLine();
            }



            private static void LoopMatch()
            {
                Stopwatch timer = new Stopwatch();
                timer.Start(); // Start the timer

                for (long i = 1; i <= 1000000000; i++)
                {
                    long compare = i % 20;
                    _dummy = _array[compare];
                }

                timer.Stop(); // Stop the timer
                decimal micro = (decimal)timer.Elapsed.Ticks / 10M;
                Console.WriteLine("Execution time for 'Loop Match' was {0:F1} microseconds.", micro);
            }



            private static void LoopNoMatch()
            {
                Stopwatch timer = new Stopwatch();
                timer.Start(); // Start the timer

                for (long i = 1; i <= 1000000000; i++)
                {
                    _dummy = _array[19];
                }

                timer.Stop(); // Stop the timer
                decimal micro = (decimal)timer.Elapsed.Ticks / 10M;
                Console.WriteLine("Execution time for 'Loop No Match' was {0:F1} microseconds.", micro);
            }



            private static void SwitchMatch()
            {
                Stopwatch timer = new Stopwatch();
                timer.Start(); // Start the timer

                for (long i = 1; i <= 1000000000; i++)
                {
                    long compare = i % 20;

                    switch (compare)
                    {
                        case 0:
                            _dummy = _array[0];
                            break;
                        case 1:
                            _dummy = _array[1];
                            break;
                        case 2:
                            _dummy = _array[2];
                            break;
                        case 3:
                            _dummy = _array[3];
                            break;
                        case 4:
                            _dummy = _array[4];
                            break;
                        case 5:
                            _dummy = _array[5];
                            break;
                        case 6:
                            _dummy = _array[6];
                            break;
                        case 7:
                            _dummy = _array[7];
                            break;
                        case 8:
                            _dummy = _array[8];
                            break;
                        case 9:
                            _dummy = _array[9];
                            break;
                        case 10:
                            _dummy = _array[10];
                            break;
                        case 11:
                            _dummy = _array[11];
                            break;
                        case 12:
                            _dummy = _array[12];
                            break;
                        case 13:
                            _dummy = _array[13];
                            break;
                        case 14:
                            _dummy = _array[14];
                            break;
                        case 15:
                            _dummy = _array[15];
                            break;
                        case 16:
                            _dummy = _array[16];
                            break;
                        case 17:
                            _dummy = _array[17];
                            break;
                        case 18:
                            _dummy = _array[18];
                            break;
                        default:
                            _dummy = _array[19];
                            break;
                    }
                }

                timer.Stop(); // Stop the timer
                decimal micro = (decimal)timer.Elapsed.Ticks / 10M;
                Console.WriteLine("Execution time for 'Switch Match' was {0:F1} microseconds.", micro);
            }


            private static void SwitchNoMatch()
            {
                Stopwatch timer = new Stopwatch();
                timer.Start(); // Start the timer

                for (long i = 1; i <= 1000000000; i++)
                {
                    long compare = 21;

                    switch (compare)
                    {
                        case 0:
                            _dummy = _array[0];
                            break;
                        case 1:
                            _dummy = _array[1];
                            break;
                        case 2:
                            _dummy = _array[2];
                            break;
                        case 3:
                            _dummy = _array[3];
                            break;
                        case 4:
                            _dummy = _array[4];
                            break;
                        case 5:
                            _dummy = _array[5];
                            break;
                        case 6:
                            _dummy = _array[6];
                            break;
                        case 7:
                            _dummy = _array[7];
                            break;
                        case 8:
                            _dummy = _array[8];
                            break;
                        case 9:
                            _dummy = _array[9];
                            break;
                        case 10:
                            _dummy = _array[10];
                            break;
                        case 11:
                            _dummy = _array[11];
                            break;
                        case 12:
                            _dummy = _array[12];
                            break;
                        case 13:
                            _dummy = _array[13];
                            break;
                        case 14:
                            _dummy = _array[14];
                            break;
                        case 15:
                            _dummy = _array[15];
                            break;
                        case 16:
                            _dummy = _array[16];
                            break;
                        case 17:
                            _dummy = _array[17];
                            break;
                        case 18:
                            _dummy = _array[18];
                            break;
                        default:
                            _dummy = _array[19];
                            break;
                    }
                }

                timer.Stop(); // Stop the timer
                decimal micro = (decimal)timer.Elapsed.Ticks / 10M;
                Console.WriteLine("Execution time for 'Switch No Match' was {0:F1} microseconds.", micro);
            }



            private static void IfMatch()
            {
                Stopwatch timer = new Stopwatch();
                timer.Start(); // Start the timer

                for (long i = 1; i <= 1000000000; i++)
                {
                    long compare = i % 20;

                    if (compare == 0) { _dummy = _array[0]; }
                    else if (compare == 1) { _dummy = _array[1]; }
                    else if (compare == 2) { _dummy = _array[2]; }
                    else if (compare == 3) { _dummy = _array[3]; }
                    else if (compare == 4) { _dummy = _array[4]; }
                    else if (compare == 5) { _dummy = _array[5]; }
                    else if (compare == 6) { _dummy = _array[6]; }
                    else if (compare == 7) { _dummy = _array[7]; }
                    else if (compare == 8) { _dummy = _array[8]; }
                    else if (compare == 9) { _dummy = _array[9]; }
                    else if (compare == 10) { _dummy = _array[10]; }
                    else if (compare == 11) { _dummy = _array[11]; }
                    else if (compare == 12) { _dummy = _array[12]; }
                    else if (compare == 13) { _dummy = _array[13]; }
                    else if (compare == 14) { _dummy = _array[14]; }
                    else if (compare == 15) { _dummy = _array[15]; }
                    else if (compare == 16) { _dummy = _array[16]; }
                    else if (compare == 17) { _dummy = _array[17]; }
                    else if (compare == 18) { _dummy = _array[18]; }
                    else { _dummy = _array[19]; }
                }

                timer.Stop(); // Stop the timer
                decimal micro = (decimal)timer.Elapsed.Ticks / 10M;
                Console.WriteLine("Execution time for 'If Match' was {0:F1} microseconds.", micro);
            }



            private static void IfNoMatch()
            {
                Stopwatch timer = new Stopwatch();
                timer.Start(); // Start the timer

                for (long i = 1; i <= 1000000000; i++)
                {
                    long compare = 21;

                    if (compare == 0) { _dummy = _array[0]; }
                    else if (compare == 1) { _dummy = _array[1]; }
                    else if (compare == 2) { _dummy = _array[2]; }
                    else if (compare == 3) { _dummy = _array[3]; }
                    else if (compare == 4) { _dummy = _array[4]; }
                    else if (compare == 5) { _dummy = _array[5]; }
                    else if (compare == 6) { _dummy = _array[6]; }
                    else if (compare == 7) { _dummy = _array[7]; }
                    else if (compare == 8) { _dummy = _array[8]; }
                    else if (compare == 9) { _dummy = _array[9]; }
                    else if (compare == 10) { _dummy = _array[10]; }
                    else if (compare == 11) { _dummy = _array[11]; }
                    else if (compare == 12) { _dummy = _array[12]; }
                    else if (compare == 13) { _dummy = _array[13]; }
                    else if (compare == 14) { _dummy = _array[14]; }
                    else if (compare == 15) { _dummy = _array[15]; }
                    else if (compare == 16) { _dummy = _array[16]; }
                    else if (compare == 17) { _dummy = _array[17]; }
                    else if (compare == 18) { _dummy = _array[18]; }
                    else { _dummy = _array[19]; }
                }

                timer.Stop(); // Stop the timer
                decimal micro = (decimal)timer.Elapsed.Ticks / 10M;
                Console.WriteLine("Execution time for 'If No Match' was {0:F1} microseconds.", micro);
            }

            private static void ForVsForeach()
            {
            int[] arr = new int[100];
            Stopwatch timer = new Stopwatch();
            timer.Start(); // Start the timer
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
            timer.Stop(); // Stop the timer
            decimal micro = (decimal)timer.ElapsedMilliseconds; 
            
            Console.WriteLine("For loop time value:" + micro.ToString());
            int sum = 0;
            timer.Start();
            foreach (int val in arr)
            {
                sum += val;
            }
            timer.Stop();
            decimal micro1 = (decimal)timer.ElapsedMilliseconds;
            Console.WriteLine("ForEach as array Loop time value:" + micro1.ToString());
            sum = 0;
            timer.Start();
            IEnumerable<int> arrEnum = arr;
            foreach (int val in arrEnum)
            {
                sum += val;
            }
            timer.Stop();
            decimal micro2 = (decimal)timer.ElapsedMilliseconds;
            Console.WriteLine("ForEach as Enumerable Loop time value:" + micro2.ToString());
        }

        //Memory Leakage for sample code
        private static void MemoryLeakage_Task1()
        {
            var list = new List<byte[]>();
            while (true)
            {
                list.Add(new byte[4000]); // Change the size here.
               System.Threading.Thread.Sleep(1000); // Change the wait time here.
                //list.Clear();
               // list.RemoveAll();
                //list.Remove(new byte[4000]);
            }
           
        }

        private static void MemoryLeaker_Task2()
        {

            Resource resource = null;
           
            try
            {
                resource = new Resource();
                resource.mybyte = new byte[4000];

                // use resource  
            }
            finally
            {
                //if (resource != null)
                //{
                //    resource.Dispose();
                //}
            }
        }
}
   
}
