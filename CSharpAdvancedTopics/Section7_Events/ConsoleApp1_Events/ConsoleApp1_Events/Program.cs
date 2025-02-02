using System.Threading.Tasks.Sources;

namespace ConsoleApp1_Events
{
    internal class Program
    {
        static int score = 0;
        static void Main(string[] args)
        {
            //creating an instance of the publisher, of the class "Shooter" that will raise the events
            Shooter shooter = new Shooter();

            //Subscriber: subscribing the methods (having delegate signature) to the event from the Publisher class "Shooter"
            //"KillingCompleted" is the event name from inside the Publisher class "Shooter", to which we subscribe the methods (having delegate signature)
            //here we are chaining methods to a given delegate, we can add as many methods as we want
            shooter.KillingCompleted += KilledEnemy;  //<<<--- Note that there is no direct link netween the instance of Publisher class "Shooter" and the Subscriber method KilledEnemy
                                                      //we are simply raising an event from Publisher => and the Subscriber method is executed
                                                      //CODE IS LOOSELY COUPLED: the Publisher and Subscriber are NOT directly linked, they are linked through the event
            shooter.KillingCompleted += AddScore;

            //Publisher: calling the method that will invoke/raise the event
            shooter.OnShoot();
        }

        //Subsriber: is a method that will subscribe to our event, needs to have same signature as the delegate
        //is an ACTION that will be executed when the event is raised
        private static void Shooter_KillingCompleted(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        //Subsriber: is a method that will subscribe to our event, needs to have same signature as the delegate
        //is an ACTION that will be executed when the event is raised
        //this method will be executed when the random generated number is even, so the target is hit
        //will also print in console the score
        public static void KilledEnemy(object sender, EventArgs e)
        {
            Console.WriteLine("I killed an enemy!");
            Console.WriteLine("My score is now: " + score);

        }

        //Subsriber: is a method that will subscribe to our event, needs to have same signature as the delegate
        //is an ACTION that will be executed when the event is raised
        //this method will increment the score each time an enemy target is hit
        public static void AddScore(object sender, EventArgs e)
        {
            score++;
        }
    }

    //this is the Publisher, is the class that will raise the events
    //contains: delegate, event, method that will invoke the events
    internal class Shooter
    {
        //Publisher: defining a delegate matching the event signature
        //convention --- "Killing" is the action + "Handler" at the end (this handles the action)
        public delegate void KillingHandler(object sender, EventArgs e);

        //Publisher: defining the event --- we need to use the type of the delegate "KillingHandler" (this means the action is completed)
        //convention --- "Killing" is the action + "Completed" at the end
        public event KillingHandler KillingCompleted;

        private Random rng = new Random();

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
                    //here every time before we invoke the event we need to check if the event is empty
                    if (KillingCompleted != null)
                    {
                        //here we invoke the event: all the methods subscribed to this event will be executed, each method is an ACTION
                        //"this" represents an instance of the class "Shooter" that raised the event
                        KillingCompleted.Invoke(this, EventArgs.Empty);
                    }
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