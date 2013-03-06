using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public enum BatteryType
    {
        Liion, NiMH, NiCd
    }
    public class Battery
    {
        //fields
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private BatteryType type;
        //constructors
        public Battery()
        {
        }

        public Battery(BatteryType type)
            : this(null, 0, 0, type)
        {
        }
        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType type)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.type = type;
        }
        //properties
        public string Model 
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int HoursIdle 
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }

        public int HoursTalk 
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }

        public BatteryType Type
        {
            get
            {
                return type;
            }
        }
    }
}
