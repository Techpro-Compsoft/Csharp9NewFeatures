using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp9NewFeatures
{
    internal class _07GetEnumeratorSupport
    {
        public void Demo()
        {
            foreach (var item in (1, 2, 3, 4))
            {
                //1 2 3 4
            }
            foreach (var i in 1..5)
            {
                Console.WriteLine(i);
                //1 2 3 4
            }
        }
    }

    public static class TupleExtensions
    {
        public static IEnumerator<T>
            GetEnumerator<T>(this ValueTuple<T, T, T, T> tuple)
        {
            yield return tuple.Item1;
            yield return tuple.Item2;
            yield return tuple.Item3;
            yield return tuple.Item4;
        }
        public static IEnumerator<Index> GetEnumerator(this Range number)
        {
            for (Index i = number.Start; i.Value < number.End.Value; i = i.Value + 1)
            {
                yield return i;
            }
        }
    }
   
}
