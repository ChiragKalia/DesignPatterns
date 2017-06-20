using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Ducks.Interfaces.Implementations.Fly
{
    class FlyNoWay : FlyBehaviour
    {
        public void fly()
        {
            //Do nothing - Can't fly
            Console.WriteLine("Can't fly");
        }
    }
}
