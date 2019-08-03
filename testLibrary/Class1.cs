using System;

namespace testLibrary
{
    public abstract class Behavior
    {
        public string Demand { get; set; } = "I want";
        public abstract int Frequency { get; }
        public string FormattedDemand
        {
            get => string.Format(Demand, Frequency);
        }
    }

    public class Sleep : Behavior
    {
        public Sleep() => Demand = "I want to sleep {0} hours";
        public override int Frequency => 5;
        
    }
    public class Behaviors
    {
        Sleep mySleep => new Sleep { Demand = "Sleep...." };
    }

    public class Hungry : Behavior
    {
        public Hungry() => Demand = "I want to eat {0} meals";
        public override int Frequency => 1;

        public class Thirsty : Behavior
        {
            public Thirsty() => Demand = "I want to drink {0} glass of watter";
            public override int Frequency => 1;
        }
    }

    public class Information : Int1, Int2
    {
        public int getAge(int days)
        {
            return days / 365;
        }

        public string getFullName(string first, string second)
        {
            return first + " " + second;
        }
    }
}
