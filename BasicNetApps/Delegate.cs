using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicNetApps
{
    class Delegate
    {
        public delegate int MyDelegate(int x, int y);

        public int Display(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {

            return x - y;
        }
   
    }
}
