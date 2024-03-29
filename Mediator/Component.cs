using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Mediator
{
    public interface IComponent
    {
        IMediator Mediator { get; }
    }

    public class Component1 : IComponent
    {
        private IMediator _mediator;
        public IMediator Mediator { get => _mediator; set => _mediator = value; }

        public int AnotherCounter { get; set; }

        public Component1(int count)
        {
            AnotherCounter = count;
        }

        public void SomeImportantBusinessAction()
        {
            AnotherCounter++;
            _mediator.Notify(this);
        }
    }

    public class Component2 : IComponent
    {
        private IMediator _mediator;
        public IMediator Mediator { get => _mediator; set => _mediator = value; }

        public int Counter { get; set; }

        public Component2(int count)
        {
            Counter = count;
        }

        public void AnotherImportantBusinessAction()
        {
            Counter++;
            _mediator.Notify(this);
        }

    }
}
