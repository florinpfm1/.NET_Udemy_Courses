using System.Threading.Tasks.Sources;

namespace ConsoleApp1_Events
{
    internal class Program
    {
        static int score = 0;
        static void Main(string[] args)
        {
            Shooter shooter = new Shooter();
            shooter.KillingCompleted +=KilledEnemy;
            shooter.KillingCompleted += AddScore;
            shooter.OnShoot();
        }

        private static void Shooter_KillingCompleted(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public static void KilledEnemy(object sender, EventArgs e)
        {
            Console.WriteLine("I killed an enemy!");
            Console.WriteLine("My score is now: " + score);

        }

        public static void AddScore(object sender, EventArgs e)
        {
            score++;
        }
    }

    internal class Shooter
    {
        public delegate void KillingHandler(object sender, EventArgs e);

        public event KillingHandler KillingCompleted;

        private Random rng = new Random();

        public void OnShoot()
        {
            while (true)
            {
                if (rng.Next(0, 100) % 2 == 0)
                {
                    if (KillingCompleted != null)
                    {
                        KillingCompleted.Invoke(this, EventArgs.Empty);
                    }
                }
                else
                {
                    Console.WriteLine("I missed the target");
                }

                Thread.Sleep(500);
            }
        }
    }
}