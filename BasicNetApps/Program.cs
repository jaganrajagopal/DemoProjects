using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicNetApps
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            //Console.WriteLine("Hello World!");
            //Console.ReadKey();
            //Delegate objDelegate = new Delegate();
            //Delegate.MyDelegate delevent = new Delegate.MyDelegate(objDelegate.Display);
            //int result = delevent(2, 3);
            //delevent += new Delegate.MyDelegate(objDelegate.Subtract);

            // TestNamespace

            //SampleDelegate objSample = new SampleDelegate();
            ////calling 
            //SampleDelegate.MyArithematic del = new SampleDelegate.MyArithematic(objSample.Add);
            //int result=del(4, 5);
            //// SampleDelegate.MyArithematic del2 = new SampleDelegate.MyArithematic(objSample.Subtract);
            ////int subtract = del2(5, 3);
            //del += new SampleDelegate.MyArithematic(objSample.Subtract);
            //int substract=del(3, 4);
            //try
            //{

            //    ErrorHandling objError = new ErrorHandling();
            //    objError.Display(1);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("Error Occurred due to " + ex.Message);
            //}

            Array objArray = new Array();
            objArray.ArrayMethod();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
