using DesignPatternsPlayGround.Ducks;
using DesignPatternsPlayGround.Ducks.Interfaces.Implementations.Fly;
using DesignPatternsPlayGround.Ducks.SubClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck Mallard = new MallardDuck();
            Mallard.PerformQuack();
            Mallard.PerformFly();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehaviour(new FlyRocketPowered());
            model.PerformFly();

            Console.ReadLine();
        }
    }
}
