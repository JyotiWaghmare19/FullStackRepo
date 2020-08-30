using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
           //Create stopwatch
            Stopwatch Stopwatch = new Stopwatch();
            
            //Start timing
            Stopwatch.start();

            //Delay
            Thread.Sleep(1); 

            //Stop timing
            Stopwatch.stop();
           
            Console.ReadKey();
        }
 
    }
}
