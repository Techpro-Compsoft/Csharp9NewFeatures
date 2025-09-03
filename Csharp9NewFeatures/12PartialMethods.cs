using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp9NewFeatures
{
    internal partial class _12PartialMethods
    {
        public partial bool Sum(int a, int b);
    }
    internal partial class _12PartialMethods
    {
        public void Demo()
        {
            bool result = Sum(1, 2);
            Console.WriteLine(result); // False
        }
        public partial bool Sum(int a, int b)
        {
            return a + b > 0;
        }
    }
}
