using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Observer
{
    public class ButtonNET
    {
        public delegate void Handler(ButtonNET button);
        public event Handler OnClick;
        protected string Label { get; }

        public ButtonNET(string label)
        {
            Label = label;
        }

        public void AddClickHandler(Handler handler)
        {
            OnClick += handler;
        }

        public void Click()
        {
            if (OnClick != null)
            {
                OnClick(this); 
            }
        }
    }

    public class ButtonNETTracker : IObservable<ButtonNET>
    {
        protected IList<IObserver<ButtonNET>> observers;

        public ButtonNETTracker()
        {
            observers = new List<IObserver<ButtonNET>>();
        }

        public IDisposable Subscribe(IObserver<ButtonNET> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
            return new Unsubscriber(observers, observer);
        }

        private class Unsubscriber : IDisposable
        {
            private IList<IObserver<ButtonNET>> _observers;
            private IObserver<ButtonNET> _observer;

            public Unsubscriber(IList<IObserver<ButtonNET>> observers, IObserver<ButtonNET> observer)
            {
                _observers = observers;
                _observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                {
                    _observers.Remove(_observer);
                }
            }
        }

        public void TrackClickEvent(ButtonNET button)
        {
            foreach (var observer in observers)
            {
                observer.OnCompleted();
            }
        }

    }

    public class ButtonNETReporter : IObserver<ButtonNET>
    {
        private IDisposable? _unsubscriber;
        private string Name { get; }

        public ButtonNETReporter(string name)
        {
            Name = name;
        }

        public virtual void Subscribe(IObservable<ButtonNET> observable)
        {
            if (observable != null)
            {
                _unsubscriber = observable.Subscribe(this);
            }
        }

        public virtual void OnCompleted()
        {
            Console.WriteLine($"{Name} Test");
        }

        public virtual void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public virtual void OnNext(ButtonNET value)
        {
            throw new NotImplementedException();
        }
    }

}
