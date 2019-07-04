using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoParentChild
{
    class AbstractChild: AbstractParent
    {
        public override void Work()
        {
            Console.WriteLine("abstract child work!");
        }
        public void Play()
        {
            Console.WriteLine("abstract child play!");
        }
    }
}
