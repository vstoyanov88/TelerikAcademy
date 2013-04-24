using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main()
        {
            TimerDelegate d = new TimerDelegate(Timer);
            d(5);
            Console.WriteLine();
            Timer test = new Timer(20, 500, d);
            Thread thread=new Thread(new ThreadStart(test.Run));
            thread.Start();

        }

        static void Timer(int seconds)
        {
            Console.WriteLine(seconds);
        }

        
    }
}
