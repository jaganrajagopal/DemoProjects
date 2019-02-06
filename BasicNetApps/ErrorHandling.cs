using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicNetApps
{
    class ErrorHandling
    {
        public int Display(int y)
        {
            throw new Exception("My error");
            return  y;
        }

        public string Display(dynamic message,int id)
        {
            return "HI" + message;
        }
    }
}
