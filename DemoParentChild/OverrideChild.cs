using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoParentChild
{
    class OverrideChild : VirtualParent
    {
        public override void Work()
        {
            base.Work();
            Console.WriteLine("override child work!");
        }
    }
}
