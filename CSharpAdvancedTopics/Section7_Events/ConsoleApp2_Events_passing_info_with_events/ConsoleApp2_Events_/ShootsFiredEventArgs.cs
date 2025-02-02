using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_Events_
{
    //this class will be used to send some additional infos about the event when someone is killed to the Publisher
    //convention --- "ShootsFired" is the event name + "EventArgs" at the end
    public class ShootsFiredEventArgs : EventArgs
    {
        //PROPS
        public DateTime TimeOfKill { get; set; }

        //CTOR - default empty constructor
        public ShootsFiredEventArgs()
        {
            
        }

        public ShootsFiredEventArgs(DateTime time)
        {
            this.TimeOfKill = time;
        }
    }
}
