using System;
using System.Collections.Generic;
using System.Text;
using static StrategyPattern.DuckBehavior;
using static StrategyPattern.DuckInterfaces;

namespace StrategyPattern
{
    public class DuckModel
    {
        public abstract class Duck
        {
            public IFlyBehavior flyBehavior;
            public IQuackBehavior quackBehavior;

            public abstract void Display();

            public void PerformFly()
            {
                flyBehavior.fly();
            }

            public void PerformQuack()
            {
                quackBehavior.quack();
            }

            public void SetFlyBehavior(IFlyBehavior fb)
            {
                flyBehavior = fb;
            }

            public void SetQuackBehavior(IQuackBehavior qb)
            {
                quackBehavior = qb;
            }

            public void Swim()
            {
                Console.WriteLine("All ducks float, even decoys!");
            }
        }

        public class ModelDuck : Duck
        {
            public ModelDuck()
            {
                flyBehavior = new FlyNoWay();
                quackBehavior = new Quack();
            }

            public override void Display()
            {
                Console.WriteLine("I'm a model duck!");
            }
        }

        public class MallardDuck : Duck
        {
            public MallardDuck()
            {
                flyBehavior = new FlyWithWings();
                quackBehavior = new Quack();
            }

            public override void Display()
            {
                Console.WriteLine("I'm a real Mallard duck");
            }
        }
    }
}
