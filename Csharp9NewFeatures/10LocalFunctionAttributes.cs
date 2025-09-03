using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp9NewFeatures
{
    internal class _10LocalFunctionAttributes
    {
        public void Demo()
        {
            [Obsolete("This method is obsolete. Use NewMethod instead.")]
            void OldMethod()
            {
                Console.WriteLine("Old Method");
            }
            OldMethod();
        }
    }
}
