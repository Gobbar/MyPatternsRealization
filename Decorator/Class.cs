using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    public interface Component
    {
        public string Method();
    }

    public class ConcreteComponent : Component
    {
        public string Method()
        {
            return "Test";
        }
    }

    public abstract class ComponentDecorator : Component
    {
        protected Component component;

        public ComponentDecorator(Component component)
        {
            this.component = component;
        }

        public virtual string Method()
        {
            return component.Method();
        }
    }

    public class Test1 : ComponentDecorator
    {
        public Test1(Component comp) : base(comp) { }

        public override string Method()
        {
            return $"<b>{base.Method()}</b>";
        }
    }

    public class Test2 : ComponentDecorator
    {
        public Test2(Component comp) : base(comp) { }

        public override string Method()
        {
            return $"<i>{base.Method()}</i>";
        }
    }
}
