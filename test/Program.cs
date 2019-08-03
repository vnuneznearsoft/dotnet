using System;
using testLibrary;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var sleep = new Sleep();
            var hungry = new Hungry();
            var thirsty = new Hungry.Thirsty();
            var play = new Play();
            var football = new Football();
            var info = new Information();
            Play playfoot = new Football();

            Console.WriteLine(info.getFullName("Tama", "gotchi"));
            Console.WriteLine(sleep.FormattedDemand);
            Console.WriteLine(hungry.FormattedDemand);
            Console.WriteLine(thirsty.FormattedDemand);
            Console.WriteLine(play.FormattedDemand);
            Console.WriteLine(football.FormattedDemand);
            playfoot.GoToPlay();
            football.GoToPlay();
            playfoot.GoToPlay(2);
            Console.ReadLine();
        }

        public class Play : Behavior
        {
            public Play() => Demand = "I want to play {0} games";
            public override int Frequency => 10;
            public virtual void GoToPlay()
            {
                Console.WriteLine("Let's play");
            }

            public virtual void GoToPlay(int times)
            {
                Console.WriteLine("Let's play football " + times.ToString() + " games");
            }
        }

        public class Behaviors
        {
            Play myPlay => new Play { Demand = "Play...." };
        }

        public class Football : Play
        {
            public override int Frequency => 6;
            public Football() => Demand = "I want to play football {0} times";
            public new void GoToPlay()
            {
                Console.WriteLine("Let's play football");
            }
            
        }

    }
}
