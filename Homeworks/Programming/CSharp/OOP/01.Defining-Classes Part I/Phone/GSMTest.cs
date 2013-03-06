using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public class GSMTest
    {
        static void Main()
        {
            GSM phone1 = new GSM();
            phone1.Price = 10;
            phone1.Owner = "az";

            GSM phone2 = new GSM();
            phone2.Price = 12;
            phone2.Manifacturer = "made in china";
            phone2.Model = "samsung 2";

            GSM phone3 = new GSM();
            phone3.Model = "nokia q";
            phone3.Owner = "pesho";
            phone3.Manifacturer = " made in china";

            GSM[] phones = new GSM[] { phone1, phone2, phone3 };
            foreach (GSM phone in phones)
            {
                phone.DisplayGsm();
                Console.WriteLine();
            }

            GSM.Iphone.DisplayGsm();

            Battery battery = new Battery(BatteryType.NiCd);
            Console.WriteLine(battery.Type);

            Call firstCall = new Call(DateTime.Now, 0987654321, 324);
            Call secondCall = new Call();
            secondCall.Number = 0999999;
            secondCall.Seconds = 433;
            GSM calls = new GSM("samsung", "china");

            //--------------
            //test call history
            //---------------
            calls.AddCall(DateTime.Now, 0987654321, 234); 
            calls.AddCall(DateTime.Now, 1234567890, 342);
            calls.DeleteCall(DateTime.Now, 1234567890, 342);
            foreach (var call in calls.Callhistory)
            {
                Console.WriteLine("{0} {1} {2}", call.DateTime, call.Number, call.Seconds);
            }
          
            Console.WriteLine( calls.CallPrice(0.34) );
            calls.RemoveAllCalls();
            foreach (var call in calls.Callhistory)
            {
                Console.WriteLine("{0} {1} {2}", call.DateTime, call.Number, call.Seconds);
            }
        }
    }
}
