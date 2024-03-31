using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    public static class DecoratorTest
    {
        public static void Test()
        {
            var component = new ConcreteComponent();

            ComponentDecorator decorator = new Test1(component);
            Console.WriteLine(decorator.Method());

            decorator = new Test2(decorator);
            Console.WriteLine(decorator.Method());

            decorator = new Test2(decorator);
            Console.WriteLine(decorator.Method());
        }
    }
}
