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
        public MallardDuck()
        {
            quackBehaviour = new Quack();
            flyBehaviour = new FlyWithWings();
        }
    }
}
