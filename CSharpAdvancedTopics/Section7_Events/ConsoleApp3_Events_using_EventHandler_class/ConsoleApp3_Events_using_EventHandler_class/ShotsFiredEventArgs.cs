using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_Events_using_EventHandler_class
{
    //this class will be used to send some additional infos about the event when someone is killed to the Publisher
    //convention --- "ShootsFired" is the event name + "EventArgs" at the end
    public class ShotsFiredEventArgs
    {
        //PROPS
        public DateTime TimeOfKill { get; set; }

        //CTOR - default empty constructor
        public ShotsFiredEventArgs()
        {

        }

        public ShotsFiredEventArgs(DateTime time)
        {
            this.TimeOfKill = time;
        }
    }
}
