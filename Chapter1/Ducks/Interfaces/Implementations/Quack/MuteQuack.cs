using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Ducks.Interfaces.Implementations.Quack
{
    public class MuteQuack : QuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("Do Nothing - Can't Quack");
        }
    }
}
