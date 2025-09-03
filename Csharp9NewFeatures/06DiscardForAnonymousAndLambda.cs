using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp9NewFeatures
{
    internal class _06DiscardForAnonymousAndLambda
    {
        public EventHandler myEvent;

        public void Demo()
        {
            myEvent += (_, e) => Console.WriteLine("Event triggered");
            myEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
