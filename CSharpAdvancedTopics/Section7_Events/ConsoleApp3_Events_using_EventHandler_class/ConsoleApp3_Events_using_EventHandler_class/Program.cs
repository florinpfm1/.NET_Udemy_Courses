namespace ConsoleApp3_Events_using_EventHandler_class
{
    internal class Program
    {
        static int score = 0;
        static void Main(string[] args)
        {
            //creating an instance of the publisher, of the class "Shooter" that will raise the events
            Shooter shooter = new Shooter();

            //Subscriber: subscribing the methods (having delegate signature) to the event from the Publisher class "Shooter"
            //"ShotsFired" is the event name from inside the Publisher class "Shooter", to which we subscribe the methods (having delegate signature)
            //here we are chaining methods to a given delegate, we can add as many methods as we want
            shooter.ShotsFired += KilledEnemy;  //<<<--- Note that there is no direct link netween the instance of Publisher class "Shooter" and the Subscriber method KilledEnemy
                                                //we are simply raising an event from Publisher => and the Subscriber method is executed
                                                //CODE IS LOOSELY COUPLED: the Publisher and Subscriber are NOT directly linked, they are linked through the event
            shooter.ShotsFired += AddScore;

            //Publisher: calling the method that will invoke/raise the event
            shooter.OnShoot();
        }

        //Subsriber: is a method that will subscribe to our event, needs to have same signature as the delegate
        //is an ACTION that will be executed when the event is raised
        //this method is not yet finalized , don't know what it is supposed to do, so ... I did not subscribe it to the event from the Publisher class "Shooter"
        private static void KillingInProgress(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        //Subsriber: is a method that will subscribe to our event, needs to have same signature as the delegate
        //is an ACTION that will be executed when the event is raised
        //this method will be executed when the random generated number is even, so the target is hit
        //will also print in console the score
        //through EventArgs we have access to the additional infos about the event, so we can print in console the time of killing
        public static void KilledEnemy(object sender, ShotsFiredEventArgs e)
        {
            //this transform the input object "sender" into an instance of the class "Shooter"
            var tempSender = sender as Shooter;
            Console.WriteLine($"I killed an enemy! And my name is {tempSender.Name}");
            Console.WriteLine($"Time of kill is: {e.TimeOfKill}");
            Console.WriteLine($"My score now is {score}.");

        }

        //Subsriber: is a method that will subscribe to our event, needs to have same signature as the delegate
        //is an ACTION that will be executed when the event is raised
        //this method will increment the score each time an enemy target is hit
        public static void AddScore(object sender, ShotsFiredEventArgs e)
        {
            score++;
        }
    }
}
