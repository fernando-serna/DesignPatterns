using System;
using static StrategyPattern.DuckInterfaces;

namespace StrategyPattern
{
    public class DuckBehavior
    {
        public class FlyWithWings : IFlyBehavior
        {
            public void fly()
            {
                Console.WriteLine("I'm flying!");
            }
        }

        public class FlyRocketPowered : IFlyBehavior
        {
            public void fly()
            {
                Console.WriteLine("I'm flying with a rocket!");
            }
        }

        public class FlyNoWay : IFlyBehavior
        {
            public void fly()
            {
                Console.WriteLine("I can't fly");
            }
        }

        public class Quack : IQuackBehavior
        {
            public void quack()
            {
                Console.WriteLine("Quack!!");
            }
        }

        public class Squeak : IQuackBehavior
        {
            public void quack()
            {
                Console.WriteLine("Squeek!");
            }
        }

        public class MuteQuack : IQuackBehavior
        {
            public void quack()
            {
                Console.WriteLine("No Quack!");
            }
        }
    }
}
