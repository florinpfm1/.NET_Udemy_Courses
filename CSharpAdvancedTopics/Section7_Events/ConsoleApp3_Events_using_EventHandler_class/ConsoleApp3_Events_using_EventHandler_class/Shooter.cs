using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_Events_using_EventHandler_class
{
    //this is the Publisher, is the class that will raise the events
    //contains: delegate, event, method that will invoke the events
    public class Shooter
    {
        //Publisher: defining the event handler
        //the event handler class uses a delegate and event under the hood, but it is more powerful and flexible, so ... better coding 
        public event EventHandler<ShotsFiredEventArgs> ShotsFired;

        /* THIS IS THE OLD DELEGATE with EVENT - was replaced by EVENT HANDLER class
        //Publisher: defining a delegate matching the event signature
        //convention --- "Shooting" is the action + "Handler" at the end (this handles the action)
        //"ShootsFiredEventArgs" is the class that will be used to send some additional infos about the event when someone is killed to the Publisher
        public delegate void ShootingHandler(object sender, ShotsFiredEventArgs e);
        

        //Publisher: defining the event --- we need to use the type of the delegate "ShootingHandler" (this means the action is completed)
        //convention event name --- "Killing" is the action + "Completed" at the end  ???????????????????????
        public event ShootingHandler ShotsFired;
        */

        private Random rng = new Random();

        public string Name { get; set; } = "Billy";

        //Publisher: method that will invoke/raise the event
        // convention --- "On" used before the action + "Shoot" is the action name
        public void OnShoot()
        {
            //here the implementation is an infinite loop that will have 50% chance to hit the target
            //random number generated is even then the target is hit, if odd then the target is missed
            while (true)
            {
                if (rng.Next(0, 100) % 2 == 0)
                {
                    //here every time before we invoke the event we need to check if the event is empty:
                    //   ShotsFired?. ..... - will check if the event is null, if not null then it will invoke the event


                    //here we invoke the event: all the methods subscribed to this event will be executed, each method is an ACTION
                    //"this" represents an instance of the class "Shooter" that raised the event
                    //here EventArgs is used to send some additional infos about the events to the Publisher, when the Publisher raises/invokes the event it can also use this extra infos about each event to do something
                    //here EventsArgs - we initialize a new instance of the class "ShootsFiredEventArgs" and we pass the current time as a parameter
                    ShotsFired?.Invoke(this, new ShotsFiredEventArgs(DateTime.Now));
                    
                }
                else
                {
                    Console.WriteLine("I missed the target");
                }

                //this is to slow down the infinite loop execution by 500 ms
                Thread.Sleep(500);
            }
        }
    }
}
