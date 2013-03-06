using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public class GSM
    {
        //fields
        private string model;
        private string manifacturer;
        private string owner;
        private int? price;

        public Battery battery = new Battery();
        public Display display = new Display();

        private static GSM IPhone4S = new GSM("IPhone4S", "Apple");

        private List<Call> callHistory = new List<Call>();
        //constructors
        public GSM()
        {
        }

        public GSM(string model, string manifacturer) : this(model, manifacturer, null, null, null, null)
        {
        }

        public GSM(string model, string manifacturer, int? price, Battery battery)
            : this(model, manifacturer,null, price, battery,null)
        { 
        }

        public GSM(string model, string manifacturer, string owner, int? price, Battery battery, Display display)
        {
            this.model = model;
            this.manifacturer = manifacturer;
            this.owner = owner;
            this.price = price;
            this.battery = battery;
            this.display = display;
        }
        //properties
        public string Model 
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Manifacturer 
        {
            get { return this.manifacturer; }
            set { this.manifacturer = value; }
        }

        public string Owner 
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public int? Price 
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public static GSM Iphone
        {
            get { return IPhone4S; }
        }

        public List<Call> Callhistory
        {
            get { return callHistory; }
            set { this.callHistory = value; }
        }

        //methods
        public void DisplayGsm()
        {
            Console.WriteLine(" GSM model - {0} \n GSM manifacturer - {1} \n GSM owner - {2} \n GSM price - {3}", this.model ?? "[unknown]", this.manifacturer ?? "[unknown]", this.owner ?? "[unkwnown]", this.price ?? 0);
        }

        public void AddCall(DateTime dateTime, int number, int seconds)
        {
            Call call= new Call(dateTime, number, seconds);
            callHistory.Add(call);
        }

        public void DeleteCall(DateTime dateTime, int number, int seconds)
        {
            for (int i = 0; i < callHistory.Count; i++)
            {
                if (callHistory[i].DateTime == dateTime & callHistory[i].Number == number) 
                {
                    callHistory.RemoveAt(i);
                    i--;
                }
            }
        }

        public void RemoveAllCalls()
        {
            callHistory.Clear();
        }

        public double CallPrice(double pricePerMin)
        {
            double totalCallPrice = 0;
            for (int i = 0; i < callHistory.Count; i++)
            {
                totalCallPrice += callHistory[i].Seconds;
            }
            totalCallPrice = (totalCallPrice / 60) * pricePerMin;
            return totalCallPrice;
        }
    }
}
