using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayGround.Ducks.Interfaces.Implementations.Fly
{
    public class FlyWithWings : FlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("I'm Flying!!");
        }
    }
}
