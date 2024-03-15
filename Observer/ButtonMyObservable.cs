using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Observer
{
    internal interface IObserver
    {
        void NotifyHandler(object sender);
    }

    internal interface IObservable
    {
        void Notify();
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
    }

    internal class ButtonMyObservable : IObservable
    {
        public string Label { get; }

        protected IList<IObserver> observers { get; }

        //IEnumerable<IObserver> IObservable.observers => throw new NotImplementedException();

        public ButtonMyObservable(string label)
        {
            Label = label;
            observers = new List<IObserver>();
        }

        public void Click()
        {
            Notify();
        }

        public void Notify()
        {
            foreach(var observer in observers)
            {
                observer.NotifyHandler(this);
            }
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer); 
        }
    }

    internal class ConsoleProvider : IObserver
    {
        public ConsoleProvider() { }
        
        public void NotifyHandler(object sender)
        {
            var button = sender as ButtonMyObservable;
            Console.WriteLine((button?.Label ?? string.Empty) + " Pressed");
        }
    }
}
