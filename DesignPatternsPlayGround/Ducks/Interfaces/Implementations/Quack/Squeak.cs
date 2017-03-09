using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPlayGround.Ducks.Interfaces.Implementations.Quack
{
    public class Squeak : QuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("Rubber Duckie Squeak");
        }
    }
}
