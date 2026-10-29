using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureApplication
{
    public class Alarm
    {
        public event Action? SomethingHappend;
        int temperature = 10;



        public int Temperature
        {
            get { return temperature; }
            set
            {
                temperature = value;
                if (temperature > 5)
                    SomethingHappend?.Invoke();
            }
        }


       

    }
}
