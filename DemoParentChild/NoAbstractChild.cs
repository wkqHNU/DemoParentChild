using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoParentChild
{
    class NoAbstractChild: NoAbstractParent
    {
        public NoAbstractChild()
        {

        }
        public NoAbstractChild(string str):base(str)
        {

        }

        public void Work()
        {
            base.Work();
            Console.WriteLine("no abstract child work!");
        }
        public void Play()
        {
            Console.WriteLine("no abstract child play!");
        }
    }
}
