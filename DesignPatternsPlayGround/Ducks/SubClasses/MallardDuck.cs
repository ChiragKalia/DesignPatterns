using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsPlayGround.Ducks.Interfaces.Implementations.Fly;
using DesignPatternsPlayGround.Ducks.Interfaces.Implementations.Quack;
namespace DesignPatternsPlayGround.Ducks
{
    public class MallardDuck : Duck
    {
        //Mallard Duck is a real duck. Therefore it quacks and flies(For short durations)
        public MallardDuck()
        {
            quackBehaviour = new Quack();
            flyBehaviour = new FlyWithWings();
        }
        public override void display()
        {
            throw new NotImplementedException();
        }
    }
}
