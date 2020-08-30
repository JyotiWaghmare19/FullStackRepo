using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    class Stopwatch
    {
        public DateTime starttime;
        public DateTime stoptime;
       
        public bool isStarted;


        public void stopwatch()
        {
            starttime = new DateTime();
            stoptime = new DateTime();
            isStarted = false;

        }
        public void start()
        {
            if (isStarted)
                throw new InvalidOperationException();

            starttime = DateTime.Now;
            Console.WriteLine("Start Time: " + starttime.Hour + ":" + starttime.Minute + ":" + starttime.Second + ":" + starttime.Millisecond);
        }
        public void stop()
        {

            stoptime = DateTime.Now;
            isStarted = false;
            Console.WriteLine("Stop Time: " + stoptime.Hour + ":" + stoptime.Minute + ":" + stoptime.Second + ":" + stoptime.Millisecond);
            TimeSpan duration = stoptime - starttime;
        }
       
            private TimeSpan Interval;

            public TimeSpan MyProperty
            {
               get { Interval = stoptime - starttime;
                      return Interval;}
             
 
         }
    }
    
}
