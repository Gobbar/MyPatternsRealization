using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Observer
{
    internal static class ObserverTest
    {
        public static void MyButtonTest()
        {
            var buttonOb = new ButtonMyObservable("TestObs");
            var console = new ConsoleProvider();
            
            buttonOb.AddObserver(console);
            buttonOb.Click();
        }

        public static void NETButtonTest()
        {
            var buttonOb = new ButtonNET("TestNET");
            var provider = new ButtonNETTracker();
            buttonOb.AddClickHandler(provider.TrackClickEvent);
            var reporter = new ButtonNETReporter("Reporter1");
            reporter.Subscribe(provider);

            buttonOb.Click();
            
        }
    }
}
