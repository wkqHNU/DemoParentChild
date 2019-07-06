using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoParentChild
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------- 0.构造函数的调用顺序 ------------------------
            // 先把参数传到父类的构造函数，再把参数传到子类的构造函数
            new NoAbstractChild("123");

            // 总结1
            // 只要有抽象方法，类会自动添加abstract，变成抽象类
            // 抽象类中的方法只有在abstract下才是抽象方法，也就是并非抽象类中所有的方法都是抽象的
            // 总结2
            //向上转型：将子类对象转为父类对象。此处父类对象可以是接口。
            //向下转型：把父类对象转为子类对象。
            //向上转型是自由的；向下转型是有约束条件的。
            //非抽象继承，子类对象、父类对象的方法都能调到(用子类对象能
            //    调到子类对象的方法，用父类对象能调用父类对象的方法)。
            // ----------------------- 1.向上转型，父类不是抽象类 ------------------------
            NoAbstractParent parent1 = new NoAbstractChild();
            parent1.Work(); // 调用的父类的Work()
            //parent1.Play(); //不存在此方法
            // ----------------------- 2.向上转型，父类是抽象类 ------------------------
            AbstractParent parent2 = new AbstractChild();
            parent2.Work(); // 调用的子类的Work()
            //parent2.Play(); //不存在此方法
            // ----------------------- 3.向下转型，父类不是抽象类 ------------------------
            NoAbstractParent parent31 = new NoAbstractParent();
            try
            {
                NoAbstractChild child31 = (NoAbstractChild)parent31;
                child31.Work();
                child31.Play();
            }
            catch { }
            NoAbstractParent parent32 = new NoAbstractChild();
            NoAbstractChild child32 = (NoAbstractChild)parent32;
            child32.Work();
            child32.Play();
            // ----------------------- 4.向下转型，父类是抽象类 ------------------------
            // 无法创建抽急类或接口"AbstractParent”的实例
            //AbstractParent parent41 = new AbstractParent();
            //try
            //{
            //    NoAbstractChild child41 = (AbstractChild)parent41;
            //    child41.Work();
            //    child41.Play();
            //}
            //catch { }
            AbstractParent parent42 = new AbstractChild();
            AbstractChild child42 = (AbstractChild)parent42;
            child42.Work();
            child42.Play();
            // ----------------------- 5.向上转型，父类不是抽象类,但方法是虚方法 ------------------------
            VirtualParent parent5 = new OverrideChild();
            parent5.Work();
            // ----------------------- 6.向下转型，父类不是抽象类,但方法是虚方法 ------------------------
            VirtualParent parent6 = new OverrideChild();
            OverrideChild child6 = (OverrideChild)parent5;
            parent5.Work();


            // ----------------------- End ------------------------
            Console.ReadLine();
        }
    }
}
