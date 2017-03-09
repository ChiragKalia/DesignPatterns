using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayGround.Ducks
{
    public abstract class Duck
    {
        protected QuackBehaviour quackBehaviour;
        protected FlyBehaviour flyBehaviour;
        public void swim()
        {
            Console.WriteLine("All ducks float, Even decoys!");
        }
        public abstract void display();
        public void PerformQuack()
        {
            quackBehaviour.quack();
        }
        public void PerformFly()
        {
            flyBehaviour.fly();
        }
        public void SetFlyBehaviour(FlyBehaviour fb)
        {
            flyBehaviour = fb;
        }
        public void SetQuackBehaviour(QuackBehaviour qb)
        {
            quackBehaviour = qb;
        }
    }
}
