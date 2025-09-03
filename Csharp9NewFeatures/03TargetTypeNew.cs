using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp9NewFeatures
{
    internal class _03TargetTypeNew
    {
        public _03TargetTypeNew()
        {
            ObservableCollection<string> collection = new();
            PersonClass person = new("Hermit", "Purple",38);

        }
    }
}
