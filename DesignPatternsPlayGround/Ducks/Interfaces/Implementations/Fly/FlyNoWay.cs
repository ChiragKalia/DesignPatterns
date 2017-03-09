using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayGround.Ducks.Interfaces.Implementations.Fly
{
    class FlyNoWay
    {
        public void fly()
        {
            //Do nothing - Can't fly
            Console.WriteLine("Can't fly");
        }
    }
}
