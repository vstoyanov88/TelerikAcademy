//Using delegates write a class Timer that has can execute certain method at each t seconds.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void TimerDelegate(int seconds);

    public class Timer
    {
        private int counter;
        private int stopWatch;
        private TimerDelegate caller;

        public Timer(int counter, int stopWatch, TimerDelegate caller)
        {
            this.counter = counter;
            this.stopWatch = stopWatch;
            this.caller = caller;
        }

        public int Counter
        {
            get
            {
                return this.counter;        
            }
        }

        public int StopWatch
        {
            get
                {
                    return this.stopWatch;
                }
        }

        public void Run()
        {
            int seconds = this.counter;
            while(seconds >= 0)
            {
                Thread.Sleep(this.stopWatch);
                this.caller(seconds);
                seconds--;
            }
        }
    }
}
