using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Mediator
{
    public static class MediatorTest
    {
        public static void Test()
        {
            var comp1 = new Component1(2);
            var comp2 = new Component2(5);

            var mediator = new Mediator(comp1, comp2);
            comp1.Mediator = mediator;
            comp2.Mediator = mediator;

            Console.WriteLine("Component1: " +  comp1.AnotherCounter);
            Console.WriteLine("Component2: " +  comp2.Counter);

            comp1.SomeImportantBusinessAction();
            Console.WriteLine("Component1: " +  comp1.AnotherCounter);
            Console.WriteLine("Component2: " +  comp2.Counter);

            comp2.AnotherImportantBusinessAction();
            Console.WriteLine("Component1: " +  comp1.AnotherCounter);
            Console.WriteLine("Component2: " +  comp2.Counter);
        }
    }
}
