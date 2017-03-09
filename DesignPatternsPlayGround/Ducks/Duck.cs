using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayGround.Ducks
{
    public class Duck
    {
        protected QuackBehaviour quackBehaviour;
        protected FlyBehaviour flyBehaviour;
        public void swim()
        {
            Console.WriteLine("Swim");
        }
        public void display()
        {
            Console.WriteLine("Duck");
        }
        public void PerformQuack()
        {
            quackBehaviour.quack();
        }
        public void PerformFly()
        {
            flyBehaviour.fly();
        }
    }
}
