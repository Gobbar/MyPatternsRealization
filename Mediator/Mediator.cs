using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Mediator
{
    public interface IMediator
    {
        void Notify(IComponent component);
    }

    public class Mediator : IMediator
    {
        private Component1 _components1;
        private Component2 _components2;

        public Mediator(Component1 component1, Component2 component2)
        {
            _components1 = component1;
            _components2 = component2;
        }

        public void Notify(IComponent component)
        {
            if (component == _components1)
            {
                _components2.Counter++;
            } 
            else
            {
                _components1.AnotherCounter--;
            }
        }
    }
}

