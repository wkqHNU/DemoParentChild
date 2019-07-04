using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoParentChild
{
    class NoAbstractParent
    {
        public NoAbstractParent()
        {

        }
        public NoAbstractParent(string str)
        {

        }
        public void Work()
        {
            Console.WriteLine("no abstract parent work!");
        }
    }
}
